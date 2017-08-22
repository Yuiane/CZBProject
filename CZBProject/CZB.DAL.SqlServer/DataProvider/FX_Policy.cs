/**  版本信息模板在安装目录下，可自行修改。
* FX_Policy.cs
*
* 功 能： N/A
* 类 名： FX_Policy
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/8/22 15:50:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CZB.IDAL;
using CZB.Common.Extensions;

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

        #endregion  ExtensionMethod
    }
}

