using CZB.Common;
using CZB.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZB.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            string url = "https://51.51czb.com/api/CCCApi/ClaimInfoNotification";
            string parameter = "{\"partyId\":\"11asd123131321\",\"businessNo\":\"112321312332312123\",\"content\":\"{}\"}";
            string result = Utils.HttpPostRequest(url, parameter);
            return Content(result);
    }
}
}