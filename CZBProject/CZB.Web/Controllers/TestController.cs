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
            //{ "partyId":"5322ef2908f4f1eb4895792e5e9e54a43a936c6a","businessNo":"10000020171108008",
            //    "content":"{'repairOrderNo':'10000020171108008','repairOrderTypeCode':70,'modifyDate':'2017-11-08 14:35:30',
            //'vehicleOwnerName':'ACC17110808','vehicleOwnerTelNo':'13162636857','estimatePickCarDate':'','pickCarDate':''}"}
            #region 注册请求接口片段
            string url = "http://sit-interface.cccdrp.com/drp-interface/interface/restful/changeRepairOrderStatusRequest";
            var model = new
            {
                businessNo = "10000020171108008",
                partyId = "5322ef2908f4f1eb4895792e5e9e54a43a936c6a",
                content = new
                {
                    repairOrderNo = "10000020171108008",
                    repairOrderTypeCode = RepairOrderType.InMaintenance.GetDescription(),
                    modifyDate = DateTime.Now.ToDateString("yyyy-MM-dd HH:mm:ss"),
                    vehicleOwnerName = "ACC17110808",
                    vehicleOwnerTelNo = "13162636857",
                    messageSendTypeCode = "",
                    estimatePickCarDate = "",
                    pickCarDate = "",
                }
            };
            string postInfo = string.Format("\"partyId\":\"{0}\",\"businessNo\":\"{1}\",\"content\":\"{2}\"", model.partyId, model.businessNo, model.content.ToJson().Replace("\"", "'"));
            postInfo = "{" + postInfo + "}";
            CZB.Web.Models.UpdateDrpReturn _result = Utils.HttpRequest(url, RequestType.POST, postInfo).JsonToObj<CZB.Web.Models.UpdateDrpReturn>();
            if (_result.success)
            {
                return Content("success");
            }
            else
            {
                return Content("error");
            }

            #endregion
        }


    }
}
