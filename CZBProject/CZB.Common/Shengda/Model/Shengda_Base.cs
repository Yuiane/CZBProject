using CZB.Common.Shengda.Enum;

namespace CZB.Common.Shengda.Model
{
    /// <summary>
    /// 盛世车险接口基本参数
    /// </summary>
    public class Shengda_Base
    {
        public string token { get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        public string city { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        public string sign { get; set; }
    }
}
