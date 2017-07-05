using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;

namespace CZB.Web.Areas.Adm1n_L0g1n.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Adm1n_L0g1n/Manager
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 回复列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var list = new BLL.AutoReply().GetList(string.Empty).Tables[0].ToEntityList<Model.AutoReply>();
            return View(list);
        }
    }
}