using CZB.IDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_InsuranceType
    /// </summary>
    public partial class FX_InsuranceType : IFX_InsuranceType
    {
        public FX_InsuranceType()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("InsuranceTypeId", "FX_InsuranceType");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InsuranceTypeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_InsuranceType");
            strSql.Append(" where InsuranceTypeId=@InsuranceTypeId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4)         };
            parameters[0].Value = InsuranceTypeId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.FX_InsuranceType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_InsuranceType(");
            strSql.Append("InsuranceTypeId,InsuranceName,InsurancrMoney)");
            strSql.Append(" values (");
            strSql.Append("@InsuranceTypeId,@InsuranceName,@InsurancrMoney)");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceName", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsurancrMoney", SqlDbType.Int,4)};
            parameters[0].Value = model.InsuranceTypeId;
            parameters[1].Value = model.InsuranceName;
            parameters[2].Value = model.InsurancrMoney;

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
        public bool Update(CZB.Model.FX_InsuranceType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_InsuranceType set ");
            strSql.Append("InsuranceName=@InsuranceName,");
            strSql.Append("InsurancrMoney=@InsurancrMoney");
            strSql.Append(" where InsuranceTypeId=@InsuranceTypeId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsuranceName", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsurancrMoney", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4)};
            parameters[0].Value = model.InsuranceName;
            parameters[1].Value = model.InsurancrMoney;
            parameters[2].Value = model.InsuranceTypeId;

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
        public bool Delete(int InsuranceTypeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsuranceType ");
            strSql.Append(" where InsuranceTypeId=@InsuranceTypeId ");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4)         };
            parameters[0].Value = InsuranceTypeId;

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
        public bool DeleteList(string InsuranceTypeIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsuranceType ");
            strSql.Append(" where InsuranceTypeId in (" + InsuranceTypeIdlist + ")  ");
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
            strSql.Append("select InsuranceTypeId,InsuranceName,InsurancrMoney ");
            strSql.Append(" FROM FX_InsuranceType ");
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
            strSql.Append(" InsuranceTypeId,InsuranceName,InsurancrMoney ");
            strSql.Append(" FROM FX_InsuranceType ");
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
            strSql.Append("select count(1) FROM FX_InsuranceType ");
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
                strSql.Append("order by T.InsuranceTypeId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_InsuranceType T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "FX_InsuranceType";
            parameters[1].Value = "InsuranceTypeId";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere; 
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
