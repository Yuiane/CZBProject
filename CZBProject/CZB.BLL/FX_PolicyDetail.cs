
using System;
using System.Data;
using System.Collections.Generic;

namespace CZB.BLL
{
	/// <summary>
	/// FX_PolicyDetail
	/// </summary>
	public partial class FX_PolicyDetail
	{
        private readonly DAL.SqlServer.DataProvider.FX_PolicyDetail dal = new DAL.SqlServer.DataProvider.FX_PolicyDetail();
		public FX_PolicyDetail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PolicyDetailsId)
		{
			return dal.Exists(PolicyDetailsId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(CZB.Model.FX_PolicyDetail model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(CZB.Model.FX_PolicyDetail model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int PolicyDetailsId)
		{
			
			return dal.Delete(PolicyDetailsId);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PolicyDetailsIdlist )
		{
			return dal.DeleteList(PolicyDetailsIdlist );
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
	
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据保单获取购买的险种
        /// </summary>
        /// <param name="policyId"></param>
        /// <returns></returns>
        public DataSet GetList(int policyId)
        {
            return dal.GetList(policyId);
        }
            #endregion  ExtensionMethod
        }
}

