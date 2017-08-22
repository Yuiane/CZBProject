using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_IncomeRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_IncomeRecord
	{
		public FX_IncomeRecord()
		{}
		#region Model
		private int _incomerecordid;
		private int? _incometype;
		private int? _agentid;
		private int? _comefromagentid;
		private int? _sellerid;
		private int? _policyid;
		private string _insurecode;
		private int? _insuretype;
		private decimal? _policyamount;
		private decimal? _finalamount;
		private decimal? _totalamount;
		private decimal? _totalroyaltyratio;
		private decimal? _royaltyratio;
		private decimal? _commissionamount;
		private DateTime? _createtime;
		private string _citycode;
		/// <summary>
		/// 
		/// </summary>
		public int IncomeRecordId
		{
			set{ _incomerecordid=value;}
			get{return _incomerecordid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IncomeType
		{
			set{ _incometype=value;}
			get{return _incometype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AgentId
		{
			set{ _agentid=value;}
			get{return _agentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ComeFromAgentID
		{
			set{ _comefromagentid=value;}
			get{return _comefromagentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SellerId
		{
			set{ _sellerid=value;}
			get{return _sellerid;}
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
		public string InsureCode
		{
			set{ _insurecode=value;}
			get{return _insurecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? InsureType
		{
			set{ _insuretype=value;}
			get{return _insuretype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PolicyAmount
		{
			set{ _policyamount=value;}
			get{return _policyamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FinalAmount
		{
			set{ _finalamount=value;}
			get{return _finalamount;}
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
		public decimal? TotalRoyaltyRatio
		{
			set{ _totalroyaltyratio=value;}
			get{return _totalroyaltyratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? RoyaltyRatio
		{
			set{ _royaltyratio=value;}
			get{return _royaltyratio;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CommissionAmount
		{
			set{ _commissionamount=value;}
			get{return _commissionamount;}
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
		public string CityCode
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		#endregion Model

	}
}

