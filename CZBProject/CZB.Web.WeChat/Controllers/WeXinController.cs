﻿using CZB.Common;
using CZB.Common.Enums;
using CZB.Common.Extensions;
using CZB.Config;
using CZB.Web.WeXin.CommonService.MessageHandlers.CustomMessageHandler;
using Senparc.Weixin.MP;
using Senparc.Weixin.MP.Entities.Request;
using Senparc.Weixin.MP.MvcExtension;
using System.Web.Mvc;

namespace CZB.Web.WeChat.Controllers
{
    public class WeXinController : Controller
    {
        public static readonly string Token = BaseConfig.Token;
        public static readonly string EncodingAESKey = BaseConfig.EncodingAESKey;
        public static readonly string AppId = BaseConfig.AppId;

        /// <summary>
        /// 微信后台验证地址（使用Get），微信后台的“接口配置信息”的Url填写如：http://sdk.weixin.senparc.com/weixin
        /// </summary>
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Get(PostModel postModel, string echostr)
        {
            if (CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, Token))
            {
                return Content(echostr); //返回随机字符串则表示验证通过
            }
            else
            {
                return Content("failed:" + postModel.Signature + "," + CheckSignature.GetSignature(postModel.Timestamp, postModel.Nonce, Token) + "。" +
                    "如果你在浏览器中看到这句话，说明此地址可以被作为微信公众账号后台的Url，请注意保持Token一致。");
            }
        }

        /// <summary>
        /// 最简化的处理流程（不加密）
        /// </summary>
        [HttpPost]
        [ActionName("Index")]
        public ActionResult MiniPost(PostModel postModel)
        {
            if (!CheckSignature.Check(postModel.Signature, postModel.Timestamp, postModel.Nonce, Token))
            {
                //return Content("参数错误！");//v0.7-
                return new WeixinResult("参数错误！");//v0.8+
            }

            postModel.Token = Token;
            postModel.EncodingAESKey = EncodingAESKey;//根据自己后台的设置保持一致
            postModel.AppId = AppId;//根据自己后台的设置保持一致

            var messageHandler = new CustomMessageHandler(Request.InputStream, postModel, 10);

            messageHandler.Execute();//执行微信处理过程

            //return Content(messageHandler.ResponseDocument.ToString());//v0.7-
            //return new WeixinResult(messageHandler);//v0.8+

            var result = new FixWeixinBugWeixinResult(messageHandler);//v0.8+
            LogHelper.WriteLog(LogEnum.Error, result.ToJson());
            if (result.ToJson().Contains("success"))
            {
                return Content("success");
            }
            return result;
        }
    }
}