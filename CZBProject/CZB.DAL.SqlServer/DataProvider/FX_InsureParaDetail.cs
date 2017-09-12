
using CZB.IDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_InsureParaDetail
    /// </summary>
    public partial class FX_InsureParaDetail : IFX_InsureParaDetail
    {
        public FX_InsureParaDetail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("InsureParaDetailsId", "FX_InsureParaDetail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InsureParaDetailsId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_InsureParaDetail");
            strSql.Append(" where InsureParaDetailsId=@InsureParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureParaDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = InsureParaDetailsId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_InsureParaDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_InsureParaDetail(");
            strSql.Append("ParaCode,InsureCode,ParaValue,CityCode)");
            strSql.Append(" values (");
            strSql.Append("@ParaCode,@InsureCode,@ParaValue,@CityCode)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@ParaCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ParaValue", SqlDbType.NVarChar,50),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.ParaCode;
            parameters[1].Value = model.InsureCode;
            parameters[2].Value = model.ParaValue;
            parameters[3].Value = model.CityCode;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_InsureParaDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_InsureParaDetail set ");
            strSql.Append("ParaCode=@ParaCode,");
            strSql.Append("InsureCode=@InsureCode,");
            strSql.Append("ParaValue=@ParaValue,");
            strSql.Append("CityCode=@CityCode");
            strSql.Append(" where InsureParaDetailsId=@InsureParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@ParaCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ParaValue", SqlDbType.NVarChar,50),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureParaDetailsId", SqlDbType.Int,4)};
            parameters[0].Value = model.ParaCode;
            parameters[1].Value = model.InsureCode;
            parameters[2].Value = model.ParaValue;
            parameters[3].Value = model.CityCode;
            parameters[4].Value = model.InsureParaDetailsId;

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
        public bool Delete(int InsureParaDetailsId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsureParaDetail ");
            strSql.Append(" where InsureParaDetailsId=@InsureParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureParaDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = InsureParaDetailsId;

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
        public bool DeleteList(string InsureParaDetailsIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsureParaDetail ");
            strSql.Append(" where InsureParaDetailsId in (" + InsureParaDetailsIdlist + ")  ");
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
            strSql.Append("select InsureParaDetailsId,ParaCode,InsureCode,ParaValue,CityCode ");
            strSql.Append(" FROM FX_InsureParaDetail ");
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
            strSql.Append(" InsureParaDetailsId,ParaCode,InsureCode,ParaValue,CityCode ");
            strSql.Append(" FROM FX_InsureParaDetail ");
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
            strSql.Append("select count(1) FROM FX_InsureParaDetail ");
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
                strSql.Append("order by T.InsureParaDetailsId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_InsureParaDetail T ");
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
            parameters[0].Value = "FX_InsureParaDetail";
            parameters[1].Value = "InsureParaDetailsId";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere; 
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据城市编码和保险公司编号 获取列表
        /// </summary>
        /// <param name="insurecode">保险公司编号</param>
        /// <param name="citycode">城市编码</param>
        /// <returns></returns>
        public DataSet GetList(string insurecode, string citycode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  * from  FX_Insure fxin left join FX_InsureParaDetail d on fxin.CityCode= d.CityCode and fxin.InsureCode=d.InsureCode");
            strSql.Append(" where fxin.IsDelete=0 and fxin.CityCode=@citycode and fxin.InsureCode=@insurecode ");
            strSql.Append("  order by d.ParaCode asc");

            var sqlParameters = new SqlParameter[]{
                new SqlParameter("@citycode",citycode),
                new SqlParameter("@insurecode",insurecode)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }


        #endregion  ExtensionMethod
    }
}
