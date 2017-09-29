namespace CZB.Web.Api.Models
{
    /// <summary>
    /// 接口返回值
    /// </summary>
    public class ReturnResult
    {
        /// <summary>
        /// 接口返回状态 0-成功
        /// </summary>
        public ReturnCode code { get; set; }

        /// <summary>
        /// 接口返回描述
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// 接口返回信息
        /// </summary>
        public dynamic data { get; set; }
    }


}
