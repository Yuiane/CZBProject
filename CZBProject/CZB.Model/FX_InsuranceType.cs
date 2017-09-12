using System;
namespace CZB.Model
{
    /// <summary>
    /// FX_InsuranceType:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FX_InsuranceType
    {
        public FX_InsuranceType()
        { }
        #region Model
        private int _insurancetypeid;
        private string _insurancename;
        private int? _insurancrmoney;
        /// <summary>
        /// 
        /// </summary>
        public int InsuranceTypeId
        {
            set { _insurancetypeid = value; }
            get { return _insurancetypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InsuranceName
        {
            set { _insurancename = value; }
            get { return _insurancename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? InsurancrMoney
        {
            set { _insurancrmoney = value; }
            get { return _insurancrmoney; }
        }
        #endregion Model

    }
}
