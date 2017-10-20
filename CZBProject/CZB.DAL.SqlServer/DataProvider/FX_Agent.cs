
using CZB.Common.Extensions;
using CZB.IDAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_Agent
    /// </summary>
    public partial class FX_Agent : IFX_Agent
    {
        public FX_Agent()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("AgentId", "FX_Agent");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int AgentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_Agent");
            strSql.Append(" where AgentId=@AgentId");
            SqlParameter[] parameters = {
                    new SqlParameter("@AgentId", SqlDbType.Int,4)
            };
            parameters[0].Value = AgentId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_Agent(");
            strSql.Append("TrueName,IDNO,Mobile,UserAccountNumer,Password,OpenId,WXName,FacePic,ProvId,CityId,Address,ParentId,ParentList,AgentLevel,TotalAmout,AvailableAmount,CityCode,CreateTime,IsDelete,IsUse,RoleTypeID,ShareRate,ShareUrl,ComeFrom)");
            strSql.Append(" values (");
            strSql.Append("@TrueName,@IDNO,@Mobile,@UserAccountNumer,@Password,@OpenId,@WXName,@FacePic,@ProvId,@CityId,@Address,@ParentId,@ParentList,@AgentLevel,@TotalAmout,@AvailableAmount,@CityCode,@CreateTime,@IsDelete,@IsUse,@RoleTypeID,@ShareRate,@ShareUrl,@ComeFrom)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@TrueName", SqlDbType.NVarChar,50),
                    new SqlParameter("@IDNO", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
                    new SqlParameter("@UserAccountNumer", SqlDbType.NVarChar,50),
                    new SqlParameter("@Password", SqlDbType.NVarChar,50),
                    new SqlParameter("@OpenId", SqlDbType.NVarChar,50),
                    new SqlParameter("@WXName", SqlDbType.NVarChar,50),
                    new SqlParameter("@FacePic", SqlDbType.NVarChar,200),
                    new SqlParameter("@ProvId", SqlDbType.Int,4),
                    new SqlParameter("@CityId", SqlDbType.Int,4),
                    new SqlParameter("@Address", SqlDbType.NVarChar,200),
                    new SqlParameter("@ParentId", SqlDbType.Int,4),
                    new SqlParameter("@ParentList", SqlDbType.NVarChar,50),
                    new SqlParameter("@AgentLevel", SqlDbType.Int,4),
                    new SqlParameter("@TotalAmout", SqlDbType.Decimal,9),
                    new SqlParameter("@AvailableAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsDelete", SqlDbType.Bit,1),
                    new SqlParameter("@IsUse", SqlDbType.Bit,1),
                    new SqlParameter("@RoleTypeID", SqlDbType.Int,4),
                    new SqlParameter("@ShareRate", SqlDbType.Int,4),
                    new SqlParameter("@ShareUrl", SqlDbType.NVarChar,255),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4)};
            parameters[0].Value = model.TrueName;
            parameters[1].Value = model.IDNO;
            parameters[2].Value = model.Mobile;
            parameters[3].Value = model.UserAccountNumer;
            parameters[4].Value = model.Password;
            parameters[5].Value = model.OpenId;
            parameters[6].Value = model.WXName;
            parameters[7].Value = model.FacePic;
            parameters[8].Value = model.ProvId;
            parameters[9].Value = model.CityId;
            parameters[10].Value = model.Address;
            parameters[11].Value = model.ParentId;
            parameters[12].Value = model.ParentList;
            parameters[13].Value = model.AgentLevel;
            parameters[14].Value = model.TotalAmout;
            parameters[15].Value = model.AvailableAmount;
            parameters[16].Value = model.CityCode;
            parameters[17].Value = model.CreateTime;
            parameters[18].Value = model.IsDelete;
            parameters[19].Value = model.IsUse;
            parameters[20].Value = model.RoleTypeID;
            parameters[21].Value = model.ShareRate;
            parameters[22].Value = model.ShareUrl;
            parameters[23].Value = model.ComeFrom;

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
        ///  获取=>下级发展的数量
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public int GetCountParent(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select count(1) from FX_Agent where  charindex(@agentId,ParentList)>0 and AgentLevel !=1  ; ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@agentId",","+agentId+",")
            };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sqlParameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.ToInt32();
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_Agent model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_Agent set ");
            strSql.Append("TrueName=@TrueName,");
            strSql.Append("IDNO=@IDNO,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("UserAccountNumer=@UserAccountNumer,");
            strSql.Append("Password=@Password,");
            strSql.Append("OpenId=@OpenId,");
            strSql.Append("WXName=@WXName,");
            strSql.Append("FacePic=@FacePic,");
            strSql.Append("ProvId=@ProvId,");
            strSql.Append("CityId=@CityId,");
            strSql.Append("Address=@Address,");
            strSql.Append("ParentId=@ParentId,");
            strSql.Append("ParentList=@ParentList,");
            strSql.Append("AgentLevel=@AgentLevel,");
            strSql.Append("TotalAmout=@TotalAmout,");
            strSql.Append("AvailableAmount=@AvailableAmount,");
            strSql.Append("CityCode=@CityCode,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("IsDelete=@IsDelete,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("RoleTypeID=@RoleTypeID,");
            strSql.Append("ShareRate=@ShareRate,");
            strSql.Append("ShareUrl=@ShareUrl,");
            strSql.Append("ComeFrom=@ComeFrom");
            strSql.Append(" where AgentId=@AgentId");
            SqlParameter[] parameters = {
                    new SqlParameter("@TrueName", SqlDbType.NVarChar,50),
                    new SqlParameter("@IDNO", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
                    new SqlParameter("@UserAccountNumer", SqlDbType.NVarChar,50),
                    new SqlParameter("@Password", SqlDbType.NVarChar,50),
                    new SqlParameter("@OpenId", SqlDbType.NVarChar,50),
                    new SqlParameter("@WXName", SqlDbType.NVarChar,50),
                    new SqlParameter("@FacePic", SqlDbType.NVarChar,200),
                    new SqlParameter("@ProvId", SqlDbType.Int,4),
                    new SqlParameter("@CityId", SqlDbType.Int,4),
                    new SqlParameter("@Address", SqlDbType.NVarChar,200),
                    new SqlParameter("@ParentId", SqlDbType.Int,4),
                    new SqlParameter("@ParentList", SqlDbType.NVarChar,50),
                    new SqlParameter("@AgentLevel", SqlDbType.Int,4),
                    new SqlParameter("@TotalAmout", SqlDbType.Decimal,9),
                    new SqlParameter("@AvailableAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@IsDelete", SqlDbType.Bit,1),
                    new SqlParameter("@IsUse", SqlDbType.Bit,1),
                    new SqlParameter("@RoleTypeID", SqlDbType.Int,4),
                    new SqlParameter("@ShareRate", SqlDbType.Int,4),
                    new SqlParameter("@ShareUrl", SqlDbType.NVarChar,255),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                    new SqlParameter("@AgentId", SqlDbType.Int,4)};
            parameters[0].Value = model.TrueName;
            parameters[1].Value = model.IDNO;
            parameters[2].Value = model.Mobile;
            parameters[3].Value = model.UserAccountNumer;
            parameters[4].Value = model.Password;
            parameters[5].Value = model.OpenId;
            parameters[6].Value = model.WXName;
            parameters[7].Value = model.FacePic;
            parameters[8].Value = model.ProvId;
            parameters[9].Value = model.CityId;
            parameters[10].Value = model.Address;
            parameters[11].Value = model.ParentId;
            parameters[12].Value = model.ParentList;
            parameters[13].Value = model.AgentLevel;
            parameters[14].Value = model.TotalAmout;
            parameters[15].Value = model.AvailableAmount;
            parameters[16].Value = model.CityCode;
            parameters[17].Value = model.CreateTime;
            parameters[18].Value = model.IsDelete;
            parameters[19].Value = model.IsUse;
            parameters[20].Value = model.RoleTypeID;
            parameters[21].Value = model.ShareRate;
            parameters[22].Value = model.ShareUrl;
            parameters[23].Value = model.ComeFrom;
            parameters[24].Value = model.AgentId;

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
        public bool Delete(int AgentId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_Agent ");
            strSql.Append(" where AgentId=@AgentId");
            SqlParameter[] parameters = {
                    new SqlParameter("@AgentId", SqlDbType.Int,4)
            };
            parameters[0].Value = AgentId;

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
        public bool DeleteList(string AgentIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_Agent ");
            strSql.Append(" where AgentId in (" + AgentIdlist + ")  ");
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
            strSql.Append("select AgentId,TrueName,IDNO,Mobile,UserAccountNumer,Password,OpenId,WXName,FacePic,ProvId,CityId,Address,ParentId,ParentList,AgentLevel,TotalAmout,AvailableAmount,CityCode,CreateTime,IsDelete,IsUse,RoleTypeID,ShareRate,ShareUrl,ComeFrom ");
            strSql.Append(" FROM FX_Agent ");
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
            strSql.Append(" AgentId,TrueName,IDNO,Mobile,UserAccountNumer,Password,OpenId,WXName,FacePic,ProvId,CityId,Address,ParentId,ParentList,AgentLevel,TotalAmout,AvailableAmount,CityCode,CreateTime,IsDelete,IsUse,RoleTypeID,ShareRate,ShareUrl,ComeFrom ");
            strSql.Append(" FROM FX_Agent ");
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
            strSql.Append("select count(1) FROM FX_Agent ");
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
        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据手机号获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public DataSet GetModelByPhone(string phone)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select *  from FX_Agent where Mobile=@phone; ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@phone",phone)
            };

            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }


        /// <summary>
        /// 根据Code邀请码获取用户信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public DataSet GetModelByZ_Code(string z_code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select * from FX_Agent where UserAccountNumer=@UserAccountNumer; ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@UserAccountNumer",z_code)
            };
            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }

        /// <summary>
        /// 根据代理商编号获取代理商信息
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public DataSet GetDataByAgentId(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select *  from FX_Agent where AgentId=@agentId ; ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@agentId",agentId)
            };

            return DbHelperSQL.Query(strSql.ToString(), sqlParameters);
        }


        /// <summary>
        /// 注册代理商
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool RegisterAgent(CZB.Model.FX_Agent model)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("insert into FX_Agent(");
                        strSql.Append("TrueName,IDNO,Mobile,UserAccountNumer,Password,OpenId,WXName,FacePic,ProvId,CityId,Address,ParentId,ParentList,AgentLevel,TotalAmout,AvailableAmount,CityCode,CreateTime,IsDelete,IsUse,RoleTypeID,ShareRate)");
                        strSql.Append(" values (");
                        strSql.Append("@TrueName,@IDNO,@Mobile,@UserAccountNumer,@Password,@OpenId,@WXName,@FacePic,@ProvId,@CityId,@Address,@ParentId,@ParentList,@AgentLevel,@TotalAmout,@AvailableAmount,@CityCode,@CreateTime,@IsDelete,@IsUse,@RoleTypeID,@ShareRate)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters =
                        {
                        new SqlParameter("@TrueName", SqlDbType.NVarChar,50),
                        new SqlParameter("@IDNO", SqlDbType.NVarChar,50),
                        new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
                        new SqlParameter("@UserAccountNumer", SqlDbType.NVarChar,50),
                        new SqlParameter("@Password", SqlDbType.NVarChar,50),
                        new SqlParameter("@OpenId", SqlDbType.NVarChar,50),
                        new SqlParameter("@WXName", SqlDbType.NVarChar,50),
                        new SqlParameter("@FacePic", SqlDbType.NVarChar,200),
                        new SqlParameter("@ProvId", SqlDbType.Int,4),
                        new SqlParameter("@CityId", SqlDbType.Int,4),
                        new SqlParameter("@Address", SqlDbType.NVarChar,200),
                        new SqlParameter("@ParentId", SqlDbType.Int,4),
                        new SqlParameter("@ParentList", SqlDbType.NVarChar,50),
                        new SqlParameter("@AgentLevel", SqlDbType.Int,4),
                        new SqlParameter("@TotalAmout", SqlDbType.Decimal,9),
                        new SqlParameter("@AvailableAmount", SqlDbType.Decimal,9),
                        new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                        new SqlParameter("@CreateTime", SqlDbType.DateTime),
                        new SqlParameter("@IsDelete", SqlDbType.Bit,1),
                        new SqlParameter("@IsUse", SqlDbType.Bit,1),
                        new SqlParameter("@RoleTypeID", SqlDbType.Int,4),
                        new SqlParameter("@ShareRate", SqlDbType.Int,4)
                        };
                        parameters[0].Value = model.TrueName;
                        parameters[1].Value = model.IDNO;
                        parameters[2].Value = model.Mobile;
                        parameters[3].Value = model.UserAccountNumer;
                        parameters[4].Value = model.Password;
                        parameters[5].Value = model.OpenId;
                        parameters[6].Value = model.WXName;
                        parameters[7].Value = model.FacePic;
                        parameters[8].Value = model.ProvId;
                        parameters[9].Value = model.CityId;
                        parameters[10].Value = model.Address;
                        parameters[11].Value = model.ParentId;
                        parameters[12].Value = model.ParentList;
                        parameters[13].Value = model.AgentLevel;
                        parameters[14].Value = model.TotalAmout;
                        parameters[15].Value = model.AvailableAmount;
                        parameters[16].Value = model.CityCode;
                        parameters[17].Value = model.CreateTime;
                        parameters[18].Value = model.IsDelete;
                        parameters[19].Value = model.IsUse;
                        parameters[20].Value = model.RoleTypeID;
                        parameters[21].Value = model.ShareRate;

                        object obj = DbHelperSQL.GetSingle(conn, trans, strSql.ToString(), parameters);
                        int addId = 0;
                        if (obj != null)
                        {
                            addId = Convert.ToInt32(obj);
                        }
                        if (addId > 0)
                        {
                            string parentList = model.ParentList + addId + ",";
                            StringBuilder strUpdateSql = new StringBuilder();
                            strUpdateSql.Append(" update FX_Agent ");
                            strUpdateSql.Append(" set ParentList = @ParentList ");
                            strUpdateSql.Append(" where AgentId = @AgentId ");

                            SqlParameter[] updateParameters = {
                                                        new SqlParameter("@ParentList",SqlDbType.VarChar,50),
                                                        new SqlParameter("@AgentId",SqlDbType.Int,4)
                                                        };

                            updateParameters[0].Value = parentList;
                            updateParameters[1].Value = addId;
                            DbHelperSQL.ExecuteSql(conn, trans, strUpdateSql.ToString(), updateParameters);
                        }
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion  ExtensionMethod
    }
}
