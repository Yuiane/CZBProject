using CZB.Common.Extensions;
using CZB.Web.WeChat.Areas.Adm1n_L0g1n.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CZB.Web.WeChat.Areas.Adm1n_L0g1n.Controllers
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
        /// <param name="type">回复列表</param>
        /// <returns></returns>
        public ActionResult List(int? id)
        {
            var list = new BLL.AutoReplys().GetList(string.Empty).Tables[0].ToEntityList<Model.AutoReply>();
            if (id.HasValue)
            {
                if (id == 1)
                {
                    //关注
                    list = list.Where(exp => exp.MessageType == 0).ToList();
                }
                else
                {
                    //关键词
                    list = list.Where(exp => exp.MessageType == 1).ToList();
                }
            }
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
                model.info = new BLL.AutoReplys().GetModelById(id);
            }
            return View(model);
        }

        /// <summary>
        /// 修改&增加一条数据
        /// </summary>
        /// <returns></returns>
        [ValidateInput(false)]
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
                var state = Request.Form["selectState"].ToInt32();
                if (id.IsNotNullOrWhiteSpace())
                {
                    //修改
                    Model.AutoReply model = new BLL.AutoReplys().GetModelById(id);
                    model.ID = id;
                    model.Keyword = txtKeyWord;
                    model.ReplyType = selectReplyType;
                    model.MessageType = selectMessageType;
                    model.ReplyIdList = txtContent;
                    model.state = state;
                    if (new BLL.AutoReplys().Update(model))
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
                    if (new BLL.AutoReplys().Add(model))
                    {
                        return Content("3");
                    }
                    else
                    {
                        return Content("4");
                    }
                }
            }
            catch (Exception err)
            {
                return Content(err.Message);
            }
            return Content("0");
        }
    }
}
