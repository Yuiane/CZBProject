using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZB.Model;
using CZB.IDAL;

namespace CZB.DAL.SqlServer
{
    /// <summary>
    /// 数据访问类:CZB_AutoReply
    /// </summary>
    public partial class AutoReply : IAutoReply
    {
        #region  BasicMethod

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.AutoReply model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CZB_AutoReply(");
            strSql.Append("ID,MessageType,Keyword,ReplyType,ReplyIdList,Creater,Createtime,Updater,Updatetime,state)");
            strSql.Append(" values (");
            strSql.Append("@ID,@MessageType,@Keyword,@ReplyType,@ReplyIdList,@Creater,@Createtime,@Updater,@Updatetime,@state)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50),
                    new SqlParameter("@MessageType", SqlDbType.Int,4),
                    new SqlParameter("@Keyword", SqlDbType.NVarChar,255),
                    new SqlParameter("@ReplyType", SqlDbType.Int,4),
                    new SqlParameter("@ReplyIdList", SqlDbType.NVarChar,500),
                    new SqlParameter("@Creater", SqlDbType.NVarChar,50),
                    new SqlParameter("@Createtime", SqlDbType.DateTime),
                    new SqlParameter("@Updater", SqlDbType.NVarChar,50),
                    new SqlParameter("@Updatetime", SqlDbType.DateTime),
                    new SqlParameter("@state", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MessageType;
            parameters[2].Value = model.Keyword;
            parameters[3].Value = model.ReplyType;
            parameters[4].Value = model.ReplyIdList;
            parameters[5].Value = model.Creater;
            parameters[6].Value = model.Createtime;
            parameters[7].Value = model.Updater;
            parameters[8].Value = model.Updatetime;
            parameters[9].Value = model.state;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 根据编号获取一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetModelById(string id)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from CZB_AutoReply where Id=@id ");

            var sqlParameter = new SqlParameter[] {
                    new SqlParameter("@id",id)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameter);
        }

        /// <summary>
        /// 获取关键词回复
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public DataSet GetAutoReplyListBykeyWord(string keyWord)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from CZB_AutoReply where MessageType=1 and [state]=0 and keyWord=@keyWord ");

            var sqlParameter = new SqlParameter[] {
                new SqlParameter("@keyWord",keyWord)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameter);
        }

        /// <summary>
        /// 获取关注回复
        /// </summary>
        /// <returns></returns>
        public DataSet GetSubscribeInfo()
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from CZB_AutoReply where MessageType=0 and [state]=0 ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Model.AutoReply model)
        {
            var strSql = new StringBuilder();
            strSql.Append("update CZB_AutoReply set ");
            strSql.Append("MessageType=@MessageType,");
            strSql.Append("Keyword=@Keyword,");
            strSql.Append("ReplyType=@ReplyType,");
            strSql.Append("ReplyIdList=@ReplyIdList,");
            strSql.Append("Creater=@Creater,");
            strSql.Append("Createtime=@Createtime,");
            strSql.Append("Updater=@Updater,");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("state=@state");
            strSql.Append(" where ");
            strSql.Append("ID=@ID");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50),
                    new SqlParameter("@MessageType", SqlDbType.Int,4),
                    new SqlParameter("@Keyword", SqlDbType.NVarChar,255),
                    new SqlParameter("@ReplyType", SqlDbType.Int,4),
                    new SqlParameter("@ReplyIdList", SqlDbType.NVarChar,500),
                    new SqlParameter("@Creater", SqlDbType.NVarChar,50),
                    new SqlParameter("@Createtime", SqlDbType.DateTime),
                    new SqlParameter("@Updater", SqlDbType.NVarChar,50),
                    new SqlParameter("@Updatetime", SqlDbType.DateTime),
                    new SqlParameter("@state", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MessageType;
            parameters[2].Value = model.Keyword;
            parameters[3].Value = model.ReplyType;
            parameters[4].Value = model.ReplyIdList;
            parameters[5].Value = model.Creater;
            parameters[6].Value = model.Createtime;
            parameters[7].Value = model.Updater;
            parameters[8].Value = model.Updatetime;
            parameters[9].Value = model.state;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CZB_AutoReply ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
            };

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,MessageType,Keyword,ReplyType,ReplyIdList,Creater,Createtime,Updater,Updatetime,state ");
            strSql.Append(" FROM CZB_AutoReply ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,MessageType,Keyword,ReplyType,ReplyIdList,Creater,Createtime,Updater,Updatetime,state ");
            strSql.Append(" FROM CZB_AutoReply ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM CZB_AutoReply ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }


        #endregion  BasicMethod
    }
}
