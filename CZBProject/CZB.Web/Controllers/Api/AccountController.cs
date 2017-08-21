using System;
using System.Web;
using System.Web.Http;
using CZB.Common;
using CZB.Common.Extensions;
using CZB.Web.Models;


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
                        // 获取用户相关基本信息 
                        return new ReturnResult
                        {
                            code = ReturnCode.Success,
                            desc = "登录成功",
                            data = new
                            {
                                token = "",
                                phone = phone
                            }
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

    }
}
