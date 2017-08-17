using System;
using System.Data;
namespace CZB.IDAL
{
    /// <summary>
    /// 接口层TB_MessageRecord
    /// </summary>
    public interface ITB_MessageRecord
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(string Id);

        /// <summary>
        /// 验证手机号和验证码的有效性[10分钟有效]
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        bool Exists(string phone, string code);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        bool Add(CZB.Model.TB_MessageRecord model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.TB_MessageRecord model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(string Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        DataSet GetModel(string Id);
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

        #endregion  MethodEx
    }
}
