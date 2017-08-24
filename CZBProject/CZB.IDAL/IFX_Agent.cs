using System;
using System.Data;
namespace CZB.IDAL
{
    /// <summary>
    /// 接口层FX_Agent
    /// </summary>
    public interface IFX_Agent
    {
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int AgentId);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(CZB.Model.FX_Agent model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.FX_Agent model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int AgentId);
        bool DeleteList(string AgentIdlist);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);


        #endregion  成员方法
        #region  MethodEx
        /// <summary>
        /// 根据手机号获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        DataSet GetModelByPhone(string phone);


        /// <summary>
        ///  获取=>下级发展的数量
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        int GetCountParent(int agentId);
        #endregion  MethodEx
    }
}
