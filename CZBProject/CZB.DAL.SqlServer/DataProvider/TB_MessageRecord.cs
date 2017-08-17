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
    /// <summary>
	/// 数据访问类:TB_MessageRecord
	/// </summary>
	public partial class TB_MessageRecord : ITB_MessageRecord
    {
        public TB_MessageRecord()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_MessageRecord");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,50)            };
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 验证手机号和验证码的有效性[10分钟有效]
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="code">验证码</param>
        /// <returns></returns>
        public bool Exists(string phone, string code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_MessageRecord");
            strSql.Append(" where SendPhone=@SendPhone and SendCode=@SendCode   ");
            strSql.Append(" and datediff(mi,SendTime,GETDATE()) < 10 ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SendPhone", phone),
                    new SqlParameter("@SendCode",code)
            };
            parameters[0].Value = phone;
            parameters[1].Value = code;
            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.TB_MessageRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_MessageRecord(");
            strSql.Append("Id,SendPhone,SendContent,SendTime,SendCode)");
            strSql.Append(" values (");
            strSql.Append("@Id,@SendPhone,@SendContent,@SendTime,@SendCode)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,50),
                    new SqlParameter("@SendPhone", SqlDbType.NVarChar,50),
                    new SqlParameter("@SendContent", SqlDbType.NVarChar,500),
                    new SqlParameter("@SendTime", SqlDbType.DateTime),
                    new SqlParameter("@SendCode", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.SendPhone;
            parameters[2].Value = model.SendContent;
            parameters[3].Value = model.SendTime;
            parameters[4].Value = model.SendCode;

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
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.TB_MessageRecord model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_MessageRecord set ");
            strSql.Append("SendPhone=@SendPhone,");
            strSql.Append("SendContent=@SendContent,");
            strSql.Append("SendTime=@SendTime,");
            strSql.Append("SendCode=@SendCode");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@SendPhone", SqlDbType.NVarChar,50),
                    new SqlParameter("@SendContent", SqlDbType.NVarChar,500),
                    new SqlParameter("@SendTime", SqlDbType.DateTime),
                    new SqlParameter("@SendCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@Id", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.SendPhone;
            parameters[1].Value = model.SendContent;
            parameters[2].Value = model.SendTime;
            parameters[3].Value = model.SendCode;
            parameters[4].Value = model.Id;

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
        public bool Delete(string Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_MessageRecord ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,50)            };
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TB_MessageRecord ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        /// 得到一个对象实体
        /// </summary>
        public DataSet GetModel(string Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,SendPhone,SendContent,SendTime,SendCode from TB_MessageRecord ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,50)            };
            parameters[0].Value = Id;

            CZB.Model.TB_MessageRecord model = new CZB.Model.TB_MessageRecord();
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,SendPhone,SendContent,SendTime,SendCode ");
            strSql.Append(" FROM TB_MessageRecord ");
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
            strSql.Append(" Id,SendPhone,SendContent,SendTime,SendCode ");
            strSql.Append(" FROM TB_MessageRecord ");
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
            strSql.Append("select count(1) FROM TB_MessageRecord ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from TB_MessageRecord T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
