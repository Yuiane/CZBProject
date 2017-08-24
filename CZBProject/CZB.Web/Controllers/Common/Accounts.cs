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
    }
}