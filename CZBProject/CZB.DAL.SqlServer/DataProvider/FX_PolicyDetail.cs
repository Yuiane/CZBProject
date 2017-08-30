using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;
namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_PolicyDetail
    /// </summary>
    public partial class FX_PolicyDetail : IFX_PolicyDetail
    {
        public FX_PolicyDetail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("PolicyDetailsId", "FX_PolicyDetail");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PolicyDetailsId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_PolicyDetail");
            strSql.Append(" where PolicyDetailsId=@PolicyDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = PolicyDetailsId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_PolicyDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_PolicyDetail(");
            strSql.Append("PolicyId,InsuranceTypeId,InsuranceTypeDetail,TotalAmount,CreateTime,UpdateTime,IsUse)");
            strSql.Append(" values (");
            strSql.Append("@PolicyId,@InsuranceTypeId,@InsuranceTypeDetail,@TotalAmount,@CreateTime,@UpdateTime,@IsUse)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyId", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceTypeDetail", SqlDbType.NVarChar,100),
                    new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsUse", SqlDbType.Int,4)};
            parameters[0].Value = model.PolicyId;
            parameters[1].Value = model.InsuranceTypeId;
            parameters[2].Value = model.InsuranceTypeDetail;
            parameters[3].Value = model.TotalAmount;
            parameters[4].Value = model.CreateTime;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.IsUse;

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
        public bool Update(CZB.Model.FX_PolicyDetail model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_PolicyDetail set ");
            strSql.Append("PolicyId=@PolicyId,");
            strSql.Append("InsuranceTypeId=@InsuranceTypeId,");
            strSql.Append("InsuranceTypeDetail=@InsuranceTypeDetail,");
            strSql.Append("TotalAmount=@TotalAmount,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("UpdateTime=@UpdateTime,");
            strSql.Append("IsUse=@IsUse");
            strSql.Append(" where PolicyDetailsId=@PolicyDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyId", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4),
                    new SqlParameter("@InsuranceTypeDetail", SqlDbType.NVarChar,100),
                    new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsUse", SqlDbType.Int,4),
                    new SqlParameter("@PolicyDetailsId", SqlDbType.Int,4)};
            parameters[0].Value = model.PolicyId;
            parameters[1].Value = model.InsuranceTypeId;
            parameters[2].Value = model.InsuranceTypeDetail;
            parameters[3].Value = model.TotalAmount;
            parameters[4].Value = model.CreateTime;
            parameters[5].Value = model.UpdateTime;
            parameters[6].Value = model.IsUse;
            parameters[7].Value = model.PolicyDetailsId;

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
        public bool Delete(int PolicyDetailsId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_PolicyDetail ");
            strSql.Append(" where PolicyDetailsId=@PolicyDetailsId");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyDetailsId", SqlDbType.Int,4)
            };
            parameters[0].Value = PolicyDetailsId;

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
        public bool DeleteList(string PolicyDetailsIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_PolicyDetail ");
            strSql.Append(" where PolicyDetailsId in (" + PolicyDetailsIdlist + ")  ");
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
            strSql.Append("select PolicyDetailsId,PolicyId,InsuranceTypeId,InsuranceTypeDetail,TotalAmount,CreateTime,UpdateTime,IsUse ");
            strSql.Append(" FROM FX_PolicyDetail ");
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
            strSql.Append(" PolicyDetailsId,PolicyId,InsuranceTypeId,InsuranceTypeDetail,TotalAmount,CreateTime,UpdateTime,IsUse ");
            strSql.Append(" FROM FX_PolicyDetail ");
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
            strSql.Append("select count(1) FROM FX_PolicyDetail ");
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
                strSql.Append("order by T.PolicyDetailsId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_PolicyDetail T ");
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
			parameters[0].Value = "FX_PolicyDetail";
			parameters[1].Value = "PolicyDetailsId";
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
        /// 根据保单获取购买的险种
        /// </summary>
        /// <param name="policyId"></param>
        /// <returns></returns>
        public DataSet GetList(int policyId)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select CONCAT(it.InsuranceName, ");
            strSql.Append(" ( ");
            strSql.Append(" case when pd.InsuranceTypeDetail='' then '' ");
            strSql.Append("  else  ");
            strSql.Append("  '  保额('+pd.InsuranceTypeDetail+')' ");
            strSql.Append("  end)) insureTypeName,");
            strSql.Append("  pd.TotalAmount insureMoney from FX_PolicyDetail pd");
            strSql.Append("  inner join FX_InsuranceType it on pd.InsuranceTypeId=it.InsuranceTypeId  ");
            strSql.Append("  where pd.policyId= @policyId ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@policyId",policyId)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }
        #endregion  ExtensionMethod
    }
}

