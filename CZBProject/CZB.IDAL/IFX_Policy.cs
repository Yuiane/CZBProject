using System.Collections.Generic;
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


        /// <summary>
        /// 获取总保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        DataSet GetPolicyAll(int agentId);

        /// <summary>
        /// 获取销售所有保单
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        DataSet GetListByAgentId(int agentId);

        /// <summary>
        /// 获取我的保单列表
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        DataSet GetPolicyListByState(int agentId, int state);


        /// <summary>
        /// 根据保单编号获取保单详细信息
        /// </summary>
        /// <param name="policyId">保单编号</param>
        /// <returns></returns>
        DataSet GetListByPolicyId(int policyId);

        /// <summary>
        /// 添加保单
        /// </summary>
        /// <param name="model"></param>
        /// <param name="policyDetailList"></param>
        /// <returns></returns>
        bool AddPolicyList(Model.FX_Policy model, List<Model.FX_PolicyDetail> policyDetailList);
        #endregion  MethodEx
    }
}
