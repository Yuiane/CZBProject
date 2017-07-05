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
            return Content(BaseConfig.DefaultInfo);
            var info = new BLL.AutoReply().GetList("");
            return Content(info.ToString());
        }
    }
}