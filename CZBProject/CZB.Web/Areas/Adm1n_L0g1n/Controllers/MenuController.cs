using CZB.Common.Extensions;
using CZB.Config;
using Senparc.Weixin;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.CommonAPIs;
using Senparc.Weixin.MP.Containers;
using Senparc.Weixin.MP.Entities.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZB.Web.Areas.Adm1n_L0g1n.Controllers
{
    public class MenuController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        // GET: Adm1n_L0g1n/Menu
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 获取当前菜单
        /// </summary>
        /// <returns></returns>
        public JsonResult GetMenu()
        {
            if (!AccessTokenContainer.CheckRegistered(BaseConfig.AppId))
            {
                AccessTokenContainer.Register(BaseConfig.AppId, BaseConfig.AppSecret);
            }
            var result = CommonApi.GetMenu(BaseConfig.AppId);
            if (result.errcode == ReturnCode.请求成功)
            {
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            return Json("", JsonRequestBehavior.AllowGet);
        }
    }
}