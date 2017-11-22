using Newtonsoft.Json;

namespace CZB.Common.AutoNaviMap
{
    /// <summary>
    /// 高德地图api接口
    /// </summary>
    public class AutoNaviMapApi
    {
        /// <summary>
        /// 逆地址编码
        /// </summary>
        /// <param name="longitude">经度</param>
        /// <param name="latitude">纬度</param>
        /// <returns></returns>
        public Regeo SendRegeo(string longitude, string latitude)
        {
            try
            {
                var urlFormat = string.Format("http://restapi.amap.com/v3/geocode/regeo?key={0}&&location={1},{2}",
                    "c8f465b4df09892839ad92a2283a5d47", longitude, latitude);
                string _value = Utils.HttpGet(urlFormat);
                if (!string.IsNullOrEmpty(_value))
                {
                    return JsonConvert.DeserializeObject<Regeo>(_value);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
