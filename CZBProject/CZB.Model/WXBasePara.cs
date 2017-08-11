/**  版本信息模板在安装目录下，可自行修改。
* FX_WXBasePara.cs
*
* 功 能： N/A
* 类 名： FX_WXBasePara
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/8/10 17:29:31   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_WXBasePara:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WXBasePara
	{
		public WXBasePara()
		{}
		#region Model
		private string _appid;
		private string _appsecret;
		private string _baseaccesstoken;
		private DateTime? _basetokenstarttime;
		private string _accesstokennotbase;
		private DateTime? _notbasetokenstarttime;
		private string _notbaserefreshtoken;
		private string _jsapi_ticket;
		private DateTime? _jsapi_tickettime;
		private string _api_ticket;
		private DateTime? _api_tickettime;
		/// <summary>
		/// 
		/// </summary>
		public string AppId
		{
			set{ _appid=value;}
			get{return _appid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppSecret
		{
			set{ _appsecret=value;}
			get{return _appsecret;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BaseAccessToken
		{
			set{ _baseaccesstoken=value;}
			get{return _baseaccesstoken;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BaseTokenStartTime
		{
			set{ _basetokenstarttime=value;}
			get{return _basetokenstarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AccessTokenNotBase
		{
			set{ _accesstokennotbase=value;}
			get{return _accesstokennotbase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NotBaseTokenStartTime
		{
			set{ _notbasetokenstarttime=value;}
			get{return _notbasetokenstarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NotBaseRefreshToken
		{
			set{ _notbaserefreshtoken=value;}
			get{return _notbaserefreshtoken;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string jsapi_ticket
		{
			set{ _jsapi_ticket=value;}
			get{return _jsapi_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? jsapi_ticketTime
		{
			set{ _jsapi_tickettime=value;}
			get{return _jsapi_tickettime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string api_ticket
		{
			set{ _api_ticket=value;}
			get{return _api_ticket;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? api_ticketTime
		{
			set{ _api_tickettime=value;}
			get{return _api_tickettime;}
		}
		#endregion Model

	}
}

