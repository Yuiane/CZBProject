using CZB.Common;
using CZB.Common.Extensions;
using CZB.Common.OpenWeChat;
using CZB.Web.Api.Common;
using CZB.Web.Api.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace CZB.Web.Api.Controllers
{
    /// <summary>
    /// 车直保-销售端app接口
    /// </summary>
    public partial class AccountController : ApiController
    {
        public string Token = HttpContext.Current.Request.Headers["token"];

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("UserLogin")]
        public ReturnResult UserLoginsss()
        {
            try
            {
                string phone = Request.Param("phone");
                string code = Request.Param("code");
                if (phone.IsNotNullOrWhiteSpace() && code.IsNotNullOrWhiteSpace())
                {
                    //验证码10分钟有效性
                    if (new BLL.TB_MessageRecord().Exists(phone, code))
                    {
                        var userInfo = new Accounts().UserLogin(phone);
                        // 获取用户相关基本信息 
                        return new ReturnResult
                        {
                            code = ReturnCode.Success,
                            desc = "登录成功",
                            data = userInfo
                        };
                    }
                    else
                    {
                        // 获取用户相关基本信息 
                        return new ReturnResult
                        {
                            code = ReturnCode.Error,
                            desc = "验证码不正确或已超时",
                            data = ""
                        };
                    }

                }
                else
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.NullOrEmpty,
                        desc = "参数异常 phone:" + phone + "&code:" + code,
                        data = ""
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    desc = "登录失败 err:" + err.Message,
                    data = ""
                };
            }
        }


        /// <summary>
        /// 第三方登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("UserLoginOAuth")]
        public ReturnResult UserLoginOAuth()
        {
            try
            {
                string code = Request.ParamUtil("code");
                if (code.IsNotNullOrWhiteSpace())
                {
                    var info = new OpenApi().GetAccess_token(code);
                    if (info != null)
                    {
                        var userInfo = new Accounts().UserLoginThird(info.openid);
                        if (userInfo != null)
                        {
                            return new ReturnResult()
                            {
                                code = ReturnCode.Success,
                                data = userInfo,
                                desc = "第三方登录成功"
                            };
                        }
                        else
                        {
                            return new ReturnResult()
                            {
                                code = ReturnCode.Error,
                                data = "",
                                desc = "该微信尚未绑定代理商,请先绑定"
                            };
                        }
                    }
                }
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = "授权失败"
                };
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }

        /// <summary>
        /// 第三方账号绑定
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("BandWechatLogin")]
        public ReturnResult BandWechatLogin()
        {
            try
            {
                var agentId = Request.Param("agentId").ToInt32();
                string code = Request.ParamUtil("code");
                if (code.IsNotNullOrWhiteSpace() && agentId > 0)
                {
                    var info = new OpenApi().GetAccess_token(code);
                    if (info != null)
                    {
                        if (new BLL.FX_Agent().BandWechatLogin(agentId, info.openid))
                        {
                            return new ReturnResult
                            {
                                code = ReturnCode.Success,
                                desc = "绑定成功",
                                data = ""
                            };
                        }
                    }
                }
                else
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.NullOrEmpty,
                        desc = "参数异常 agentId:" + agentId + "&code:" + code,
                        data = ""
                    };
                }
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    desc = "内部错误",
                    data = ""
                };
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message

                };
            }
        }

        /// <summary>
        /// 刷新用户信息
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("RefreshUserInfo")]
        public ReturnResult RefreshUserInfo()
        {
            try
            {
                string phone = Request.Param("phone");
                if (phone.IsNotNullOrWhiteSpace())
                {
                    var userInfo = new Accounts().UserLogin(phone);
                    // 获取用户相关基本信息 
                    return new ReturnResult
                    {
                        code = ReturnCode.Success,
                        desc = "登录成功",
                        data = userInfo
                    };
                }
                else
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "参数异常 phone:" + phone
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }

        /// <summary>
        /// 发送验证码
        /// api/Account/SendPhoneMessage?phone=18051803995
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("SendPhoneMessage")]
        public ReturnResult SendPhoneMessage()
        {
            try
            {
                var phone = Request.Param("phone");
                if (phone.IsNotNullOrWhiteSpace())
                {
                    var random = new Random().Next(1000, 9999);
                    var sendContent = "您本次登录的验证码：" + random + " ";
                    var messageRecord = new Model.TB_MessageRecord()
                    {
                        Id = Guid.NewGuid().ToStringEx(),
                        SendCode = random.ToStringEx(),
                        SendContent = sendContent,
                        SendTime = DateTime.Now,
                        SendPhone = phone
                    };
                    if (new BLL.TB_MessageRecord().Add(messageRecord))
                    {
                        var result = Messages.SendMessage(phone, sendContent);
                        return new ReturnResult()
                        {
                            code = ReturnCode.Success,
                            desc = "请求成功",
                            data = new
                            {
                                phone = phone,
                                code = random
                            }
                        };
                    }
                    return new ReturnResult()
                    {
                        code = ReturnCode.Error,
                        desc = "请求失败",
                        data = ""
                    };
                }
                else
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        desc = "参数异常 phone:" + phone,
                        data = ""
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    desc = "发送验证码接口请求异常:" + err.Message,
                    data = ""
                };
            }
        }


        /// <summary>
        /// 保单列表
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("PolicyListByState")]
        public ReturnResult PolicyListByState()
        {
            try
            {
                var orderState = Request.Param("state").ToInt32();
                var agentId = Request.Param("agentId").ToInt32();
                if (orderState > 0 || agentId > 0)
                {
                    List<PolicyListReturn> policyListList = new BLL.FX_Policy().GetPolicyListByState(agentId, orderState).Tables[0].ToEntityList<PolicyListReturn>();
                    return new ReturnResult
                    {
                        code = ReturnCode.Success,
                        data = new
                        {
                            policyListList = policyListList
                        },
                        desc = "请求成功"
                    };
                }
                else
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "参数异常 state:" + orderState + " agentId:" + agentId
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = "内部异常:" + err.Message
                };
            }
        }


        /// <summary>
        /// 保单详情
        /// </summary>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("PolicyDetailByPolicyId")]
        public ReturnResult PolicyDetailByPolicyId()
        {
            try
            {
                var policyId = Request.Param("policyId").ToInt32();
                if (policyId > 0)
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.Success,
                        data = new Accounts().GetPolicyDetailByPolicyId(policyId),
                        desc = "请求成功"
                    };
                }
                else
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "参数异常 policyId:" + policyId
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = "内部异常:" + err.Message
                };

            }
        }


        // <summary>
        /// 获取保单类型
        /// </summary>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("InsureList")]
        public ReturnResult InsureList()
        {
            try
            {
                return new ReturnResult
                {
                    code = ReturnCode.Success,
                    data = new Accounts().InsureList(),
                    desc = "请求成功"
                };
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = "内部异常:" + err.Message
                };
            }
        }


        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="base64Str"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("UploadImage")]
        public ReturnResult UploadImage()
        {
            try
            {
                string base64Str = Request.Param("base64Str");
                return new ReturnResult
                {
                    code = ReturnCode.Success,
                    desc = new Accounts().Base64StringToImage(base64Str),
                    data = new { }
                };
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    desc = "请求出错 :" + err.Message,
                    data = ""
                };
            }
        }


        /// <summary>
        /// 新增保单
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("AddPolicy")]
        public ReturnResult AddPolicy()
        {
            try
            {

                //var json = "{\"agentId\":\"56\",\"city\": \"苏州\", \"cityCode\": \"320500\", \"codeType\": \"geren\", \"codeTypeValue\": \"320723199601292415\", \"customerName\": \"袁连杰\",\"customerPhone\": \"18051803995\",\"insureListSelectedString\": \",交强险,不计免赔（责任免除) ,车船税,第三者责任险: 800万,盗抢险,车上人员(司机)责任保险,划痕险,玻璃单独破碎险,自燃险,车辆损失险,车上人员(乘客)责任保险,\", \"notifications\": \"000001\", \"textarea\": \"就这里吧\", \"timeEnd\": \"2019-09-11\", \"timeStarts\": \"2018-09-12\", \"_1_image_path\": \"http://localhost:52453/upload/20170912/105217105.jpg \", \"_2_image_path\": \"http://localhost:52453/upload/20170912/105217104.jpg \"}";
                Models.PostAddPolicy model = Request.CZBParam<Models.PostAddPolicy>();
                if (new Accounts().AddPolicy(model))
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.Success,
                        data = "",
                        desc = "请求成功"
                    };
                }
                else
                {
                    return new ReturnResult
                    {
                        code = ReturnCode.Error,
                        data = "",
                        desc = "请求失败"
                    };

                }
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }

        /// <summary>
        /// 获取我的团队【推荐树】
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("MyTeam")]
        public ReturnResult GetMyTeam()
        {
            try
            {
                var agentId = Request.Param("agentId").ToInt32();
                if (agentId <= 0)
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "参数异常 agentId:" + agentId
                    };
                }

                return new ReturnResult()
                {
                    code = ReturnCode.Success,
                    data = new Accounts().GetMyTeam(agentId),
                    desc = "请求成功"
                };
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }


        /// <summary>
        /// 获取我的收益详情
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("RecordList")]
        public ReturnResult GetChanegeRecordDetail()
        {
            try
            {
                int agentId = Request.Param("agentId").ToInt32();
                string startTime = Request.Param("startTime").ToStringEx();
                string endTime = Request.Param("endTime").ToStringEx();

                if (agentId <= 0)
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "参数异常 agentId:" + agentId
                    };
                }
                return new ReturnResult()
                {
                    code = ReturnCode.NullOrEmpty,
                    data = new Accounts().RecordList(agentId, startTime, endTime),
                    desc = "请求成功"
                };

            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }

        /// <summary>
        /// APP注册代理商
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("Register")]
        public ReturnResult Register()
        {
            try
            {
                string name = Request.Param("name").ToStringEx();     //用户名
                string number = Request.Param("number").ToStringEx(); //身份证号
                string phone = Request.Param("phone").ToStringEx();   //手机号码
                string code = Request.Param("code").ToStringEx();     //短信验证码
                string zcode = Request.Param("zcode").ToStringEx();   //代理商邀请码

                if (name.IsNullOrWhiteSpace())
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "用户名为必填项"
                    };
                }

                if (number.IsNullOrWhiteSpace())
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "身份证号为必填项"
                    };
                }

                if (phone.IsNullOrWhiteSpace())
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "手机号码为必填项"
                    };
                }

                if (code.IsNullOrWhiteSpace())
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "验证码为必填项"
                    };
                }

                if (zcode.IsNullOrWhiteSpace())
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.NullOrEmpty,
                        data = "",
                        desc = "邀请码为必填项"
                    };
                }

                Model.FX_Agent agentModel = new Model.FX_Agent()
                {
                    TrueName = name,
                    IDNO = number,
                    Mobile = phone,
                    OpenId = "",
                    WXName = "",
                    FacePic = "",
                    ParentId = 0,
                    ParentList = ",",
                    TotalAmout = 0,
                    AvailableAmount = 0,
                    CreateTime = DateTime.Now,
                    IsDelete = false,
                    IsUse = true,
                    ComeFrom = 1,
                    UserAccountNumer = new BLL.FX_Agent().GetUserAccountNumer().ToStringEx()
                };

                Model.FX_Agent agentParentModel = new BLL.FX_Agent().GetModelByZCode(zcode);
                if (agentParentModel != null)
                {
                    agentModel.CityCode = agentParentModel.CityCode;
                    if (agentParentModel.AgentLevel == 1)
                    {
                        agentModel.ParentList += agentParentModel.AgentId + ",";
                        agentModel.AgentLevel = 2;
                    }
                    else
                    {
                        Model.FX_Agent agentFirstParent = new BLL.FX_Agent().GetModelByZCode(agentParentModel.ParentId.Value.ToStringEx());
                        if (agentFirstParent != null)
                        {
                            agentModel.ParentList += agentFirstParent.AgentId + ",";
                            agentModel.ParentList += agentParentModel.AgentId + ",";
                            agentModel.AgentLevel = 3;
                        }
                    }
                }

                if (new BLL.FX_Agent().RegisterAgent(agentModel))
                {
                    //LogHelper.WriteLog(CZB.Common.Enums.LogEnum.Api, agentModel.ToJson());
                    return new ReturnResult()
                    {
                        code = ReturnCode.Success,
                        data = "",
                        desc = "注册成功"
                    };
                }
                else
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.Error,
                        data = "",
                        desc = "注册失败"
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }


        /// <summary>
        /// 获取代理商最新可注册邀请码
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("POST")]
        [ActionName("GetUserAccountNumer")]
        public ReturnResult GetUserAccountNumer()
        {
            try
            {
                int number = new BLL.FX_Agent().GetUserAccountNumer();
                if (number > 0)
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.Success,
                        data = new
                        {
                            number = number
                        },
                        desc = ""
                    };
                }
                else
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.Error,
                        data = "",
                        desc = "未知错误"
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Error,
                    data = "",
                    desc = err.Message
                };
            }
        }
    }
}
