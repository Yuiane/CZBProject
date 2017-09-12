using CZB.Common.Extensions;
using CZB.IDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CZB.DAL.SqlServer.DataProvider
{
    /// <summary>
    /// 数据访问类:FX_Policy
    /// </summary>
    public partial class FX_Policy : IFX_Policy
    {
        public FX_Policy()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("PolicyId", "FX_Policy");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PolicyId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FX_Policy");
            strSql.Append(" where PolicyId=@PolicyId");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyId", SqlDbType.Int,4)
            };
            parameters[0].Value = PolicyId;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_Policy model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FX_Policy(");
            strSql.Append("AgentId,CustomerId,VIN,DrivingLicense,DrivingLicensePic,CarType,OrganizationCode,InsureCode,FX_PolicyNo,PolicyNoCompulsory,PolicyNoBusiness,PolicyType,CreateTime,PayTime,OfferTime,OfferNum,PolicyState,PayState,PayUrl,PayValidateCode,PaydealCode,PolicyAmount,CompulsoryAmount,BusinessAmount,VehicleAndVesselTax,StartTime,EndTime,CityCode,Discount,UserId,Remark,CancelRemark,RejectNum,RejectTime,CustomerName,CustomerMoblie,CustomerIdNo,CustomerIdPic,CarModel,CarNo,CarEngineNo,CarRegisterDate,IsRead,SafetyFactor,DangerousCount,InquiryDate,ComeFrom,CZBTbCustomerID)");
            strSql.Append(" values (");
            strSql.Append("@AgentId,@CustomerId,@VIN,@DrivingLicense,@DrivingLicensePic,@CarType,@OrganizationCode,@InsureCode,@FX_PolicyNo,@PolicyNoCompulsory,@PolicyNoBusiness,@PolicyType,@CreateTime,@PayTime,@OfferTime,@OfferNum,@PolicyState,@PayState,@PayUrl,@PayValidateCode,@PaydealCode,@PolicyAmount,@CompulsoryAmount,@BusinessAmount,@VehicleAndVesselTax,@StartTime,@EndTime,@CityCode,@Discount,@UserId,@Remark,@CancelRemark,@RejectNum,@RejectTime,@CustomerName,@CustomerMoblie,@CustomerIdNo,@CustomerIdPic,@CarModel,@CarNo,@CarEngineNo,@CarRegisterDate,@IsRead,@SafetyFactor,@DangerousCount,@InquiryDate,@ComeFrom,@CZBTbCustomerID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@AgentId", SqlDbType.Int,4),
                    new SqlParameter("@CustomerId", SqlDbType.Int,4),
                    new SqlParameter("@VIN", SqlDbType.NVarChar,50),
                    new SqlParameter("@DrivingLicense", SqlDbType.NVarChar,50),
                    new SqlParameter("@DrivingLicensePic", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CarType", SqlDbType.Int,4),
                    new SqlParameter("@OrganizationCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@FX_PolicyNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyNoCompulsory", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyNoBusiness", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyType", SqlDbType.Int,4),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@PayTime", SqlDbType.DateTime),
                    new SqlParameter("@OfferTime", SqlDbType.DateTime),
                    new SqlParameter("@OfferNum", SqlDbType.Int,4),
                    new SqlParameter("@PolicyState", SqlDbType.Int,4),
                    new SqlParameter("@PayState", SqlDbType.Int,4),
                    new SqlParameter("@PayUrl", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PayValidateCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@PaydealCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@VehicleAndVesselTax", SqlDbType.Decimal,9),
                    new SqlParameter("@StartTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@Discount", SqlDbType.Decimal,9),
                    new SqlParameter("@UserId", SqlDbType.Int,4),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,100),
                    new SqlParameter("@CancelRemark", SqlDbType.NVarChar,100),
                    new SqlParameter("@RejectNum", SqlDbType.Int,4),
                    new SqlParameter("@RejectTime", SqlDbType.DateTime),
                    new SqlParameter("@CustomerName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerMoblie", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerIdNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerIdPic", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CarModel", SqlDbType.NVarChar,50),
                    new SqlParameter("@CarNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@CarEngineNo", SqlDbType.NVarChar,100),
                    new SqlParameter("@CarRegisterDate", SqlDbType.Date,3),
                    new SqlParameter("@IsRead", SqlDbType.Bit,1),
                    new SqlParameter("@SafetyFactor", SqlDbType.Decimal,9),
                    new SqlParameter("@DangerousCount", SqlDbType.Int,4),
                    new SqlParameter("@InquiryDate", SqlDbType.DateTime),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                    new SqlParameter("@CZBTbCustomerID", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.AgentId;
            parameters[1].Value = model.CustomerId;
            parameters[2].Value = model.VIN;
            parameters[3].Value = model.DrivingLicense;
            parameters[4].Value = model.DrivingLicensePic;
            parameters[5].Value = model.CarType;
            parameters[6].Value = model.OrganizationCode;
            parameters[7].Value = model.InsureCode;
            parameters[8].Value = model.FX_PolicyNo;
            parameters[9].Value = model.PolicyNoCompulsory;
            parameters[10].Value = model.PolicyNoBusiness;
            parameters[11].Value = model.PolicyType;
            parameters[12].Value = model.CreateTime;
            parameters[13].Value = model.PayTime;
            parameters[14].Value = model.OfferTime;
            parameters[15].Value = model.OfferNum;
            parameters[16].Value = model.PolicyState;
            parameters[17].Value = model.PayState;
            parameters[18].Value = model.PayUrl;
            parameters[19].Value = model.PayValidateCode;
            parameters[20].Value = model.PaydealCode;
            parameters[21].Value = model.PolicyAmount;
            parameters[22].Value = model.CompulsoryAmount;
            parameters[23].Value = model.BusinessAmount;
            parameters[24].Value = model.VehicleAndVesselTax;
            parameters[25].Value = model.StartTime;
            parameters[26].Value = model.EndTime;
            parameters[27].Value = model.CityCode;
            parameters[28].Value = model.Discount;
            parameters[29].Value = model.UserId;
            parameters[30].Value = model.Remark;
            parameters[31].Value = model.CancelRemark;
            parameters[32].Value = model.RejectNum;
            parameters[33].Value = model.RejectTime;
            parameters[34].Value = model.CustomerName;
            parameters[35].Value = model.CustomerMoblie;
            parameters[36].Value = model.CustomerIdNo;
            parameters[37].Value = model.CustomerIdPic;
            parameters[38].Value = model.CarModel;
            parameters[39].Value = model.CarNo;
            parameters[40].Value = model.CarEngineNo;
            parameters[41].Value = model.CarRegisterDate;
            parameters[42].Value = model.IsRead;
            parameters[43].Value = model.SafetyFactor;
            parameters[44].Value = model.DangerousCount;
            parameters[45].Value = model.InquiryDate;
            parameters[46].Value = model.ComeFrom;
            parameters[47].Value = model.CZBTbCustomerID;

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
        public bool Update(CZB.Model.FX_Policy model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FX_Policy set ");
            strSql.Append("AgentId=@AgentId,");
            strSql.Append("CustomerId=@CustomerId,");
            strSql.Append("VIN=@VIN,");
            strSql.Append("DrivingLicense=@DrivingLicense,");
            strSql.Append("DrivingLicensePic=@DrivingLicensePic,");
            strSql.Append("CarType=@CarType,");
            strSql.Append("OrganizationCode=@OrganizationCode,");
            strSql.Append("InsureCode=@InsureCode,");
            strSql.Append("FX_PolicyNo=@FX_PolicyNo,");
            strSql.Append("PolicyNoCompulsory=@PolicyNoCompulsory,");
            strSql.Append("PolicyNoBusiness=@PolicyNoBusiness,");
            strSql.Append("PolicyType=@PolicyType,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("PayTime=@PayTime,");
            strSql.Append("OfferTime=@OfferTime,");
            strSql.Append("OfferNum=@OfferNum,");
            strSql.Append("PolicyState=@PolicyState,");
            strSql.Append("PayState=@PayState,");
            strSql.Append("PayUrl=@PayUrl,");
            strSql.Append("PayValidateCode=@PayValidateCode,");
            strSql.Append("PaydealCode=@PaydealCode,");
            strSql.Append("PolicyAmount=@PolicyAmount,");
            strSql.Append("CompulsoryAmount=@CompulsoryAmount,");
            strSql.Append("BusinessAmount=@BusinessAmount,");
            strSql.Append("VehicleAndVesselTax=@VehicleAndVesselTax,");
            strSql.Append("StartTime=@StartTime,");
            strSql.Append("EndTime=@EndTime,");
            strSql.Append("CityCode=@CityCode,");
            strSql.Append("Discount=@Discount,");
            strSql.Append("UserId=@UserId,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("CancelRemark=@CancelRemark,");
            strSql.Append("RejectNum=@RejectNum,");
            strSql.Append("RejectTime=@RejectTime,");
            strSql.Append("CustomerName=@CustomerName,");
            strSql.Append("CustomerMoblie=@CustomerMoblie,");
            strSql.Append("CustomerIdNo=@CustomerIdNo,");
            strSql.Append("CustomerIdPic=@CustomerIdPic,");
            strSql.Append("CarModel=@CarModel,");
            strSql.Append("CarNo=@CarNo,");
            strSql.Append("CarEngineNo=@CarEngineNo,");
            strSql.Append("CarRegisterDate=@CarRegisterDate,");
            strSql.Append("IsRead=@IsRead,");
            strSql.Append("SafetyFactor=@SafetyFactor,");
            strSql.Append("DangerousCount=@DangerousCount,");
            strSql.Append("InquiryDate=@InquiryDate,");
            strSql.Append("ComeFrom=@ComeFrom,");
            strSql.Append("CZBTbCustomerID=@CZBTbCustomerID");
            strSql.Append(" where PolicyId=@PolicyId");
            SqlParameter[] parameters = {
                    new SqlParameter("@AgentId", SqlDbType.Int,4),
                    new SqlParameter("@CustomerId", SqlDbType.Int,4),
                    new SqlParameter("@VIN", SqlDbType.NVarChar,50),
                    new SqlParameter("@DrivingLicense", SqlDbType.NVarChar,50),
                    new SqlParameter("@DrivingLicensePic", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CarType", SqlDbType.Int,4),
                    new SqlParameter("@OrganizationCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@FX_PolicyNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyNoCompulsory", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyNoBusiness", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyType", SqlDbType.Int,4),
                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                    new SqlParameter("@PayTime", SqlDbType.DateTime),
                    new SqlParameter("@OfferTime", SqlDbType.DateTime),
                    new SqlParameter("@OfferNum", SqlDbType.Int,4),
                    new SqlParameter("@PolicyState", SqlDbType.Int,4),
                    new SqlParameter("@PayState", SqlDbType.Int,4),
                    new SqlParameter("@PayUrl", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PayValidateCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@PaydealCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@CompulsoryAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@BusinessAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@VehicleAndVesselTax", SqlDbType.Decimal,9),
                    new SqlParameter("@StartTime", SqlDbType.DateTime),
                    new SqlParameter("@EndTime", SqlDbType.DateTime),
                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                    new SqlParameter("@Discount", SqlDbType.Decimal,9),
                    new SqlParameter("@UserId", SqlDbType.Int,4),
                    new SqlParameter("@Remark", SqlDbType.NVarChar,100),
                    new SqlParameter("@CancelRemark", SqlDbType.NVarChar,100),
                    new SqlParameter("@RejectNum", SqlDbType.Int,4),
                    new SqlParameter("@RejectTime", SqlDbType.DateTime),
                    new SqlParameter("@CustomerName", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerMoblie", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerIdNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@CustomerIdPic", SqlDbType.NVarChar,-1),
                    new SqlParameter("@CarModel", SqlDbType.NVarChar,50),
                    new SqlParameter("@CarNo", SqlDbType.NVarChar,50),
                    new SqlParameter("@CarEngineNo", SqlDbType.NVarChar,100),
                    new SqlParameter("@CarRegisterDate", SqlDbType.Date,3),
                    new SqlParameter("@IsRead", SqlDbType.Bit,1),
                    new SqlParameter("@SafetyFactor", SqlDbType.Decimal,9),
                    new SqlParameter("@DangerousCount", SqlDbType.Int,4),
                    new SqlParameter("@InquiryDate", SqlDbType.DateTime),
                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                    new SqlParameter("@CZBTbCustomerID", SqlDbType.NVarChar,50),
                    new SqlParameter("@PolicyId", SqlDbType.Int,4)};
            parameters[0].Value = model.AgentId;
            parameters[1].Value = model.CustomerId;
            parameters[2].Value = model.VIN;
            parameters[3].Value = model.DrivingLicense;
            parameters[4].Value = model.DrivingLicensePic;
            parameters[5].Value = model.CarType;
            parameters[6].Value = model.OrganizationCode;
            parameters[7].Value = model.InsureCode;
            parameters[8].Value = model.FX_PolicyNo;
            parameters[9].Value = model.PolicyNoCompulsory;
            parameters[10].Value = model.PolicyNoBusiness;
            parameters[11].Value = model.PolicyType;
            parameters[12].Value = model.CreateTime;
            parameters[13].Value = model.PayTime;
            parameters[14].Value = model.OfferTime;
            parameters[15].Value = model.OfferNum;
            parameters[16].Value = model.PolicyState;
            parameters[17].Value = model.PayState;
            parameters[18].Value = model.PayUrl;
            parameters[19].Value = model.PayValidateCode;
            parameters[20].Value = model.PaydealCode;
            parameters[21].Value = model.PolicyAmount;
            parameters[22].Value = model.CompulsoryAmount;
            parameters[23].Value = model.BusinessAmount;
            parameters[24].Value = model.VehicleAndVesselTax;
            parameters[25].Value = model.StartTime;
            parameters[26].Value = model.EndTime;
            parameters[27].Value = model.CityCode;
            parameters[28].Value = model.Discount;
            parameters[29].Value = model.UserId;
            parameters[30].Value = model.Remark;
            parameters[31].Value = model.CancelRemark;
            parameters[32].Value = model.RejectNum;
            parameters[33].Value = model.RejectTime;
            parameters[34].Value = model.CustomerName;
            parameters[35].Value = model.CustomerMoblie;
            parameters[36].Value = model.CustomerIdNo;
            parameters[37].Value = model.CustomerIdPic;
            parameters[38].Value = model.CarModel;
            parameters[39].Value = model.CarNo;
            parameters[40].Value = model.CarEngineNo;
            parameters[41].Value = model.CarRegisterDate;
            parameters[42].Value = model.IsRead;
            parameters[43].Value = model.SafetyFactor;
            parameters[44].Value = model.DangerousCount;
            parameters[45].Value = model.InquiryDate;
            parameters[46].Value = model.ComeFrom;
            parameters[47].Value = model.CZBTbCustomerID;
            parameters[48].Value = model.PolicyId;

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
        public bool Delete(int PolicyId)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_Policy ");
            strSql.Append(" where PolicyId=@PolicyId");
            SqlParameter[] parameters = {
                    new SqlParameter("@PolicyId", SqlDbType.Int,4)
            };
            parameters[0].Value = PolicyId;

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
        public bool DeleteList(string PolicyIdlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from FX_Policy ");
            strSql.Append(" where PolicyId in (" + PolicyIdlist + ")  ");
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
            strSql.Append("select PolicyId,AgentId,CustomerId,VIN,DrivingLicense,DrivingLicensePic,CarType,OrganizationCode,InsureCode,FX_PolicyNo,PolicyNoCompulsory,PolicyNoBusiness,PolicyType,CreateTime,PayTime,OfferTime,OfferNum,PolicyState,PayState,PayUrl,PayValidateCode,PaydealCode,PolicyAmount,CompulsoryAmount,BusinessAmount,VehicleAndVesselTax,StartTime,EndTime,CityCode,Discount,UserId,Remark,CancelRemark,RejectNum,RejectTime,CustomerName,CustomerMoblie,CustomerIdNo,CustomerIdPic,CarModel,CarNo,CarEngineNo,CarRegisterDate,IsRead,SafetyFactor,DangerousCount,InquiryDate,ComeFrom,CZBTbCustomerID ");
            strSql.Append(" FROM FX_Policy ");
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
            strSql.Append(" PolicyId,AgentId,CustomerId,VIN,DrivingLicense,DrivingLicensePic,CarType,OrganizationCode,InsureCode,FX_PolicyNo,PolicyNoCompulsory,PolicyNoBusiness,PolicyType,CreateTime,PayTime,OfferTime,OfferNum,PolicyState,PayState,PayUrl,PayValidateCode,PaydealCode,PolicyAmount,CompulsoryAmount,BusinessAmount,VehicleAndVesselTax,StartTime,EndTime,CityCode,Discount,UserId,Remark,CancelRemark,RejectNum,RejectTime,CustomerName,CustomerMoblie,CustomerIdNo,CustomerIdPic,CarModel,CarNo,CarEngineNo,CarRegisterDate,IsRead,SafetyFactor,DangerousCount,InquiryDate,ComeFrom,CZBTbCustomerID ");
            strSql.Append(" FROM FX_Policy ");
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
            strSql.Append("select count(1) FROM FX_Policy ");
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
                strSql.Append("order by T.PolicyId desc");
            }
            strSql.Append(")AS Row, T.*  from FX_Policy T ");
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
        /// 获取当月保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        public DataSet GetPolicyMonth(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(PolicyAmount ) as num from [FX_Policy] ");
            strSql.Append(" where  policystate=3 and AgentId=@agentId and  Month(PayTime)=@month ");

            var sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@agentId",agentId),
                new SqlParameter("@month",DateTime.Now.Month)
            };
            return DbHelperSQL.Query(strSql.ToStringEx(), sqlParameters);
        }

        /// <summary>
        /// 获取总保额
        /// </summary>
        /// <param name="agentId">代理商</param>
        /// <returns></returns>
        public DataSet GetPolicyAll(int agentId)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select sum(PolicyAmount ) as num from [FX_Policy] ");
            strSql.Append(" where  policystate=3 and AgentId=@agentId  ");

            var sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@agentId",agentId)
            };
            return DbHelperSQL.Query(strSql.ToStringEx(), sqlParameters);
        }


        /// <summary>
        /// 获取销售所有保单
        /// </summary>
        /// <param name="agentId"></param>
        /// <returns></returns>
        public DataSet GetListByAgentId(int agentId)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from FX_Policy where 1=1 ");
            strSql.Append(" and AgentId=@agentId ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@agentId",agentId)
            };

            return DbHelperSQL.Query(strSql.ToStringEx(), sqlParameters);
        }


        /// <summary>
        /// 获取我的保单列表
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public DataSet GetPolicyListByState(int agentId, int state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select p.FX_PolicyNo FX_PolicyNo,  p.PolicyId policyId, p.CarNo carName,i.InsureName insureName,p.PolicyAmount policyAmount, ");
            strSql.Append(" p.CustomerName customerName,p.CustomerMoblie moblie,p.CreateTime createTime ,p.PolicyState policyState,p.EndTime endtime   ");
            strSql.Append(" ,p.CancelRemark from FX_Policy p inner join Fx_Agent a   ");
            strSql.Append(" on p.AgentId = a.AgentId  ");
            strSql.Append(" inner join FX_InsureCode i on p.InsureCode = i.InsureCode ");
            strSql.Append(" where 1=1 ");
            strSql.Append(" and a.agentId=@agentId ");
            if (state != 0)
            {
                strSql.Append(" and p.policyState= @state ");
            }
            SqlParameter[] parameters;

            if (state != 0)
            {
                parameters = new SqlParameter[]  {
                                            new SqlParameter("@agentId",SqlDbType.Int,4),
                                            new SqlParameter("@state",SqlDbType.Int,4)
                                        };
            }
            else
            {
                parameters = new SqlParameter[]  {
                                            new SqlParameter("@agentId",SqlDbType.Int,4)
                                        };
            }
            parameters[0].Value = agentId;
            if (state != 0)
            {
                parameters[1].Value = state;
            }
            if (state == 3)
            {
                strSql.Append(" and p.EndTime > getdate() ");
            }
            else if (state == 4)
            {
                parameters[1].Value = 3;
                strSql.Append(" and p.EndTime < getdate() ");
            }
            strSql.Append(" order by p.CreateTime desc ");
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 根据保单编号获取保单详细信息
        /// </summary>
        /// <param name="policyId">保单编号</param>
        /// <returns></returns>
        public DataSet GetListByPolicyId(int policyId)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select * from FX_Policy where 1=1 ");
            strSql.Append(" and policyId=@policyId ");

            var sqlParameters = new SqlParameter[] {
                new SqlParameter("@policyId",policyId)
            };
            return DbHelperSQL.Query(strSql.ToStringEx(), sqlParameters);
        }

        /// <summary>
        /// 添加保单
        /// </summary>
        /// <param name="model"></param>
        /// <param name="policyDetailList"></param>
        /// <returns></returns>
        public bool AddPolicyList(Model.FX_Policy model, List<Model.FX_PolicyDetail> policyDetailList)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        #region 新增保单===主表
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("insert into FX_Policy(");
                        strSql.Append("AgentId,CustomerId,VIN,DrivingLicense,DrivingLicensePic,CarType,OrganizationCode,InsureCode,FX_PolicyNo,PolicyNoCompulsory,PolicyNoBusiness,PolicyType,CreateTime,PayTime,OfferTime,OfferNum,PolicyState,PayState,PayUrl,PayValidateCode,PaydealCode,PolicyAmount,CompulsoryAmount,BusinessAmount,VehicleAndVesselTax,StartTime,EndTime,CityCode,Discount,UserId,Remark,CancelRemark,RejectNum,RejectTime,CustomerName,CustomerMoblie,CustomerIdNo,CustomerIdPic,CarModel,CarNo,CarEngineNo,CarRegisterDate,IsRead,SafetyFactor,DangerousCount,InquiryDate,ComeFrom,CZBTbCustomerID)");
                        strSql.Append(" values (");
                        strSql.Append("@AgentId,@CustomerId,@VIN,@DrivingLicense,@DrivingLicensePic,@CarType,@OrganizationCode,@InsureCode,@FX_PolicyNo,@PolicyNoCompulsory,@PolicyNoBusiness,@PolicyType,@CreateTime,@PayTime,@OfferTime,@OfferNum,@PolicyState,@PayState,@PayUrl,@PayValidateCode,@PaydealCode,@PolicyAmount,@CompulsoryAmount,@BusinessAmount,@VehicleAndVesselTax,@StartTime,@EndTime,@CityCode,@Discount,@UserId,@Remark,@CancelRemark,@RejectNum,@RejectTime,@CustomerName,@CustomerMoblie,@CustomerIdNo,@CustomerIdPic,@CarModel,@CarNo,@CarEngineNo,@CarRegisterDate,@IsRead,@SafetyFactor,@DangerousCount,@InquiryDate,@ComeFrom,@CZBTbCustomerID)");
                        strSql.Append(";select @@IDENTITY");
                        SqlParameter[] parameters =
                            {
                                    new SqlParameter("@AgentId", SqlDbType.Int,4),
                                    new SqlParameter("@CustomerId", SqlDbType.Int,4),
                                    new SqlParameter("@VIN", SqlDbType.NVarChar,50),
                                    new SqlParameter("@DrivingLicense", SqlDbType.NVarChar,50),
                                    new SqlParameter("@DrivingLicensePic", SqlDbType.NVarChar,-1),
                                    new SqlParameter("@CarType", SqlDbType.Int,4),
                                    new SqlParameter("@OrganizationCode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@InsureCode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@FX_PolicyNo", SqlDbType.NVarChar,50),
                                    new SqlParameter("@PolicyNoCompulsory", SqlDbType.NVarChar,50),
                                    new SqlParameter("@PolicyNoBusiness", SqlDbType.NVarChar,50),
                                    new SqlParameter("@PolicyType", SqlDbType.Int,4),
                                    new SqlParameter("@CreateTime", SqlDbType.DateTime),
                                    new SqlParameter("@PayTime", SqlDbType.DateTime),
                                    new SqlParameter("@OfferTime", SqlDbType.DateTime),
                                    new SqlParameter("@OfferNum", SqlDbType.Int,4),
                                    new SqlParameter("@PolicyState", SqlDbType.Int,4),
                                    new SqlParameter("@PayState", SqlDbType.Int,4),
                                    new SqlParameter("@PayUrl", SqlDbType.NVarChar,-1),
                                    new SqlParameter("@PayValidateCode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@PaydealCode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@PolicyAmount", SqlDbType.Decimal,9),
                                    new SqlParameter("@CompulsoryAmount", SqlDbType.Decimal,9),
                                    new SqlParameter("@BusinessAmount", SqlDbType.Decimal,9),
                                    new SqlParameter("@VehicleAndVesselTax", SqlDbType.Decimal,9),
                                    new SqlParameter("@StartTime", SqlDbType.DateTime),
                                    new SqlParameter("@EndTime", SqlDbType.DateTime),
                                    new SqlParameter("@CityCode", SqlDbType.NVarChar,50),
                                    new SqlParameter("@Discount", SqlDbType.Decimal,9),
                                    new SqlParameter("@UserId", SqlDbType.Int,4),
                                    new SqlParameter("@Remark", SqlDbType.NVarChar,100),
                                    new SqlParameter("@CancelRemark", SqlDbType.NVarChar,100),
                                    new SqlParameter("@RejectNum", SqlDbType.Int,4),
                                    new SqlParameter("@RejectTime", SqlDbType.DateTime),
                                    new SqlParameter("@CustomerName", SqlDbType.NVarChar,50),
                                    new SqlParameter("@CustomerMoblie", SqlDbType.NVarChar,50),
                                    new SqlParameter("@CustomerIdNo", SqlDbType.NVarChar,50),
                                    new SqlParameter("@CustomerIdPic", SqlDbType.NVarChar,-1),
                                    new SqlParameter("@CarModel", SqlDbType.NVarChar,50),
                                    new SqlParameter("@CarNo", SqlDbType.NVarChar,50),
                                    new SqlParameter("@CarEngineNo", SqlDbType.NVarChar,100),
                                    new SqlParameter("@CarRegisterDate", SqlDbType.DateTime),
                                    new SqlParameter("@IsRead", SqlDbType.Bit,1),
                                    new SqlParameter("@SafetyFactor", SqlDbType.Decimal,9),
                                    new SqlParameter("@DangerousCount", SqlDbType.Int,4),
                                    new SqlParameter("@InquiryDate", SqlDbType.DateTime),
                                    new SqlParameter("@ComeFrom", SqlDbType.Int,4),
                                    new SqlParameter("@CZBTbCustomerID", SqlDbType.NVarChar,50)
                            };
                        parameters[0].Value = model.AgentId;
                        parameters[1].Value = model.CustomerId;
                        parameters[2].Value = model.VIN;
                        parameters[3].Value = model.DrivingLicense;
                        parameters[4].Value = model.DrivingLicensePic;
                        parameters[5].Value = model.CarType;
                        parameters[6].Value = model.OrganizationCode;
                        parameters[7].Value = model.InsureCode;
                        parameters[8].Value = model.FX_PolicyNo;
                        parameters[9].Value = model.PolicyNoCompulsory;
                        parameters[10].Value = model.PolicyNoBusiness;
                        parameters[11].Value = model.PolicyType;
                        parameters[12].Value = model.CreateTime;
                        parameters[13].Value = model.PayTime;
                        parameters[14].Value = model.OfferTime;
                        parameters[15].Value = model.OfferNum;
                        parameters[16].Value = model.PolicyState;
                        parameters[17].Value = model.PayState;
                        parameters[18].Value = model.PayUrl;
                        parameters[19].Value = model.PayValidateCode;
                        parameters[20].Value = model.PaydealCode;
                        parameters[21].Value = model.PolicyAmount;
                        parameters[22].Value = model.CompulsoryAmount;
                        parameters[23].Value = model.BusinessAmount;
                        parameters[24].Value = model.VehicleAndVesselTax;
                        parameters[25].Value = model.StartTime;
                        parameters[26].Value = model.EndTime;
                        parameters[27].Value = model.CityCode;
                        parameters[28].Value = model.Discount;
                        parameters[29].Value = model.UserId;
                        parameters[30].Value = model.Remark;
                        parameters[31].Value = model.CancelRemark;
                        parameters[32].Value = model.RejectNum;
                        parameters[33].Value = model.RejectTime;
                        parameters[34].Value = model.CustomerName;
                        parameters[35].Value = model.CustomerMoblie;
                        parameters[36].Value = model.CustomerIdNo;
                        parameters[37].Value = model.CustomerIdPic;
                        parameters[38].Value = model.CarModel;
                        parameters[39].Value = model.CarNo;
                        parameters[40].Value = model.CarEngineNo;
                        parameters[41].Value = model.CarRegisterDate;
                        parameters[42].Value = model.IsRead;
                        parameters[43].Value = model.SafetyFactor;
                        parameters[44].Value = model.DangerousCount;
                        parameters[45].Value = model.InquiryDate;
                        parameters[46].Value = model.ComeFrom;
                        parameters[47].Value = model.CZBTbCustomerID;
                        object obj = DbHelperSQL.GetSingle(conn, trans, strSql.ToString(), parameters);
                        if (obj == null)
                        {
                            trans.Rollback();
                            return false;
                        }
                        else
                        {
                            model.PolicyId = Convert.ToInt32(obj);
                        }
                        #endregion

                        #region 具体险种列表
                        foreach (Model.FX_PolicyDetail p in policyDetailList)
                        {
                            StringBuilder _strSql = new StringBuilder();
                            _strSql.Append("insert into FX_PolicyDetail(");
                            _strSql.Append("PolicyId,InsuranceTypeId,InsuranceTypeDetail,TotalAmount,CreateTime,UpdateTime,IsUse)");
                            _strSql.Append(" values (");
                            _strSql.Append("@PolicyId,@InsuranceTypeId,@InsuranceTypeDetail,@TotalAmount,@CreateTime,@UpdateTime,@IsUse)");
                            _strSql.Append(";select @@IDENTITY");
                            SqlParameter[] _parameters = {
                                                        new SqlParameter("@PolicyId", SqlDbType.Int,4),
                                                        new SqlParameter("@InsuranceTypeId", SqlDbType.Int,4),
                                                        new SqlParameter("@InsuranceTypeDetail", SqlDbType.NVarChar,100),
                                                        new SqlParameter("@TotalAmount", SqlDbType.Decimal,9),
                                                        new SqlParameter("@CreateTime", SqlDbType.DateTime),
                                                        new SqlParameter("@UpdateTime", SqlDbType.DateTime),
                                                         new SqlParameter("@IsUse", SqlDbType.Int,4)};
                            _parameters[0].Value = model.PolicyId;
                            _parameters[1].Value = p.InsuranceTypeId;
                            _parameters[2].Value = p.InsuranceTypeDetail;
                            _parameters[3].Value = p.TotalAmount;
                            _parameters[4].Value = p.CreateTime;
                            _parameters[5].Value = p.UpdateTime;
                            _parameters[6].Value = p.IsUse;

                            DbHelperSQL.GetSingle(conn, trans, _strSql.ToString(), _parameters);
                        }
                        #endregion

                        #region ===分佣参数表
                        if (model.PolicyInsurePara != null)
                        {
                            Model.FX_PolicyInsurePara modelinsuerpara = model.PolicyInsurePara;
                            StringBuilder strSqlInsurePara = new StringBuilder();
                            strSqlInsurePara.Append("insert into FX_PolicyInsurePara(");
                            strSqlInsurePara.Append("PolicyID,InsureCode,BusinessTotal,BusinessCommission,BusinessCommissionLevel1,BusinessCommissionLevel2,BusinessTax,CompulsoryTotal,CompulsoryCommission,CompulsoryCommissionLelve1,CompulsoryCommissionLelve2,CompulsoryTax,CreateTime)");
                            strSqlInsurePara.Append(" values (");
                            strSqlInsurePara.Append("@PolicyID,@InsureCode,@BusinessTotal,@BusinessCommission,@BusinessCommissionLevel1,@BusinessCommissionLevel2,@BusinessTax,@CompulsoryTotal,@CompulsoryCommission,@CompulsoryCommissionLelve1,@CompulsoryCommissionLelve2,@CompulsoryTax,@CreateTime)");
                            strSqlInsurePara.Append(";select @@IDENTITY");
                            SqlParameter[] parametersInsurePara = {
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
                                        new SqlParameter("@CreateTime", SqlDbType.DateTime)
                            };
                            parametersInsurePara[0].Value = model.PolicyId;
                            parametersInsurePara[1].Value = model.InsureCode;
                            parametersInsurePara[2].Value = modelinsuerpara.BusinessTotal;
                            parametersInsurePara[3].Value = modelinsuerpara.BusinessCommission;
                            parametersInsurePara[4].Value = modelinsuerpara.BusinessCommissionLevel1;
                            parametersInsurePara[5].Value = modelinsuerpara.BusinessCommissionLevel2;
                            parametersInsurePara[6].Value = modelinsuerpara.BusinessTax;
                            parametersInsurePara[7].Value = modelinsuerpara.CompulsoryTotal;
                            parametersInsurePara[8].Value = modelinsuerpara.CompulsoryCommission;
                            parametersInsurePara[9].Value = modelinsuerpara.CompulsoryCommissionLelve1;
                            parametersInsurePara[10].Value = modelinsuerpara.CompulsoryCommissionLelve2;
                            parametersInsurePara[11].Value = modelinsuerpara.CompulsoryTax;
                            parametersInsurePara[12].Value = modelinsuerpara.CreateTime;
                            DbHelperSQL.GetSingle(conn, trans, strSqlInsurePara.ToString(), parametersInsurePara);
                        }
                        #endregion

                        trans.Commit();
                    }
                    catch (Exception err)
                    {
                        trans.Rollback();
                        Common.LogHelper.WriteLog(Common.Enums.LogEnum.Error, "err:" + err.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion  ExtensionMethod
    }
}
