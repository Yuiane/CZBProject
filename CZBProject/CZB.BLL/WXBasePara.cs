
using System;
using System.Data;
using System.Collections.Generic;
using CZB.Common.Extensions;

using CZB.Model;
using CZB.Config;

namespace CZB.BLL
{
    /// <summary>
    /// FX_WXBasePara
    /// </summary>
    public partial class WXBasePara
    {
        private readonly DAL.SqlServer.DataProvider.WXBasePara dal = new DAL.SqlServer.DataProvider.WXBasePara();
        public WXBasePara()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string AppId)
        {
            return dal.Exists(AppId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.WXBasePara model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.WXBasePara model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string AppId)
        {

            return dal.Delete(AppId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string AppIdlist)
        {
            return dal.DeleteList(AppIdlist);
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
        #endregion  BasicMethod
        #region  ExtensionMethod


        /// <summary>
        /// 根据appid获取一条记录
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public Model.WXBasePara GetAccessTokenModel(string appId)
        {
            return GetAccessTokenDataSet(appId).Tables[0].ToEntity<Model.WXBasePara>();
        }


        /// <summary>
        /// 根据appid获取一条记录
        /// </summary>
        /// <returns></returns>
        public DataSet GetAccessTokenDataSet(string appId)
        {
            return dal.GetAccessToken(appId);
        }


        #endregion  ExtensionMethod
    }
}

