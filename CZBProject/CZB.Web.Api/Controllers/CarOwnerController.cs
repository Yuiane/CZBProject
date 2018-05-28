using CZB.Common.AutoNaviMap;
using CZB.Common.Extensions;
using CZB.Web.Api.Models;
using System;
using System.Web.Http;

namespace CZB.Web.Api.Controllers
{
    public partial class AccountController : ApiController
    {
        /// <summary>
        /// 车主端登录
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("UserLogin2")]
        public ReturnResult CarLogin()
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
                        //var userInfo = new Accounts().UserLogin(phone);
                        // 获取用户相关基本信息 
                        return new ReturnResult
                        {
                            code = ReturnCode.Success,
                            desc = "登录成功",
                            data = ""//userInfo
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
        /// 逆地理编码
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [AcceptVerbs("GET", "POST")]
        [ActionName("SendRegeo")]
        public ReturnResult SendRegeo()
        {
            try
            {
                string longitude = Request.Param("longitude"); //经
                string latitude = Request.Param("latitude"); //纬
                var info = new AutoNaviMapApi().SendRegeo(longitude, latitude);
                if (info != null)
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.Success,
                        data = info,
                        desc = "请求成功"
                    };
                }
                else
                {
                    return new ReturnResult()
                    {
                        code = ReturnCode.Error,
                        data = "",
                        desc = "地图解析异常"
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
