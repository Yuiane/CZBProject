using CZB.Common.Shengda.Model;
using CZB.Common.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.Shengda
{
    /// <summary>
    /// 盛大车险接口
    /// </summary>
    public static class Shengda_Api
    {
        const string SHENGDA_URL = "http://101.231.154.154:8047/v4.1";
        /// <summary>
        /// 盛大车险接口-上年投保信息查询
        /// </summary>
        /// <param name="renewal"></param>
        /// <returns></returns>
        public static string Renewal(Shengda_Renewal renewal)
        {
            try
            {
                string urlFormat = SHENGDA_URL + "/renewal";
                if (renewal != null)
                {
                    Dictionary<string, string> model = new Dictionary<string, string>();
                    model.Add("licenseNo", renewal.licenseNo);
                    model.Add("token", renewal.token);
                    model.Add("city", renewal.city);
                    model.Add("timestamp", renewal.timestamp);
                    model.Add("sign", renewal.sign);
                    return Utils.HttpPost_ShengDa(urlFormat, model);
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
