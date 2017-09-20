using CZB.Common.Extensions;
using System.Data;

namespace CZB.BLL
{
    /// <summary>
    /// FX_Agent
    /// </summary>
    public partial class FX_Agent
    {
        private readonly DAL.SqlServer.DataProvider.FX_Agent dal = new DAL.SqlServer.DataProvider.FX_Agent();
        public FX_Agent()
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
        public bool Exists(int AgentId)
        {
            return dal.Exists(AgentId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_Agent model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_Agent model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int AgentId)
        {
            return dal.Delete(AgentId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string AgentIdlist)
        {
            return dal.DeleteList(AgentIdlist);
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


        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据手机号获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        private DataSet GetDataByPhone(string phone)
        {
            return dal.GetModelByPhone(phone);
        }

        /// <summary>
        /// 根据手机号获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public Model.FX_Agent GetModelByPhone(string phone)
        {
            return GetDataByPhone(phone).Tables[0].ToEntity<Model.FX_Agent>();
        }

        /// <summary>
        /// 根据代理商编号获取代理商信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public Model.FX_Agent GetModelByAgentId(int agentId)
        {
            return GetDataByAgentId(agentId).Tables[0].ToEntity<Model.FX_Agent>();
        }

        /// <summary>
        /// 根据代理商编号获取一条信息
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        private DataSet GetDataByAgentId(int agentId)
        {
            return dal.GetDataByAgentId(agentId);
        }

        /// <summary>
        /// 获取=>下级发展的数量
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public int GetCountParent(int agentId)
        {
            return dal.GetCountParent(agentId);
        }

        #endregion  ExtensionMethod
    }
}
