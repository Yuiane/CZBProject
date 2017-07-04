/**  版本信息模板在安装目录下，可自行修改。
* CZB_AutoReply.cs
*
* 功 能： N/A
* 类 名： CZB_AutoReply
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/4 13:50:29   袁连杰    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace CZB.DAL
{
    public class AutoReply
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model">ActivityJoinInfo</param>
        /// <returns></returns>
        public static bool Add(Model.AutoReply model)
        {
            return DatabaseProvider.GetInstance().Add(model);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            return DatabaseProvider.GetInstance().GetList(strWhere);
        }
    }
}

