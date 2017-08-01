using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;

namespace CZB.DAL.SqlServer.DataProvider
{
	/// <summary>
	/// 数据访问类:CCCAPI_ClaimAttachments
	/// </summary>
	public partial class CCCAPI_ClaimAttachments:ICCCAPI_ClaimAttachments
	{
		public CCCAPI_ClaimAttachments()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CCCAPI_ClaimAttachments");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CZB.Model.CCCAPI_ClaimAttachments model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CCCAPI_ClaimAttachments(");
			strSql.Append("Id,AttachmentCategoryName,AttachmentUrl,AttachmentId,AttachmentName)");
			strSql.Append(" values (");
			strSql.Append("@Id,@AttachmentCategoryName,@AttachmentUrl,@AttachmentId,@AttachmentName)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50),
					new SqlParameter("@AttachmentCategoryName", SqlDbType.NVarChar,30),
					new SqlParameter("@AttachmentUrl", SqlDbType.NVarChar,255),
					new SqlParameter("@AttachmentId", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.AttachmentCategoryName;
			parameters[2].Value = model.AttachmentUrl;
			parameters[3].Value = model.AttachmentId;
			parameters[4].Value = model.AttachmentName;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(CZB.Model.CCCAPI_ClaimAttachments model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CCCAPI_ClaimAttachments set ");
			strSql.Append("AttachmentCategoryName=@AttachmentCategoryName,");
			strSql.Append("AttachmentUrl=@AttachmentUrl,");
			strSql.Append("AttachmentId=@AttachmentId,");
			strSql.Append("AttachmentName=@AttachmentName");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@AttachmentCategoryName", SqlDbType.NVarChar,30),
					new SqlParameter("@AttachmentUrl", SqlDbType.NVarChar,255),
					new SqlParameter("@AttachmentId", SqlDbType.Int,4),
					new SqlParameter("@AttachmentName", SqlDbType.NVarChar,100),
					new SqlParameter("@Id", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.AttachmentCategoryName;
			parameters[1].Value = model.AttachmentUrl;
			parameters[2].Value = model.AttachmentId;
			parameters[3].Value = model.AttachmentName;
			parameters[4].Value = model.Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CCCAPI_ClaimAttachments ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CCCAPI_ClaimAttachments ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public CZB.Model.CCCAPI_ClaimAttachments GetModel(string Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,AttachmentCategoryName,AttachmentUrl,AttachmentId,AttachmentName from CCCAPI_ClaimAttachments ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Id;

			CZB.Model.CCCAPI_ClaimAttachments model=new CZB.Model.CCCAPI_ClaimAttachments();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public CZB.Model.CCCAPI_ClaimAttachments DataRowToModel(DataRow row)
		{
			CZB.Model.CCCAPI_ClaimAttachments model=new CZB.Model.CCCAPI_ClaimAttachments();
			if (row != null)
			{
				if(row["Id"]!=null)
				{
					model.Id=row["Id"].ToString();
				}
				if(row["AttachmentCategoryName"]!=null)
				{
					model.AttachmentCategoryName=row["AttachmentCategoryName"].ToString();
				}
				if(row["AttachmentUrl"]!=null)
				{
					model.AttachmentUrl=row["AttachmentUrl"].ToString();
				}
				if(row["AttachmentId"]!=null && row["AttachmentId"].ToString()!="")
				{
					model.AttachmentId=int.Parse(row["AttachmentId"].ToString());
				}
				if(row["AttachmentName"]!=null)
				{
					model.AttachmentName=row["AttachmentName"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,AttachmentCategoryName,AttachmentUrl,AttachmentId,AttachmentName ");
			strSql.Append(" FROM CCCAPI_ClaimAttachments ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,AttachmentCategoryName,AttachmentUrl,AttachmentId,AttachmentName ");
			strSql.Append(" FROM CCCAPI_ClaimAttachments ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM CCCAPI_ClaimAttachments ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from CCCAPI_ClaimAttachments T ");
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
			parameters[0].Value = "CCCAPI_ClaimAttachments";
			parameters[1].Value = "Id";
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

