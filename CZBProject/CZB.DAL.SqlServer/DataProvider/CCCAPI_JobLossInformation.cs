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
	/// 数据访问类:CCCAPI_JobLossInformation
	/// </summary>
	public partial class CCCAPI_JobLossInformation : ICCCAPI_JobLossInformation
    {
        public CCCAPI_JobLossInformation()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CCCAPI_JobLossInformation");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255)           };
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(CZB.Model.CCCAPI_JobLossInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CCCAPI_JobLossInformation(");
            strSql.Append("Id,partyId,businessNo,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal)");
            strSql.Append(" values (");
            strSql.Append("@Id,@partyId,@businessNo,@senderTelNo,@senderName,@vehicleOwnerName,@vehicleOwnerTelNo,@repairOrderNo,@claimNo,@sourceType,@sendRepairFlag,@insuranceCompanyGroupCode,@insuranceCompanyGroupName,@insuranceCompanyCode,@insuranceCompanyName,@repairFactoryCode,@repairFactoryName,@repairFacilityType,@qualificationLevel,@estimatorCode,@estimatorName,@workFlowNodeCode,@workFlowNodeName,@assignDate,@estimateStartTime,@estimateEndTime,@reportNo,@reportDate,@lossVehicleTypeCode,@lossVehicleType,@plateNo,@vin,@brandModel,@engineNo,@vehicleCategoryCode,@vehicleCategory,@usingTypeCode,@usingType,@licenseFirstRegisterDate,@purchasePrice,@plateTypeCode,@plateType,@plateColorCode,@plateColor,@vehicleBodyColor,@currentValue,@fuelRemain,@mileage,@itemsInCar,@mainCollisionPoints,@subCollisionPoints,@country,@vehicleManufMakeName,@vehicleSubModelName,@claimAttachmentsIDs,@partType,@partTypeCode,@manageRate,@laborFeeManageRate,@electricianMachinistRate,@sheetMetalRate,@paintRate,@managementFee,@multiPaintDiscountRate,@ChangeItemIDs,@RepairItemsIDs,@MaterialItemsIDs,@feeTotal_partFee,@feeTotal_laborFee,@feeTotal_materialFee,@feeTotal_entireSalvage,@feeTotal_totalSalvage,@feeTotal_depreciation,@feeTotal_manageFee,@feeTotal_estimateAmount,@feeTotal_rescueFee,@feeTotal_lossTotal)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255),
                    new SqlParameter("@partyId", SqlDbType.VarChar,255),
                    new SqlParameter("@businessNo", SqlDbType.VarChar,255),
                    new SqlParameter("@senderTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@senderName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@repairOrderNo", SqlDbType.VarChar,50),
                    new SqlParameter("@claimNo", SqlDbType.VarChar,50),
                    new SqlParameter("@sourceType", SqlDbType.VarChar,50),
                    new SqlParameter("@sendRepairFlag", SqlDbType.VarChar,3),
                    new SqlParameter("@insuranceCompanyGroupCode", SqlDbType.VarChar,50),
                    new SqlParameter("@insuranceCompanyGroupName", SqlDbType.VarChar,100),
                    new SqlParameter("@insuranceCompanyCode", SqlDbType.VarChar,30),
                    new SqlParameter("@insuranceCompanyName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFactoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@repairFactoryName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFacilityType", SqlDbType.VarChar,30),
                    new SqlParameter("@qualificationLevel", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorName", SqlDbType.VarChar,60),
                    new SqlParameter("@workFlowNodeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@workFlowNodeName", SqlDbType.VarChar,30),
                    new SqlParameter("@assignDate", SqlDbType.DateTime),
                    new SqlParameter("@estimateStartTime", SqlDbType.DateTime),
                    new SqlParameter("@estimateEndTime", SqlDbType.DateTime),
                    new SqlParameter("@reportNo", SqlDbType.VarChar,30),
                    new SqlParameter("@reportDate", SqlDbType.DateTime),
                    new SqlParameter("@lossVehicleTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@lossVehicleType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vin", SqlDbType.VarChar,150),
                    new SqlParameter("@brandModel", SqlDbType.VarChar,150),
                    new SqlParameter("@engineNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategory", SqlDbType.VarChar,30),
                    new SqlParameter("@usingTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@usingType", SqlDbType.VarChar,30),
                    new SqlParameter("@licenseFirstRegisterDate", SqlDbType.DateTime),
                    new SqlParameter("@purchasePrice", SqlDbType.Decimal,9),
                    new SqlParameter("@plateTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColor", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleBodyColor", SqlDbType.VarChar,30),
                    new SqlParameter("@currentValue", SqlDbType.Decimal,9),
                    new SqlParameter("@fuelRemain", SqlDbType.Decimal,9),
                    new SqlParameter("@mileage", SqlDbType.Decimal,9),
                    new SqlParameter("@itemsInCar", SqlDbType.VarChar,255),
                    new SqlParameter("@mainCollisionPoints", SqlDbType.VarChar,3),
                    new SqlParameter("@subCollisionPoints", SqlDbType.VarChar,50),
                    new SqlParameter("@country", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleManufMakeName", SqlDbType.VarChar,255),
                    new SqlParameter("@vehicleSubModelName", SqlDbType.VarChar,255),
                    new SqlParameter("@claimAttachmentsIDs", SqlDbType.VarChar,50),
                    new SqlParameter("@partType", SqlDbType.VarChar,30),
                    new SqlParameter("@partTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@manageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@electricianMachinistRate", SqlDbType.Decimal,9),
                    new SqlParameter("@sheetMetalRate", SqlDbType.Decimal,9),
                    new SqlParameter("@paintRate", SqlDbType.Decimal,9),
                    new SqlParameter("@managementFee", SqlDbType.Decimal,9),
                    new SqlParameter("@multiPaintDiscountRate", SqlDbType.Decimal,9),
                    new SqlParameter("@ChangeItemIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@RepairItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@MaterialItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@feeTotal_partFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_laborFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_materialFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_entireSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_totalSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_depreciation", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_manageFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_estimateAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_rescueFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_lossTotal", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.partyId;
            parameters[2].Value = model.businessNo;
            parameters[3].Value = model.senderTelNo;
            parameters[4].Value = model.senderName;
            parameters[5].Value = model.vehicleOwnerName;
            parameters[6].Value = model.vehicleOwnerTelNo;
            parameters[7].Value = model.repairOrderNo;
            parameters[8].Value = model.claimNo;
            parameters[9].Value = model.sourceType;
            parameters[10].Value = model.sendRepairFlag;
            parameters[11].Value = model.insuranceCompanyGroupCode;
            parameters[12].Value = model.insuranceCompanyGroupName;
            parameters[13].Value = model.insuranceCompanyCode;
            parameters[14].Value = model.insuranceCompanyName;
            parameters[15].Value = model.repairFactoryCode;
            parameters[16].Value = model.repairFactoryName;
            parameters[17].Value = model.repairFacilityType;
            parameters[18].Value = model.qualificationLevel;
            parameters[19].Value = model.estimatorCode;
            parameters[20].Value = model.estimatorName;
            parameters[21].Value = model.workFlowNodeCode;
            parameters[22].Value = model.workFlowNodeName;
            parameters[23].Value = model.assignDate;
            parameters[24].Value = model.estimateStartTime;
            parameters[25].Value = model.estimateEndTime;
            parameters[26].Value = model.reportNo;
            parameters[27].Value = model.reportDate;
            parameters[28].Value = model.lossVehicleTypeCode;
            parameters[29].Value = model.lossVehicleType;
            parameters[30].Value = model.plateNo;
            parameters[31].Value = model.vin;
            parameters[32].Value = model.brandModel;
            parameters[33].Value = model.engineNo;
            parameters[34].Value = model.vehicleCategoryCode;
            parameters[35].Value = model.vehicleCategory;
            parameters[36].Value = model.usingTypeCode;
            parameters[37].Value = model.usingType;
            parameters[38].Value = model.licenseFirstRegisterDate;
            parameters[39].Value = model.purchasePrice;
            parameters[40].Value = model.plateTypeCode;
            parameters[41].Value = model.plateType;
            parameters[42].Value = model.plateColorCode;
            parameters[43].Value = model.plateColor;
            parameters[44].Value = model.vehicleBodyColor;
            parameters[45].Value = model.currentValue;
            parameters[46].Value = model.fuelRemain;
            parameters[47].Value = model.mileage;
            parameters[48].Value = model.itemsInCar;
            parameters[49].Value = model.mainCollisionPoints;
            parameters[50].Value = model.subCollisionPoints;
            parameters[51].Value = model.country;
            parameters[52].Value = model.vehicleManufMakeName;
            parameters[53].Value = model.vehicleSubModelName;
            parameters[54].Value = model.claimAttachmentsIDs;
            parameters[55].Value = model.partType;
            parameters[56].Value = model.partTypeCode;
            parameters[57].Value = model.manageRate;
            parameters[58].Value = model.laborFeeManageRate;
            parameters[59].Value = model.electricianMachinistRate;
            parameters[60].Value = model.sheetMetalRate;
            parameters[61].Value = model.paintRate;
            parameters[62].Value = model.managementFee;
            parameters[63].Value = model.multiPaintDiscountRate;
            parameters[64].Value = model.ChangeItemIDs;
            parameters[65].Value = model.RepairItemsIDs;
            parameters[66].Value = model.MaterialItemsIDs;
            parameters[67].Value = model.feeTotal_partFee;
            parameters[68].Value = model.feeTotal_laborFee;
            parameters[69].Value = model.feeTotal_materialFee;
            parameters[70].Value = model.feeTotal_entireSalvage;
            parameters[71].Value = model.feeTotal_totalSalvage;
            parameters[72].Value = model.feeTotal_depreciation;
            parameters[73].Value = model.feeTotal_manageFee;
            parameters[74].Value = model.feeTotal_estimateAmount;
            parameters[75].Value = model.feeTotal_rescueFee;
            parameters[76].Value = model.feeTotal_lossTotal;

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
        /// 根据工单号查询是否存在
        /// </summary>
        /// <param name="businessNo"></param>
        /// <returns></returns>
        public bool ExistsBusinessNo(string businessNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CCCAPI_JobLossInformation");
            strSql.Append(" where businessNo=@businessNo ");
            SqlParameter[] parameters = {
                    new SqlParameter("@businessNo", SqlDbType.NVarChar,255)           };
            parameters[0].Value = businessNo;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.CCCAPI_JobLossInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CCCAPI_JobLossInformation set ");
            strSql.Append("partyId=@partyId,");
            strSql.Append("businessNo=@businessNo,");
            strSql.Append("senderTelNo=@senderTelNo,");
            strSql.Append("senderName=@senderName,");
            strSql.Append("vehicleOwnerName=@vehicleOwnerName,");
            strSql.Append("vehicleOwnerTelNo=@vehicleOwnerTelNo,");
            strSql.Append("repairOrderNo=@repairOrderNo,");
            strSql.Append("claimNo=@claimNo,");
            strSql.Append("sourceType=@sourceType,");
            strSql.Append("sendRepairFlag=@sendRepairFlag,");
            strSql.Append("insuranceCompanyGroupCode=@insuranceCompanyGroupCode,");
            strSql.Append("insuranceCompanyGroupName=@insuranceCompanyGroupName,");
            strSql.Append("insuranceCompanyCode=@insuranceCompanyCode,");
            strSql.Append("insuranceCompanyName=@insuranceCompanyName,");
            strSql.Append("repairFactoryCode=@repairFactoryCode,");
            strSql.Append("repairFactoryName=@repairFactoryName,");
            strSql.Append("repairFacilityType=@repairFacilityType,");
            strSql.Append("qualificationLevel=@qualificationLevel,");
            strSql.Append("estimatorCode=@estimatorCode,");
            strSql.Append("estimatorName=@estimatorName,");
            strSql.Append("workFlowNodeCode=@workFlowNodeCode,");
            strSql.Append("workFlowNodeName=@workFlowNodeName,");
            strSql.Append("assignDate=@assignDate,");
            strSql.Append("estimateStartTime=@estimateStartTime,");
            strSql.Append("estimateEndTime=@estimateEndTime,");
            strSql.Append("reportNo=@reportNo,");
            strSql.Append("reportDate=@reportDate,");
            strSql.Append("lossVehicleTypeCode=@lossVehicleTypeCode,");
            strSql.Append("lossVehicleType=@lossVehicleType,");
            strSql.Append("plateNo=@plateNo,");
            strSql.Append("vin=@vin,");
            strSql.Append("brandModel=@brandModel,");
            strSql.Append("engineNo=@engineNo,");
            strSql.Append("vehicleCategoryCode=@vehicleCategoryCode,");
            strSql.Append("vehicleCategory=@vehicleCategory,");
            strSql.Append("usingTypeCode=@usingTypeCode,");
            strSql.Append("usingType=@usingType,");
            strSql.Append("licenseFirstRegisterDate=@licenseFirstRegisterDate,");
            strSql.Append("purchasePrice=@purchasePrice,");
            strSql.Append("plateTypeCode=@plateTypeCode,");
            strSql.Append("plateType=@plateType,");
            strSql.Append("plateColorCode=@plateColorCode,");
            strSql.Append("plateColor=@plateColor,");
            strSql.Append("vehicleBodyColor=@vehicleBodyColor,");
            strSql.Append("currentValue=@currentValue,");
            strSql.Append("fuelRemain=@fuelRemain,");
            strSql.Append("mileage=@mileage,");
            strSql.Append("itemsInCar=@itemsInCar,");
            strSql.Append("mainCollisionPoints=@mainCollisionPoints,");
            strSql.Append("subCollisionPoints=@subCollisionPoints,");
            strSql.Append("country=@country,");
            strSql.Append("vehicleManufMakeName=@vehicleManufMakeName,");
            strSql.Append("vehicleSubModelName=@vehicleSubModelName,");
            strSql.Append("claimAttachmentsIDs=@claimAttachmentsIDs,");
            strSql.Append("partType=@partType,");
            strSql.Append("partTypeCode=@partTypeCode,");
            strSql.Append("manageRate=@manageRate,");
            strSql.Append("laborFeeManageRate=@laborFeeManageRate,");
            strSql.Append("electricianMachinistRate=@electricianMachinistRate,");
            strSql.Append("sheetMetalRate=@sheetMetalRate,");
            strSql.Append("paintRate=@paintRate,");
            strSql.Append("managementFee=@managementFee,");
            strSql.Append("multiPaintDiscountRate=@multiPaintDiscountRate,");
            strSql.Append("ChangeItemIDs=@ChangeItemIDs,");
            strSql.Append("RepairItemsIDs=@RepairItemsIDs,");
            strSql.Append("MaterialItemsIDs=@MaterialItemsIDs,");
            strSql.Append("feeTotal_partFee=@feeTotal_partFee,");
            strSql.Append("feeTotal_laborFee=@feeTotal_laborFee,");
            strSql.Append("feeTotal_materialFee=@feeTotal_materialFee,");
            strSql.Append("feeTotal_entireSalvage=@feeTotal_entireSalvage,");
            strSql.Append("feeTotal_totalSalvage=@feeTotal_totalSalvage,");
            strSql.Append("feeTotal_depreciation=@feeTotal_depreciation,");
            strSql.Append("feeTotal_manageFee=@feeTotal_manageFee,");
            strSql.Append("feeTotal_estimateAmount=@feeTotal_estimateAmount,");
            strSql.Append("feeTotal_rescueFee=@feeTotal_rescueFee,");
            strSql.Append("feeTotal_lossTotal=@feeTotal_lossTotal");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@partyId", SqlDbType.VarChar,255),
                    new SqlParameter("@businessNo", SqlDbType.VarChar,255),
                    new SqlParameter("@senderTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@senderName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@repairOrderNo", SqlDbType.VarChar,50),
                    new SqlParameter("@claimNo", SqlDbType.VarChar,50),
                    new SqlParameter("@sourceType", SqlDbType.VarChar,50),
                    new SqlParameter("@sendRepairFlag", SqlDbType.VarChar,3),
                    new SqlParameter("@insuranceCompanyGroupCode", SqlDbType.VarChar,50),
                    new SqlParameter("@insuranceCompanyGroupName", SqlDbType.VarChar,100),
                    new SqlParameter("@insuranceCompanyCode", SqlDbType.VarChar,30),
                    new SqlParameter("@insuranceCompanyName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFactoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@repairFactoryName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFacilityType", SqlDbType.VarChar,30),
                    new SqlParameter("@qualificationLevel", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorName", SqlDbType.VarChar,60),
                    new SqlParameter("@workFlowNodeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@workFlowNodeName", SqlDbType.VarChar,30),
                    new SqlParameter("@assignDate", SqlDbType.DateTime),
                    new SqlParameter("@estimateStartTime", SqlDbType.DateTime),
                    new SqlParameter("@estimateEndTime", SqlDbType.DateTime),
                    new SqlParameter("@reportNo", SqlDbType.VarChar,30),
                    new SqlParameter("@reportDate", SqlDbType.DateTime),
                    new SqlParameter("@lossVehicleTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@lossVehicleType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vin", SqlDbType.VarChar,150),
                    new SqlParameter("@brandModel", SqlDbType.VarChar,150),
                    new SqlParameter("@engineNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategory", SqlDbType.VarChar,30),
                    new SqlParameter("@usingTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@usingType", SqlDbType.VarChar,30),
                    new SqlParameter("@licenseFirstRegisterDate", SqlDbType.DateTime),
                    new SqlParameter("@purchasePrice", SqlDbType.Decimal,9),
                    new SqlParameter("@plateTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColor", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleBodyColor", SqlDbType.VarChar,30),
                    new SqlParameter("@currentValue", SqlDbType.Decimal,9),
                    new SqlParameter("@fuelRemain", SqlDbType.Decimal,9),
                    new SqlParameter("@mileage", SqlDbType.Decimal,9),
                    new SqlParameter("@itemsInCar", SqlDbType.VarChar,255),
                    new SqlParameter("@mainCollisionPoints", SqlDbType.VarChar,3),
                    new SqlParameter("@subCollisionPoints", SqlDbType.VarChar,50),
                    new SqlParameter("@country", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleManufMakeName", SqlDbType.VarChar,255),
                    new SqlParameter("@vehicleSubModelName", SqlDbType.VarChar,255),
                    new SqlParameter("@claimAttachmentsIDs", SqlDbType.VarChar,50),
                    new SqlParameter("@partType", SqlDbType.VarChar,30),
                    new SqlParameter("@partTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@manageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@electricianMachinistRate", SqlDbType.Decimal,9),
                    new SqlParameter("@sheetMetalRate", SqlDbType.Decimal,9),
                    new SqlParameter("@paintRate", SqlDbType.Decimal,9),
                    new SqlParameter("@managementFee", SqlDbType.Decimal,9),
                    new SqlParameter("@multiPaintDiscountRate", SqlDbType.Decimal,9),
                    new SqlParameter("@ChangeItemIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@RepairItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@MaterialItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@feeTotal_partFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_laborFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_materialFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_entireSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_totalSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_depreciation", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_manageFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_estimateAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_rescueFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_lossTotal", SqlDbType.Decimal,9),
                    new SqlParameter("@Id", SqlDbType.NVarChar,255)};
            parameters[0].Value = model.partyId;
            parameters[1].Value = model.businessNo;
            parameters[2].Value = model.senderTelNo;
            parameters[3].Value = model.senderName;
            parameters[4].Value = model.vehicleOwnerName;
            parameters[5].Value = model.vehicleOwnerTelNo;
            parameters[6].Value = model.repairOrderNo;
            parameters[7].Value = model.claimNo;
            parameters[8].Value = model.sourceType;
            parameters[9].Value = model.sendRepairFlag;
            parameters[10].Value = model.insuranceCompanyGroupCode;
            parameters[11].Value = model.insuranceCompanyGroupName;
            parameters[12].Value = model.insuranceCompanyCode;
            parameters[13].Value = model.insuranceCompanyName;
            parameters[14].Value = model.repairFactoryCode;
            parameters[15].Value = model.repairFactoryName;
            parameters[16].Value = model.repairFacilityType;
            parameters[17].Value = model.qualificationLevel;
            parameters[18].Value = model.estimatorCode;
            parameters[19].Value = model.estimatorName;
            parameters[20].Value = model.workFlowNodeCode;
            parameters[21].Value = model.workFlowNodeName;
            parameters[22].Value = model.assignDate;
            parameters[23].Value = model.estimateStartTime;
            parameters[24].Value = model.estimateEndTime;
            parameters[25].Value = model.reportNo;
            parameters[26].Value = model.reportDate;
            parameters[27].Value = model.lossVehicleTypeCode;
            parameters[28].Value = model.lossVehicleType;
            parameters[29].Value = model.plateNo;
            parameters[30].Value = model.vin;
            parameters[31].Value = model.brandModel;
            parameters[32].Value = model.engineNo;
            parameters[33].Value = model.vehicleCategoryCode;
            parameters[34].Value = model.vehicleCategory;
            parameters[35].Value = model.usingTypeCode;
            parameters[36].Value = model.usingType;
            parameters[37].Value = model.licenseFirstRegisterDate;
            parameters[38].Value = model.purchasePrice;
            parameters[39].Value = model.plateTypeCode;
            parameters[40].Value = model.plateType;
            parameters[41].Value = model.plateColorCode;
            parameters[42].Value = model.plateColor;
            parameters[43].Value = model.vehicleBodyColor;
            parameters[44].Value = model.currentValue;
            parameters[45].Value = model.fuelRemain;
            parameters[46].Value = model.mileage;
            parameters[47].Value = model.itemsInCar;
            parameters[48].Value = model.mainCollisionPoints;
            parameters[49].Value = model.subCollisionPoints;
            parameters[50].Value = model.country;
            parameters[51].Value = model.vehicleManufMakeName;
            parameters[52].Value = model.vehicleSubModelName;
            parameters[53].Value = model.claimAttachmentsIDs;
            parameters[54].Value = model.partType;
            parameters[55].Value = model.partTypeCode;
            parameters[56].Value = model.manageRate;
            parameters[57].Value = model.laborFeeManageRate;
            parameters[58].Value = model.electricianMachinistRate;
            parameters[59].Value = model.sheetMetalRate;
            parameters[60].Value = model.paintRate;
            parameters[61].Value = model.managementFee;
            parameters[62].Value = model.multiPaintDiscountRate;
            parameters[63].Value = model.ChangeItemIDs;
            parameters[64].Value = model.RepairItemsIDs;
            parameters[65].Value = model.MaterialItemsIDs;
            parameters[66].Value = model.feeTotal_partFee;
            parameters[67].Value = model.feeTotal_laborFee;
            parameters[68].Value = model.feeTotal_materialFee;
            parameters[69].Value = model.feeTotal_entireSalvage;
            parameters[70].Value = model.feeTotal_totalSalvage;
            parameters[71].Value = model.feeTotal_depreciation;
            parameters[72].Value = model.feeTotal_manageFee;
            parameters[73].Value = model.feeTotal_estimateAmount;
            parameters[74].Value = model.feeTotal_rescueFee;
            parameters[75].Value = model.feeTotal_lossTotal;
            parameters[76].Value = model.Id;

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
        public bool Delete(string Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CCCAPI_JobLossInformation ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255)           };
            parameters[0].Value = Id;

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
        public bool DeleteList(string Idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CCCAPI_JobLossInformation ");
            strSql.Append(" where Id in (" + Idlist + ")  ");
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
        public CZB.Model.CCCAPI_JobLossInformation GetModel(string Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,partyId,businessNo,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal from CCCAPI_JobLossInformation ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255)           };
            parameters[0].Value = Id;

            CZB.Model.CCCAPI_JobLossInformation model = new CZB.Model.CCCAPI_JobLossInformation();
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
        public CZB.Model.CCCAPI_JobLossInformation DataRowToModel(DataRow row)
        {
            CZB.Model.CCCAPI_JobLossInformation model = new CZB.Model.CCCAPI_JobLossInformation();
            if (row != null)
            {
                if (row["Id"] != null)
                {
                    model.Id = row["Id"].ToString();
                }
                if (row["partyId"] != null)
                {
                    model.partyId = row["partyId"].ToString();
                }
                if (row["businessNo"] != null)
                {
                    model.businessNo = row["businessNo"].ToString();
                }
                if (row["senderTelNo"] != null)
                {
                    model.senderTelNo = row["senderTelNo"].ToString();
                }
                if (row["senderName"] != null)
                {
                    model.senderName = row["senderName"].ToString();
                }
                if (row["vehicleOwnerName"] != null)
                {
                    model.vehicleOwnerName = row["vehicleOwnerName"].ToString();
                }
                if (row["vehicleOwnerTelNo"] != null)
                {
                    model.vehicleOwnerTelNo = row["vehicleOwnerTelNo"].ToString();
                }
                if (row["repairOrderNo"] != null)
                {
                    model.repairOrderNo = row["repairOrderNo"].ToString();
                }
                if (row["claimNo"] != null)
                {
                    model.claimNo = row["claimNo"].ToString();
                }
                if (row["sourceType"] != null)
                {
                    model.sourceType = row["sourceType"].ToString();
                }
                if (row["sendRepairFlag"] != null)
                {
                    model.sendRepairFlag = row["sendRepairFlag"].ToString();
                }
                if (row["insuranceCompanyGroupCode"] != null)
                {
                    model.insuranceCompanyGroupCode = row["insuranceCompanyGroupCode"].ToString();
                }
                if (row["insuranceCompanyGroupName"] != null)
                {
                    model.insuranceCompanyGroupName = row["insuranceCompanyGroupName"].ToString();
                }
                if (row["insuranceCompanyCode"] != null)
                {
                    model.insuranceCompanyCode = row["insuranceCompanyCode"].ToString();
                }
                if (row["insuranceCompanyName"] != null)
                {
                    model.insuranceCompanyName = row["insuranceCompanyName"].ToString();
                }
                if (row["repairFactoryCode"] != null)
                {
                    model.repairFactoryCode = row["repairFactoryCode"].ToString();
                }
                if (row["repairFactoryName"] != null)
                {
                    model.repairFactoryName = row["repairFactoryName"].ToString();
                }
                if (row["repairFacilityType"] != null)
                {
                    model.repairFacilityType = row["repairFacilityType"].ToString();
                }
                if (row["qualificationLevel"] != null)
                {
                    model.qualificationLevel = row["qualificationLevel"].ToString();
                }
                if (row["estimatorCode"] != null)
                {
                    model.estimatorCode = row["estimatorCode"].ToString();
                }
                if (row["estimatorName"] != null)
                {
                    model.estimatorName = row["estimatorName"].ToString();
                }
                if (row["workFlowNodeCode"] != null)
                {
                    model.workFlowNodeCode = row["workFlowNodeCode"].ToString();
                }
                if (row["workFlowNodeName"] != null)
                {
                    model.workFlowNodeName = row["workFlowNodeName"].ToString();
                }
                if (row["assignDate"] != null && row["assignDate"].ToString() != "")
                {
                    model.assignDate = DateTime.Parse(row["assignDate"].ToString());
                }
                if (row["estimateStartTime"] != null && row["estimateStartTime"].ToString() != "")
                {
                    model.estimateStartTime = DateTime.Parse(row["estimateStartTime"].ToString());
                }
                if (row["estimateEndTime"] != null && row["estimateEndTime"].ToString() != "")
                {
                    model.estimateEndTime = DateTime.Parse(row["estimateEndTime"].ToString());
                }
                if (row["reportNo"] != null)
                {
                    model.reportNo = row["reportNo"].ToString();
                }
                if (row["reportDate"] != null && row["reportDate"].ToString() != "")
                {
                    model.reportDate = DateTime.Parse(row["reportDate"].ToString());
                }
                if (row["lossVehicleTypeCode"] != null)
                {
                    model.lossVehicleTypeCode = row["lossVehicleTypeCode"].ToString();
                }
                if (row["lossVehicleType"] != null)
                {
                    model.lossVehicleType = row["lossVehicleType"].ToString();
                }
                if (row["plateNo"] != null)
                {
                    model.plateNo = row["plateNo"].ToString();
                }
                if (row["vin"] != null)
                {
                    model.vin = row["vin"].ToString();
                }
                if (row["brandModel"] != null)
                {
                    model.brandModel = row["brandModel"].ToString();
                }
                if (row["engineNo"] != null)
                {
                    model.engineNo = row["engineNo"].ToString();
                }
                if (row["vehicleCategoryCode"] != null)
                {
                    model.vehicleCategoryCode = row["vehicleCategoryCode"].ToString();
                }
                if (row["vehicleCategory"] != null)
                {
                    model.vehicleCategory = row["vehicleCategory"].ToString();
                }
                if (row["usingTypeCode"] != null)
                {
                    model.usingTypeCode = row["usingTypeCode"].ToString();
                }
                if (row["usingType"] != null)
                {
                    model.usingType = row["usingType"].ToString();
                }
                if (row["licenseFirstRegisterDate"] != null && row["licenseFirstRegisterDate"].ToString() != "")
                {
                    model.licenseFirstRegisterDate = DateTime.Parse(row["licenseFirstRegisterDate"].ToString());
                }
                if (row["purchasePrice"] != null && row["purchasePrice"].ToString() != "")
                {
                    model.purchasePrice = decimal.Parse(row["purchasePrice"].ToString());
                }
                if (row["plateTypeCode"] != null)
                {
                    model.plateTypeCode = row["plateTypeCode"].ToString();
                }
                if (row["plateType"] != null)
                {
                    model.plateType = row["plateType"].ToString();
                }
                if (row["plateColorCode"] != null)
                {
                    model.plateColorCode = row["plateColorCode"].ToString();
                }
                if (row["plateColor"] != null)
                {
                    model.plateColor = row["plateColor"].ToString();
                }
                if (row["vehicleBodyColor"] != null)
                {
                    model.vehicleBodyColor = row["vehicleBodyColor"].ToString();
                }
                if (row["currentValue"] != null && row["currentValue"].ToString() != "")
                {
                    model.currentValue = decimal.Parse(row["currentValue"].ToString());
                }
                if (row["fuelRemain"] != null && row["fuelRemain"].ToString() != "")
                {
                    model.fuelRemain = decimal.Parse(row["fuelRemain"].ToString());
                }
                if (row["mileage"] != null && row["mileage"].ToString() != "")
                {
                    model.mileage = decimal.Parse(row["mileage"].ToString());
                }
                if (row["itemsInCar"] != null)
                {
                    model.itemsInCar = row["itemsInCar"].ToString();
                }
                if (row["mainCollisionPoints"] != null)
                {
                    model.mainCollisionPoints = row["mainCollisionPoints"].ToString();
                }
                if (row["subCollisionPoints"] != null)
                {
                    model.subCollisionPoints = row["subCollisionPoints"].ToString();
                }
                if (row["country"] != null)
                {
                    model.country = row["country"].ToString();
                }
                if (row["vehicleManufMakeName"] != null)
                {
                    model.vehicleManufMakeName = row["vehicleManufMakeName"].ToString();
                }
                if (row["vehicleSubModelName"] != null)
                {
                    model.vehicleSubModelName = row["vehicleSubModelName"].ToString();
                }
                if (row["claimAttachmentsIDs"] != null)
                {
                    model.claimAttachmentsIDs = row["claimAttachmentsIDs"].ToString();
                }
                if (row["partType"] != null)
                {
                    model.partType = row["partType"].ToString();
                }
                if (row["partTypeCode"] != null)
                {
                    model.partTypeCode = row["partTypeCode"].ToString();
                }
                if (row["manageRate"] != null && row["manageRate"].ToString() != "")
                {
                    model.manageRate = decimal.Parse(row["manageRate"].ToString());
                }
                if (row["laborFeeManageRate"] != null && row["laborFeeManageRate"].ToString() != "")
                {
                    model.laborFeeManageRate = decimal.Parse(row["laborFeeManageRate"].ToString());
                }
                if (row["electricianMachinistRate"] != null && row["electricianMachinistRate"].ToString() != "")
                {
                    model.electricianMachinistRate = decimal.Parse(row["electricianMachinistRate"].ToString());
                }
                if (row["sheetMetalRate"] != null && row["sheetMetalRate"].ToString() != "")
                {
                    model.sheetMetalRate = decimal.Parse(row["sheetMetalRate"].ToString());
                }
                if (row["paintRate"] != null && row["paintRate"].ToString() != "")
                {
                    model.paintRate = decimal.Parse(row["paintRate"].ToString());
                }
                if (row["managementFee"] != null && row["managementFee"].ToString() != "")
                {
                    model.managementFee = decimal.Parse(row["managementFee"].ToString());
                }
                if (row["multiPaintDiscountRate"] != null && row["multiPaintDiscountRate"].ToString() != "")
                {
                    model.multiPaintDiscountRate = decimal.Parse(row["multiPaintDiscountRate"].ToString());
                }
                if (row["ChangeItemIDs"] != null)
                {
                    model.ChangeItemIDs = row["ChangeItemIDs"].ToString();
                }
                if (row["RepairItemsIDs"] != null)
                {
                    model.RepairItemsIDs = row["RepairItemsIDs"].ToString();
                }
                if (row["MaterialItemsIDs"] != null)
                {
                    model.MaterialItemsIDs = row["MaterialItemsIDs"].ToString();
                }
                if (row["feeTotal_partFee"] != null && row["feeTotal_partFee"].ToString() != "")
                {
                    model.feeTotal_partFee = decimal.Parse(row["feeTotal_partFee"].ToString());
                }
                if (row["feeTotal_laborFee"] != null && row["feeTotal_laborFee"].ToString() != "")
                {
                    model.feeTotal_laborFee = decimal.Parse(row["feeTotal_laborFee"].ToString());
                }
                if (row["feeTotal_materialFee"] != null && row["feeTotal_materialFee"].ToString() != "")
                {
                    model.feeTotal_materialFee = decimal.Parse(row["feeTotal_materialFee"].ToString());
                }
                if (row["feeTotal_entireSalvage"] != null && row["feeTotal_entireSalvage"].ToString() != "")
                {
                    model.feeTotal_entireSalvage = decimal.Parse(row["feeTotal_entireSalvage"].ToString());
                }
                if (row["feeTotal_totalSalvage"] != null && row["feeTotal_totalSalvage"].ToString() != "")
                {
                    model.feeTotal_totalSalvage = decimal.Parse(row["feeTotal_totalSalvage"].ToString());
                }
                if (row["feeTotal_depreciation"] != null && row["feeTotal_depreciation"].ToString() != "")
                {
                    model.feeTotal_depreciation = decimal.Parse(row["feeTotal_depreciation"].ToString());
                }
                if (row["feeTotal_manageFee"] != null && row["feeTotal_manageFee"].ToString() != "")
                {
                    model.feeTotal_manageFee = decimal.Parse(row["feeTotal_manageFee"].ToString());
                }
                if (row["feeTotal_estimateAmount"] != null && row["feeTotal_estimateAmount"].ToString() != "")
                {
                    model.feeTotal_estimateAmount = decimal.Parse(row["feeTotal_estimateAmount"].ToString());
                }
                if (row["feeTotal_rescueFee"] != null && row["feeTotal_rescueFee"].ToString() != "")
                {
                    model.feeTotal_rescueFee = decimal.Parse(row["feeTotal_rescueFee"].ToString());
                }
                if (row["feeTotal_lossTotal"] != null && row["feeTotal_lossTotal"].ToString() != "")
                {
                    model.feeTotal_lossTotal = decimal.Parse(row["feeTotal_lossTotal"].ToString());
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
            strSql.Append("select Id,partyId,businessNo,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
            strSql.Append(" FROM CCCAPI_JobLossInformation ");
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
            strSql.Append(" Id,partyId,businessNo,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
            strSql.Append(" FROM CCCAPI_JobLossInformation ");
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
            strSql.Append("select count(1) FROM CCCAPI_JobLossInformation ");
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
                strSql.Append("order by T.Id desc");
            }
            strSql.Append(")AS Row, T.*  from CCCAPI_JobLossInformation T ");
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
			parameters[0].Value = "CCCAPI_JobLossInformation";
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

        /// <summary>
        /// 录入新增
        /// </summary>
        /// <param name="model">工单基本信息</param>
        /// <param name="claimAttachmentsList">附件信息(复数)</param>
        /// <param name="changeItems">换件项目(复数)</param>
        /// <param name="materialItems">维修项目(复数)</param>
        /// <param name="repairItems">辅料项目(复数)</param>
        /// <returns></returns>
        public bool AddJobLoss(Model.CCCAPI_JobLossInformation info_Model,
            List<Model.CCCAPI_ClaimAttachments> claimAttachmentsList,
            List<Model.CCCAPI_ChangeItems> changeItems,
            List<Model.CCCAPI_MaterialItems> materialItems,
            List<Model.CCCAPI_RepairItems> repairItems)
        {
            using (SqlConnection conn = new SqlConnection(DbHelperSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        if (claimAttachmentsList != null && claimAttachmentsList.Count > 0)
                        {
                            foreach (Model.CCCAPI_ClaimAttachments model in claimAttachmentsList)
                            {
                                StringBuilder strSqlClaimAttachments = new StringBuilder();
                                strSqlClaimAttachments.Append("insert into CCCAPI_ClaimAttachments(");
                                strSqlClaimAttachments.Append("Id,AttachmentCategoryName,AttachmentUrl,AttachmentId,AttachmentName)");
                                strSqlClaimAttachments.Append(" values (");
                                strSqlClaimAttachments.Append("@Id,@AttachmentCategoryName,@AttachmentUrl,@AttachmentId,@AttachmentName)");
                                SqlParameter[] parametersClaimAttachments = new SqlParameter[]{
                                                                new SqlParameter("@Id", model.Id),
                                                                new SqlParameter("@AttachmentCategoryName", model.AttachmentCategoryName),
                                                                new SqlParameter("@AttachmentUrl", model.AttachmentUrl),
                                                                new SqlParameter("@AttachmentId",  model.AttachmentId),
                                                                new SqlParameter("@AttachmentName",  model.AttachmentName)
                                                            };

                                DbHelperSQL.ExecuteSql(conn, trans, strSqlClaimAttachments.ToString(), parametersClaimAttachments);
                            }
                        }
                        if (changeItems != null && changeItems.Count > 0)
                        {
                            foreach (Model.CCCAPI_ChangeItems model in changeItems)
                            {
                                StringBuilder strSqlChangeItems = new StringBuilder();
                                strSqlChangeItems.Append("insert into CCCAPI_ChangeItems(");
                                strSqlChangeItems.Append("Id,ItemId,itemName,ManualFlag,partNo,partQuantity,unitPriceAfterDiscount,partFeeAfterDiscount,depreciation,salvage,recycleFlag)");
                                strSqlChangeItems.Append(" values (");
                                strSqlChangeItems.Append("@Id,@ItemId,@itemName,@ManualFlag,@partNo,@partQuantity,@unitPriceAfterDiscount,@partFeeAfterDiscount,@depreciation,@salvage,@recycleFlag)");
                                SqlParameter[] parametersChangeItems = {
                                    new SqlParameter("@Id", model.Id),
                                    new SqlParameter("@ItemId", model.ItemId),
                                    new SqlParameter("@itemName", model.itemName),
                                    new SqlParameter("@ManualFlag", model.ManualFlag),
                                    new SqlParameter("@partNo", model.partNo),
                                    new SqlParameter("@partQuantity", model.partQuantity),
                                    new SqlParameter("@unitPriceAfterDiscount", model.unitPriceAfterDiscount),
                                    new SqlParameter("@partFeeAfterDiscount", model.partFeeAfterDiscount),
                                    new SqlParameter("@depreciation", model.depreciation),
                                    new SqlParameter("@salvage", model.salvage),
                                    new SqlParameter("@recycleFlag", model.recycleFlag)
                                };
                                DbHelperSQL.ExecuteSql(conn, trans, strSqlChangeItems.ToString(), parametersChangeItems);
                            }
                        }
                        if (materialItems != null && materialItems.Count > 0)
                        {
                            foreach (Model.CCCAPI_MaterialItems model in materialItems)
                            {
                                StringBuilder strSqlMaterialItems = new StringBuilder();
                                strSqlMaterialItems.Append("insert into CCCAPI_MaterialItems(");
                                strSqlMaterialItems.Append("id,itemid,itemName,manualFlag,materialUnit,partQuantity,unitPrice,partFee)");
                                strSqlMaterialItems.Append(" values (");
                                strSqlMaterialItems.Append("@id,@itemid,@itemName,@manualFlag,@materialUnit,@partQuantity,@unitPrice,@partFee)");
                                SqlParameter[] parametersMaterialItems = {
                                    new SqlParameter("@id", model.id),
                                    new SqlParameter("@itemid", model.itemid),
                                    new SqlParameter("@itemName", model.itemName),
                                    new SqlParameter("@manualFlag", model.manualFlag),
                                    new SqlParameter("@materialUnit", model.materialUnit),
                                    new SqlParameter("@partQuantity", model.partQuantity),
                                    new SqlParameter("@unitPrice", model.unitPrice),
                                    new SqlParameter("@partFee", model.partFee)
                                };
                                DbHelperSQL.ExecuteSql(conn, trans, strSqlMaterialItems.ToString(), parametersMaterialItems);
                            }
                        }
                        if (repairItems != null && repairItems.Count > 0)
                        {
                            foreach (Model.CCCAPI_RepairItems model in repairItems)
                            {
                                var strSqlRepairItems = new StringBuilder();
                                strSqlRepairItems.Append("insert into CCCAPI_RepairItems(");
                                strSqlRepairItems.Append("id,itemId,itemName,manualFlag,operationType,partNo,laborType,laborHourFee,laborFeeManageRate,paintDiscountFlag,laborHour,laborFeeAfterDiscount,outerRepairFlag,outerLaborFee)");
                                strSqlRepairItems.Append(" values (");
                                strSqlRepairItems.Append("@id,@itemId,@itemName,@manualFlag,@operationType,@partNo,@laborType,@laborHourFee,@laborFeeManageRate,@paintDiscountFlag,@laborHour,@laborFeeAfterDiscount,@outerRepairFlag,@outerLaborFee)");
                                SqlParameter[] parametersstrSqlRepairItems = {
                                    new SqlParameter("@id", model.id),
                                    new SqlParameter("@itemId", model.itemId),
                                    new SqlParameter("@itemName", model.itemName),
                                    new SqlParameter("@manualFlag", model.manualFlag),
                                    new SqlParameter("@operationType", model.operationType),
                                    new SqlParameter("@partNo", model.partNo),
                                    new SqlParameter("@laborType",model.laborHourFee),
                                    new SqlParameter("@laborHourFee", model.laborHourFee),
                                    new SqlParameter("@laborFeeManageRate", model.laborFeeManageRate),
                                    new SqlParameter("@paintDiscountFlag", model.paintDiscountFlag),
                                    new SqlParameter("@laborHour", model.laborHour),
                                    new SqlParameter("@laborFeeAfterDiscount", model.laborFeeAfterDiscount),
                                    new SqlParameter("@outerRepairFlag", model.outerRepairFlag),
                                    new SqlParameter("@outerLaborFee", model.outerLaborFee)
                                };
                                DbHelperSQL.ExecuteSql(conn, trans, strSqlRepairItems.ToString(), parametersstrSqlRepairItems);
                            }
                        }

                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("insert into CCCAPI_JobLossInformation(");
                        strSql.Append("Id,partyId,businessNo,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal)");
                        strSql.Append(" values (");
                        strSql.Append("@Id,@partyId,@businessNo,@senderTelNo,@senderName,@vehicleOwnerName,@vehicleOwnerTelNo,@repairOrderNo,@claimNo,@sourceType,@sendRepairFlag,@insuranceCompanyGroupCode,@insuranceCompanyGroupName,@insuranceCompanyCode,@insuranceCompanyName,@repairFactoryCode,@repairFactoryName,@repairFacilityType,@qualificationLevel,@estimatorCode,@estimatorName,@workFlowNodeCode,@workFlowNodeName,@assignDate,@estimateStartTime,@estimateEndTime,@reportNo,@reportDate,@lossVehicleTypeCode,@lossVehicleType,@plateNo,@vin,@brandModel,@engineNo,@vehicleCategoryCode,@vehicleCategory,@usingTypeCode,@usingType,@licenseFirstRegisterDate,@purchasePrice,@plateTypeCode,@plateType,@plateColorCode,@plateColor,@vehicleBodyColor,@currentValue,@fuelRemain,@mileage,@itemsInCar,@mainCollisionPoints,@subCollisionPoints,@country,@vehicleManufMakeName,@vehicleSubModelName,@claimAttachmentsIDs,@partType,@partTypeCode,@manageRate,@laborFeeManageRate,@electricianMachinistRate,@sheetMetalRate,@paintRate,@managementFee,@multiPaintDiscountRate,@ChangeItemIDs,@RepairItemsIDs,@MaterialItemsIDs,@feeTotal_partFee,@feeTotal_laborFee,@feeTotal_materialFee,@feeTotal_entireSalvage,@feeTotal_totalSalvage,@feeTotal_depreciation,@feeTotal_manageFee,@feeTotal_estimateAmount,@feeTotal_rescueFee,@feeTotal_lossTotal)");
                        SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255),
                    new SqlParameter("@partyId", SqlDbType.VarChar,255),
                    new SqlParameter("@businessNo", SqlDbType.VarChar,255),
                    new SqlParameter("@senderTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@senderName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerName", SqlDbType.VarChar,50),
                    new SqlParameter("@vehicleOwnerTelNo", SqlDbType.VarChar,50),
                    new SqlParameter("@repairOrderNo", SqlDbType.VarChar,50),
                    new SqlParameter("@claimNo", SqlDbType.VarChar,50),
                    new SqlParameter("@sourceType", SqlDbType.VarChar,50),
                    new SqlParameter("@sendRepairFlag", SqlDbType.VarChar,3),
                    new SqlParameter("@insuranceCompanyGroupCode", SqlDbType.VarChar,50),
                    new SqlParameter("@insuranceCompanyGroupName", SqlDbType.VarChar,100),
                    new SqlParameter("@insuranceCompanyCode", SqlDbType.VarChar,30),
                    new SqlParameter("@insuranceCompanyName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFactoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@repairFactoryName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairFacilityType", SqlDbType.VarChar,30),
                    new SqlParameter("@qualificationLevel", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@estimatorName", SqlDbType.VarChar,60),
                    new SqlParameter("@workFlowNodeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@workFlowNodeName", SqlDbType.VarChar,30),
                    new SqlParameter("@assignDate", SqlDbType.DateTime),
                    new SqlParameter("@estimateStartTime", SqlDbType.DateTime),
                    new SqlParameter("@estimateEndTime", SqlDbType.DateTime),
                    new SqlParameter("@reportNo", SqlDbType.VarChar,30),
                    new SqlParameter("@reportDate", SqlDbType.DateTime),
                    new SqlParameter("@lossVehicleTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@lossVehicleType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vin", SqlDbType.VarChar,150),
                    new SqlParameter("@brandModel", SqlDbType.VarChar,150),
                    new SqlParameter("@engineNo", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategoryCode", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleCategory", SqlDbType.VarChar,30),
                    new SqlParameter("@usingTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@usingType", SqlDbType.VarChar,30),
                    new SqlParameter("@licenseFirstRegisterDate", SqlDbType.DateTime),
                    new SqlParameter("@purchasePrice", SqlDbType.Decimal,9),
                    new SqlParameter("@plateTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateType", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColorCode", SqlDbType.VarChar,30),
                    new SqlParameter("@plateColor", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleBodyColor", SqlDbType.VarChar,30),
                    new SqlParameter("@currentValue", SqlDbType.Decimal,9),
                    new SqlParameter("@fuelRemain", SqlDbType.Decimal,9),
                    new SqlParameter("@mileage", SqlDbType.Decimal,9),
                    new SqlParameter("@itemsInCar", SqlDbType.VarChar,255),
                    new SqlParameter("@mainCollisionPoints", SqlDbType.VarChar,3),
                    new SqlParameter("@subCollisionPoints", SqlDbType.VarChar,50),
                    new SqlParameter("@country", SqlDbType.VarChar,30),
                    new SqlParameter("@vehicleManufMakeName", SqlDbType.VarChar,255),
                    new SqlParameter("@vehicleSubModelName", SqlDbType.VarChar,255),
                    new SqlParameter("@claimAttachmentsIDs", SqlDbType.VarChar,50),
                    new SqlParameter("@partType", SqlDbType.VarChar,30),
                    new SqlParameter("@partTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@manageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@electricianMachinistRate", SqlDbType.Decimal,9),
                    new SqlParameter("@sheetMetalRate", SqlDbType.Decimal,9),
                    new SqlParameter("@paintRate", SqlDbType.Decimal,9),
                    new SqlParameter("@managementFee", SqlDbType.Decimal,9),
                    new SqlParameter("@multiPaintDiscountRate", SqlDbType.Decimal,9),
                    new SqlParameter("@ChangeItemIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@RepairItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@MaterialItemsIDs", SqlDbType.NVarChar,-1),
                    new SqlParameter("@feeTotal_partFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_laborFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_materialFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_entireSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_totalSalvage", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_depreciation", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_manageFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_estimateAmount", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_rescueFee", SqlDbType.Decimal,9),
                    new SqlParameter("@feeTotal_lossTotal", SqlDbType.Decimal,9)};
                        parameters[0].Value = info_Model.Id;
                        parameters[1].Value = info_Model.partyId;
                        parameters[2].Value = info_Model.businessNo;
                        parameters[3].Value = info_Model.senderTelNo;
                        parameters[4].Value = info_Model.senderName;
                        parameters[5].Value = info_Model.vehicleOwnerName;
                        parameters[6].Value = info_Model.vehicleOwnerTelNo;
                        parameters[7].Value = info_Model.repairOrderNo;
                        parameters[8].Value = info_Model.claimNo;
                        parameters[9].Value = info_Model.sourceType;
                        parameters[10].Value = info_Model.sendRepairFlag;
                        parameters[11].Value = info_Model.insuranceCompanyGroupCode;
                        parameters[12].Value = info_Model.insuranceCompanyGroupName;
                        parameters[13].Value = info_Model.insuranceCompanyCode;
                        parameters[14].Value = info_Model.insuranceCompanyName;
                        parameters[15].Value = info_Model.repairFactoryCode;
                        parameters[16].Value = info_Model.repairFactoryName;
                        parameters[17].Value = info_Model.repairFacilityType;
                        parameters[18].Value = info_Model.qualificationLevel;
                        parameters[19].Value = info_Model.estimatorCode;
                        parameters[20].Value = info_Model.estimatorName;
                        parameters[21].Value = info_Model.workFlowNodeCode;
                        parameters[22].Value = info_Model.workFlowNodeName;
                        parameters[23].Value = info_Model.assignDate;
                        parameters[24].Value = info_Model.estimateStartTime;
                        parameters[25].Value = info_Model.estimateEndTime;
                        parameters[26].Value = info_Model.reportNo;
                        parameters[27].Value = info_Model.reportDate;
                        parameters[28].Value = info_Model.lossVehicleTypeCode;
                        parameters[29].Value = info_Model.lossVehicleType;
                        parameters[30].Value = info_Model.plateNo;
                        parameters[31].Value = info_Model.vin;
                        parameters[32].Value = info_Model.brandModel;
                        parameters[33].Value = info_Model.engineNo;
                        parameters[34].Value = info_Model.vehicleCategoryCode;
                        parameters[35].Value = info_Model.vehicleCategory;
                        parameters[36].Value = info_Model.usingTypeCode;
                        parameters[37].Value = info_Model.usingType;
                        parameters[38].Value = info_Model.licenseFirstRegisterDate;
                        parameters[39].Value = info_Model.purchasePrice;
                        parameters[40].Value = info_Model.plateTypeCode;
                        parameters[41].Value = info_Model.plateType;
                        parameters[42].Value = info_Model.plateColorCode;
                        parameters[43].Value = info_Model.plateColor;
                        parameters[44].Value = info_Model.vehicleBodyColor;
                        parameters[45].Value = info_Model.currentValue;
                        parameters[46].Value = info_Model.fuelRemain;
                        parameters[47].Value = info_Model.mileage;
                        parameters[48].Value = info_Model.itemsInCar;
                        parameters[49].Value = info_Model.mainCollisionPoints;
                        parameters[50].Value = info_Model.subCollisionPoints;
                        parameters[51].Value = info_Model.country;
                        parameters[52].Value = info_Model.vehicleManufMakeName;
                        parameters[53].Value = info_Model.vehicleSubModelName;
                        parameters[54].Value = info_Model.claimAttachmentsIDs;
                        parameters[55].Value = info_Model.partType;
                        parameters[56].Value = info_Model.partTypeCode;
                        parameters[57].Value = info_Model.manageRate;
                        parameters[58].Value = info_Model.laborFeeManageRate;
                        parameters[59].Value = info_Model.electricianMachinistRate;
                        parameters[60].Value = info_Model.sheetMetalRate;
                        parameters[61].Value = info_Model.paintRate;
                        parameters[62].Value = info_Model.managementFee;
                        parameters[63].Value = info_Model.multiPaintDiscountRate;
                        parameters[64].Value = info_Model.ChangeItemIDs;
                        parameters[65].Value = info_Model.RepairItemsIDs;
                        parameters[66].Value = info_Model.MaterialItemsIDs;
                        parameters[67].Value = info_Model.feeTotal_partFee;
                        parameters[68].Value = info_Model.feeTotal_laborFee;
                        parameters[69].Value = info_Model.feeTotal_materialFee;
                        parameters[70].Value = info_Model.feeTotal_entireSalvage;
                        parameters[71].Value = info_Model.feeTotal_totalSalvage;
                        parameters[72].Value = info_Model.feeTotal_depreciation;
                        parameters[73].Value = info_Model.feeTotal_manageFee;
                        parameters[74].Value = info_Model.feeTotal_estimateAmount;
                        parameters[75].Value = info_Model.feeTotal_rescueFee;
                        parameters[76].Value = info_Model.feeTotal_lossTotal;

                        int rows = DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);

                        trans.Commit();
                        return true;
                    }
                    catch (Exception err)
                    {
                        trans.Rollback();
                        throw err;
                    }
                }
            }
            return false;
        }

        #endregion  ExtensionMethod
    }
}
