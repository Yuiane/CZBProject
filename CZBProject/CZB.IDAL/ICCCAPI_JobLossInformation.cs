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
using System;
using System.Collections.Generic;
using System.Data;
namespace CZB.IDAL
{
    /// <summary>
    /// 接口层CCCAPI_JobLossInformation
    /// </summary>
    public interface ICCCAPI_JobLossInformation
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(string Id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        bool Add(CZB.Model.CCCAPI_JobLossInformation model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.CCCAPI_JobLossInformation model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(string Id);
        bool DeleteList(string Idlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        CZB.Model.CCCAPI_JobLossInformation GetModel(string Id);
        CZB.Model.CCCAPI_JobLossInformation DataRowToModel(DataRow row);
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
        bool AddJobLoss(Model.CCCAPI_JobLossInformation info_Model,
            List<Model.CCCAPI_ClaimAttachments> claimAttachmentsList,
            List<Model.CCCAPI_ChangeItems> changeItems,
            List<Model.CCCAPI_MaterialItems> materialItems,
            List<Model.CCCAPI_RepairItems> repairItems);

        #endregion  MethodEx
    }
}
