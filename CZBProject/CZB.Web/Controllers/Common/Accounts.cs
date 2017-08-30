using CZB.Common.Extensions;
using CZB.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZB.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class Accounts
    {
        /// <summary>
        /// 用户登录返回信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public UserLoginReturn UserLogin(string phone)
        {
            var returnModel = new UserLoginReturn();
            var model = new BLL.FX_Agent().GetModelByPhone(phone);
            if (model != null)
            {
                //用户基本信息
                int level = model.AgentLevel.ToInt32();
                int agentId = model.AgentId.ToInt32();
                returnModel.userInfo = new UserInfo()
                {
                    headImg = model.FacePic,
                    id = agentId.ToStringEx(),
                    level = level,
                    money = model.TotalAmout.ToStringEx(),
                    levelName = level == 1 ? "一级代理商" : level == 2 ? "二级代理商" : "三级代理商",
                    name = model.TrueName,
                    phone = model.Mobile
                };
                //中部菜单信息
                var Menulist = new List<ShowMenuList>();

                var _shouyi_title = "0";
                var _shouyi = new BLL.FX_IncomeRecord().GetIncomeRecord(agentId);
                if (_shouyi.Tables[0].Rows.Count > 0)
                {
                    if (_shouyi.Tables[0].Rows[0]["num"] != null && _shouyi.Tables[0].Rows[0]["num"].ToStringEx() != "")
                    {
                        _shouyi_title = _shouyi.Tables[0].Rows[0]["num"].ToString();
                    }
                }
                var _baofei_all_title = "0";
                var _baofei_all = new BLL.FX_Policy().GetPolicyAll(agentId);
                if (_baofei_all.Tables[0].Rows.Count > 0)
                {
                    if (_baofei_all.Tables[0].Rows[0]["num"] != null && _baofei_all.Tables[0].Rows[0]["num"].ToStringEx() != "")
                    {
                        _baofei_all_title = _baofei_all.Tables[0].Rows[0]["num"].ToStringEx();
                    }
                }

                Menulist.Add(new ShowMenuList()
                {
                    showMenuName = "总收益/总保费",
                    showMenuNumber = _shouyi_title + "/" + _baofei_all_title
                });

                //当月销售
                string moneySaler = "0";
                var info = new BLL.FX_Policy().GetPolicyMonth(agentId);
                if (info != null && info.Tables[0] != null && info.Tables[0].Rows.Count > 0 && info.Tables[0].Rows[0]["num"] != null)
                {
                    if (info.Tables[0].Rows[0]["num"].ToStringEx() != "")
                    {
                        moneySaler = info.Tables[0].Rows[0]["num"].ToStringEx();
                    }
                }
                //目标

                //当月目标
                string paraCode = "CP008";
                switch (model.AgentLevel)
                {
                    case 1:
                        paraCode = "CP008";
                        break;
                    case 2:
                        paraCode = "CP009";
                        break;
                    case 3:
                        paraCode = "CP010";
                        break;
                }
                string cityParaDetailName = string.Empty;
                var cityParaDetailModel = new BLL.FX_CityParaDetails().GetListByCode(model.CityCode, paraCode).Tables[0].ToEntity<Model.FX_CityParaDetails>();
                if (cityParaDetailModel != null)
                {
                    cityParaDetailName = cityParaDetailModel.ParaValue;
                }
                Menulist.Add(new ShowMenuList()
                {
                    showMenuName = "当月销售/目标",
                    showMenuNumber = moneySaler + "/" + cityParaDetailName
                });

                if (level == 1 || level == 2)
                {
                    int parentAgentCount = new BLL.FX_Agent().GetCountParent(agentId);
                    var _shouyi_daili_title = "0";
                    var _shouyi_daili = new BLL.FX_IncomeRecord().GetCommissionAmount(agentId);
                    if (_shouyi_daili.Tables[0].Rows.Count > 0)
                    {
                        if (_shouyi_daili.Tables[0].Rows[0]["num"] != null && _shouyi_daili.Tables[0].Rows[0]["num"].ToStringEx() != "")
                        {
                            _shouyi_daili_title = _shouyi_daili.Tables[0].Rows[0]["num"].ToString();
                        }
                    }
                    Menulist.Add(new ShowMenuList()
                    {
                        showMenuName = "代理数/代理收益",
                        showMenuNumber = parentAgentCount + "/" + _shouyi_daili_title
                    });
                    Menulist.Add(new ShowMenuList()
                    {
                        showMenuName = "我的积分",
                        showMenuNumber = "0"
                    });
                }
                returnModel.showMenuList = Menulist;

                //保单信息
                var orderList = new List<OrderList>();
                var _orderList = new BLL.FX_Policy().GetListByAgentId(agentId).Tables[0];

                orderList.Add(new OrderList()
                {
                    orderStateName = "待报价",
                    orderStateNumber = _orderList.Select("PolicyState=1").Length.ToStringEx()
                });
                orderList.Add(new OrderList()
                {
                    orderStateName = "待支付",
                    orderStateNumber = _orderList.Select("PolicyState=2").Length.ToStringEx()
                });
                orderList.Add(new OrderList()
                {
                    orderStateName = "已生效",
                    orderStateNumber = _orderList.Select("PolicyState= 3  and EndTime >='" + DateTime.Now.ToString() + "' ").Length.ToStringEx()
                });
                orderList.Add(new OrderList()
                {
                    orderStateName = "已过期",
                    orderStateNumber = _orderList.Select("PolicyState= 3  and  EndTime <'" + DateTime.Now.ToString() + "'").Length.ToStringEx()
                });
                orderList.Add(new OrderList()
                {
                    orderStateName = "已拒绝",
                    orderStateNumber = _orderList.Select("PolicyState='-1' ").Length.ToStringEx()
                });



                returnModel.orderList = orderList;
            }
            return returnModel;
        }

        /// <summary>
        /// 获取保单详情
        /// </summary>
        /// <param name="policyId"></param>
        /// <returns></returns>
        public PolicyDetailReturn GetPolicyDetailByPolicyId(int policyId)
        {
            PolicyDetailReturn model = new PolicyDetailReturn();
            var policyInfo = new BLL.FX_Policy().GetListByPolicyId(policyId).Tables[0].ToEntity<Model.FX_Policy>();
            if (policyInfo != null)
            {
                model.policyDetailInfo = new PolicyDetailInfo()
                {
                    startTime = policyInfo.StartTime.ToDateString("yyyy-MM-dd"),
                    carNo = policyInfo.CarNo,
                    carVin = policyInfo.VIN,
                    customerName = policyInfo.CustomerName,
                    endTime = policyInfo.EndTime.ToDateString("yyyy-MM-dd"),
                    insureName = new BLL.FX_InsureCode().GetInsureName(policyInfo.InsureCode),  //保险公司名称
                    PayUrl = policyInfo.PayUrl,
                    policyAmount = policyInfo.PolicyAmount.ToStringEx(),
                    policyBusiness = "",
                    policyCompulsory = ""
                };

                var policyInsurePara = new BLL.FX_PolicyInsurePara().GetList(policyInfo.PolicyId).Tables[0].ToEntity<Model.FX_PolicyInsurePara>();
                if (policyInsurePara != null)
                {
                    decimal RP002 = policyInsurePara.BusinessCommission.ToDecimal() / 100;//商业直接销售反点 2-6
                    decimal RP006 = policyInsurePara.CompulsoryCommission.ToDecimal() / 100;//交强险直接返点2-6
                    decimal RP009 = policyInsurePara.BusinessTax.ToDecimal() / 100;//商业险税点
                    decimal RP010 = policyInsurePara.CompulsoryTax.ToDecimal() / 100;//交强险税点

                    //商业险预计提成
                    model.policyDetailInfo.policyBusiness = (policyInfo.BusinessAmount.ToDecimal() / (1 + RP009) * RP002).ToString("F2");
                    model.policyDetailInfo.policyCompulsory = (policyInfo.CompulsoryAmount.ToDecimal() / (1 + RP010) * RP006).ToString("F2");
                    //交强险预计提成
                }
                model.InsureTypeList = new BLL.FX_PolicyDetail().GetList(policyId).Tables[0].ToEntityList<InsureTypeDetail>();
            }
            return model;
        }
    }
}