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
        [ActionName("UserLogin")]
        public ReturnResult CarLogin()
        {
            try
            {
                return new ReturnResult()
                {
                    code = ReturnCode.Success,
                    data = "",
                    desc = ""
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
