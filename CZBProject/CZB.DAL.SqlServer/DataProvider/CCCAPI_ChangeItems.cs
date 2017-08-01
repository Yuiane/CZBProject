using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;

namespace CZB.DAL.SqlServer.DataProvider
{
	/// <summary>
	/// 数据访问类:CCCAPI_ChangeItems
	/// </summary>
	public partial class CCCAPI_ChangeItems:ICCCAPI_ChangeItems
	{
		public CCCAPI_ChangeItems()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CCCAPI_ChangeItems");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CZB.Model.CCCAPI_ChangeItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CCCAPI_ChangeItems(");
			strSql.Append("Id,ItemId,itemName,ManualFlag,partNo,partQuantity,unitPriceAfterDiscount,partFeeAfterDiscount,depreciation,salvage,recycleFlag)");
			strSql.Append(" values (");
			strSql.Append("@Id,@ItemId,@itemName,@ManualFlag,@partNo,@partQuantity,@unitPriceAfterDiscount,@partFeeAfterDiscount,@depreciation,@salvage,@recycleFlag)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50),
					new SqlParameter("@ItemId", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.NVarChar,255),
					new SqlParameter("@ManualFlag", SqlDbType.Bit,1),
					new SqlParameter("@partNo", SqlDbType.VarChar,30),
					new SqlParameter("@partQuantity", SqlDbType.Decimal,5),
					new SqlParameter("@unitPriceAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@partFeeAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@depreciation", SqlDbType.Decimal,9),
					new SqlParameter("@salvage", SqlDbType.Decimal,9),
					new SqlParameter("@recycleFlag", SqlDbType.Bit,1)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ItemId;
			parameters[2].Value = model.itemName;
			parameters[3].Value = model.ManualFlag;
			parameters[4].Value = model.partNo;
			parameters[5].Value = model.partQuantity;
			parameters[6].Value = model.unitPriceAfterDiscount;
			parameters[7].Value = model.partFeeAfterDiscount;
			parameters[8].Value = model.depreciation;
			parameters[9].Value = model.salvage;
			parameters[10].Value = model.recycleFlag;

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
		public bool Update(CZB.Model.CCCAPI_ChangeItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CCCAPI_ChangeItems set ");
			strSql.Append("ItemId=@ItemId,");
			strSql.Append("itemName=@itemName,");
			strSql.Append("ManualFlag=@ManualFlag,");
			strSql.Append("partNo=@partNo,");
			strSql.Append("partQuantity=@partQuantity,");
			strSql.Append("unitPriceAfterDiscount=@unitPriceAfterDiscount,");
			strSql.Append("partFeeAfterDiscount=@partFeeAfterDiscount,");
			strSql.Append("depreciation=@depreciation,");
			strSql.Append("salvage=@salvage,");
			strSql.Append("recycleFlag=@recycleFlag");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ItemId", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.NVarChar,255),
					new SqlParameter("@ManualFlag", SqlDbType.Bit,1),
					new SqlParameter("@partNo", SqlDbType.VarChar,30),
					new SqlParameter("@partQuantity", SqlDbType.Decimal,5),
					new SqlParameter("@unitPriceAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@partFeeAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@depreciation", SqlDbType.Decimal,9),
					new SqlParameter("@salvage", SqlDbType.Decimal,9),
					new SqlParameter("@recycleFlag", SqlDbType.Bit,1),
					new SqlParameter("@Id", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ItemId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.ManualFlag;
			parameters[3].Value = model.partNo;
			parameters[4].Value = model.partQuantity;
			parameters[5].Value = model.unitPriceAfterDiscount;
			parameters[6].Value = model.partFeeAfterDiscount;
			parameters[7].Value = model.depreciation;
			parameters[8].Value = model.salvage;
			parameters[9].Value = model.recycleFlag;
			parameters[10].Value = model.Id;

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
			strSql.Append("delete from CCCAPI_ChangeItems ");
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
			strSql.Append("delete from CCCAPI_ChangeItems ");
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
		public CZB.Model.CCCAPI_ChangeItems GetModel(string Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ItemId,itemName,ManualFlag,partNo,partQuantity,unitPriceAfterDiscount,partFeeAfterDiscount,depreciation,salvage,recycleFlag from CCCAPI_ChangeItems ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Id;

			CZB.Model.CCCAPI_ChangeItems model=new CZB.Model.CCCAPI_ChangeItems();
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
		public CZB.Model.CCCAPI_ChangeItems DataRowToModel(DataRow row)
		{
			CZB.Model.CCCAPI_ChangeItems model=new CZB.Model.CCCAPI_ChangeItems();
			if (row != null)
			{
				if(row["Id"]!=null)
				{
					model.Id=row["Id"].ToString();
				}
				if(row["ItemId"]!=null && row["ItemId"].ToString()!="")
				{
					model.ItemId=decimal.Parse(row["ItemId"].ToString());
				}
				if(row["itemName"]!=null)
				{
					model.itemName=row["itemName"].ToString();
				}
				if(row["ManualFlag"]!=null && row["ManualFlag"].ToString()!="")
				{
					if((row["ManualFlag"].ToString()=="1")||(row["ManualFlag"].ToString().ToLower()=="true"))
					{
						model.ManualFlag=true;
					}
					else
					{
						model.ManualFlag=false;
					}
				}
				if(row["partNo"]!=null)
				{
					model.partNo=row["partNo"].ToString();
				}
				if(row["partQuantity"]!=null && row["partQuantity"].ToString()!="")
				{
					model.partQuantity=decimal.Parse(row["partQuantity"].ToString());
				}
				if(row["unitPriceAfterDiscount"]!=null && row["unitPriceAfterDiscount"].ToString()!="")
				{
					model.unitPriceAfterDiscount=decimal.Parse(row["unitPriceAfterDiscount"].ToString());
				}
				if(row["partFeeAfterDiscount"]!=null && row["partFeeAfterDiscount"].ToString()!="")
				{
					model.partFeeAfterDiscount=decimal.Parse(row["partFeeAfterDiscount"].ToString());
				}
				if(row["depreciation"]!=null && row["depreciation"].ToString()!="")
				{
					model.depreciation=decimal.Parse(row["depreciation"].ToString());
				}
				if(row["salvage"]!=null && row["salvage"].ToString()!="")
				{
					model.salvage=decimal.Parse(row["salvage"].ToString());
				}
				if(row["recycleFlag"]!=null && row["recycleFlag"].ToString()!="")
				{
					if((row["recycleFlag"].ToString()=="1")||(row["recycleFlag"].ToString().ToLower()=="true"))
					{
						model.recycleFlag=true;
					}
					else
					{
						model.recycleFlag=false;
					}
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
			strSql.Append("select Id,ItemId,itemName,ManualFlag,partNo,partQuantity,unitPriceAfterDiscount,partFeeAfterDiscount,depreciation,salvage,recycleFlag ");
			strSql.Append(" FROM CCCAPI_ChangeItems ");
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
			strSql.Append(" Id,ItemId,itemName,ManualFlag,partNo,partQuantity,unitPriceAfterDiscount,partFeeAfterDiscount,depreciation,salvage,recycleFlag ");
			strSql.Append(" FROM CCCAPI_ChangeItems ");
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
			strSql.Append("select count(1) FROM CCCAPI_ChangeItems ");
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
			strSql.Append(")AS Row, T.*  from CCCAPI_ChangeItems T ");
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
			parameters[0].Value = "CCCAPI_ChangeItems";
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

