using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_InsureCode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_InsureCode
	{
		public FX_InsureCode()
		{}
		#region Model
		private int _insurecodeid;
		private string _insurecode;
		private string _insurename;
		private DateTime? _createtime;
		/// <summary>
		/// 
		/// </summary>
		public int InsureCodeId
		{
			set{ _insurecodeid=value;}
			get{return _insurecodeid;}
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
		public string InsureName
		{
			set{ _insurename=value;}
			get{return _insurename;}
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

