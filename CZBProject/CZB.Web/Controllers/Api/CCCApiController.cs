using CZB.Common;
using CZB.Common.CCCModel;
using CZB.Common.Enums;
using CZB.Common.Extensions;
using CZB.Common.Helpers;
using CZB.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

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
                var model = Request.Param<CZB.Common.CCCModel.Models>();
                if (model != null)
                {
                    var info = "partyId:" + model.partyId + "\r\n  businessNo:" + model.businessNo + "\r\n model.content:" + model.content.ToJson();
                    LogHelper.WriteLog(LogEnum.CCCApi, info);
                    ReturnResult result = new ReturnResult();
                    //定损
                    if (model.content.workflow.workFlowNodeCode == WorkFlowNode.ToAssessTheDamage.GetDescription())
                    {
                        result = ToAssessTheDamage(model);
                    }
                    else
                    {
                        result = NuclearDamage(model);
                    }
                    return result;
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
        /// 工单维修接口
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        [Route("UpdateDrpInfo")]
        [AcceptVerbs("Get", "Post")]
        public ReturnResult UpdateDrpInfo()
        {
            StringBuilder strLog = new StringBuilder();
            try
            {
                strLog.AppendLine("--------------begin--------------");
                Models.UpdateDrpInfo model = Request.CZBParam<Models.UpdateDrpInfo>();
                if (model == null)
                {
                    strLog.AppendLine("--------------数据不符合要求--------------");
                    LogHelper.WriteLog(LogEnum.Api, strLog.ToStringEx());
                    return new ReturnResult()
                    {
                        resultCode = ResultCode.DataFormatDoesNotMeetRequirements,
                        repairOrderNo = "",
                        resultMsg = "请求失败"
                    };
                }

                if (model.repairOrderNo.IsNullOrWhiteSpace())
                {
                    strLog.AppendLine("--------------repairOrderNo数据不符合要求--------------");
                    LogHelper.WriteLog(LogEnum.Api, strLog.ToStringEx());
                    return new ReturnResult()
                    {
                        resultCode = ResultCode.EntriesMustNotBeNull,
                        repairOrderNo = "",
                        resultMsg = "请求失败"
                    };
                }

                strLog.AppendLine("--------------model:--------------" + model.ToJson());
                string url = "http://sit-interface.cccdrp.com/drp-interface/interface/restful/changeRepairOrderStatusRequest";
                var _model = new
                {
                    businessNo = model.repairOrderNo,
                    partyId = new BLL.CCCAPI_JobLossInformation().GetPartyId(model.repairOrderNo),
                    content = new
                    {
                        repairOrderNo = model.repairOrderNo,
                        repairOrderTypeCode = model.repairOrderTypeCode,
                        modifyDate = DateTime.Now.ToDateString("yyyy-MM-dd HH:mm:ss"),
                        vehicleOwnerName = model.vehicleOwnerName,
                        vehicleOwnerTelNo = model.vehicleOwnerTelNo,
                        estimatePickCarDate = model.estimatePickCarDate.ToDateString(),
                        pickCarDate = model.pickCarDate.ToDateString()
                    }
                };
                string postInfo = string.Format("\"partyId\":\"{0}\",\"businessNo\":\"{1}\",\"content\":\"{2}\"", _model.partyId, _model.businessNo, _model.content.ToJson().Replace("\"", "'"));
                postInfo = "{" + postInfo + "}";
                strLog.AppendLine("--------------postInfo:--------------" + postInfo);
                CZB.Web.Models.UpdateDrpReturn _result = Utils.HttpPostRequest(url, postInfo).JsonToObj<CZB.Web.Models.UpdateDrpReturn>();
                if (_result.success)
                {
                    strLog.AppendLine("--------------success--------------");
                    LogHelper.WriteLog(LogEnum.Api, strLog.ToStringEx());
                    return new ReturnResult()
                    {
                        resultCode = ResultCode.Success,
                        repairOrderNo = "",
                        resultMsg = "请求成功"
                    };
                }
                else
                {
                    strLog.AppendLine("--------------success--------------");
                    LogHelper.WriteLog(LogEnum.Api, strLog.ToStringEx());
                    return new ReturnResult()
                    {
                        resultCode = ResultCode.UnknownException,
                        repairOrderNo = "",
                        resultMsg = "请求失败"
                    };
                }

            }
            catch (Exception err)
            {
                LogHelper.WriteLog(LogEnum.Api, strLog.ToStringEx());
                return new ReturnResult
                {
                    resultCode = ResultCode.UnknownException,
                    repairOrderNo = err.Message,
                    resultMsg = "未知异常情况"
                };
            }
        }

        /// <summary>
        ///  核损
        /// </summary>
        /// <returns></returns>
        public ReturnResult NuclearDamage(CZB.Common.CCCModel.Models model)
        {
            if (!new CZB.BLL.CCCAPI_JobLossInformation().ExistsBusinessNo(model.businessNo))
            {
                return new ReturnResult
                {
                    repairOrderNo = model.businessNo,
                    resultCode = ResultCode.UnknownException,
                    resultMsg = "未检索到定损数据"
                };
            }

            var result = CheckIsNullOrEmpty(model);

            //非正常状态=>异常结束
            if (result.resultCode != ResultCode.Success)
            {
                return result;
            }

            Model.CCCAPI_JobLossInformation infoModel = new Model.CCCAPI_JobLossInformation()
            {
                Id = Guid.NewGuid().ToStringEx(),
                partyId = model.partyId,
                businessNo = model.businessNo,
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
                //费率折扣 discountRate
                partType = model.content.discountRate.partType,
                partTypeCode = model.content.discountRate.partTypeCode,
                manageRate = model.content.discountRate.manageRate.ToDecimal(),
                laborFeeManageRate = model.content.discountRate.laborFeeManageRate.ToDecimal(),
                electricianMachinistRate = model.content.discountRate.electricianMachinistRate.ToDecimal(),
                sheetMetalRate = model.content.discountRate.sheetMetalRate.ToDecimal(),
                paintRate = model.content.discountRate.paintRate.ToDecimal(),
                multiPaintDiscountRate = model.content.discountRate.multiPaintDiscountRate.ToDecimal(),
                //定损项目费用合计 feeTotal
                feeTotal_partFee = model.content.feeTotal.partFee.ToDecimal(),
                feeTotal_laborFee = model.content.feeTotal.laborFee.ToDecimal(),
                feeTotal_materialFee = model.content.feeTotal.materialFee.ToDecimal(),
                feeTotal_entireSalvage = model.content.feeTotal.entireSalvage.ToDecimal(),
                feeTotal_totalSalvage = model.content.feeTotal.totalSalvage.ToDecimal(),
                feeTotal_depreciation = model.content.feeTotal.depreciation.ToDecimal(),
                feeTotal_manageFee = model.content.feeTotal.manageFee.ToDecimal(),
                feeTotal_estimateAmount = model.content.feeTotal.estimateAmount.ToDecimal(),
                feeTotal_rescueFee = model.content.feeTotal.rescueFee.ToDecimal(),
                feeTotal_lossTotal = model.content.feeTotal.lossTotal.ToDecimal(),
                ChangeItemIDs = "", //损失项目-换件项目(复数)
                claimAttachmentsIDs = "",//附件信息(复数)
                MaterialItemsIDs = "",//损失项目-辅料项目(复数)
                RepairItemsIDs = "",//损失项目-维修项目(复数)
                estimatorCode = model.content.repairFacility.appraiserCode, //修理厂信息-维修顾问账号
                estimatorName = model.content.repairFacility.appraiserName, //修理厂信息-维修顾问姓名
                managementFee = 0,//费率折扣-管理费率
            };
            infoModel.claimAttachmentsIDs = "";
            List<Model.CCCAPI_ClaimAttachments> claimAttachmentsList = null;
            if (model.content.claimAttachments != null && model.content.claimAttachments.Count > 0)
            {
                infoModel.claimAttachmentsIDs += ",";
                claimAttachmentsList = new List<CCCAPI_ClaimAttachments>();
                foreach (var claimAttachmentsModel in model.content.claimAttachments)
                {
                    var _guid = Guid.NewGuid().ToStringEx();
                    claimAttachmentsList.Add(new Model.CCCAPI_ClaimAttachments()
                    {
                        AttachmentCategoryName = claimAttachmentsModel.attachmentCategoryName,
                        AttachmentId = claimAttachmentsModel.attachmentId.ToInt32(),
                        AttachmentName = claimAttachmentsModel.attachmentName,
                        AttachmentUrl = claimAttachmentsModel.attachmentUrl,
                        Id = _guid
                    });
                    infoModel.claimAttachmentsIDs += _guid + ",";
                }
            }

            List<Model.CCCAPI_ChangeItems> changeItemsList = null;
            if (model.content.lossItem != null && model.content.lossItem.changeItems != null && model.content.lossItem.changeItems.Count > 0)
            {
                infoModel.ChangeItemIDs += ",";
                changeItemsList = new List<CCCAPI_ChangeItems>();
                foreach (var changeItemsModel in model.content.lossItem.changeItems)
                {
                    var _guid = Guid.NewGuid().ToStringEx();
                    changeItemsList.Add(new Model.CCCAPI_ChangeItems()
                    {
                        ItemId = changeItemsModel.itemId.ToDecimal(),
                        unitPriceAfterDiscount = changeItemsModel.unitPriceAfterDiscount.ToDecimal(),
                        salvage = changeItemsModel.salvage.ToDecimal(),
                        depreciation = changeItemsModel.depreciation.ToDecimal(),
                        itemName = changeItemsModel.itemName,
                        ManualFlag = changeItemsModel.manualFlag.ToLower() == "true" ? true : false,
                        partFeeAfterDiscount = changeItemsModel.partFeeAfterDiscount.ToDecimal(),
                        partNo = changeItemsModel.partNo,
                        partQuantity = changeItemsModel.partQuantity.ToDecimal(),
                        recycleFlag = changeItemsModel.recycleFlag.ToLower() == "true" ? true : false,
                        Id = _guid
                    });
                    infoModel.ChangeItemIDs += _guid + ",";
                }
            }

            List<Model.CCCAPI_MaterialItems> materialItems = null;
            if (model.content.lossItem != null && model.content.lossItem.materialItems != null && model.content.lossItem.materialItems.Count > 0)
            {
                infoModel.MaterialItemsIDs += ",";
                materialItems = new List<CCCAPI_MaterialItems>();
                foreach (var materialItemsModel in model.content.lossItem.materialItems)
                {
                    var _guid = Guid.NewGuid().ToStringEx();
                    materialItems.Add(new CCCAPI_MaterialItems()
                    {
                        id = _guid,
                        itemid = materialItemsModel.itemId.ToDecimal(),
                        itemName = materialItemsModel.itemName,
                        manualFlag = materialItemsModel.manualFlag.ToLower() == "true" ? true : false,
                        materialUnit = materialItemsModel.materialUnit.ToStringEx(),
                        partFee = materialItemsModel.partFee.ToDecimal(),
                        partQuantity = materialItemsModel.partQuantity.ToDecimal(),
                        unitPrice = materialItemsModel.unitPrice.ToDecimal()
                    });
                    infoModel.MaterialItemsIDs += _guid + ",";
                }
            }

            List<Model.CCCAPI_RepairItems> repairItems = null;
            if (model.content.lossItem != null && model.content.lossItem.repairItems != null && model.content.lossItem.repairItems.Count > 0)
            {
                infoModel.RepairItemsIDs += ",";
                repairItems = new List<Model.CCCAPI_RepairItems>();
                foreach (var repairItemModel in model.content.lossItem.repairItems)
                {
                    var _guid = Guid.NewGuid().ToStringEx();
                    repairItems.Add(new Model.CCCAPI_RepairItems()
                    {
                        id = _guid,
                        itemId = repairItemModel.itemId.ToDecimal(),
                        itemName = repairItemModel.itemName,
                        laborFeeAfterDiscount = repairItemModel.laborFeeAfterDiscount.ToDecimal(),
                        laborFeeManageRate = repairItemModel.laborFeeManageRate.ToDecimal(),
                        laborHour = repairItemModel.laborHour.ToDecimal(),
                        laborHourFee = repairItemModel.laborHourFee.ToDecimal(),
                        laborType = repairItemModel.laborType,
                        manualFlag = repairItemModel.manualFlag == "1" ? true : false,
                        operationType = repairItemModel.operationType,
                        outerLaborFee = repairItemModel.outerLaborFee.ToDecimal(),
                        outerRepairFlag = repairItemModel.outerRepairFlag == "1" ? true : false,
                        paintDiscountFlag = repairItemModel.paintDiscountFlag == "1" ? true : false,
                        partNo = repairItemModel.partNo.ToStringEx()
                    });
                    infoModel.RepairItemsIDs += _guid + ",";
                }
            }




            Model.STAPI_DrpRepairSheet stModel = new Model.STAPI_DrpRepairSheet()
            {
                drpDeptId = infoModel.partyId,
                drpRepairSheet = new drpRepairSheet()
                {
                    senderTelNo = infoModel.senderTelNo,
                    senderName = infoModel.senderName,
                    vehicleOwnerName = infoModel.vehicleOwnerName,
                    vehicleOwnerTelNo = infoModel.vehicleOwnerTelNo,
                    repairOrderNo = infoModel.repairOrderNo,
                    claimNo = infoModel.claimNo,
                    sourceType = infoModel.sourceType,
                    sendRepairFlag = infoModel.sendRepairFlag,
                    insuranceCompanyGroupCode = infoModel.insuranceCompanyGroupCode,
                    insuranceCompanyGroupName = infoModel.insuranceCompanyGroupName,
                    insuranceCompanyName = infoModel.insuranceCompanyName,
                    insuranceCompanyCode = infoModel.insuranceCompanyCode,
                    repairFactoryCode = infoModel.repairFactoryCode,
                    repairFactoryName = infoModel.repairFactoryName,
                    repairFacilityType = infoModel.repairFacilityType,
                    qualificationLevel = infoModel.qualificationLevel,
                    estimatorCode = infoModel.estimatorCode,
                    estimatorName = infoModel.estimatorName,
                    workFlowNodeCode = infoModel.workFlowNodeCode,
                    workFlowNodeName = infoModel.workFlowNodeName,
                    assignDate = infoModel.assignDate.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    estimateStartTime = infoModel.estimateStartTime.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    estimateEndTime = infoModel.estimateEndTime.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    reportNo = infoModel.reportNo,
                    reportDate = infoModel.reportDate.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    lossVehicleTypeCode = infoModel.lossVehicleTypeCode,
                    lossVehicleType = infoModel.lossVehicleType,
                    plateNo = infoModel.plateNo,
                    vin = infoModel.vin,
                    brandModel = infoModel.brandModel,
                    engineNo = infoModel.engineNo,
                    vehicleCategoryCode = infoModel.vehicleCategoryCode,
                    vehicleCategory = infoModel.vehicleCategory,
                    usingTypeCode = infoModel.usingTypeCode,
                    usingType = infoModel.usingType,
                    licenseFirstRegisterDate = infoModel.licenseFirstRegisterDate.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    purchasePrice = infoModel.purchasePrice.ToDecimal(),
                    plateTypeCode = infoModel.plateTypeCode,
                    plateType = infoModel.plateType,
                    plateColorCode = infoModel.plateColorCode,
                    plateColor = infoModel.plateColor,
                    vehicleBodyColor = infoModel.vehicleBodyColor,
                    currentValue = infoModel.currentValue.ToDecimal(),
                    fuelRemain = infoModel.fuelRemain.ToDecimal(),
                    mileage = infoModel.mileage.ToDecimal(),
                    itemsInCar = infoModel.itemsInCar,
                    mainCollisionPoints = infoModel.mainCollisionPoints,
                    subCollisionPoints = infoModel.subCollisionPoints,
                    country = infoModel.country,
                    vehicleManufMakeName = infoModel.vehicleManufMakeName,
                    vehicleSubModelName = infoModel.vehicleSubModelName,
                    partType = infoModel.partType,
                    partTypeCode = infoModel.partTypeCode,
                    manageRate = infoModel.manageRate.ToDecimal(),
                    laborFeeManageRate = infoModel.laborFeeManageRate.ToDecimal(),
                    electricianMachinistRate = infoModel.electricianMachinistRate.ToDecimal(),
                    sheetMetalRate = infoModel.sheetMetalRate.ToDecimal(),
                    paintRate = infoModel.paintRate.ToDecimal(),
                    managementFee = infoModel.managementFee.ToDecimal(),
                    multiPaintDiscountRate = infoModel.multiPaintDiscountRate.ToDecimal(),
                    partFee = infoModel.feeTotal_partFee.ToDecimal(),
                    laborFee = infoModel.feeTotal_laborFee.ToDecimal(),
                    materialFee = infoModel.feeTotal_materialFee.ToDecimal(),
                    entireSalvage = infoModel.feeTotal_entireSalvage.ToDecimal(),
                    totalSalvage = infoModel.feeTotal_totalSalvage.ToDecimal(),
                    depreciation = infoModel.feeTotal_depreciation.ToDecimal(),
                    manageFee = infoModel.feeTotal_manageFee.ToDecimal(),
                    estimateAmount = infoModel.feeTotal_estimateAmount.ToDecimal(),
                    rescueFee = infoModel.feeTotal_rescueFee.ToDecimal(),
                    lossTotal = infoModel.feeTotal_lossTotal.ToDecimal()
                }
            };


            stModel.drpChangeItems = null;
            if (model.content.lossItem != null && model.content.lossItem.changeItems != null && model.content.lossItem.changeItems.Count > 0)
            {
                stModel.drpChangeItems = new List<drpChangeItems>();
                foreach (var changeItemsModel in model.content.lossItem.changeItems)
                {
                    stModel.drpChangeItems.Add(new Model.drpChangeItems()
                    {
                        itemId = changeItemsModel.itemId,
                        unitPriceAfterDiscount = changeItemsModel.unitPriceAfterDiscount.ToDecimal(),
                        salvage = changeItemsModel.salvage.ToDecimal(),
                        depreciation = changeItemsModel.depreciation.ToDecimal(),
                        itemName = changeItemsModel.itemName,
                        manualFlag = changeItemsModel.manualFlag.ToLower() == "true" ? true : false,
                        partFeeAfterDiscount = changeItemsModel.partFeeAfterDiscount.ToDecimal(),
                        partNo = changeItemsModel.partNo,
                        partQuantity = changeItemsModel.partQuantity.ToDecimal(),
                        recycleFlag = changeItemsModel.recycleFlag.ToLower() == "true" ? true : false
                    });
                }
            }



            stModel.drpRepairItems = null;
            if (model.content.lossItem != null && model.content.lossItem.repairItems != null && model.content.lossItem.repairItems.Count > 0)
            {
                stModel.drpRepairItems = new List<Model.drpRepairItems>();
                foreach (var repairItemModel in model.content.lossItem.repairItems)
                {
                    stModel.drpRepairItems.Add(new Model.drpRepairItems()
                    {
                        itemId = repairItemModel.itemId,
                        itemName = repairItemModel.itemName,
                        laborFeeAfterDiscount = repairItemModel.laborFeeAfterDiscount.ToDecimal(),
                        laborFeeManageRate = repairItemModel.laborFeeManageRate.ToDecimal(),
                        laborHour = repairItemModel.laborHour.ToDecimal(),
                        laborHourFee = repairItemModel.laborHourFee.ToDecimal(),
                        laborType = repairItemModel.laborType,
                        manualFlag = repairItemModel.manualFlag == "1" ? true : false,
                        operationType = repairItemModel.operationType,
                        outerLaborFee = repairItemModel.outerLaborFee.ToDecimal(),
                        outerRepairFlag = repairItemModel.outerRepairFlag == "1" ? true : false,
                        paintDiscountFlag = repairItemModel.paintDiscountFlag == "1" ? true : false,
                        partNo = repairItemModel.partNo.ToStringEx()
                    });
                }
            }

            stModel.drpMaterialItems = null;
            if (model.content.lossItem != null && model.content.lossItem.materialItems != null && model.content.lossItem.materialItems.Count > 0)
            {
                stModel.drpMaterialItems = new List<drpMaterialItems>();
                foreach (var materialItemsModel in model.content.lossItem.materialItems)
                {

                    stModel.drpMaterialItems.Add(new drpMaterialItems()
                    {
                        itemId = materialItemsModel.itemId,
                        itemName = materialItemsModel.itemName,
                        manualFlag = materialItemsModel.manualFlag.ToLower() == "true" ? true : false,
                        materialUnit = materialItemsModel.materialUnit.ToStringEx(),
                        partFee = materialItemsModel.partFee.ToDecimal(),
                        partQuantity = materialItemsModel.partQuantity.ToDecimal(),
                        unitPrice = materialItemsModel.unitPrice.ToDecimal()
                    });
                }
            }

            stModel.drpAttachments = null;
            if (model.content.claimAttachments != null && model.content.claimAttachments.Count > 0)
            {

                stModel.drpAttachments = new List<drpAttachments>();
                foreach (var claimAttachmentsModel in model.content.claimAttachments)
                {
                    stModel.drpAttachments.Add(new Model.drpAttachments()
                    {
                        attachmentCategoryName = claimAttachmentsModel.attachmentCategoryName,
                        attachmentId = claimAttachmentsModel.attachmentId,
                        attachmentName = claimAttachmentsModel.attachmentName,
                        attachmentUrl = claimAttachmentsModel.attachmentUrl,
                    });
                }
            }

            new CZB.Web.Common.CCCApis().SendToSiTeng(stModel.ToJson());

            if (new CZB.BLL.CCCAPI_JobLossInformation().AddJobLoss(infoModel, claimAttachmentsList, changeItemsList, materialItems, repairItems))
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

        /// <summary>
        /// 定损
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ReturnResult ToAssessTheDamage(CZB.Common.CCCModel.Models model)
        {
            Model.CCCAPI_JobLossInformation infoModel = new Model.CCCAPI_JobLossInformation()
            {
                Id = Guid.NewGuid().ToStringEx(),
                partyId = model.partyId,
                businessNo = model.businessNo,
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
                lossVehicleTypeCode = model.content.vehicleInfo.baseInfo.lossVehicleTypeCode, //损失车辆Code
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
                //费率折扣 discountRate
                partType = model.content.discountRate.partType,
                partTypeCode = model.content.discountRate.partTypeCode,
                manageRate = model.content.discountRate.manageRate.ToDecimal(),
                laborFeeManageRate = model.content.discountRate.laborFeeManageRate.ToDecimal(),
                electricianMachinistRate = model.content.discountRate.electricianMachinistRate.ToDecimal(),
                sheetMetalRate = model.content.discountRate.sheetMetalRate.ToDecimal(),
                paintRate = model.content.discountRate.paintRate.ToDecimal(),
                multiPaintDiscountRate = model.content.discountRate.multiPaintDiscountRate.ToDecimal(),
                //定损项目费用合计 feeTotal
                feeTotal_partFee = model.content.feeTotal.partFee.ToDecimal(),
                feeTotal_laborFee = model.content.feeTotal.laborFee.ToDecimal(),
                feeTotal_materialFee = model.content.feeTotal.materialFee.ToDecimal(),
                feeTotal_entireSalvage = model.content.feeTotal.entireSalvage.ToDecimal(),
                feeTotal_totalSalvage = model.content.feeTotal.totalSalvage.ToDecimal(),
                feeTotal_depreciation = model.content.feeTotal.depreciation.ToDecimal(),
                feeTotal_manageFee = model.content.feeTotal.manageFee.ToDecimal(),
                feeTotal_estimateAmount = model.content.feeTotal.estimateAmount.ToDecimal(),
                feeTotal_rescueFee = model.content.feeTotal.rescueFee.ToDecimal(),
                feeTotal_lossTotal = model.content.feeTotal.lossTotal.ToDecimal(),
                ChangeItemIDs = "", //损失项目-换件项目(复数)
                claimAttachmentsIDs = "",//附件信息(复数)
                MaterialItemsIDs = "",//损失项目-辅料项目(复数)
                RepairItemsIDs = "",//损失项目-维修项目(复数)
                estimatorCode = model.content.repairFacility.appraiserCode, //修理厂信息-维修顾问账号
                estimatorName = model.content.repairFacility.appraiserName, //修理厂信息-维修顾问姓名
                managementFee = 0,//费率折扣-管理费率
            };

            if (new CZB.BLL.CCCAPI_JobLossInformation().Add(infoModel))
            {
                return new ReturnResult
                {
                    resultCode = ResultCode.Success,
                    repairOrderNo = model.businessNo,
                    resultMsg = "定损成功"
                };
            }
            else
            {
                return new ReturnResult
                {
                    resultCode = ResultCode.UnknownException,
                    repairOrderNo = model.businessNo,
                    resultMsg = "定损数据库操作败"
                };
            }
        }


        /// <summary>
        /// 验证数据null问题
        /// </summary>
        /// <returns></returns>
        public ReturnResult CheckIsNullOrEmpty(CZB.Common.CCCModel.Models model)
        {
            var result = new ReturnResult()
            {
                resultCode = ResultCode.Success,
                repairOrderNo = model.businessNo,
                resultMsg = ""
            };
            //联系人contact
            if (model.content.contact != null)
            {
                if (model.content.contact.vehicleOwnerName.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "车主为必须项!";
                    return result;
                }
                if (model.content.contact.vehicleOwnerTelNo.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "车主联系电话为必须项!";
                    return result;
                }
            }
            else
            {
                result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                result.resultMsg = "未获取到联系人信息!";
                return result;
            }

            //工单信息claimInfo
            if (model.content.claimInfo != null)
            {
                if (model.content.claimInfo.repairOrderNo.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "工单信息-DRP工单号为必须项!";
                    return result;
                }
                if (model.content.workflow.workFlowNodeCode == WorkFlowNode.NuclearDamage.GetDescription())
                {
                    if (model.content.claimInfo.claimNo.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "工单信息-定损单号为必须项!";
                        return result;
                    }
                }

                if (model.content.workflow.assignDate == WorkFlowNode.NuclearDamage.GetDescription())
                {
                    if (model.content.workflow.assignDate.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "工单信息-任务分配时间为必须项!";
                        return result;
                    }
                }


                if (model.content.claimInfo.sourceType.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "工单信息-业务来源为必须项!";
                    return result;
                }
            }
            else
            {
                result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                result.resultMsg = "未获取到工单信息!";
                return result;
            }

            //保险公司 insuranceCompany
            if (model.content.workflow.workFlowNodeCode == WorkFlowNode.NuclearDamage.GetDescription())
            {
                if (model.content.insuranceCompany != null)
                {
                    if (model.content.insuranceCompany.insuranceCompanyGroupCode.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "保险公司-保险公司Code为必须项!";
                        return result;
                    }
                    if (model.content.insuranceCompany.insuranceCompanyGroupName.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "保险公司-保险公司名称为必须项!";
                        return result;
                    }
                    if (model.content.insuranceCompany.insuranceCompanyCode.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "保险公司-保险公司分支机构Code为必须项!";
                        return result;
                    }
                    if (model.content.insuranceCompany.insuranceCompanyName.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "保险公司-保险公司分支机构名称为必须项!";
                        return result;
                    }
                }
                else
                {
                    result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                    result.resultMsg = "未获取到保险公司信息!";
                    return result;
                }
            }

            //事故信息accInfo
            if (model.content.accInfo != null)
            {
                if (model.content.workflow.workFlowNodeCode == WorkFlowNode.NuclearDamage.GetDescription())
                {
                    if (model.content.accInfo.reportNo.IsNullOrWhiteSpace())
                    {
                        result.resultCode = ResultCode.EntriesMustNotBeNull;
                        result.resultMsg = "事故信息-报案号为必须项!";
                        return result;
                    }
                }
            }
            else
            {
                result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                result.resultMsg = "未获取到事故信息!";
                return result;
            }

            //费率折扣 discountRate
            if (model.content.discountRate != null)
            {
                if (model.content.discountRate.partType.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-配件渠道名称为必须项!";
                    return result;
                }
                if (model.content.discountRate.partTypeCode.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-配件渠道CODE为必须项!";
                    return result;
                }
                if (model.content.discountRate.manageRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-配件折扣率为必须项!";
                    return result;
                }
                if (model.content.discountRate.laborFeeManageRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-工时折扣率为必须项!";
                    return result;
                }
                if (model.content.discountRate.electricianMachinistRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-机电为必须项!";
                    return result;
                }
                if (model.content.discountRate.sheetMetalRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-钣金为必须项!";
                    return result;
                }
                if (model.content.discountRate.paintRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-喷漆为必须项!";
                    return result;
                }
                if (model.content.discountRate.multiPaintDiscountRate.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "费率折扣-多面喷漆折扣率为必须项!";
                    return result;
                }
            }
            else
            {
                result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                result.resultMsg = "未获取到事故信息!";
                return result;
            }

            //定损项目费用合计 feeTotal
            if (model.content.feeTotal != null)
            {
                if (model.content.feeTotal.partFee.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-配件费用为必须项!";
                    return result;
                }
                if (model.content.feeTotal.laborFee.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-工时费用为必须项!";
                    return result;
                }
                if (model.content.feeTotal.materialFee.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-辅料费用为必须项!";
                    return result;
                }
                if (model.content.feeTotal.entireSalvage.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-整单残值为必须项!";
                    return result;
                }
                if (model.content.feeTotal.totalSalvage.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-残值总计为必须项!";
                    return result;
                }
                if (model.content.feeTotal.depreciation.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-折旧费为必须项!";
                    return result;
                }
                if (model.content.feeTotal.manageFee.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-管理费为必须项!";
                    return result;
                }
                if (model.content.feeTotal.estimateAmount.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-定损金额为必须项!";
                    return result;
                }
                if (model.content.feeTotal.rescueFee.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-施救费为必须项!";
                    return result;
                }
                if (model.content.feeTotal.lossTotal.IsNullOrWhiteSpace())
                {
                    result.resultCode = ResultCode.EntriesMustNotBeNull;
                    result.resultMsg = "定损项目费用合计-损失金额为必须项!";
                    return result;
                }
            }
            else
            {
                result.resultCode = ResultCode.DataFormatDoesNotMeetRequirements;
                result.resultMsg = "未获取到定损项目费用合计信息!";
                return result;
            }

            return result;
        }
    }
}
