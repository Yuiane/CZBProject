using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;
using CZB.Web.Areas.Adm1n_L0g1n.Models;

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

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Update(string id)
        {
            AutoReplyModel model = new AutoReplyModel();
            if (id.IsNotNullOrWhiteSpace())
            {
                model.info = new BLL.AutoReply().GetModelById(id);
            }
            return View(model);
        }

        /// <summary>
        /// 修改&增加一条数据
        /// </summary>
        /// <returns></returns>
        public ActionResult AddOrUpdate()
        {
            try
            {
                string id = Request.Form["txtId"].ToStringEx();
                var txtKeyWord = Request.Form["txtKeyWord"].ToStringEx();
                var selectReplyType = Request.Form["selectReplyType"].ToInt32();
                var selectMessageType = Request.Form["selectMessageType"].ToInt32();
                var txtContent = Request.Form["txtContent"].ToStringEx();
                var selectState = Request.Form["selectState"].ToInt32();
                var state = Request.Form["state"].ToInt32();
                if (id.IsNotNullOrWhiteSpace())
                {
                    //修改
                    Model.AutoReply model = new BLL.AutoReply().GetModelById(id);
                    model.ID = id;
                    model.Keyword = txtKeyWord;
                    model.ReplyType = selectReplyType;
                    model.MessageType = selectMessageType;
                    model.ReplyIdList = txtContent;
                    model.state = state;
                    if (new BLL.AutoReply().Update(model))
                    {
                        return Content("1");
                    }
                    else
                    {

                        return Content("2");
                    }
                }
                else
                {
                    //新增
                    Model.AutoReply model = new Model.AutoReply();
                    model.ID = Guid.NewGuid().ToStringEx();
                    model.Keyword = txtKeyWord;
                    model.ReplyType = selectReplyType;
                    model.MessageType = selectMessageType;
                    model.ReplyIdList = txtContent;
                    model.state = state;
                    if (new BLL.AutoReply().Add(model))
                    {
                        return Content("3");
                    }
                    else
                    {
                        return Content("4");
                    }
                }
            }
            catch(Exception err)
            {
                return Content(err.Message);
            }
            return Content("0");
        }
    }
}