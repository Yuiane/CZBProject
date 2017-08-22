﻿using System;
using System.Data;
namespace CZB.IDAL
{
	/// <summary>
	/// 接口层FX_IncomeRecord
	/// </summary>
	public interface IFX_IncomeRecord
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int IncomeRecordId);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(CZB.Model.FX_IncomeRecord model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(CZB.Model.FX_IncomeRecord model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int IncomeRecordId);
		bool DeleteList(string IncomeRecordIdlist );
		
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}