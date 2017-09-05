using System.Collections.Generic;

namespace CZB.Web.Models
{
    /// <summary>
    /// 获取保单公司类型和险种
    /// </summary>
    public class InsureListReturn
    {
        public string InsureCode { get; set; }

        public string InsureName { get; set; }

        public List<TypeList> typeList { get; set; }

        public List<Insurance> InsuranceList { get; set; }
    }

    public class TypeList
    {
        public string ParaName { get; set; }

        public string ParaValue { get; set; }
    }

    /// <summary>
    /// 险种类型列表
    /// </summary>
    public class Insurance
    {

        public string InsuranceTypeId { get; set; }

        public string InsuranceName { get; set; }

        public string InsurancrMoney { get; set; }
    }
}
