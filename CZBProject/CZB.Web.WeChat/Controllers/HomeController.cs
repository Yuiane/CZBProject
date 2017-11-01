using CZB.Common;
using CZB.Common.Extensions;
using CZB.Config;
using Senparc.Weixin.MP.CommonAPIs;
using System.Web.Mvc;

namespace CZB.Web.WeChat.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string urlFormat = string.Format("https://api.weixin.qq.com/cgi-bin/message/custom/send?access_token={0}", CommonApi.GetToken(BaseConfig.AppId, BaseConfig.AppSecret).access_token);
            var info = new
            {
                touser = "og-q0wg7saJnt68jajqjkunIYAsc",
                msgtype = "text",
                text = new
                {
                    content = "123"
                }
            };
            return Content(Utils.HttpPostRequest(urlFormat, info.ToJson()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
