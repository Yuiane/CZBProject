using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZB.Web.Open.Controllers
{
    public class CarController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Car
        public ActionResult Index()
        {
            return View();
        }
    }
}