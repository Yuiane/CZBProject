namespace CZB.Common.AutoNaviMap
{
    /// <summary>
    /// 逆地理编码
    /// http://lbs.amap.com/api/webservice/guide/api/georegeo/#regeo
    /// https://restapi.amap.com/v3/geocode/regeo?key=c8f465b4df09892839ad92a2283a5d47&location=120.733871,31.253432
    /// </summary>
    public class Regeo : Base
    {
        /// <summary>
        /// 逆地理编码列表
        /// </summary>
        public RegeoInfo regeocode { get; set; }
    }

    /// <summary>
    /// 逆地理接口返回基本信息
    /// </summary>
    public class RegeoInfo
    {
        /// <summary>
        /// 结构化地址信息包括：省份＋城市＋区县＋城镇＋乡村＋街道＋门牌号码
        /// 如果坐标点处于海域范围内，则结构化地址信息为：省份＋城市＋区县＋海域信息
        /// </summary>
        public string formatted_address { get; set; }

        /// <summary>
        /// 地址元素列表
        /// </summary>
        public AddressComponent addressComponent { get; set; }
    }

    /// <summary>
    /// 地址元素列表
    /// </summary>
    public class AddressComponent
    {
        /// <summary>
        /// 坐标点所在省名称
        /// </summary>
        public string province { get; set; }

        /// <summary>
        /// 坐标点所在城市名称
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 城市编码 例如:0512
        /// </summary>
        public string citycode { get; set; }

        /// <summary>
        /// 坐标点所在区
        /// </summary>
        public string district { get; set; }

        /// <summary>
        /// 行政区编码 例如:320506
        /// </summary>
        public string adcode { get; set; }
    }
}
