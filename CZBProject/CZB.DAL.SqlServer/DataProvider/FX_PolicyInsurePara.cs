using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_PolicyInsurePara
    /// </summary>
    public partial class FX_PolicyInsurePara : IFX_PolicyInsurePara
    {
        public FX_PolicyInsurePara()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("FX_PolicyInsureMoneyParaID", "FX_PolicyInsurePara");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int FX_PolicyInsureMoneyParaID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_PolicyInsurePara");
            strSql.Append(" where FX_PolicyInsureMoneyParaID=@FX_PolicyInsureMoneyParaID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FX_PolicyInsureMoneyParaID", SqlDbType.Int,4)
            };
            parameters[0].Value = FX_PolicyInsureMoneyParaID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_PolicyInsurePara model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_PolicyInsurePara(");
            strSql.Append("PolicyID,InsureCode,BusinessTotal,BusinessCommission,BusinessCommissionLevel1,BusinessCommissionLevel2,BusinessTax,CompulsoryTotal,CompulsoryCommission,CompulsoryCommissionLelve1,CompulsoryCommissionLelve2,CompulsoryTax,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@PolicyID,@InsureCode,@BusinessTotal,@BusinessCommission,@BusinessCommissionLevel1,@BusinessCommissionLevel2,@BusinessTax,@CompulsoryTotal,@CompulsoryCommission,@CompulsoryCommissionLelve1,@CompulsoryCommissionLelve2,@CompulsoryTax,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyID", SqlDbType.Int,4),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@BusinessTotal", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommission", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommissionLevel1", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommissionLevel2", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessTax", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryTotal", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommission", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommissionLelve1", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommissionLelve2", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryTax", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.PolicyID;
            parameters[1].Value = model.InsureCode;
            parameters[2].Value = model.BusinessTotal;
            parameters[3].Value = model.BusinessCommission;
            parameters[4].Value = model.BusinessCommissionLevel1;
            parameters[5].Value = model.BusinessCommissionLevel2;
            parameters[6].Value = model.BusinessTax;
            parameters[7].Value = model.CompulsoryTotal;
            parameters[8].Value = model.CompulsoryCommission;
            parameters[9].Value = model.CompulsoryCommissionLelve1;
            parameters[10].Value = model.CompulsoryCommissionLelve2;
            parameters[11].Value = model.CompulsoryTax;
            parameters[12].Value = model.CreateTime;

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
        public bool Update(CZB.Model.FX_PolicyInsurePara model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_PolicyInsurePara set ");
            strSql.Append("PolicyID=@PolicyID,");
            strSql.Append("InsureCode=@InsureCode,");
            strSql.Append("BusinessTotal=@BusinessTotal,");
            strSql.Append("BusinessCommission=@BusinessCommission,");
            strSql.Append("BusinessCommissionLevel1=@BusinessCommissionLevel1,");
            strSql.Append("BusinessCommissionLevel2=@BusinessCommissionLevel2,");
            strSql.Append("BusinessTax=@BusinessTax,");
            strSql.Append("CompulsoryTotal=@CompulsoryTotal,");
            strSql.Append("CompulsoryCommission=@CompulsoryCommission,");
            strSql.Append("CompulsoryCommissionLelve1=@CompulsoryCommissionLelve1,");
            strSql.Append("CompulsoryCommissionLelve2=@CompulsoryCommissionLelve2,");
            strSql.Append("CompulsoryTax=@CompulsoryTax,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where FX_PolicyInsureMoneyParaID=@FX_PolicyInsureMoneyParaID");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyID", SqlDbType.Int,4),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@BusinessTotal", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommission", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommissionLevel1", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessCommissionLevel2", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessTax", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryTotal", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommission", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommissionLelve1", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryCommissionLelve2", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryTax", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@FX_PolicyInsureMoneyParaID", SqlDbType.Int,4)};
            parameters[0].Value = model.PolicyID;
            parameters[1].Value = model.InsureCode;
            parameters[2].Value = model.BusinessTotal;
            parameters[3].Value = model.BusinessCommission;
            parameters[4].Value = model.BusinessCommissionLevel1;
            parameters[5].Value = model.BusinessCommissionLevel2;
            parameters[6].Value = model.BusinessTax;
            parameters[7].Value = model.CompulsoryTotal;
            parameters[8].Value = model.CompulsoryCommission;
            parameters[9].Value = model.CompulsoryCommissionLelve1;
            parameters[10].Value = model.CompulsoryCommissionLelve2;
            parameters[11].Value = model.CompulsoryTax;
            parameters[12].Value = model.CreateTime;
            parameters[13].Value = model.FX_PolicyInsureMoneyParaID;

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
        public bool Delete(int FX_PolicyInsureMoneyParaID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_PolicyInsurePara ");
            strSql.Append(" where FX_PolicyInsureMoneyParaID=@FX_PolicyInsureMoneyParaID");
            SqlParameter[] parameters = {
                    new SqlParameter("@FX_PolicyInsureMoneyParaID", SqlDbType.Int,4)
            };
            parameters[0].Value = FX_PolicyInsureMoneyParaID;

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
        public bool DeleteList(string FX_PolicyInsureMoneyParaIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_PolicyInsurePara ");
            strSql.Append(" where FX_PolicyInsureMoneyParaID in (" + FX_PolicyInsureMoneyParaIDlist + ")  ");
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
            strSql.Append("select FX_PolicyInsureMoneyParaID,PolicyID,InsureCode,BusinessTotal,BusinessCommission,BusinessCommissionLevel1,BusinessCommissionLevel2,BusinessTax,CompulsoryTotal,CompulsoryCommission,CompulsoryCommissionLelve1,CompulsoryCommissionLelve2,CompulsoryTax,CreateTime ");
            strSql.Append(" FROM FX_PolicyInsurePara ");
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
            strSql.Append(" FX_PolicyInsureMoneyParaID,PolicyID,InsureCode,BusinessTotal,BusinessCommission,BusinessCommissionLevel1,BusinessCommissionLevel2,BusinessTax,CompulsoryTotal,CompulsoryCommission,CompulsoryCommissionLelve1,CompulsoryCommissionLelve2,CompulsoryTax,CreateTime ");
            strSql.Append(" FROM FX_PolicyInsurePara ");
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
            strSql.Append("select count(1) FROM FX_PolicyInsurePara ");
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
                strSql.Append("order by T.FX_PolicyInsureMoneyParaID desc");
            }
            strSql.Append(")AS Row, T.*  from FX_PolicyInsurePara T ");
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
			parameters[0].Value = "FX_PolicyInsurePara";
			parameters[1].Value = "FX_PolicyInsureMoneyParaID";
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
        /// 获取一条数据
        /// </summary>
        /// <param name="policyId">保单编号</param>
        /// <returns></returns>
        public DataSet GetList(int policyId)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from  FX_PolicyInsurePara  where PolicyID= @policyId ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@policyId",policyId)
            };

            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        #endregion  ExtensionMethod
    }
}

