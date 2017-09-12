using CZB.Common;
using CZB.Common.Extensions;
using CZB.Web.Models;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;

namespace CZB.Web.Controllers.Api
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
    }
}
