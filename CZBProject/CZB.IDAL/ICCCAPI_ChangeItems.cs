using System;
using System.Data;
namespace CZB.IDAL
{
	/// <summary>
	/// 接口层CCCAPI_ChangeItems
	/// </summary>
	public interface ICCCAPI_ChangeItems
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string Id);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(CZB.Model.CCCAPI_ChangeItems model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(CZB.Model.CCCAPI_ChangeItems model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string Id);
		bool DeleteList(string Idlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		CZB.Model.CCCAPI_ChangeItems GetModel(string Id);
		CZB.Model.CCCAPI_ChangeItems DataRowToModel(DataRow row);
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
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
