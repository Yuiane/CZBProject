namespace CZB.Web.Api.Models
{
    /// <summary>
    /// 获取保险公司返点列表
    /// </summary>
    public class InsureModel
    {

        public string InsureCode { get; set; }

        public string InsureName { get; set; }

        public string ParaName { get; set; }

        public string ParaValue { get; set; }
    }

    /// <summary>
    /// 险种类型列表
    /// </summary>
    public class InsuranceModel
    {

        public string InsuranceTypeId { get; set; }

        public string InsuranceName { get; set; }

        public string InsurancrMoney { get; set; }

        public string InsureCode { get; set; }
    }

}
