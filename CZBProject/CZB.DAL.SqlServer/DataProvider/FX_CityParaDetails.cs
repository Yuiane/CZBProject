﻿
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_CityParaDetails
    /// </summary>
    public partial class FX_CityParaDetails : IFX_CityParaDetails
    {
        public FX_CityParaDetails()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("CityParaDetailsId", "FX_CityParaDetails");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int CityParaDetailsId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_CityParaDetails");
            strSql.Append(" where CityParaDetailsId=@CityParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@CityParaDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = CityParaDetailsId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_CityParaDetails model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_CityParaDetails(");
            strSql.Append("CityCode,ParaCode,ParaValue,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@CityCode,@ParaCode,@ParaValue,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@CityCode", SqlDbType.Int,4),
                    new SqlParameter("@ParaCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ParaValue", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.CityCode;
            parameters[1].Value = model.ParaCode;
            parameters[2].Value = model.ParaValue;
            parameters[3].Value = model.CreateTime;

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
        public bool Update(CZB.Model.FX_CityParaDetails model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_CityParaDetails set ");
            strSql.Append("CityCode=@CityCode,");
            strSql.Append("ParaCode=@ParaCode,");
            strSql.Append("ParaValue=@ParaValue,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where CityParaDetailsId=@CityParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@CityCode", SqlDbType.Int,4),
                    new SqlParameter("@ParaCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ParaValue", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@CityParaDetailsId", SqlDbType.Int,4)};
            parameters[0].Value = model.CityCode;
            parameters[1].Value = model.ParaCode;
            parameters[2].Value = model.ParaValue;
            parameters[3].Value = model.CreateTime;
            parameters[4].Value = model.CityParaDetailsId;

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
        public bool Delete(int CityParaDetailsId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_CityParaDetails ");
            strSql.Append(" where CityParaDetailsId=@CityParaDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@CityParaDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = CityParaDetailsId;

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
        public bool DeleteList(string CityParaDetailsIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_CityParaDetails ");
            strSql.Append(" where CityParaDetailsId in (" + CityParaDetailsIdlist + ")  ");
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
            strSql.Append("select CityParaDetailsId,CityCode,ParaCode,ParaValue,CreateTime ");
            strSql.Append(" FROM FX_CityParaDetails ");
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
            strSql.Append(" CityParaDetailsId,CityCode,ParaCode,ParaValue,CreateTime ");
            strSql.Append(" FROM FX_CityParaDetails ");
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
            strSql.Append("select count(1) FROM FX_CityParaDetails ");
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
                strSql.Append("order by T.CityParaDetailsId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_CityParaDetails T ");
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
			parameters[0].Value = "FX_CityParaDetails";
			parameters[1].Value = "CityParaDetailsId";
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
        /// 获取销售目标
        /// </summary>
        /// <param name="cityCode"></param>
        /// <param name="paraCode"></param>
        /// <returns></returns>
        public DataSet GetListByCode(string cityCode, string paraCode)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from FX_CityParaDetails   ");
            strSql.Append(" where 1= 1 ");
            strSql.Append(" and CityCode = @cityCode ");
            strSql.Append(" and ParaCode = @paraCode ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@cityCode",cityCode),
                new SqlParameter("@paraCode",paraCode)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        #endregion  ExtensionMethod
    }
}

