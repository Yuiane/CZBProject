namespace CZB.Web.Api.Models
{
    /// <summary>
    /// 接口状态返回码枚举
    /// </summary>
    public enum ReturnCode
    {
        /// <summary>
        /// 请求成功
        /// </summary>
        Success = 100,

        /// <summary>
        /// 请求失败
        /// </summary>
        Error = 1,

        /// <summary>
        /// 缺少必要参数|类型不匹配
        /// </summary>
        NullOrEmpty = 1001
    }
}
