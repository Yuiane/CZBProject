using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;
using System.IO;
using System.Security.Cryptography;
using CZB.Web.Areas.Adm1n_L0g1n.Models;
using Senparc.Weixin.MP.AdvancedAPIs;

namespace CZB.Web.Areas.Adm1n_L0g1n.Controllers
{
    public class MaterialController : BaseController
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

        public ActionResult GetOnlineList()
        {
            var result = MediaApi.GetNewsMediaList("", 0, 5);
            return Content(result.ToJson());
        }




        /// <summary>
        /// 修改&新增 页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Update(string id)
        {
            MaterialModel model = new MaterialModel();
            if (id.IsNotNullOrWhiteSpace())
            {
                model.info = new BLL.Materials().GetModelById(id).Tables[0].ToEntity<Model.Material>();
            }
            return View(model);
        }

        /// <summary>
        /// 修改&新增业务方法
        /// </summary>
        /// <returns></returns>
        public ActionResult AddOrUpdate()
        {

            var id = Request.Form["txtId"].ToStringEx();
            var context = Request.Form["txtContent"].ToStringEx();
            var linkuurl = Request.Form["txtKeyWord"].ToStringEx();
            var state = Request.Form["selectState"].ToInt32();
            var replyState = Request.Form["selectReplyType"].ToInt32();
            var imgUrl = Upload(System.Web.HttpContext.Current.Request.Files);
            if (id.IsNotNullOrWhiteSpace())
            {
                //修改
                Model.Material model = new BLL.Materials().GetModelById(id).Tables[0].ToEntity<Model.Material>();
                if (model != null)
                {
                    model.Context = context;
                    model.LinkUrl = linkuurl;
                    model.State = state;
                    model.ReplyType = replyState;
                    model.UpdateTime = DateTime.Now;
                    if (imgUrl.IsNotNullOrWhiteSpace())
                    {
                        model.ImageUrl = imgUrl;
                    }
                    if (new BLL.Materials().Update(model))
                    {
                        return Content("1");
                    }
                    else
                    {
                        return Content("2");
                    }
                }
            }

            else
            {
                //新增
                Model.Material model = new Model.Material()
                {
                    ID = Guid.NewGuid().ToStringEx(),
                    Context = context,
                    ImageUrl = "",
                    ReplyType = replyState,
                    State = state,
                    LinkUrl = linkuurl
                };
                if (imgUrl.IsNotNullOrWhiteSpace())
                {
                    model.ImageUrl = imgUrl;
                }

                if (new BLL.Materials().Add(model))
                {
                    return Content("3");
                }
                else
                {
                    return Content("4");
                }
            }
            return Content("0");
        }


        /// <summary>
        /// 上传图片
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        public string Upload(HttpFileCollection files)
        {
            try
            {
                //HttpFileCollection files = System.Web.HttpContext.Current.Request.Files;
                if (files.Count == 0) return string.Empty;
                MD5 md5Hasher = new MD5CryptoServiceProvider();
                /*计算指定Stream对象的哈希值*/
                byte[] arrbytHashValue = md5Hasher.ComputeHash(files[0].InputStream);
                /*由以连字符分隔的十六进制对构成的String，其中每一对表示value中对应的元素；例如“F-2C-4A”*/
                string strHashData = System.BitConverter.ToString(arrbytHashValue).Replace("-", "");
                string FileEextension = Path.GetExtension(files[0].FileName);
                string uploadDate = DateTime.Now.ToString("yyyyMMdd");
                string virtualPath = string.Format("/upload/{0}/{1}{2}", uploadDate, strHashData, FileEextension);
                string fullFileName = Server.MapPath(virtualPath);
                //创建文件夹，保存文件  
                string path = Path.GetDirectoryName(fullFileName);
                Directory.CreateDirectory(path);
                if (!System.IO.File.Exists(fullFileName))
                {
                    files[0].SaveAs(fullFileName);
                }
                return virtualPath;
            }
            catch { }
            return string.Empty;
        }
    }
}