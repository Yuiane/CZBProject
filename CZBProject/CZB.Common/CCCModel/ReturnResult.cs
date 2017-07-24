using CZB.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.CCCModel
{
    /// <summary>
    /// 返回结果集
    /// </summary>
    public class ReturnResult
    {
        /// <summary>
        /// 处理结果码表Code
        /// </summary>
        public ResultCode resultCode { get; set; }

        /// <summary>
        /// 处理结果消息字符型
        /// </summary>
        public string resultMsg { get; set; }

        /// <summary>
        /// DRP工单号字符型
        /// </summary>
        public string repairOrderNo { get; set; }
    }
}
