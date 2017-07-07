using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;

namespace CZB.Web.Areas.Adm1n_L0g1n.Controllers
{
    public class MaterialController : Controller
    {
        // GET: Adm1n_L0g1n/Material
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 素材列表
        /// </summary>
        /// <returns></returns>
        public ActionResult List()
        {
            var list = new BLL.Materials().GetAllList().Tables[0].ToEntityList<Model.Material>();

            return View(list);
        }

        /// <summary>
        /// 修改&新增
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
    }
}