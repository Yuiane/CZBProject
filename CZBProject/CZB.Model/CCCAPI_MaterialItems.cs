using System;
namespace CZB.Model
{
	/// <summary>
	/// CCCAPI_MaterialItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CCCAPI_MaterialItems
	{
		public CCCAPI_MaterialItems()
		{}
		#region Model
		private string _id;
		private decimal? _itemid;
		private string _itemname;
		private bool _manualflag;
		private string _materialunit;
		private decimal? _partquantity;
		private decimal? _unitprice;
		private decimal? _partfee;
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
		public decimal? itemid
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
		public string materialUnit
		{
			set{ _materialunit=value;}
			get{return _materialunit;}
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
		public decimal? unitPrice
		{
			set{ _unitprice=value;}
			get{return _unitprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? partFee
		{
			set{ _partfee=value;}
			get{return _partfee;}
		}
		#endregion Model

	}
}

