using CZB.Common;
using CZB.Common.Enums;
using CZB.Common.Extensions;
using CZB.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;

namespace CZB.Web.Api.Common
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
                    phone = model.Mobile,
                    cityCode = model.CityCode
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

        /// <summary>
        /// 获取保险公司列表和险种类型
        /// </summary>
        /// <returns></returns>
        public List<InsureListReturn> InsureList()
        {
            List<InsureListReturn> model = new List<InsureListReturn>();
            List<InsureModel> insureList = new BLL.FX_InsureCode().GetInsureList().Tables[0].ToEntityList<InsureModel>();
            List<InsuranceModel> insuranceList = new BLL.FX_InsureCode().GetInsuranceList().Tables[0].ToEntityList<InsuranceModel>();
            //insuranceList = insuranceList.Where(exp => exp.InsuranceName != "交强险" && exp.InsuranceName != "车船税" && exp.InsuranceName != "不计免赔(责任免除)").ToList();
            model = insureList.OrderBy(exp => exp.InsureCode)
                .GroupBy(exp => new { exp.InsureCode, exp.InsureName })
                .Select(a => new InsureListReturn
                {
                    InsureCode = a.Key.InsureCode,
                    InsureName = a.Key.InsureName,
                    typeList = a.Select(b => new TypeList()
                    {
                        ParaName = b.ParaName,
                        ParaValue = b.ParaValue
                    }).ToList(),
                    InsuranceList = insuranceList.Where(c => c.InsureCode == a.Key.InsureCode)
                    .Select(c => new Insurance
                    {
                        InsuranceName = c.InsuranceName,
                        InsuranceTypeId = c.InsuranceTypeId,
                        InsurancrMoney = c.InsurancrMoney
                    }).OrderByDescending(d => d.Selected).ToList()
                }).ToList();
            return model;
        }

        /// <summary>
        /// base64编码的文本 转为 图片
        /// </summary>
        /// <param name="base64Str">base64编码的文本</param>
        public string Base64StringToImage(string base64Str)
        {
            try
            {
                DateTime dt = DateTime.Now;
                string basePath = System.Web.HttpContext.Current.Server.MapPath("~");
                string rootDir = "upload";
                string subDir = dt.ToString("yyyyMMdd");
                DirectoryInfo dir = new DirectoryInfo(basePath + rootDir + "\\");
                if (!dir.Exists)
                    dir.Create();

                DirectoryInfo dir2 = new DirectoryInfo(dir.FullName + subDir + "\\");
                if (!dir2.Exists)
                    dir2.Create();

                byte[] arr = Convert.FromBase64String(base64Str);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                string fileReName = string.Format("{0}", dt.ToString("HHmmssfff"));
                bmp.Save(dir2.FullName + fileReName + ".jpg", ImageFormat.Jpeg);
                return "upload/" + subDir + "/" + fileReName + ".jpg";
            }
            catch (Exception ex)
            {
                return "";
                //MessageBox.Show("Base64StringToImage 转换失败\nException：" + ex.Message);
            }
        }

        /// <summary>
        /// 添加保单
        /// </summary>
        /// <param name="postModel"></param>
        /// <returns></returns>
        public bool AddPolicy(Models.PostAddPolicy postModel)
        {
            Model.FX_Policy model = new Model.FX_Policy
            {
                AgentId = postModel.agentId.ToInt32(),
                CustomerName = postModel.customerName.Trim(),
                CustomerMoblie = postModel.customerPhone.Trim(),
                FX_PolicyNo = "FX" + Utils.GetOrderNumber(),
                StartTime = postModel.timeStarts.ToDateTime(),
                EndTime = postModel.timeEnd.ToDateTime(),
                DrivingLicensePic = postModel._1_image_path,
                CustomerIdPic = postModel._2_image_path,
                InsureCode = postModel.notifications,
                CityCode = postModel.cityCode,
                Remark = postModel.textarea,
                PolicyAmount = 0,
                CarRegisterDate = DateTime.Now,
                ComeFrom = 1, ////保单来源
                UserId = 1,
                DrivingLicense = "", //数据库不允许null
                CreateTime = DateTime.Now,
                PolicyState = 1,
                OfferNum = 0,
                RejectNum = 0,
                PayState = 0,
            };
            if (postModel.codeType == "geren")
            {
                model.CarType = 1;
                //身份证号
                model.CustomerIdNo = postModel.codeTypeValue;
            }
            else
            {
                model.CarType = 2;
                //组织机构代码
                model.OrganizationCode = postModel.codeTypeValue;
            }
            List<InsuranceDetail> insuranceList = ToInsuranceList(postModel.insureListSelectedString.Replace("万", "0000"));
            List<Model.FX_InsuranceType> insuranceTypeList = new BLL.FX_InsuranceType().GetAllList().Tables[0].ToEntityList<Model.FX_InsuranceType>();
            List<Model.FX_PolicyDetail> policyDetailList = new List<Model.FX_PolicyDetail>();
            foreach (InsuranceDetail insuranceDetail in insuranceList)
            {
                Model.FX_InsuranceType insuranceTypeInfo = insuranceTypeList.FirstOrDefault(exp => exp.InsuranceName == insuranceDetail.name);
                if (insuranceTypeInfo != null)
                {
                    Model.FX_PolicyDetail fxdetial = new Model.FX_PolicyDetail();
                    fxdetial.InsuranceTypeId = insuranceTypeInfo.InsuranceTypeId;
                    fxdetial.InsuranceTypeDetail = insuranceDetail.price > 0 ? insuranceDetail.price.ToStringEx() : "";
                    fxdetial.TotalAmount = 0;
                    fxdetial.CreateTime = DateTime.Now;
                    fxdetial.UpdateTime = DateTime.Now;
                    fxdetial.IsUse = 1;
                    policyDetailList.Add(fxdetial);
                }
            }

            #region 保险提成参数
            try
            {
                model.PolicyInsurePara = GetPolicyInsurePara(model.InsureCode, model.CityCode);
            }
            catch { }
            #endregion
            if (new BLL.FX_Policy().AddPolicyList(model, policyDetailList))
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// 获取我的团队推荐信息
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public IntroduceReturn GetMyTeam(int agentId)
        {
            Model.FX_Agent agentModel = new BLL.FX_Agent().GetModelByAgentId(agentId);
            if (agentModel == null)
            {
                return null;
            }
            IntroduceReturn introduceList = new IntroduceReturn()
            {
                parentAgentInfo = new IntroduceDetail(),
                childAgentList = new List<IntroduceDetail>(),
            };
            introduceList.agentLevel = agentModel.AgentLevel.Value;
            //代理商本身信息
            introduceList.agentInfo = new IntroduceDetail()
            {
                id = agentModel.AgentId,
                parentId = agentModel.ParentId.ToInt32(),
                name = agentModel.TrueName,
                mobile = agentModel.Mobile,
                picUrl = agentModel.FacePic,
                policyAmout = new BLL.FX_Policy().GetMonthPolicy(agentModel.AgentId)
            };
            StringBuilder strWhere = new StringBuilder();
            //非三级代理商增加子集信息
            if (agentModel.AgentLevel != AgentLevelEnum.ThirdAgent.GetHashCode())
            {
                strWhere = new StringBuilder();
                strWhere.AppendFormat(" CHARINDEX(',{0},',ParentList)>0 and AgentLevel={1}", agentModel.AgentId, (agentModel.AgentLevel.ToInt32() + 1));
                List<Model.FX_Agent> agentList = new BLL.FX_Agent().GetList(strWhere.ToString()).Tables[0].ToEntityList<Model.FX_Agent>();
                if (agentList != null && agentList.Count > 0)
                {
                    agentList = agentList.OrderBy(exp => exp.TrueName).ToList();
                    introduceList.childAgentList = new List<IntroduceDetail>();
                    foreach (Model.FX_Agent info in agentList)
                    {
                        introduceList.childAgentList.Add(new IntroduceDetail()
                        {
                            id = info.AgentId,
                            parentId = info.ParentId.ToInt32(),
                            name = info.TrueName,
                            mobile = info.Mobile,
                            picUrl = info.FacePic,
                            policyAmout = new BLL.FX_Policy().GetMonthPolicy(info.AgentId)
                        });
                    }
                }
            }
            //非一级加载推荐人信息
            if (agentModel.AgentLevel != AgentLevelEnum.FirstAgent.GetHashCode())
            {
                Model.FX_Agent parentAgentModel = new BLL.FX_Agent().GetModelByAgentId(agentModel.ParentId.ToInt32());
                if (parentAgentModel != null)
                {
                    introduceList.parentAgentInfo = new IntroduceDetail()
                    {
                        id = parentAgentModel.AgentId,
                        name = parentAgentModel.TrueName,
                        parentId = parentAgentModel.ParentId.ToInt32(),
                        mobile = parentAgentModel.Mobile,
                        picUrl = parentAgentModel.FacePic,
                        policyAmout = new BLL.FX_Policy().GetMonthPolicy(parentAgentModel.AgentId)
                    };
                }
            }
            return introduceList;
        }


        /// <summary>
        /// 获取我的收益详情
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        public FundChangeRecordReturn RecordList(int agentId, string startTime, string endTime)
        {
            FundChangeRecordReturn model = new FundChangeRecordReturn();
            StringBuilder strWhere = new StringBuilder();

            if (startTime.IsNotNullOrWhiteSpace())
            {
                strWhere.AppendFormat(" and ir.CreateTime > '{0}'", startTime);
            }

            if (endTime.IsNotNullOrWhiteSpace())
            {
                endTime = endTime.ToDateTime().AddDays(1).ToDateString();
                strWhere.AppendFormat(" and ir.CreateTime < '{0}'", endTime);
            }

            model.list = new BLL.FX_IncomeRecord().GetIncomeRecordList(agentId, strWhere.ToString()).Tables[0].ToEntityList<FundChangeRecordDetail>();
            return model;
        }

        #region 险种处理
        public class InsuranceDetail
        {
            public string name { get; set; }

            public decimal price { get; set; }
        }
        /// <summary>
        /// 前台的险种拼接
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public List<InsuranceDetail> ToInsuranceList(string value)
        {
            List<InsuranceDetail> insuranceList = new List<InsuranceDetail>();
            if (value.Contains(','))
            {
                string[] valueList = value.Split(',');
                foreach (string _v in valueList)
                {
                    if (!_v.IsNullOrWhiteSpace())
                    {
                        if (_v.IndexOf(':') > 0)
                        {
                            string[] detailList = _v.Split(':');
                            if (detailList[0] != null && detailList[1] != null)
                            {
                                insuranceList.Add(new InsuranceDetail()
                                {
                                    name = detailList[0],
                                    price = detailList[1].ToDecimal()
                                });
                            }
                        }
                        else
                        {
                            insuranceList.Add(new InsuranceDetail()
                            {
                                name = _v,
                                price = 0
                            });
                        }
                    }
                }
            }
            return insuranceList;
        }


        /// <summary>
        /// 根据城市编码和保险公司编号 获取各返点参数列表
        /// </summary>
        /// <param name="insurecode"></param>
        /// <param name="citycode"></param>
        /// <returns></returns>
        public Model.FX_PolicyInsurePara GetPolicyInsurePara(string insurecode, string citycode)
        {
            Model.FX_PolicyInsurePara mop = new Model.FX_PolicyInsurePara();
            DataTable dt = new BLL.FX_InsureParaDetail().GetList(insurecode, citycode).Tables[0];
            if (dt.Rows.Count <= 0)
                return null;
            mop.BusinessTotal = Convert.ToDecimal(dt.Rows[0]["ParaValue"]);//商业总反点
            mop.BusinessCommission = Convert.ToDecimal(dt.Rows[1]["ParaValue"]);//商业直接销售反点 2-6
            mop.BusinessCommissionLevel2 = Convert.ToDecimal(dt.Rows[2]["ParaValue"]);//商业二级销售反点3-7
            mop.BusinessCommissionLevel1 = Convert.ToDecimal(dt.Rows[3]["ParaValue"]);//商业顶级反点4-8
            mop.CompulsoryTotal = Convert.ToDecimal(dt.Rows[4]["ParaValue"]);//交强险总返点
            mop.CompulsoryCommission = Convert.ToDecimal(dt.Rows[5]["ParaValue"]);//交强险直接返点2-6
            mop.CompulsoryCommissionLelve2 = Convert.ToDecimal(dt.Rows[6]["ParaValue"]);//交强险二级返点3-7
            mop.CompulsoryCommissionLelve1 = Convert.ToDecimal(dt.Rows[7]["ParaValue"]);//交强险顶级返点-8
            mop.BusinessTax = Convert.ToDecimal(dt.Rows[8]["ParaValue"]);//商业险税点
            mop.CompulsoryTax = Convert.ToDecimal(dt.Rows[9]["ParaValue"]);//交强险税点
            mop.CreateTime = DateTime.Now;
            mop.InsureCode = insurecode;
            return mop;
        }

        #endregion
    }
}
