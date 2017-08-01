using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;

namespace CZB.DAL.SqlServer.DataProvider
{
	/// <summary>
	/// 数据访问类:CCCAPI_MaterialItems
	/// </summary>
	public partial class CCCAPI_MaterialItems:ICCCAPI_MaterialItems
	{
		public CCCAPI_MaterialItems()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CCCAPI_MaterialItems");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CZB.Model.CCCAPI_MaterialItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CCCAPI_MaterialItems(");
			strSql.Append("id,itemid,itemName,manualFlag,materialUnit,partQuantity,unitPrice,partFee)");
			strSql.Append(" values (");
			strSql.Append("@id,@itemid,@itemName,@manualFlag,@materialUnit,@partQuantity,@unitPrice,@partFee)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50),
					new SqlParameter("@itemid", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@manualFlag", SqlDbType.Bit,1),
					new SqlParameter("@materialUnit", SqlDbType.VarChar,20),
					new SqlParameter("@partQuantity", SqlDbType.Decimal,5),
					new SqlParameter("@unitPrice", SqlDbType.Decimal,9),
					new SqlParameter("@partFee", SqlDbType.Decimal,9)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.itemid;
			parameters[2].Value = model.itemName;
			parameters[3].Value = model.manualFlag;
			parameters[4].Value = model.materialUnit;
			parameters[5].Value = model.partQuantity;
			parameters[6].Value = model.unitPrice;
			parameters[7].Value = model.partFee;

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
		public bool Update(CZB.Model.CCCAPI_MaterialItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CCCAPI_MaterialItems set ");
			strSql.Append("itemid=@itemid,");
			strSql.Append("itemName=@itemName,");
			strSql.Append("manualFlag=@manualFlag,");
			strSql.Append("materialUnit=@materialUnit,");
			strSql.Append("partQuantity=@partQuantity,");
			strSql.Append("unitPrice=@unitPrice,");
			strSql.Append("partFee=@partFee");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@itemid", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@manualFlag", SqlDbType.Bit,1),
					new SqlParameter("@materialUnit", SqlDbType.VarChar,20),
					new SqlParameter("@partQuantity", SqlDbType.Decimal,5),
					new SqlParameter("@unitPrice", SqlDbType.Decimal,9),
					new SqlParameter("@partFee", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.itemid;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.manualFlag;
			parameters[3].Value = model.materialUnit;
			parameters[4].Value = model.partQuantity;
			parameters[5].Value = model.unitPrice;
			parameters[6].Value = model.partFee;
			parameters[7].Value = model.id;

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
		public bool Delete(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CCCAPI_MaterialItems ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CCCAPI_MaterialItems ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public CZB.Model.CCCAPI_MaterialItems GetModel(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,itemid,itemName,manualFlag,materialUnit,partQuantity,unitPrice,partFee from CCCAPI_MaterialItems ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = id;

			CZB.Model.CCCAPI_MaterialItems model=new CZB.Model.CCCAPI_MaterialItems();
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
		public CZB.Model.CCCAPI_MaterialItems DataRowToModel(DataRow row)
		{
			CZB.Model.CCCAPI_MaterialItems model=new CZB.Model.CCCAPI_MaterialItems();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["itemid"]!=null && row["itemid"].ToString()!="")
				{
					model.itemid=decimal.Parse(row["itemid"].ToString());
				}
				if(row["itemName"]!=null)
				{
					model.itemName=row["itemName"].ToString();
				}
				if(row["manualFlag"]!=null && row["manualFlag"].ToString()!="")
				{
					if((row["manualFlag"].ToString()=="1")||(row["manualFlag"].ToString().ToLower()=="true"))
					{
						model.manualFlag=true;
					}
					else
					{
						model.manualFlag=false;
					}
				}
				if(row["materialUnit"]!=null)
				{
					model.materialUnit=row["materialUnit"].ToString();
				}
				if(row["partQuantity"]!=null && row["partQuantity"].ToString()!="")
				{
					model.partQuantity=decimal.Parse(row["partQuantity"].ToString());
				}
				if(row["unitPrice"]!=null && row["unitPrice"].ToString()!="")
				{
					model.unitPrice=decimal.Parse(row["unitPrice"].ToString());
				}
				if(row["partFee"]!=null && row["partFee"].ToString()!="")
				{
					model.partFee=decimal.Parse(row["partFee"].ToString());
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
			strSql.Append("select id,itemid,itemName,manualFlag,materialUnit,partQuantity,unitPrice,partFee ");
			strSql.Append(" FROM CCCAPI_MaterialItems ");
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
			strSql.Append(" id,itemid,itemName,manualFlag,materialUnit,partQuantity,unitPrice,partFee ");
			strSql.Append(" FROM CCCAPI_MaterialItems ");
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
			strSql.Append("select count(1) FROM CCCAPI_MaterialItems ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from CCCAPI_MaterialItems T ");
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
			parameters[0].Value = "CCCAPI_MaterialItems";
			parameters[1].Value = "id";
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

