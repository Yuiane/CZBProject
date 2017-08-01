using System;
namespace CZB.Model
{
	/// <summary>
	/// CCCAPI_ChangeItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CCCAPI_ChangeItems
	{
		public CCCAPI_ChangeItems()
		{}
		#region Model
		private string _id;
		private decimal? _itemid;
		private string _itemname;
		private bool _manualflag;
		private string _partno;
		private decimal? _partquantity;
		private decimal? _unitpriceafterdiscount;
		private decimal? _partfeeafterdiscount;
		private decimal? _depreciation;
		private decimal? _salvage;
		private bool _recycleflag;
		/// <summary>
		/// 
		/// </summary>
		public string Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ItemId
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
		public bool ManualFlag
		{
			set{ _manualflag=value;}
			get{return _manualflag;}
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
		public decimal? partQuantity
		{
			set{ _partquantity=value;}
			get{return _partquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? unitPriceAfterDiscount
		{
			set{ _unitpriceafterdiscount=value;}
			get{return _unitpriceafterdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? partFeeAfterDiscount
		{
			set{ _partfeeafterdiscount=value;}
			get{return _partfeeafterdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? depreciation
		{
			set{ _depreciation=value;}
			get{return _depreciation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? salvage
		{
			set{ _salvage=value;}
			get{return _salvage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool recycleFlag
		{
			set{ _recycleflag=value;}
			get{return _recycleflag;}
		}
		#endregion Model

	}
}

