/**  版本信息模板在安装目录下，可自行修改。
* CZB_AutoReply.cs
*
* 功 能： N/A
* 类 名： CZB_AutoReply
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/4 13:48:14   袁连杰    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*/
using System;
namespace CZB.Model
{
	/// <summary>
	/// CZB_AutoReply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AutoReply
	{
		public AutoReply()
		{}
		#region Model
		private string _id;
		private int? _messagetype;
		private string _keyword;
		private int? _replytype;
		private string _replyidlist;
		private string _creater;
		private DateTime? _createtime;
		private string _updater;
		private DateTime? _updatetime;
		private int? _state;
		/// <summary>
		/// 
		/// </summary>
		public string ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 消息类型  0.关注回复 1.关键词回复
		/// </summary>
		public int? MessageType
		{
			set{ _messagetype=value;}
			get{return _messagetype;}
		}
		/// <summary>
		/// 关键词
		/// </summary>
		public string Keyword
		{
			set{ _keyword=value;}
			get{return _keyword;}
		}
		/// <summary>
		/// 0.文字 1.图片 2.图文
		/// </summary>
		public int? ReplyType
		{
			set{ _replytype=value;}
			get{return _replytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReplyIdList
		{
			set{ _replyidlist=value;}
			get{return _replyidlist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Creater
		{
			set{ _creater=value;}
			get{return _creater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Createtime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Updater
		{
			set{ _updater=value;}
			get{return _updater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 0-有效 1-无效
		/// </summary>
		public int? state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

