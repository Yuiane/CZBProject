using System;
using System.Data;
namespace CZB.IDAL
{
    /// <summary>
    /// 接口层FX_Policy
    /// </summary>
    public interface IFX_Policy
    {
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int PolicyId);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(CZB.Model.FX_Policy model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.FX_Policy model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int PolicyId);
        bool DeleteList(string PolicyIdlist);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int PageSize,int PageIndex,string strWhere);
        #endregion  成员方法
        #region  MethodEx
        /// <summary>
        /// 获取当月保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        DataSet GetPolicyMonth(int agentId);
        #endregion  MethodEx
    }
}
