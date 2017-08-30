using System;
using System.Data;
namespace CZB.IDAL
{
    /// <summary>
    /// 接口层FX_PolicyDetail
    /// </summary>
    public interface IFX_PolicyDetail
    {
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int PolicyDetailsId);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(CZB.Model.FX_PolicyDetail model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.FX_PolicyDetail model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int PolicyDetailsId);
        bool DeleteList(string PolicyDetailsIdlist);
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
        /// 根据保单获取购买的险种
        /// </summary>
        /// <param name="policyId"></param>
        /// <returns></returns>
        DataSet GetList(int policyId);

        #endregion  MethodEx
    }
}
