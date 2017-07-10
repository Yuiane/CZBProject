using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CZB.Common.Extensions;
using System.IO;
using System.Security.Cryptography;

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
        public ActionResult Update(string id)
        {
            return View();
        }

        public ActionResult AddOrUpdate()
        {
            string imgUrl = Upload(System.Web.HttpContext.Current.Request.Files);
            return Content("");
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
                string virtualPath = string.Format("/Upload/{0}/{1}{2}", uploadDate, strHashData, FileEextension);
                string fullFileName = Server.MapPath(virtualPath);
                //创建文件夹，保存文件  
                string path = Path.GetDirectoryName(fullFileName);
                Directory.CreateDirectory(path);
                if (!System.IO.File.Exists(fullFileName))
                {
                    files[0].SaveAs(fullFileName);
                }
                return files[0].FileName.Substring(files[0].FileName.LastIndexOf("\\") + 1, files[0].FileName.Length - files[0].FileName.LastIndexOf("\\") - 1);
            }
            catch { }
            return string.Empty;
        }
    }
}