using CZB.Common;
using CZB.Common.Enums;
using CZB.Common.Extensions;
using CZB.Common.Helpers;
using System;
using System.Web.Mvc;

namespace CZB.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {

            #region 注册请求接口片段
            string url = "http://sit-interface.cccdrp.com/drp-interface/interface/restful/changeRepairOrderStatusRequest";
            var model = new
            {
                businessNo = "00000120170726006",
                partyId = "5322ef2908f4f1eb4895792e5e9e54a43a936c6a",
                content = new
                {
                    repairOrderNo = "00000120170726006",
                    repairOrderTypeCode = RepairOrderType.Completed.GetDescription(),
                    modifyDate = DateTime.Now.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    vehicleOwnerName = "袁xx",
                    vehicleOwnerTelNo = "18549802931",
                    messageSendTypeCode = MessageSendType.WeChatAndMessage.GetDescription(),
                    estimatePickCarDate = DateTime.Now.ToDateString(),
                    pickCarDate = DateTime.Now.ToDateString(),
                }
            };
            string postInfo = string.Format("\"partyId\":\"{0}\",\"businessNo\":\"{1}\",\"content\":\"{2}\"", model.partyId, model.businessNo, model.content.ToJson().Replace("\"", "'"));
            postInfo = "{" + postInfo + "}";
            LogHelper.WriteLog(LogEnum.Error, postInfo);
            string result = Utils.HttpPostRequest(url, postInfo);
            return Content(result);
            #endregion
        }
    }
}
