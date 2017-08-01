
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;

namespace CZB.DAL.SqlServer.DataProvider
{
	/// <summary>
	/// 数据访问类:CCCAPI_RepairItems
	/// </summary>
	public partial class CCCAPI_RepairItems:ICCCAPI_RepairItems
	{
		public CCCAPI_RepairItems()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CCCAPI_RepairItems");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(CZB.Model.CCCAPI_RepairItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CCCAPI_RepairItems(");
			strSql.Append("id,itemId,itemName,manualFlag,operationType,partNo,laborType,laborHourFee,laborFeeManageRate,paintDiscountFlag,laborHour,laborFeeAfterDiscount,outerRepairFlag,outerLaborFee)");
			strSql.Append(" values (");
			strSql.Append("@id,@itemId,@itemName,@manualFlag,@operationType,@partNo,@laborType,@laborHourFee,@laborFeeManageRate,@paintDiscountFlag,@laborHour,@laborFeeAfterDiscount,@outerRepairFlag,@outerLaborFee)");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50),
					new SqlParameter("@itemId", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@manualFlag", SqlDbType.Bit,1),
					new SqlParameter("@operationType", SqlDbType.VarChar,30),
					new SqlParameter("@partNo", SqlDbType.VarChar,30),
					new SqlParameter("@laborType", SqlDbType.VarChar,30),
					new SqlParameter("@laborHourFee", SqlDbType.Decimal,9),
					new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
					new SqlParameter("@paintDiscountFlag", SqlDbType.Bit,1),
					new SqlParameter("@laborHour", SqlDbType.Decimal,9),
					new SqlParameter("@laborFeeAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@outerRepairFlag", SqlDbType.Bit,1),
					new SqlParameter("@outerLaborFee", SqlDbType.Decimal,9)};
			parameters[0].Value = model.id;
			parameters[1].Value = model.itemId;
			parameters[2].Value = model.itemName;
			parameters[3].Value = model.manualFlag;
			parameters[4].Value = model.operationType;
			parameters[5].Value = model.partNo;
			parameters[6].Value = model.laborType;
			parameters[7].Value = model.laborHourFee;
			parameters[8].Value = model.laborFeeManageRate;
			parameters[9].Value = model.paintDiscountFlag;
			parameters[10].Value = model.laborHour;
			parameters[11].Value = model.laborFeeAfterDiscount;
			parameters[12].Value = model.outerRepairFlag;
			parameters[13].Value = model.outerLaborFee;

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
		public bool Update(CZB.Model.CCCAPI_RepairItems model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CCCAPI_RepairItems set ");
			strSql.Append("itemId=@itemId,");
			strSql.Append("itemName=@itemName,");
			strSql.Append("manualFlag=@manualFlag,");
			strSql.Append("operationType=@operationType,");
			strSql.Append("partNo=@partNo,");
			strSql.Append("laborType=@laborType,");
			strSql.Append("laborHourFee=@laborHourFee,");
			strSql.Append("laborFeeManageRate=@laborFeeManageRate,");
			strSql.Append("paintDiscountFlag=@paintDiscountFlag,");
			strSql.Append("laborHour=@laborHour,");
			strSql.Append("laborFeeAfterDiscount=@laborFeeAfterDiscount,");
			strSql.Append("outerRepairFlag=@outerRepairFlag,");
			strSql.Append("outerLaborFee=@outerLaborFee");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@itemId", SqlDbType.Decimal,9),
					new SqlParameter("@itemName", SqlDbType.VarChar,100),
					new SqlParameter("@manualFlag", SqlDbType.Bit,1),
					new SqlParameter("@operationType", SqlDbType.VarChar,30),
					new SqlParameter("@partNo", SqlDbType.VarChar,30),
					new SqlParameter("@laborType", SqlDbType.VarChar,30),
					new SqlParameter("@laborHourFee", SqlDbType.Decimal,9),
					new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
					new SqlParameter("@paintDiscountFlag", SqlDbType.Bit,1),
					new SqlParameter("@laborHour", SqlDbType.Decimal,9),
					new SqlParameter("@laborFeeAfterDiscount", SqlDbType.Decimal,9),
					new SqlParameter("@outerRepairFlag", SqlDbType.Bit,1),
					new SqlParameter("@outerLaborFee", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.itemId;
			parameters[1].Value = model.itemName;
			parameters[2].Value = model.manualFlag;
			parameters[3].Value = model.operationType;
			parameters[4].Value = model.partNo;
			parameters[5].Value = model.laborType;
			parameters[6].Value = model.laborHourFee;
			parameters[7].Value = model.laborFeeManageRate;
			parameters[8].Value = model.paintDiscountFlag;
			parameters[9].Value = model.laborHour;
			parameters[10].Value = model.laborFeeAfterDiscount;
			parameters[11].Value = model.outerRepairFlag;
			parameters[12].Value = model.outerLaborFee;
			parameters[13].Value = model.id;

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
			strSql.Append("delete from CCCAPI_RepairItems ");
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
			strSql.Append("delete from CCCAPI_RepairItems ");
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
		public CZB.Model.CCCAPI_RepairItems GetModel(string id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,itemId,itemName,manualFlag,operationType,partNo,laborType,laborHourFee,laborFeeManageRate,paintDiscountFlag,laborHour,laborFeeAfterDiscount,outerRepairFlag,outerLaborFee from CCCAPI_RepairItems ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.NVarChar,50)			};
			parameters[0].Value = id;

			CZB.Model.CCCAPI_RepairItems model=new CZB.Model.CCCAPI_RepairItems();
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
		public CZB.Model.CCCAPI_RepairItems DataRowToModel(DataRow row)
		{
			CZB.Model.CCCAPI_RepairItems model=new CZB.Model.CCCAPI_RepairItems();
			if (row != null)
			{
				if(row["id"]!=null)
				{
					model.id=row["id"].ToString();
				}
				if(row["itemId"]!=null && row["itemId"].ToString()!="")
				{
					model.itemId=decimal.Parse(row["itemId"].ToString());
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
				if(row["operationType"]!=null)
				{
					model.operationType=row["operationType"].ToString();
				}
				if(row["partNo"]!=null)
				{
					model.partNo=row["partNo"].ToString();
				}
				if(row["laborType"]!=null)
				{
					model.laborType=row["laborType"].ToString();
				}
				if(row["laborHourFee"]!=null && row["laborHourFee"].ToString()!="")
				{
					model.laborHourFee=decimal.Parse(row["laborHourFee"].ToString());
				}
				if(row["laborFeeManageRate"]!=null && row["laborFeeManageRate"].ToString()!="")
				{
					model.laborFeeManageRate=decimal.Parse(row["laborFeeManageRate"].ToString());
				}
				if(row["paintDiscountFlag"]!=null && row["paintDiscountFlag"].ToString()!="")
				{
					if((row["paintDiscountFlag"].ToString()=="1")||(row["paintDiscountFlag"].ToString().ToLower()=="true"))
					{
						model.paintDiscountFlag=true;
					}
					else
					{
						model.paintDiscountFlag=false;
					}
				}
				if(row["laborHour"]!=null && row["laborHour"].ToString()!="")
				{
					model.laborHour=decimal.Parse(row["laborHour"].ToString());
				}
				if(row["laborFeeAfterDiscount"]!=null && row["laborFeeAfterDiscount"].ToString()!="")
				{
					model.laborFeeAfterDiscount=decimal.Parse(row["laborFeeAfterDiscount"].ToString());
				}
				if(row["outerRepairFlag"]!=null && row["outerRepairFlag"].ToString()!="")
				{
					if((row["outerRepairFlag"].ToString()=="1")||(row["outerRepairFlag"].ToString().ToLower()=="true"))
					{
						model.outerRepairFlag=true;
					}
					else
					{
						model.outerRepairFlag=false;
					}
				}
				if(row["outerLaborFee"]!=null && row["outerLaborFee"].ToString()!="")
				{
					model.outerLaborFee=decimal.Parse(row["outerLaborFee"].ToString());
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
			strSql.Append("select id,itemId,itemName,manualFlag,operationType,partNo,laborType,laborHourFee,laborFeeManageRate,paintDiscountFlag,laborHour,laborFeeAfterDiscount,outerRepairFlag,outerLaborFee ");
			strSql.Append(" FROM CCCAPI_RepairItems ");
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
			strSql.Append(" id,itemId,itemName,manualFlag,operationType,partNo,laborType,laborHourFee,laborFeeManageRate,paintDiscountFlag,laborHour,laborFeeAfterDiscount,outerRepairFlag,outerLaborFee ");
			strSql.Append(" FROM CCCAPI_RepairItems ");
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
			strSql.Append("select count(1) FROM CCCAPI_RepairItems ");
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
			strSql.Append(")AS Row, T.*  from CCCAPI_RepairItems T ");
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
			parameters[0].Value = "CCCAPI_RepairItems";
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

