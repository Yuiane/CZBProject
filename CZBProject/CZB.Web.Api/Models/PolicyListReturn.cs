namespace CZB.Web.Api.Models
{
    /// <summary>
    /// 保单列表返回接口
    /// </summary>
    public class PolicyListReturn
    {
        /// <summary>
        /// 保单编号
        /// </summary>
        public string policyId { get; set; }

        //车牌名称 carNo
        public string carName { get; set; }

        //保险公司 insureName

        public string insureName { get; set; }
        //保额 policyAmount

        public string policyAmount { get; set; }
        //车主名称 customerName

        public string customerName { get; set; }
        //车主号码 moblie

        public string moblie { get; set; }
        //日期 createTime

        public string createTime { get; set; }
        //被拒原因 CancelRemark

        public string cancelRemark { get; set; }
    }
}
