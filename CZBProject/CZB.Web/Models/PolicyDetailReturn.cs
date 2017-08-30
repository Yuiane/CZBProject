using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZB.Web.Models
{
    /// <summary>
    /// 保单详情返回字段
    /// </summary>
    public class PolicyDetailReturn
    {
        /// <summary>
        /// 保单详情基础信息
        /// </summary>
        public PolicyDetailInfo policyDetailInfo { get; set; }

        /// <summary>
        /// 险种列表
        /// </summary>
        public List<InsureTypeDetail> InsureTypeList { get; set; }
    }

    /// <summary>
    /// 保单详情基础信息
    /// </summary>
    public class PolicyDetailInfo
    {
        //车主
        public string customerName { get; set; }

        //保险公司
        public string insureName { get; set; }

        //车牌
        public string carNo { get; set; }

        //Vin
        public string carVin { get; set; }

        //总报价
        public string policyAmount { get; set; }

        //开始时间
        public string startTime { get; set; }

        //结束时间
        public string endTime { get; set; }

        //商业险预计提成
        public string policyBusiness { get; set; }

        //交强险预计提成
        public string policyCompulsory { get; set; }

        //支付信息
        public string PayUrl { get; set; }

    }


    /// <summary>
    /// 险种列表
    /// </summary>
    public class InsureTypeDetail
    {
        /// <summary>
        /// 险种名称
        /// </summary>
        public string insureTypeName { get; set; }

        /// <summary>
        /// 险种金额
        /// </summary>
        public string insureMoney { get; set; }
    }
}