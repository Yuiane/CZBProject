using CZB.Common;
using CZB.Common.CCCModel;
using CZB.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using CZB.Common.Extensions;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CZB.Web.Controllers
{
    /// <summary>
    /// CCC接口管理
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/CCCApi")]
    public class CCCApiController : ApiController
    {
        /// <summary>
        /// 工单回传接口
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("ClaimInfoNotification")]
        [AcceptVerbs("Get", "Post")]
        public ReturnResult ClaimInfoNotification(Models model)
        {
            try
            {
                
                var info = "";
                if (model != null)
                {
                    info += "partyId:" + model.partyId + "\r\n  businessNo:" + model.businessNo + "\r\n content:" + model.content.ToJson();
                    LogHelper.WriteLog(LogEnum.CCCApi, info);
                    return new ReturnResult
                    {
                        resultCode = ResultCode.Success,
                        repairOrderNo = info,
                        resultMsg = "测试成功返回结果，日志记录请求值"
                    };
                }
                else
                {
                    return new ReturnResult
                    {
                        resultCode = ResultCode.UnknownException,
                        repairOrderNo = "参数错误",
                        resultMsg = "未知异常情况"
                    };
                }
            }
            catch (Exception err)
            {
                return new ReturnResult
                {
                    resultCode = ResultCode.UnknownException,
                    repairOrderNo = err.Message,
                    resultMsg = "未知异常情况"
                };
            }
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("GetInfo")]
        [AcceptVerbs("Get", "Post")]
        public ReturnResult GetInfo()
        {
            return new ReturnResult
            {
                resultCode = ResultCode.EntriesMustNotBeNull,
                repairOrderNo = "111222333",
                resultMsg = "444555666"
            };
        }
    }
}
