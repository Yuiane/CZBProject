using CZB.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
	/// 数据访问类:CZB_Material
	/// </summary>
	public partial class Material : IMaterial
    {
        public Material()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CZB_Material");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,50)         };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.Material model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CZB_Material(");
            strSql.Append("ID,ReplyType,Context,ImageUrl,LinkUrl,State,Creater,Createtime,Updater,UpdateTime)");
            strSql.Append(" values (");
            strSql.Append("@ID,@ReplyType,@Context,@ImageUrl,@LinkUrl,@State,@Creater,@Createtime,@Updater,@UpdateTime)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,50),
                    new SqlParameter("@ReplyType", SqlDbType.Int,4),
                    new SqlParameter("@Context", SqlDbType.VarChar,-1),
                    new SqlParameter("@ImageUrl", SqlDbType.VarChar,255),
                    new SqlParameter("@LinkUrl", SqlDbType.VarChar,255),
                    new SqlParameter("@State", SqlDbType.Int,4),
                    new SqlParameter("@Creater", SqlDbType.VarChar,50),
                    new SqlParameter("@Createtime", SqlDbType.DateTime),
                    new SqlParameter("@Updater", SqlDbType.VarChar,50),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ReplyType;
            parameters[2].Value = model.Context;
            parameters[3].Value = model.ImageUrl;
            parameters[4].Value = model.LinkUrl;
            parameters[5].Value = model.State;
            parameters[6].Value = model.Creater;
            parameters[7].Value = model.Createtime;
            parameters[8].Value = model.Updater;
            parameters[9].Value = model.UpdateTime;

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
        public bool Update(CZB.Model.Material model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CZB_Material set ");
            strSql.Append("ReplyType=@ReplyType,");
            strSql.Append("Context=@Context,");
            strSql.Append("ImageUrl=@ImageUrl,");
            strSql.Append("LinkUrl=@LinkUrl,");
            strSql.Append("State=@State,");
            strSql.Append("Creater=@Creater,");
            strSql.Append("Createtime=@Createtime,");
            strSql.Append("Updater=@Updater,");
            strSql.Append("UpdateTime=@UpdateTime");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ReplyType", SqlDbType.Int,4),
                    new SqlParameter("@Context", SqlDbType.VarChar,-1),
                    new SqlParameter("@ImageUrl", SqlDbType.VarChar,255),
                    new SqlParameter("@LinkUrl", SqlDbType.VarChar,255),
                    new SqlParameter("@State", SqlDbType.Int,4),
                    new SqlParameter("@Creater", SqlDbType.VarChar,50),
                    new SqlParameter("@Createtime", SqlDbType.DateTime),
                    new SqlParameter("@Updater", SqlDbType.VarChar,50),
                    new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.VarChar,50)};
            parameters[0].Value = model.ReplyType;
            parameters[1].Value = model.Context;
            parameters[2].Value = model.ImageUrl;
            parameters[3].Value = model.LinkUrl;
            parameters[4].Value = model.State;
            parameters[5].Value = model.Creater;
            parameters[6].Value = model.Createtime;
            parameters[7].Value = model.Updater;
            parameters[8].Value = model.UpdateTime;
            parameters[9].Value = model.ID;

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
        public bool Delete(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CZB_Material ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,50)         };
            parameters[0].Value = ID;

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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CZB_Material ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
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
        /// 得到一个对象实体
        /// </summary>
        public CZB.Model.Material GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ReplyType,Context,ImageUrl,LinkUrl,State,Creater,Createtime,Updater,UpdateTime from CZB_Material ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.VarChar,50)         };
            parameters[0].Value = ID;

            CZB.Model.Material model = new CZB.Model.Material();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public CZB.Model.Material DataRowToModel(DataRow row)
        {
            CZB.Model.Material model = new CZB.Model.Material();
            if (row != null)
            {
                if (row["ID"] != null)
                {
                    model.ID = row["ID"].ToString();
                }
                if (row["ReplyType"] != null && row["ReplyType"].ToString() != "")
                {
                    model.ReplyType = int.Parse(row["ReplyType"].ToString());
                }
                if (row["Context"] != null)
                {
                    model.Context = row["Context"].ToString();
                }
                if (row["ImageUrl"] != null)
                {
                    model.ImageUrl = row["ImageUrl"].ToString();
                }
                if (row["LinkUrl"] != null)
                {
                    model.LinkUrl = row["LinkUrl"].ToString();
                }
                if (row["State"] != null && row["State"].ToString() != "")
                {
                    model.State = int.Parse(row["State"].ToString());
                }
                if (row["Creater"] != null)
                {
                    model.Creater = row["Creater"].ToString();
                }
                if (row["Createtime"] != null && row["Createtime"].ToString() != "")
                {
                    model.Createtime = DateTime.Parse(row["Createtime"].ToString());
                }
                if (row["Updater"] != null)
                {
                    model.Updater = row["Updater"].ToString();
                }
                if (row["UpdateTime"] != null && row["UpdateTime"].ToString() != "")
                {
                    model.UpdateTime = DateTime.Parse(row["UpdateTime"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ReplyType,Context,ImageUrl,LinkUrl,State,Creater,Createtime,Updater,UpdateTime ");
            strSql.Append(" FROM CZB_Material ");
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
            strSql.Append(" ID,ReplyType,Context,ImageUrl,LinkUrl,State,Creater,Createtime,Updater,UpdateTime ");
            strSql.Append(" FROM CZB_Material ");
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
            strSql.Append("select count(1) FROM CZB_Material ");
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
                strSql.Append("order by T.ID desc");
            }
            strSql.Append(")AS Row, T.*  from CZB_Material T ");
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
			parameters[0].Value = "CZB_Material";
			parameters[1].Value = "ID";
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
