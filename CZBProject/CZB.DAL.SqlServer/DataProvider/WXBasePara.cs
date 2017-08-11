using CZB.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.DAL.SqlServer.DataProvider
{
    public class WXBasePara : IWXBasePara
    {
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string AppId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_WXBasePara");
            strSql.Append(" where AppId=@AppId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@AppId", SqlDbType.NVarChar,50)         };
            parameters[0].Value = AppId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.WXBasePara model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_WXBasePara(");
            strSql.Append("AppId,AppSecret,BaseAccessToken,BaseTokenStartTime,AccessTokenNotBase,NotBaseTokenStartTime,NotBaseRefreshToken,jsapi_ticket,jsapi_ticketTime,api_ticket,api_ticketTime)");
            strSql.Append(" values (");
            strSql.Append("@AppId,@AppSecret,@BaseAccessToken,@BaseTokenStartTime,@AccessTokenNotBase,@NotBaseTokenStartTime,@NotBaseRefreshToken,@jsapi_ticket,@jsapi_ticketTime,@api_ticket,@api_ticketTime)");
            SqlParameter[] parameters = {
                    new SqlParameter("@AppId", SqlDbType.NVarChar,50),
                    new SqlParameter("@AppSecret", SqlDbType.NVarChar,50),
                    new SqlParameter("@BaseAccessToken", SqlDbType.NVarChar,-1),
                    new SqlParameter("@BaseTokenStartTime", SqlDbType.DateTime),
                    new SqlParameter("@AccessTokenNotBase", SqlDbType.NVarChar,-1),
                    new SqlParameter("@NotBaseTokenStartTime", SqlDbType.DateTime),
                    new SqlParameter("@NotBaseRefreshToken", SqlDbType.NVarChar,-1),
                    new SqlParameter("@jsapi_ticket", SqlDbType.NVarChar,-1),
                    new SqlParameter("@jsapi_ticketTime", SqlDbType.DateTime),
                    new SqlParameter("@api_ticket", SqlDbType.NVarChar,-1),
                    new SqlParameter("@api_ticketTime", SqlDbType.DateTime)};
            parameters[0].Value = model.AppId;
            parameters[1].Value = model.AppSecret;
            parameters[2].Value = model.BaseAccessToken;
            parameters[3].Value = model.BaseTokenStartTime;
            parameters[4].Value = model.AccessTokenNotBase;
            parameters[5].Value = model.NotBaseTokenStartTime;
            parameters[6].Value = model.NotBaseRefreshToken;
            parameters[7].Value = model.jsapi_ticket;
            parameters[8].Value = model.jsapi_ticketTime;
            parameters[9].Value = model.api_ticket;
            parameters[10].Value = model.api_ticketTime;

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
        /// 根据appid获取一条记录
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public DataSet GetAccessToken(string appId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from FX_WXBasePara  ");
            strSql.Append(" where AppId=@appId ; ");
            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@appId",appId)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.WXBasePara model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_WXBasePara set ");
            strSql.Append("AppSecret=@AppSecret,");
            strSql.Append("BaseAccessToken=@BaseAccessToken,");
            strSql.Append("BaseTokenStartTime=@BaseTokenStartTime,");
            strSql.Append("AccessTokenNotBase=@AccessTokenNotBase,");
            strSql.Append("NotBaseTokenStartTime=@NotBaseTokenStartTime,");
            strSql.Append("NotBaseRefreshToken=@NotBaseRefreshToken,");
            strSql.Append("jsapi_ticket=@jsapi_ticket,");
            strSql.Append("jsapi_ticketTime=@jsapi_ticketTime,");
            strSql.Append("api_ticket=@api_ticket,");
            strSql.Append("api_ticketTime=@api_ticketTime");
            strSql.Append(" where AppId=@AppId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@AppSecret", SqlDbType.NVarChar,50),
                    new SqlParameter("@BaseAccessToken", SqlDbType.NVarChar,-1),
                    new SqlParameter("@BaseTokenStartTime", SqlDbType.DateTime),
                    new SqlParameter("@AccessTokenNotBase", SqlDbType.NVarChar,-1),
                    new SqlParameter("@NotBaseTokenStartTime", SqlDbType.DateTime),
                    new SqlParameter("@NotBaseRefreshToken", SqlDbType.NVarChar,-1),
                    new SqlParameter("@jsapi_ticket", SqlDbType.NVarChar,-1),
                    new SqlParameter("@jsapi_ticketTime", SqlDbType.DateTime),
                    new SqlParameter("@api_ticket", SqlDbType.NVarChar,-1),
                    new SqlParameter("@api_ticketTime", SqlDbType.DateTime),
                    new SqlParameter("@AppId", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.AppSecret;
            parameters[1].Value = model.BaseAccessToken;
            parameters[2].Value = model.BaseTokenStartTime;
            parameters[3].Value = model.AccessTokenNotBase;
            parameters[4].Value = model.NotBaseTokenStartTime;
            parameters[5].Value = model.NotBaseRefreshToken;
            parameters[6].Value = model.jsapi_ticket;
            parameters[7].Value = model.jsapi_ticketTime;
            parameters[8].Value = model.api_ticket;
            parameters[9].Value = model.api_ticketTime;
            parameters[10].Value = model.AppId;

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
        public bool Delete(string AppId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_WXBasePara ");
            strSql.Append(" where AppId=@AppId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@AppId", SqlDbType.NVarChar,50)         };
            parameters[0].Value = AppId;

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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string AppIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_WXBasePara ");
            strSql.Append(" where AppId in (" + AppIdlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
            strSql.Append("select AppId,AppSecret,BaseAccessToken,BaseTokenStartTime,AccessTokenNotBase,NotBaseTokenStartTime,NotBaseRefreshToken,jsapi_ticket,jsapi_ticketTime,api_ticket,api_ticketTime ");
            strSql.Append(" FROM FX_WXBasePara ");
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
            strSql.Append(" AppId,AppSecret,BaseAccessToken,BaseTokenStartTime,AccessTokenNotBase,NotBaseTokenStartTime,NotBaseRefreshToken,jsapi_ticket,jsapi_ticketTime,api_ticket,api_ticketTime ");
            strSql.Append(" FROM FX_WXBasePara ");
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
            strSql.Append("select count(1) FROM FX_WXBasePara ");
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
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.AppId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_WXBasePara T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod
    }
}
