using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:TB_Czb_CarOwner
    /// </summary>
    public partial class TB_Czb_CarOwner
    {
        public TB_Czb_CarOwner()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from TB_Czb_CarOwner");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50)            };
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.TB_Czb_CarOwner model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into TB_Czb_CarOwner(");
            strSql.Append("ID,Name,NickName,OpenId,PhoneNumber,PinYin,PinYinShort,IDCard,IDCardImage,IsCertificate,IsVip,IsEnable,IsValid,Creator,CreateTime,Modifier,ModifyTime,HeadImage,CityCode,ComeFrom,StoreID,Amount,IsRecommend,Recommender,App_HeadImage)");
            strSql.Append(" values (");
            strSql.Append("@ID,@Name,@NickName,@OpenId,@PhoneNumber,@PinYin,@PinYinShort,@IDCard,@IDCardImage,@IsCertificate,@IsVip,@IsEnable,@IsValid,@Creator,@CreateTime,@Modifier,@ModifyTime,@HeadImage,@CityCode,@ComeFrom,@StoreID,@Amount,@IsRecommend,@Recommender,@App_HeadImage)");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50),
                    new SqlParameter("@Name", SqlDbType.NVarChar,10),
                    new SqlParameter("@NickName", SqlDbType.NVarChar,50),
                    new SqlParameter("@OpenId", SqlDbType.NVarChar,50),
                    new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,15),
                    new SqlParameter("@PinYin", SqlDbType.NVarChar,50),
                    new SqlParameter("@PinYinShort", SqlDbType.NVarChar,10),
                    new SqlParameter("@IDCard", SqlDbType.NVarChar,18),
                    new SqlParameter("@IDCardImage", SqlDbType.NVarChar,-1),
                    new SqlParameter("@IsCertificate", SqlDbType.Bit,1),
                    new SqlParameter("@IsVip", SqlDbType.Bit,1),
                    new SqlParameter("@IsEnable", SqlDbType.Bit,1),
                    new SqlParameter("@IsValid", SqlDbType.Bit,1),
                    new SqlParameter("@Creator", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@Modifier", SqlDbType.NVarChar,50),
                    new SqlParameter("@ModifyTime", SqlDbType.DateTime),
                    new SqlParameter("@HeadImage", SqlDbType.NVarChar,255),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                    new SqlParameter("@StoreID", SqlDbType.NVarChar,50),
                    new SqlParameter("@Amount", SqlDbType.Decimal,9),
                    new SqlParameter("@IsRecommend", SqlDbType.Int,4),
                    new SqlParameter("@Recommender", SqlDbType.NVarChar,255),
                    new SqlParameter("@App_HeadImage", SqlDbType.NVarChar,255)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.NickName;
            parameters[3].Value = model.OpenId;
            parameters[4].Value = model.PhoneNumber;
            parameters[5].Value = model.PinYin;
            parameters[6].Value = model.PinYinShort;
            parameters[7].Value = model.IDCard;
            parameters[8].Value = model.IDCardImage;
            parameters[9].Value = model.IsCertificate;
            parameters[10].Value = model.IsVip;
            parameters[11].Value = model.IsEnable;
            parameters[12].Value = model.IsValid;
            parameters[13].Value = model.Creator;
            parameters[14].Value = model.CreateTime;
            parameters[15].Value = model.Modifier;
            parameters[16].Value = model.ModifyTime;
            parameters[17].Value = model.HeadImage;
            parameters[18].Value = model.CityCode;
            parameters[19].Value = model.ComeFrom;
            parameters[20].Value = model.StoreID;
            parameters[21].Value = model.Amount;
            parameters[22].Value = model.IsRecommend;
            parameters[23].Value = model.Recommender;
            parameters[24].Value = model.App_HeadImage;

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
        public bool Update(CZB.Model.TB_Czb_CarOwner model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TB_Czb_CarOwner set ");
            strSql.Append("Name=@Name,");
            strSql.Append("NickName=@NickName,");
            strSql.Append("OpenId=@OpenId,");
            strSql.Append("PhoneNumber=@PhoneNumber,");
            strSql.Append("PinYin=@PinYin,");
            strSql.Append("PinYinShort=@PinYinShort,");
            strSql.Append("IDCard=@IDCard,");
            strSql.Append("IDCardImage=@IDCardImage,");
            strSql.Append("IsCertificate=@IsCertificate,");
            strSql.Append("IsVip=@IsVip,");
            strSql.Append("IsEnable=@IsEnable,");
            strSql.Append("IsValid=@IsValid,");
            strSql.Append("Creator=@Creator,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("Modifier=@Modifier,");
            strSql.Append("ModifyTime=@ModifyTime,");
            strSql.Append("HeadImage=@HeadImage,");
            strSql.Append("CityCode=@CityCode,");
            strSql.Append("ComeFrom=@ComeFrom,");
            strSql.Append("StoreID=@StoreID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("IsRecommend=@IsRecommend,");
            strSql.Append("Recommender=@Recommender,");
            strSql.Append("App_HeadImage=@App_HeadImage");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Name", SqlDbType.NVarChar,10),
                    new SqlParameter("@NickName", SqlDbType.NVarChar,50),
                    new SqlParameter("@OpenId", SqlDbType.NVarChar,50),
                    new SqlParameter("@PhoneNumber", SqlDbType.NVarChar,15),
                    new SqlParameter("@PinYin", SqlDbType.NVarChar,50),
                    new SqlParameter("@PinYinShort", SqlDbType.NVarChar,10),
                    new SqlParameter("@IDCard", SqlDbType.NVarChar,18),
                    new SqlParameter("@IDCardImage", SqlDbType.NVarChar,-1),
                    new SqlParameter("@IsCertificate", SqlDbType.Bit,1),
                    new SqlParameter("@IsVip", SqlDbType.Bit,1),
                    new SqlParameter("@IsEnable", SqlDbType.Bit,1),
                    new SqlParameter("@IsValid", SqlDbType.Bit,1),
                    new SqlParameter("@Creator", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@Modifier", SqlDbType.NVarChar,50),
                    new SqlParameter("@ModifyTime", SqlDbType.DateTime),
                    new SqlParameter("@HeadImage", SqlDbType.NVarChar,255),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                    new SqlParameter("@StoreID", SqlDbType.NVarChar,50),
                    new SqlParameter("@Amount", SqlDbType.Decimal,9),
                    new SqlParameter("@IsRecommend", SqlDbType.Int,4),
                    new SqlParameter("@Recommender", SqlDbType.NVarChar,255),
                    new SqlParameter("@App_HeadImage", SqlDbType.NVarChar,255),
                    new SqlParameter("@ID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.NickName;
            parameters[2].Value = model.OpenId;
            parameters[3].Value = model.PhoneNumber;
            parameters[4].Value = model.PinYin;
            parameters[5].Value = model.PinYinShort;
            parameters[6].Value = model.IDCard;
            parameters[7].Value = model.IDCardImage;
            parameters[8].Value = model.IsCertificate;
            parameters[9].Value = model.IsVip;
            parameters[10].Value = model.IsEnable;
            parameters[11].Value = model.IsValid;
            parameters[12].Value = model.Creator;
            parameters[13].Value = model.CreateTime;
            parameters[14].Value = model.Modifier;
            parameters[15].Value = model.ModifyTime;
            parameters[16].Value = model.HeadImage;
            parameters[17].Value = model.CityCode;
            parameters[18].Value = model.ComeFrom;
            parameters[19].Value = model.StoreID;
            parameters[20].Value = model.Amount;
            parameters[21].Value = model.IsRecommend;
            parameters[22].Value = model.Recommender;
            parameters[23].Value = model.App_HeadImage;
            parameters[24].Value = model.ID;

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
            strSql.Append("delete from TB_Czb_CarOwner ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50)            };
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
        /// 得到一个对象实体
        /// </summary>
        public DataSet GetModel(string ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,NickName,OpenId,PhoneNumber,PinYin,PinYinShort,IDCard,IDCardImage,IsCertificate,IsVip,IsEnable,IsValid,Creator,CreateTime,Modifier,ModifyTime,HeadImage,CityCode,ComeFrom,StoreID,Amount,IsRecommend,Recommender,App_HeadImage from TB_Czb_CarOwner ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.NVarChar,50)            };
            parameters[0].Value = ID;
            return DbHelperSQL.Query(strSql.ToString(), parameters);

        }



        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,NickName,OpenId,PhoneNumber,PinYin,PinYinShort,IDCard,IDCardImage,IsCertificate,IsVip,IsEnable,IsValid,Creator,CreateTime,Modifier,ModifyTime,HeadImage,CityCode,ComeFrom,StoreID,Amount,IsRecommend,Recommender,App_HeadImage ");
            strSql.Append(" FROM TB_Czb_CarOwner ");
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
            strSql.Append(" ID,Name,NickName,OpenId,PhoneNumber,PinYin,PinYinShort,IDCard,IDCardImage,IsCertificate,IsVip,IsEnable,IsValid,Creator,CreateTime,Modifier,ModifyTime,HeadImage,CityCode,ComeFrom,StoreID,Amount,IsRecommend,Recommender,App_HeadImage ");
            strSql.Append(" FROM TB_Czb_CarOwner ");
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
            strSql.Append("select count(1) FROM TB_Czb_CarOwner ");
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
            strSql.Append(")AS Row, T.*  from TB_Czb_CarOwner T ");
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
            parameters[0].Value = "TB_Czb_CarOwner";
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
