using System;
namespace CZB.Model
{
    /// <summary>
    /// FX_InsureParaDetail:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FX_InsureParaDetail
    {
        public FX_InsureParaDetail()
        { }
        #region Model
        private int _insureparadetailsid;
        private string _paracode;
        private string _insurecode;
        private string _paravalue;
        private string _citycode;
        /// <summary>
        /// 
        /// </summary>
        public int InsureParaDetailsId
        {
            set { _insureparadetailsid = value; }
            get { return _insureparadetailsid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParaCode
        {
            set { _paracode = value; }
            get { return _paracode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InsureCode
        {
            set { _insurecode = value; }
            get { return _insurecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParaValue
        {
            set { _paravalue = value; }
            get { return _paravalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CityCode
        {
            set { _citycode = value; }
            get { return _citycode; }
        }
        #endregion Model

    }
}
