using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_CityParaDetails:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_CityParaDetails
	{
		public FX_CityParaDetails()
		{}
		#region Model
		private int _cityparadetailsid;
		private int? _citycode;
		private string _paracode;
		private string _paravalue;
		private DateTime _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int CityParaDetailsId
		{
			set{ _cityparadetailsid=value;}
			get{return _cityparadetailsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CityCode
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParaCode
		{
			set{ _paracode=value;}
			get{return _paracode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ParaValue
		{
			set{ _paravalue=value;}
			get{return _paravalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		#endregion Model

	}
}

