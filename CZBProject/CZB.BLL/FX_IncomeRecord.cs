/**  版本信息模板在安装目录下，可自行修改。
* FX_IncomeRecord.cs
*
* 功 能： N/A
* 类 名： FX_IncomeRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/8/22 15:50:26   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
namespace CZB.BLL
{
    /// <summary>
    /// FX_IncomeRecord
    /// </summary>
    public partial class FX_IncomeRecord
    {
        private readonly DAL.SqlServer.DataProvider.FX_IncomeRecord dal = new DAL.SqlServer.DataProvider.FX_IncomeRecord();
        public FX_IncomeRecord()
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
        public bool Exists(int IncomeRecordId)
        {
            return dal.Exists(IncomeRecordId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_IncomeRecord model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_IncomeRecord model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int IncomeRecordId)
        {

            return dal.Delete(IncomeRecordId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IncomeRecordIdlist)
        {
            return dal.DeleteList(IncomeRecordIdlist);
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

        #endregion  ExtensionMethod
    }
}

