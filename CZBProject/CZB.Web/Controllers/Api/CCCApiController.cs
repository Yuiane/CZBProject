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
using CZB.Model;

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
        public ReturnResult ClaimInfoNotification()
        {
            try
            {
                Models model = Request.Param<Models>();
                if (model != null)
                {
                    var info = "partyId:" + model.partyId + "\r\n  businessNo:" + model.businessNo + "\r\n model.content:" + model.content.ToJson();
                    LogHelper.WriteLog(LogEnum.CCCApi, info);

                    Model.CCCAPI_JobLossInformation infoModel = new Model.CCCAPI_JobLossInformation()
                    {
                        Id = Guid.NewGuid().ToStringEx(),
                        //联系人 contact
                        senderTelNo = model.content.contact.senderTelNo,                    //联系人电话
                        senderName = model.content.contact.senderName,                      //联系人姓名
                        vehicleOwnerName = model.content.contact.vehicleOwnerName,          //车主
                        vehicleOwnerTelNo = model.content.contact.vehicleOwnerTelNo,        //车主电话
                        //工单信息 claimInfo
                        repairOrderNo = model.content.claimInfo.repairOrderNo,              //DRP工单号
                        claimNo = model.content.claimInfo.claimNo,                            //定损单号
                        sourceType = model.content.claimInfo.sourceType,                      //业务来源
                        sendRepairFlag = model.content.claimInfo.sendRepairFlag,             //送修/返修标记
                        //保险公司 insuranceCompany
                        insuranceCompanyGroupCode = model.content.insuranceCompany.insuranceCompanyGroupCode, //保险公司Code
                        insuranceCompanyGroupName = model.content.insuranceCompany.insuranceCompanyGroupName,//保险公司名称
                        insuranceCompanyCode = model.content.insuranceCompany.insuranceCompanyCode,//保险公司分支机构Code
                        insuranceCompanyName = model.content.insuranceCompany.insuranceCompanyName //保险公司分支机构名称
                        //修理厂信息 repairFacility
                    };

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
