namespace CZB.Common.AutoNaviMap
{
    /// <summary>
    /// 返回基类
    /// </summary>
    public class Base
    {
        /// <summary>
        /// 返回值为 0 或 1，0 表示请求失败；1 表示请求成功。
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 当 status 为 0 时，info 会返回具体错误原因，否则返回“OK”。详情可以参考
        /// </summary>
        public string info { get; set; }

        /// <summary>
        /// 10000 请求正常 异常对应码 
        /// http://lbs.amap.com/api/webservice/guide/tools/info
        /// </summary>
        public string infocode { get; set; }
    }
}
