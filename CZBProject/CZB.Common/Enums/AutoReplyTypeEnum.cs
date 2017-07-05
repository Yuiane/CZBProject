using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.Enums
{
    /// <summary>
    /// 公众号回复消息类型
    /// 0.文字 1.图片 2.图文
    /// </summary>
    public enum AutoReplyTypeEnum
    {
        /// <summary>
        /// 文字
        /// </summary>
        Text = 0,

        /// <summary>
        /// 图片
        /// </summary>
        Image = 1,

        /// <summary>
        /// 图文
        /// </summary>
        All = 2
    }
}
