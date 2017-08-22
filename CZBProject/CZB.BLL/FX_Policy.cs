using System;
using System.Data;
using System.Collections.Generic;
namespace CZB.BLL
{
    /// <summary>
    /// FX_Policy
    /// </summary>
    public partial class FX_Policy
    {
        private readonly DAL.SqlServer.DataProvider.FX_Policy dal = new DAL.SqlServer.DataProvider.FX_Policy();
        public FX_Policy()
        { }
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
        public bool Exists(int PolicyId)
        {
            return dal.Exists(PolicyId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_Policy model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_Policy model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PolicyId)
        {

            return dal.Delete(PolicyId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string PolicyIdlist)
        {
            return dal.DeleteList(PolicyIdlist);
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
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        /// 获取当月保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        public DataSet GetPolicyMonth(int agentId)
        {
            return dal.GetPolicyMonth(agentId);
        }

        #endregion  ExtensionMethod
    }
}

