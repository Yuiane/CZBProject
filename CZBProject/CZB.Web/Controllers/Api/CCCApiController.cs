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

                    var result = new ReturnResult()
                    {
                        resultCode = ResultCode.Success,
                        repairOrderNo = model.businessNo,
                        resultMsg = ""
                    };
                    //联系人contact
                    if (model.content.contact != null)
                    {
                        if (model.content.contact.senderTelNo == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "联系人电话为必须项!";
                        }
                        if (model.content.contact.senderName == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "联系人姓名为必须项!";
                        }
                    }
                    else
                    {
                        result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                        result.resultMsg = "未获取到联系人信息!";
                    }

                    //工单信息claimInfo
                    if (model.content.claimInfo != null)
                    {
                        if (model.content.claimInfo.repairOrderNo == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "工单信息-DRP工单号为必须项!";
                        }
                        if (model.content.claimInfo.claimNo == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "工单信息-定损单号为必须项!";
                        }
                        if (model.content.claimInfo.sourceType == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "工单信息-业务来源为必须项!";
                        }
                    }
                    else
                    {
                        result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                        result.resultMsg = "未获取到工单信息!";
                    }

                    //保险公司 insuranceCompany
                    if (model.content.insuranceCompany != null)
                    {
                        if (model.content.insuranceCompany.insuranceCompanyGroupCode == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "保险公司-保险公司Code为必须项!";
                        }
                        if (model.content.insuranceCompany.insuranceCompanyGroupName == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "保险公司-保险公司名称为必须项!";
                        }
                        if (model.content.insuranceCompany.insuranceCompanyCode == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "保险公司-保险公司分支机构Code为必须项!";
                        }
                        if (model.content.insuranceCompany.insuranceCompanyName == "")
                        {
                            result.resultCode = ResultCode.EntriesMustNotBeNull;
                            result.resultMsg = "保险公司-保险公司分支机构名称为必须项!";
                        }
                    }
                    else {
                        result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                        result.resultMsg = "未获取到保险公司信息!";
                    }



                    //非正常状态=>异常结束
                    if (result.resultCode != ResultCode.Success)
                    {
                        return result;
                    }
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
                        insuranceCompanyName = model.content.insuranceCompany.insuranceCompanyName, //保险公司分支机构名称
                        //修理厂信息 repairFacility
                        repairFactoryCode = model.content.repairFacility.repairFacilityCode, //修理厂Code
                        repairFactoryName = model.content.repairFacility.repairFacilityName, // 修理厂名称
                        repairFacilityType = model.content.repairFacility.repairFacilityType, //修理厂类型
                        qualificationLevel = model.content.repairFacility.qualificationLevel, //修理厂资质
                        estimatorCode = "",
                        estimatorName = "",
                        //工单流程信息 workflow
                        workFlowNodeCode = model.content.workflow.workFlowNodeCode,   //定损状态环节Code
                        workFlowNodeName = model.content.workflow.workFlowNodeName,  //定损状态环节名称
                        assignDate = model.content.workflow.assignDate.ToDateTime(),        //任务分配时间
                        estimateStartTime = model.content.workflow.estimateStartTime.ToDateTime(), //定损开始时间
                        estimateEndTime = model.content.workflow.estimateEndTime.ToDateTime(),   //定损完成时间
                        //事故信息  accInfo
                        reportNo = model.content.accInfo.reportNo, //报案号
                        reportDate = model.content.accInfo.reportDate.ToDateTime(), //报案时间
                        //车辆信息 VehicleInfo
                        //基本信息 baseInfo
                        lossVehicleTypeCode = model.content.vehicleInfo.baseInfo.lossVehicleType, //损失车辆Code
                        lossVehicleType = model.content.vehicleInfo.baseInfo.lossVehicleType,
                        plateNo = model.content.vehicleInfo.baseInfo.plateNo,
                        vin = model.content.vehicleInfo.baseInfo.vin,
                        brandModel = model.content.vehicleInfo.baseInfo.brandModel,
                        engineNo = model.content.vehicleInfo.baseInfo.engineNo,
                        vehicleCategoryCode = model.content.vehicleInfo.baseInfo.vehicleCategoryCode,
                        vehicleCategory = model.content.vehicleInfo.baseInfo.vehicleCategory,
                        usingTypeCode = model.content.vehicleInfo.baseInfo.usingTypeCode,
                        usingType = model.content.vehicleInfo.baseInfo.usingType,
                        licenseFirstRegisterDate = model.content.vehicleInfo.baseInfo.licenseFirstRegisterDate.ToDateTime(),
                        purchasePrice = model.content.vehicleInfo.baseInfo.purchasePrice,
                        plateTypeCode = model.content.vehicleInfo.baseInfo.plateTypeCode,
                        plateType = model.content.vehicleInfo.baseInfo.plateType,
                        plateColorCode = model.content.vehicleInfo.baseInfo.plateColorCode,
                        plateColor = model.content.vehicleInfo.baseInfo.plateColor,
                        vehicleBodyColor = model.content.vehicleInfo.baseInfo.vehicleBodyColor,
                        currentValue = model.content.vehicleInfo.baseInfo.currentValue.ToDecimal(),
                        //车辆损失信息 lossInfo
                        fuelRemain = model.content.vehicleInfo.lossInfo.fuelRemain.ToDecimal(),
                        mileage = model.content.vehicleInfo.lossInfo.mileage.ToDecimal(),
                        itemsInCar = model.content.vehicleInfo.lossInfo.itemsInCar,
                        mainCollisionPoints = model.content.vehicleInfo.lossInfo.mainCollisionPoints,
                        subCollisionPoints = model.content.vehicleInfo.lossInfo.subCollisionPoints,
                        //车型数据 vehicleModel
                        country = model.content.vehicleInfo.vehicleModel.country,
                        vehicleManufMakeName = model.content.vehicleInfo.vehicleModel.vehicleManufMakeName,
                        vehicleSubModelName = model.content.vehicleInfo.vehicleModel.vehicleSubModelName,
                    };

                    if (new CZB.BLL.CCCAPI_JobLossInformation().AddJobLoss(null, null, null, null, null))
                    {

                        return new ReturnResult
                        {
                            resultCode = ResultCode.Success,
                            repairOrderNo = "请求成功",
                            resultMsg = "请求成功"
                        };
                    }
                    else
                    {
                        return new ReturnResult
                        {
                            resultCode = ResultCode.UnknownException,
                            repairOrderNo = "新增失败",
                            resultMsg = "未知异常情况"
                        };
                    }
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
