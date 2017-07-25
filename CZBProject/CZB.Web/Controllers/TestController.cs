using CZB.Common;
using CZB.Config;
using Senparc.Weixin.MP.Containers;
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
            //string url = "https://51.51czb.com/api/CCCApi/ClaimInfoNotification";
            //string parameter = "{\"partyId\":\"11asd123131321\",\"businessNo\":\"112321312332312123\",\"content\":\"{}\"}";

            try
            {
                string openid = Request.QueryString["openid"].ToString();
                string template_id = Request.QueryString["template_id"].ToString();
                string action = Request.QueryString["action"].ToString();
                string scene = Request.QueryString["scene"].ToString();

                if (!AccessTokenContainer.CheckRegistered(BaseConfig.AppId))
                {
                    AccessTokenContainer.Register(BaseConfig.AppId, BaseConfig.AppSecret);
                }
                string access_token = AccessTokenContainer.GetAccessToken(BaseConfig.AppId);
                string url = "https://api.weixin.qq.com/cgi-bin/message/template/subscribe?access_token=" + access_token;
                string parameter = "{\"touser\":\"" + openid + "\",\"template_id\":\"" + template_id + "\",\"url\":\"http://www.51czb.com/admin/Fx_Mobile/images/1.jpeg\",\"scene\":\"" + scene + "\",\"title\":\"什么titile\",\"data\":{\"content\":{\"关注哦\":\"VALUE\",\"color\":\"Red\"}}}";
                string result = Utils.HttpPostRequest(url, parameter);
                return Content(result);
            }
            catch
            {
                return Content("");
            }
        }
    }
}