﻿using System.Collections.Generic;
/**  版本信息模板在安装目录下，可自行修改。
* CCCAPI_JobLossInformation.cs
*
* 功 能： N/A
* 类 名： CCCAPI_JobLossInformation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/26 17:56:48   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System.Data;
namespace CZB.BLL
{
    /// <summary>
    /// CCCAPI_JobLossInformation
    /// </summary>
    public partial class CCCAPI_JobLossInformation
    {
        private readonly CZB.DAL.SqlServer.DataProvider.CCCAPI_JobLossInformation dal = new DAL.SqlServer.DataProvider.CCCAPI_JobLossInformation();
        public CCCAPI_JobLossInformation()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            return dal.Exists(Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.CCCAPI_JobLossInformation model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.CCCAPI_JobLossInformation model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Id)
        {

            return dal.Delete(Id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Idlist)
        {
            return dal.DeleteList(Idlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public CZB.Model.CCCAPI_JobLossInformation GetModel(string Id)
        {

            return dal.GetModel(Id);
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
        /// 根据工单号查询是否存在
        /// </summary>
        /// <param name="businessNo"></param>
        /// <returns></returns>
        public bool ExistsBusinessNo(string businessNo)
        {
            return dal.ExistsBusinessNo(businessNo);

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


        public bool AddJobLoss(Model.CCCAPI_JobLossInformation info_Model,
            List<Model.CCCAPI_ClaimAttachments> claimAttachmentsList,
            List<Model.CCCAPI_ChangeItems> changeItems,
            List<Model.CCCAPI_MaterialItems> materialItems,
            List<Model.CCCAPI_RepairItems> repairItems)
        {
            return dal.AddJobLoss(info_Model, claimAttachmentsList, changeItems, materialItems, repairItems);
        }

        /// <summary>
        /// 根据工单号获取partyId编号
        /// </summary>
        /// <param name="businessNo"></param>
        /// <returns></returns>
        public object GetPartyId(string businessNo)
        {
            return dal.GetPartyId(businessNo);
        }
        #endregion  ExtensionMethod
    }
}
