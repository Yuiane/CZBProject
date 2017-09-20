using System.Collections.Generic;
using System.Data;
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

        /// <summary>
        /// 获取总保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        public DataSet GetPolicyAll(int agentId)
        {
            return dal.GetPolicyAll(agentId);
        }

        /// <summary>
        /// 获取销售所有保单
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public DataSet GetListByAgentId(int agentId)
        {
            return dal.GetListByAgentId(agentId);
        }

        /// <summary>
        /// 根据保单编号获取保单详细信息
        /// </summary>
        /// <param name="policyId">保单编号</param>
        /// <returns></returns>
        public DataSet GetListByPolicyId(int policyId)
        {
            return dal.GetListByPolicyId(policyId);
        }


        /// <summary>
        /// 获取我的保单列表
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public DataSet GetPolicyListByState(int agentId, int state)
        {
            return dal.GetPolicyListByState(agentId, state);
        }


        /// <summary>
        /// 添加保单
        /// </summary>
        /// <param name="model"></param>
        /// <param name="policyDetailList"></param>
        /// <returns></returns>
        public bool AddPolicyList(Model.FX_Policy model, List<Model.FX_PolicyDetail> policyDetailList)
        {
            return dal.AddPolicyList(model, policyDetailList);
        }


        /// <summary>
        /// 获取当月保费
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public decimal GetMonthPolicy(int agentId)
        {
            return dal.GetMonthPolicy(agentId);
        }

        #endregion  ExtensionMethod
    }
}
