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

            string url = "http://localhost:52453/api/CCCApi/ClaimInfoNotification";
            string parameter = "{\"partyId\":\"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\",\"businessNo\":\"00000120170726003\",\"content\":{\"accInfo\":{},\"claimAttachments\":[],\"claimInfo\":{\"claimVersion\":\"E01\",\"repairOrderNo\":\"00000120170726003\",\"sourceType\":\"0\"},\"contact\":{\"vehicleOwnerName\":\"JEFF072602\",\"vehicleOwnerTelNo\":\"111\"},\"discountRate\":{\"electricianMachinistRate\":100,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"multiPaintDiscountRate\":100,\"paintRate\":110,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":90},\"feeTotal\":{\"deductionTotalLaborFee\":0,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":0,\"laborFee\":0,\"lossTotal\":0,\"manageFee\":0,\"materialFee\":0,\"partFee\":0,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{},\"lossItem\":{\"changeItems\":[],\"materialItems\":[],\"repairItems\":[]},\"repairFacility\":{\"appraiserCode\":\"jeff@xl\",\"appraiserName\":\"jeffxl\",\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"plateNo\":\"JEFF072602\",\"vin\":\"11111111111111111\"},\"lossInfo\":{\"fuelRemain\":0,\"mileage\":0,\"subCollisionPoints\":\"1R\"},\"vehicleModel\":{}},\"workflow\":{\"estimateStartTime\":\"2017-07-2610:58:39\",\"workFlowNodeCode\":\"01\",\"workFlowNodeName\":\"定损\"}}}";
            //parameter = "{\"businessNo\":\"00000120170726002\",\"content\": \"{\"accInfo\":{},\"claimAttachments\":[],\"claimInfo\":{\"claimVersion\":\"E01\",\"repairOrderNo\":\"00000120170726002\",\"sourceType\":\"0\"},\"contact\":{\"senderName\":\"联系人\",\"senderTelNo\":\"7654321\",\"vehicleOwnerName\":\"JEFF072620\",\"vehicleOwnerTelNo\":\"1234567\"},\"discountRate\":{\"electricianMachinistRate\":100,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"multiPaintDiscountRate\":100,\"paintRate\":110,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":90},\"feeTotal\":{\"deductionTotalLaborFee\":0,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":0.00,\"laborFee\":0,\"lossTotal\":0,\"manageFee\":0.00,\"materialFee\":0,\"partFee\":0,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{},\"lossItem\":{\"changeItems\":[],\"materialItems\":[],\"repairItems\":[]},\"repairFacility\":{\"appraiserCode\":\"jeff@xl\",\"appraiserName\":\"jeffxl\",\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"plateNo\":\"JEFF072620\",\"vin\":\"11111111111111111\"},\"lossInfo\":{\"fuelRemain\":42,\"itemsInCar\":\"车内物品\",\"mileage\":11,\"subCollisionPoints\":\"1R\"},\"vehicleModel\":{}},\"workflow\":{\"estimateStartTime\":\"2017-07-26 17:04:54\",\"workFlowNodeCode\":\"01\",\"workFlowNodeName\":\"定损\"}}\",\"partyId\": \"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\"}";
            //parameter = "{\"businessNo\":\"00000120170726004\",\"content\":\"{\"accInfo\":{},\"claimAttachments\":[],\"claimInfo\":{\"claimVersion\":\"E01\",\"repairOrderNo\":\"00000120170726004\",\"sourceType\":\"0\"},\"contact\":{\"vehicleOwnerName\":\"JEFF072627\",\"vehicleOwnerTelNo\":\"072627\"},\"discountRate\":{\"electricianMachinistRate\":100,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"multiPaintDiscountRate\":100,\"paintRate\":110,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":90},\"feeTotal\":{\"deductionTotalLaborFee\":0,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":0.00,\"laborFee\":0,\"lossTotal\":0,\"manageFee\":0.00,\"materialFee\":0,\"partFee\":0,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{},\"lossItem\":{\"changeItems\":[],\"materialItems\":[],\"repairItems\":[]},\"repairFacility\":{\"appraiserCode\":\"jeff@xl\",\"appraiserName\":\"jeffxl\",\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"plateNo\":\"JEFF072627\",\"vin\":\"11111111111111111\"},\"lossInfo\":{\"fuelRemain\":0,\"mileage\":0,\"subCollisionPoints\":\"1R\"},\"vehicleModel\":{}},\"workflow\":{\"estimateStartTime\":\"2017-07-26 18:00:32\",\"workFlowNodeCode\":\"01\",\"workFlowNodeName\":\"定损\"}}\",\"partyId\":\"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\"}";
            parameter = "{\"businessNo\":\"00000120170802001\",\"content\":\"{\"accInfo\":{\"reportDate\":\"2017-08-02 10:14:29\",\"reportNo\":\"DRD\"},\"claimAttachments\":[],\"claimInfo\":{\"claimNo\":\"WSS\",\"claimVersion\":\"E01\",\"repairOrderNo\":\"00000120170802001\",\"sendRepairFlag\":\"01\",\"sourceType\":\"1\"},\"contact\":{},\"discountRate\":{\"electricianMachinistRate\":100,\"laborFeeManageRate\":100,\"manageRate\":100,\"managementFee\":0,\"paintRate\":110,\"partType\":\"4S店价\",\"partTypeCode\":\"01\",\"sheetMetalRate\":90},\"feeTotal\":{\"deductionTotalLaborFee\":0,\"depreciation\":0,\"entireSalvage\":0,\"estimateAmount\":0.00,\"laborFee\":0,\"manageFee\":0.00,\"materialFee\":0,\"partFee\":0,\"rescueFee\":0,\"totalSalvage\":0},\"insuranceCompany\":{\"insuranceCompanyCode\":\"30127\",\"insuranceCompanyGroupCode\":\"30126\",\"insuranceCompanyGroupName\":\"test保险公司\",\"insuranceCompanyName\":\"test分公司\"},\"lossItem\":{\"changeItems\":[],\"materialItems\":[],\"repairItems\":[]},\"repairFacility\":{\"qualificationLevel\":\"01\",\"repairFacilityCode\":\"30124\",\"repairFacilityName\":\"test修理厂\",\"repairFacilityType\":\"01\"},\"vehicleInfo\":{\"baseInfo\":{\"lossVehicleType\":\"标的车\",\"lossVehicleTypeCode\":\"01\",\"plateNo\":\"11\",\"purchasePrice\":11,\"vin\":\"11111111111111111\"}},\"workflow\":{\"assignDate\":\"2017-08-02 10:14:39\",\"workFlowNodeCode\":\"01\",\"workFlowNodeName\":\"定损\"}},\"partyId\":\"5322ef2908f4f1eb4895792e5e9e54a43a936c6a\"}";
            string result = Utils.HttpPostRequest(url, parameter);
            return Content(result);


        }
    }
}