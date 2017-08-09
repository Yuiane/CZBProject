using CZB.Common;
using CZB.Common.CCCModel;
using CZB.Config;
using Newtonsoft.Json;
using Senparc.Weixin.MP.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;
using System.Text;
using CZB.Common.Enums;
using CZB.Common.Helpers;

namespace CZB.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string url = "http://localhost:52453/api/CCCApi/ClaimInfoNotification";
            string parameter = "{\"businessNo\":\"10000020170808005\",\"content\":{\"accInfo\":{\"reportDate\":\"2017-08-08 10:42:08\",\"reportNo\":\"17080801\"},\"claimAttachments\":[],\"claimInfo\":{\"claimNo\":\"17080801\",\"claimVersion\":\"E01\",\"repairOrderNo\":\"10000020170808005\",\"sendRepairFlag\":\"01\",\"sourceType\":\"1\"},\"contact\":{},\"discountRate\":{\"electricianMachinistRate\":40,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"paintRate\":40,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":40},\"feeTotal\":{\"deductionTotalLaborFee\":0,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":0.00,\"laborFee\":0,\"manageFee\":0.00,\"materialFee\":0,\"partFee\":0,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{\"insuranceCompanyCode\":\"30127\",\"insuranceCompanyGroupCode\":\"30126\",\"insuranceCompanyGroupName\":\"test保险公司\",\"insuranceCompanyName\":\"test分公司\"},\"lossItem\":{\"changeItems\":[],\"materialItems\":[],\"repairItems\":[]},\"repairFacility\":{\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"lossVehicleType\":\"标的车\",\"lossVehicleTypeCode\":\"01\",\"plateNo\":\"17080801\",\"purchasePrice\":15,\"vin\":\"11111111111111111\"}},\"workflow\":{\"assignDate\":\"2017-08-08 10:39:29\",\"workFlowNodeCode\":\"01\",\"workFlowNodeName\":\"定损\"}},\"partyId\":\"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\"}";
            parameter = "{\"businessNo\":\"10000020170808005\",\"content\":{\"accInfo\":{\"reportDate\":\"2017-08-08 10:42:08\",\"reportNo\":\"17080801\"},\"claimAttachments\":[{\"attachmentCategoryName\":\"车损照片\",\"attachmentId\":94546,\"attachmentName\":\"zcKtIX3CkZ14406640131841011440.jpg\",\"attachmentUrl\":\"33084/6e32919e-1e33-4111-8289-76c29ce9bf39.jpg\"},{\"attachmentCategoryName\":\"车损照片\",\"attachmentId\":94547,\"attachmentName\":\"1095a86467654e27bd7dcd5f0b86ce.jpg\",\"attachmentUrl\":\"33084/2b2b3e3c-98e5-46a4-b880-5c231082e62e.jpg\"},{\"attachmentCategoryName\":\"车损照片\",\"attachmentId\":94548,\"attachmentName\":\"448a5b0117e71669e5b20b.jpg\",\"attachmentUrl\":\"33084/bf6b5342-da75-4495-8800-50fc3caf9123.jpg\"},{\"attachmentCategoryName\":\"事故现场\",\"attachmentId\":94549,\"attachmentName\":\"448a5b0117e71669e5b20b(1).jpg\",\"attachmentUrl\":\"33084/640fd118-6351-413d-b864-ed2bf208b3d3.jpg\"},{\"attachmentCategoryName\":\"事故现场\",\"attachmentId\":94550,\"attachmentName\":\"U5030P31DT20120104101414.jpg\",\"attachmentUrl\":\"33084/2d399ff0-c672-4d8e-bcd8-92e7aeacc0c4.jpg\"}],\"claimInfo\":{\"claimNo\":\"17080801\",\"claimVersion\":\"E01\",\"repairOrderNo\":\"10000020170808005\",\"sendRepairFlag\":\"01\",\"sourceType\":\"1\"},\"contact\":{\"vehicleOwnerName\":\"17080801\",\"vehicleOwnerTelNo\":\"17080801\"},\"discountRate\":{\"electricianMachinistRate\":40,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"multiPaintDiscountRate\":100,\"paintRate\":40,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":40},\"feeTotal\":{\"deductionTotalLaborFee\":-40,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":200.00,\"laborFee\":40,\"lossTotal\":200,\"manageFee\":0.00,\"materialFee\":40,\"partFee\":120,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{\"insuranceCompanyCode\":\"30127\",\"insuranceCompanyGroupCode\":\"30126\",\"insuranceCompanyGroupName\":\"test保险公司\",\"insuranceCompanyName\":\"test分公司\"},\"lossItem\":{\"changeItems\":[{\"depreciation\":0,\"itemId\":141050,\"itemName\":\"散热器框架\",\"manualFlag\":\"0\",\"partFeeAfterDiscount\":100,\"partNo\":\"64101 1Z000\",\"partQuantity\":1,\"recycleFlag\":\"1\",\"salvage\":0,\"unitPriceAfterDiscount\":100},{\"depreciation\":0,\"itemId\":141047,\"itemName\":\"冷凝器\",\"manualFlag\":\"0\",\"partFeeAfterDiscount\":20,\"partNo\":\"97606 2H010\",\"partQuantity\":1,\"recycleFlag\":\"1\",\"salvage\":0,\"unitPriceAfterDiscount\":20}],\"materialItems\":[{\"itemId\":141048,\"itemName\":\"空调制冷剂\",\"manualFlag\":\"0\",\"partFee\":40,\"partQuantity\":2,\"unitPrice\":20}],\"repairItems\":[{\"itemId\":141050,\"itemName\":\"散热器框架\",\"laborFeeAfterDiscount\":40,\"laborFeeManageRate\":100,\"laborHour\":1,\"laborHourFee\":40,\"laborType\":\"B\",\"manualFlag\":\"0\",\"operationType\":\"04\",\"outerLaborFee\":0,\"outerRepairFlag\":\"0\",\"paintDiscountFlag\":\"1\",\"partNo\":\"64101 1Z000\"},{\"itemId\":141047,\"itemName\":\"冷凝器\",\"laborFeeAfterDiscount\":40,\"laborFeeManageRate\":100,\"laborHour\":1,\"laborHourFee\":40,\"laborType\":\"M\",\"manualFlag\":\"0\",\"operationType\":\"04\",\"outerLaborFee\":0,\"outerRepairFlag\":\"0\",\"paintDiscountFlag\":\"0\",\"partNo\":\"97606 2H010\"}]},\"repairFacility\":{\"appraiserCode\":\"lytest@x\",\"appraiserName\":\"ly\",\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"currentValue\":10,\"licenseFirstRegisterDate\":\"2017-08-08\",\"lossVehicleType\":\"标的车\",\"lossVehicleTypeCode\":\"01\",\"plateColor\":\"蓝色\",\"plateColorCode\":\"01\",\"plateNo\":\"17080801\",\"plateType\":\"小型汽车号牌\",\"plateTypeCode\":\"02\",\"purchasePrice\":15,\"usingType\":\"非营业\",\"usingTypeCode\":\"02\",\"vehicleCategory\":\"9座以下客车\",\"vehicleCategoryCode\":\"01\",\"vin\":\"11111111111111111\"},\"lossInfo\":{\"fuelRemain\":0,\"mainCollisionPoints\":\"1M\",\"mileage\":0,\"subCollisionPoints\":\"1R,1L\"},\"vehicleModel\":{\"country\":\"010\",\"vehicleManufMakeName\":\"北京现代\",\"vehicleSubModelName\":\"I30 2009款 1.6L 手动 豪享版\"}},\"workflow\":{\"assignDate\":\"2017-08-08 10:39:29\",\"estimateEndTime\":\"2017-08-08 10:48:55\",\"estimateStartTime\":\"2017-08-08 10:44:52\",\"workFlowNodeCode\":\"03\",\"workFlowNodeName\":\"核损\"}},\"partyId\":\"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\"}";
            string result = Utils.HttpPostRequest(url, parameter);
            return Content(result);
        }

        #region 注册请求接口片段
        //string url = "http://sit-interface.cccdrp.com/drp-interface/interface/restful/changeRepairOrderStatusRequest";
        //var model = new PostModel()
        //{
        //    businessNo = "00000120170726006",
        //    partyId = "5322ef2908f4f1eb4895792e5e9e54a43a936c6a",
        //    content = new PostBaseModel()
        //    {
        //        repairOrderNo = "00000120170726006",
        //        repairOrderTypeCode = RepairOrderType.Completed.GetDescription(),
        //        modifyDate = DateTime.Now.ToDateString("yyyy-MM-dd HH:mm:ss"),
        //        vehicleOwnerName = "袁xx",
        //        vehicleOwnerTelNo = "18549802931",
        //        messageSendTypeCode = MessageSendType.WeChatAndMessage.GetDescription(),
        //        estimatePickCarDate = DateTime.Now.ToDateString(),
        //        pickCarDate = DateTime.Now.ToDateString(),
        //    }
        //};
        //string postInfo = string.Format("\"partyId\":\"{0}\",\"businessNo\":\"{1}\",\"content\":\"{2}\"", model.partyId, model.businessNo, model.content.ToJson().Replace("\"", "'"));
        //postInfo = "{" + postInfo + "}";
        //LogHelper.WriteLog(LogEnum.Error, postInfo);
        //string result = Utils.HttpPostRequest(url, postInfo);
        //return Content(result);
        #endregion

    }
}