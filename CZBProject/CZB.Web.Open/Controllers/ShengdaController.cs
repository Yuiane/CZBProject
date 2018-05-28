using CZB.Common;
using CZB.Common.Shengda;
using CZB.Common.Shengda.Enum;
using CZB.Common.Shengda.Model;
using CZB.Common.Extensions;
using System;
using System.Web.Http;
using CZB.Web.Open.Models;

namespace CZB.Web.Open.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ShengdaController : ApiController
    {
        /// <summary>
        /// 上年投保信息查询
        /// </summary>
        /// <returns></returns>
        [HttpGet, HttpPost]
        [ActionName("Renewal")]
        public RenewalReturn Renewal()
        {
            var carNo = Request.Param("carNo").ToStringEx();
            carNo = System.Web.HttpUtility.UrlDecode(carNo).Trim().ToUpper();
            if (carNo.IsNullOrWhiteSpace())
            {
                return new RenewalReturn
                {
                    code = "error",
                    desc = "缺少参数"
                };
            }
            Shengda_Renewal model = new Shengda_Renewal()
            {
                licenseNo = carNo,
                city = CityEnum.SuZhou.GetHashCode().ToString(),
                timestamp = ((DateTime.Now.Ticks - new DateTime(1970, 1, 1).Ticks) / 10000000 - 8 * 60 * 60).ToString(),
                sign = "",
                token = Shengda_Parameter.token
            };
            RequestHandler requestHandler = new RequestHandler(null);
            requestHandler.SetParameter("licenseNo", model.licenseNo);
            requestHandler.SetParameter("city", CityEnum.SuZhou.GetHashCode().ToString());
            requestHandler.SetParameter("timestamp", model.timestamp);
            requestHandler.SetParameter("token", model.token);
            model.sign = requestHandler.CreateMd5Sign("", Shengda_Parameter.key);
            return Shengda_Api.Renewal(model).JsonToObj<RenewalReturn>();
        }
    }

}
