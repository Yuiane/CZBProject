using CZB.IDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_InsureCode
    /// </summary>
    public partial class FX_InsureCode : IFX_InsureCode
    {
        public FX_InsureCode()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("InsureCodeId", "FX_InsureCode");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InsureCodeId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_InsureCode");
            strSql.Append(" where InsureCodeId=@InsureCodeId");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureCodeId", SqlDbType.Int,4)
            };
            parameters[0].Value = InsureCodeId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_InsureCode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_InsureCode(");
            strSql.Append("InsureCode,InsureName,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@InsureCode,@InsureName,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.InsureCode;
            parameters[1].Value = model.InsureName;
            parameters[2].Value = model.CreateTime;

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
        public bool Update(CZB.Model.FX_InsureCode model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_InsureCode set ");
            strSql.Append("InsureCode=@InsureCode,");
            strSql.Append("InsureName=@InsureName,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where InsureCodeId=@InsureCodeId");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@InsureCodeId", SqlDbType.Int,4)};
            parameters[0].Value = model.InsureCode;
            parameters[1].Value = model.InsureName;
            parameters[2].Value = model.CreateTime;
            parameters[3].Value = model.InsureCodeId;

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
        public bool Delete(int InsureCodeId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsureCode ");
            strSql.Append(" where InsureCodeId=@InsureCodeId");
            SqlParameter[] parameters = {
                    new SqlParameter("@InsureCodeId", SqlDbType.Int,4)
            };
            parameters[0].Value = InsureCodeId;

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
        public bool DeleteList(string InsureCodeIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_InsureCode ");
            strSql.Append(" where InsureCodeId in (" + InsureCodeIdlist + ")  ");
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
            strSql.Append("select InsureCodeId,InsureCode,InsureName,CreateTime ");
            strSql.Append(" FROM FX_InsureCode ");
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
            strSql.Append(" InsureCodeId,InsureCode,InsureName,CreateTime ");
            strSql.Append(" FROM FX_InsureCode ");
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
            strSql.Append("select count(1) FROM FX_InsureCode ");
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
                strSql.Append("order by T.InsureCodeId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_InsureCode T ");
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


        /// <summary>
        /// 获取保险公司信息
        /// </summary>
        /// <param name="insureCode">保险公司编号</param>
        /// <returns></returns>
        public DataSet GetInsureName(string insureCode)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from FX_InsureCode where InsureCode =@insureCode ; ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@insureCode",insureCode)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);

        }


        /// <summary>
        /// 获取保险公司返点列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInsureList()
        {
            var strSql = new StringBuilder();
            strSql.Append(" select ic.InsureCode,ic.InsureName,ParaName,ParaValue from FX_InsureParaDetail ipd  ");
            strSql.Append(" inner join FX_InsureCode ic on ipd.InsureCode = ic.InsureCode  ");
            strSql.Append(" inner join FX_InsurePara ip on ipd.ParaCode = ip.ParaCode ");
            strSql.Append(" where ip.ParaName='交强险直接销售返点' or ip.ParaName='商业险直接销售返点' ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取险种类型列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInsuranceList()
        {
            var strSql = new StringBuilder();
            strSql.Append(" select it.*,i.InsureCode from FX_InsuranceType it ,FX_Insure i ");
            strSql.Append("  where   CHARINDEX((','+cast(it.InsuranceTypeId as varchar)+','),(','+(i.InsureTypeList)+','))>0 ; ");
            return DbHelperSQL.Query(strSql.ToString());
        }



        #endregion  ExtensionMethod
    }
}
