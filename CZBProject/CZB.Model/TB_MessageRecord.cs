using System;
namespace CZB.Model
{
	/// <summary>
	/// TB_MessageRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TB_MessageRecord
	{
		public TB_MessageRecord()
		{}
		#region Model
		private string _id;
		private string _sendphone;
		private string _sendcontent;
		private DateTime? _sendtime= DateTime.Now;
		private string _sendcode;
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
		public string SendPhone
		{
			set{ _sendphone=value;}
			get{return _sendphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendContent
		{
			set{ _sendcontent=value;}
			get{return _sendcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SendTime
		{
			set{ _sendtime=value;}
			get{return _sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SendCode
		{
			set{ _sendcode=value;}
			get{return _sendcode;}
		}
		#endregion Model

	}
}

