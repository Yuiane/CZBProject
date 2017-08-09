using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZB.Web.Controllers
{
    public class WechatController : Controller
    {
        // GET: Wechat
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// 微信H5仿易启秀【swiper】案例页
        /// </summary>
        /// <returns></returns>
        public ActionResult Html5_One()
        {
            return View();
        }
    }
}