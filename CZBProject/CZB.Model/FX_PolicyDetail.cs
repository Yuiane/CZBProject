using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_PolicyDetail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_PolicyDetail
	{
		public FX_PolicyDetail()
		{}
		#region Model
		private int _policydetailsid;
		private int? _policyid;
		private int? _insurancetypeid;
		private string _insurancetypedetail;
		private decimal? _totalamount;
		private DateTime? _createtime;
		private DateTime? _updatetime;
		private int? _isuse=0;
		/// <summary>
		/// 
		/// </summary>
		public int PolicyDetailsId
		{
			set{ _policydetailsid=value;}
			get{return _policydetailsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PolicyId
		{
			set{ _policyid=value;}
			get{return _policyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InsuranceTypeId
		{
			set{ _insurancetypeid=value;}
			get{return _insurancetypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InsuranceTypeDetail
		{
			set{ _insurancetypedetail=value;}
			get{return _insurancetypedetail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TotalAmount
		{
			set{ _totalamount=value;}
			get{return _totalamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsUse
		{
			set{ _isuse=value;}
			get{return _isuse;}
		}
		#endregion Model

	}
}

