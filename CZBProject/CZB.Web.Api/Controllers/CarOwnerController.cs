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
    }
}
