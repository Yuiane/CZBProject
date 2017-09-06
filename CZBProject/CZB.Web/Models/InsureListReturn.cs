using System.Collections.Generic;
using System.Linq;

namespace CZB.Web.Models
{
    /// <summary>
    /// 获取保单公司类型和险种
    /// </summary>
    public class InsureListReturn
    {
        public string InsureCode { get; set; }

        public string InsureName { get; set; }

        public string InsureShowName
        {
            get
            {
                string _n = InsureName + "(返点:";
                TypeList _t1 = typeList.FirstOrDefault(exp => exp.ParaName == "商业险直接销售返点");
                if (_t1 != null)
                {
                    _n += "商业险" + _t1.ParaValue + "%;";
                }
                TypeList _t2 = typeList.FirstOrDefault(exp => exp.ParaName == "交强险直接销售返点");
                if (_t2 != null)
                {
                    _n += "交强险" + _t2.ParaValue + "%)";
                }
                return _n;
            }
        }

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
