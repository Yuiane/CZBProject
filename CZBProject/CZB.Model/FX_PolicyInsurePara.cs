using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_PolicyInsurePara:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_PolicyInsurePara
	{
		public FX_PolicyInsurePara()
		{}
		#region Model
		private int _fx_policyinsuremoneyparaid;
		private int? _policyid;
		private string _insurecode;
		private decimal? _businesstotal;
		private decimal? _businesscommission;
		private decimal? _businesscommissionlevel1;
		private decimal? _businesscommissionlevel2;
		private decimal? _businesstax;
		private decimal? _compulsorytotal;
		private decimal? _compulsorycommission;
		private decimal? _compulsorycommissionlelve1;
		private decimal? _compulsorycommissionlelve2;
		private decimal? _compulsorytax;
		private DateTime? _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int FX_PolicyInsureMoneyParaID
		{
			set{ _fx_policyinsuremoneyparaid=value;}
			get{return _fx_policyinsuremoneyparaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PolicyID
		{
			set{ _policyid=value;}
			get{return _policyid;}
		}
		/// <summary>
		/// 保险公司编号
		/// </summary>
		public string InsureCode
		{
			set{ _insurecode=value;}
			get{return _insurecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessTotal
		{
			set{ _businesstotal=value;}
			get{return _businesstotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessCommission
		{
			set{ _businesscommission=value;}
			get{return _businesscommission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessCommissionLevel1
		{
			set{ _businesscommissionlevel1=value;}
			get{return _businesscommissionlevel1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessCommissionLevel2
		{
			set{ _businesscommissionlevel2=value;}
			get{return _businesscommissionlevel2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessTax
		{
			set{ _businesstax=value;}
			get{return _businesstax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryTotal
		{
			set{ _compulsorytotal=value;}
			get{return _compulsorytotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryCommission
		{
			set{ _compulsorycommission=value;}
			get{return _compulsorycommission;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryCommissionLelve1
		{
			set{ _compulsorycommissionlelve1=value;}
			get{return _compulsorycommissionlelve1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryCommissionLelve2
		{
			set{ _compulsorycommissionlelve2=value;}
			get{return _compulsorycommissionlelve2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryTax
		{
			set{ _compulsorytax=value;}
			get{return _compulsorytax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

