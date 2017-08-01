using System;
namespace CZB.Model
{
	/// <summary>
	/// CCCAPI_RepairItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CCCAPI_RepairItems
	{
		public CCCAPI_RepairItems()
		{}
		#region Model
		private string _id;
		private decimal? _itemid;
		private string _itemname;
		private bool _manualflag;
		private string _operationtype;
		private string _partno;
		private string _labortype;
		private decimal? _laborhourfee;
		private decimal? _laborfeemanagerate;
		private bool _paintdiscountflag;
		private decimal? _laborhour;
		private decimal? _laborfeeafterdiscount;
		private bool _outerrepairflag;
		private decimal? _outerlaborfee;
		/// <summary>
		/// 
		/// </summary>
		public string id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? itemId
		{
			set{ _itemid=value;}
			get{return _itemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string itemName
		{
			set{ _itemname=value;}
			get{return _itemname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool manualFlag
		{
			set{ _manualflag=value;}
			get{return _manualflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operationType
		{
			set{ _operationtype=value;}
			get{return _operationtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string partNo
		{
			set{ _partno=value;}
			get{return _partno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string laborType
		{
			set{ _labortype=value;}
			get{return _labortype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? laborHourFee
		{
			set{ _laborhourfee=value;}
			get{return _laborhourfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? laborFeeManageRate
		{
			set{ _laborfeemanagerate=value;}
			get{return _laborfeemanagerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool paintDiscountFlag
		{
			set{ _paintdiscountflag=value;}
			get{return _paintdiscountflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? laborHour
		{
			set{ _laborhour=value;}
			get{return _laborhour;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? laborFeeAfterDiscount
		{
			set{ _laborfeeafterdiscount=value;}
			get{return _laborfeeafterdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool outerRepairFlag
		{
			set{ _outerrepairflag=value;}
			get{return _outerrepairflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? outerLaborFee
		{
			set{ _outerlaborfee=value;}
			get{return _outerlaborfee;}
		}
		#endregion Model

	}
}

