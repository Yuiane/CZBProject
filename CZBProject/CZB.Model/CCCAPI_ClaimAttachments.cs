using System;
namespace CZB.Model
{
	/// <summary>
	/// CCCAPI_ClaimAttachments:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CCCAPI_ClaimAttachments
	{
		public CCCAPI_ClaimAttachments()
		{}
		#region Model
		private string _id;
		private string _attachmentcategoryname;
		private string _attachmenturl;
		private int? _attachmentid;
		private string _attachmentname;
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
		public string AttachmentCategoryName
		{
			set{ _attachmentcategoryname=value;}
			get{return _attachmentcategoryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AttachmentUrl
		{
			set{ _attachmenturl=value;}
			get{return _attachmenturl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AttachmentId
		{
			set{ _attachmentid=value;}
			get{return _attachmentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AttachmentName
		{
			set{ _attachmentname=value;}
			get{return _attachmentname;}
		}
		#endregion Model

	}
}

