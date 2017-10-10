using CZB.Common.Enums;
using System;

namespace CZB.Web.Models
{
    public class UpdateDrpInfo
    {
        /// <summary>
        /// 工单号
        /// </summary>
        public string repairOrderNo { get; set; }

        /// <summary>
        /// 当前维修状态
        /// </summary>
        public RepairOrderType repairOrderTypeCode { get; set; }

        /// <summary>
        /// 车主
        /// </summary>
        public string vehicleOwnerName { get; set; }

        /// <summary>
        /// 车主电话
        /// </summary>
        public string vehicleOwnerTelNo { get; set; }

        /// <summary>
        /// 预计提车日期
        /// </summary>
        public DateTime? estimatePickCarDate { get; set; }

        /// <summary>
        /// 提车日期
        /// </summary>
        public DateTime? pickCarDate { get; set; }

    }
}
