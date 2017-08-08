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
            strSql.Append("Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal)");
            strSql.Append(" values (");
            strSql.Append("@Id,@senderTelNo,@senderName,@vehicleOwnerName,@vehicleOwnerTelNo,@repairOrderNo,@claimNo,@sourceType,@sendRepairFlag,@insuranceCompanyGroupCode,@insuranceCompanyGroupName,@insuranceCompanyCode,@insuranceCompanyName,@repairFactoryCode,@repairFactoryName,@repairFacilityType,@qualificationLevel,@estimatorCode,@estimatorName,@workFlowNodeCode,@workFlowNodeName,@assignDate,@estimateStartTime,@estimateEndTime,@reportNo,@reportDate,@lossVehicleTypeCode,@lossVehicleType,@plateNo,@vin,@brandModel,@engineNo,@vehicleCategoryCode,@vehicleCategory,@usingTypeCode,@usingType,@licenseFirstRegisterDate,@purchasePrice,@plateTypeCode,@plateType,@plateColorCode,@plateColor,@vehicleBodyColor,@currentValue,@fuelRemain,@mileage,@itemsInCar,@mainCollisionPoints,@subCollisionPoints,@country,@vehicleManufMakeName,@vehicleSubModelName,@claimAttachmentsIDs,@partType,@partTypeCode,@manageRate,@laborFeeManageRate,@electricianMachinistRate,@sheetMetalRate,@paintRate,@managementFee,@multiPaintDiscountRate,@ChangeItemIDs,@RepairItemsIDs,@MaterialItemsIDs,@feeTotal_partFee,@feeTotal_laborFee,@feeTotal_materialFee,@feeTotal_entireSalvage,@feeTotal_totalSalvage,@feeTotal_depreciation,@feeTotal_manageFee,@feeTotal_estimateAmount,@feeTotal_rescueFee,@feeTotal_lossTotal)");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.NVarChar,255),
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
            parameters[1].Value = model.senderTelNo;
            parameters[2].Value = model.senderName;
            parameters[3].Value = model.vehicleOwnerName;
            parameters[4].Value = model.vehicleOwnerTelNo;
            parameters[5].Value = model.repairOrderNo;
            parameters[6].Value = model.claimNo;
            parameters[7].Value = model.sourceType;
            parameters[8].Value = model.sendRepairFlag;
            parameters[9].Value = model.insuranceCompanyGroupCode;
            parameters[10].Value = model.insuranceCompanyGroupName;
            parameters[11].Value = model.insuranceCompanyCode;
            parameters[12].Value = model.insuranceCompanyName;
            parameters[13].Value = model.repairFactoryCode;
            parameters[14].Value = model.repairFactoryName;
            parameters[15].Value = model.repairFacilityType;
            parameters[16].Value = model.qualificationLevel;
            parameters[17].Value = model.estimatorCode;
            parameters[18].Value = model.estimatorName;
            parameters[19].Value = model.workFlowNodeCode;
            parameters[20].Value = model.workFlowNodeName;
            parameters[21].Value = model.assignDate;
            parameters[22].Value = model.estimateStartTime;
            parameters[23].Value = model.estimateEndTime;
            parameters[24].Value = model.reportNo;
            parameters[25].Value = model.reportDate;
            parameters[26].Value = model.lossVehicleTypeCode;
            parameters[27].Value = model.lossVehicleType;
            parameters[28].Value = model.plateNo;
            parameters[29].Value = model.vin;
            parameters[30].Value = model.brandModel;
            parameters[31].Value = model.engineNo;
            parameters[32].Value = model.vehicleCategoryCode;
            parameters[33].Value = model.vehicleCategory;
            parameters[34].Value = model.usingTypeCode;
            parameters[35].Value = model.usingType;
            parameters[36].Value = model.licenseFirstRegisterDate;
            parameters[37].Value = model.purchasePrice;
            parameters[38].Value = model.plateTypeCode;
            parameters[39].Value = model.plateType;
            parameters[40].Value = model.plateColorCode;
            parameters[41].Value = model.plateColor;
            parameters[42].Value = model.vehicleBodyColor;
            parameters[43].Value = model.currentValue;
            parameters[44].Value = model.fuelRemain;
            parameters[45].Value = model.mileage;
            parameters[46].Value = model.itemsInCar;
            parameters[47].Value = model.mainCollisionPoints;
            parameters[48].Value = model.subCollisionPoints;
            parameters[49].Value = model.country;
            parameters[50].Value = model.vehicleManufMakeName;
            parameters[51].Value = model.vehicleSubModelName;
            parameters[52].Value = model.claimAttachmentsIDs;
            parameters[53].Value = model.partType;
            parameters[54].Value = model.partTypeCode;
            parameters[55].Value = model.manageRate;
            parameters[56].Value = model.laborFeeManageRate;
            parameters[57].Value = model.electricianMachinistRate;
            parameters[58].Value = model.sheetMetalRate;
            parameters[59].Value = model.paintRate;
            parameters[60].Value = model.managementFee;
            parameters[61].Value = model.multiPaintDiscountRate;
            parameters[62].Value = model.ChangeItemIDs;
            parameters[63].Value = model.RepairItemsIDs;
            parameters[64].Value = model.MaterialItemsIDs;
            parameters[65].Value = model.feeTotal_partFee;
            parameters[66].Value = model.feeTotal_laborFee;
            parameters[67].Value = model.feeTotal_materialFee;
            parameters[68].Value = model.feeTotal_entireSalvage;
            parameters[69].Value = model.feeTotal_totalSalvage;
            parameters[70].Value = model.feeTotal_depreciation;
            parameters[71].Value = model.feeTotal_manageFee;
            parameters[72].Value = model.feeTotal_estimateAmount;
            parameters[73].Value = model.feeTotal_rescueFee;
            parameters[74].Value = model.feeTotal_lossTotal;

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

        public bool ExistsBusinessNo(string businessNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from CCCAPI_JobLossInformation");
            strSql.Append(" where Id=@businessNo ");
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
            parameters[0].Value = model.senderTelNo;
            parameters[1].Value = model.senderName;
            parameters[2].Value = model.vehicleOwnerName;
            parameters[3].Value = model.vehicleOwnerTelNo;
            parameters[4].Value = model.repairOrderNo;
            parameters[5].Value = model.claimNo;
            parameters[6].Value = model.sourceType;
            parameters[7].Value = model.sendRepairFlag;
            parameters[8].Value = model.insuranceCompanyGroupCode;
            parameters[9].Value = model.insuranceCompanyGroupName;
            parameters[10].Value = model.insuranceCompanyCode;
            parameters[11].Value = model.insuranceCompanyName;
            parameters[12].Value = model.repairFactoryCode;
            parameters[13].Value = model.repairFactoryName;
            parameters[14].Value = model.repairFacilityType;
            parameters[15].Value = model.qualificationLevel;
            parameters[16].Value = model.estimatorCode;
            parameters[17].Value = model.estimatorName;
            parameters[18].Value = model.workFlowNodeCode;
            parameters[19].Value = model.workFlowNodeName;
            parameters[20].Value = model.assignDate;
            parameters[21].Value = model.estimateStartTime;
            parameters[22].Value = model.estimateEndTime;
            parameters[23].Value = model.reportNo;
            parameters[24].Value = model.reportDate;
            parameters[25].Value = model.lossVehicleTypeCode;
            parameters[26].Value = model.lossVehicleType;
            parameters[27].Value = model.plateNo;
            parameters[28].Value = model.vin;
            parameters[29].Value = model.brandModel;
            parameters[30].Value = model.engineNo;
            parameters[31].Value = model.vehicleCategoryCode;
            parameters[32].Value = model.vehicleCategory;
            parameters[33].Value = model.usingTypeCode;
            parameters[34].Value = model.usingType;
            parameters[35].Value = model.licenseFirstRegisterDate;
            parameters[36].Value = model.purchasePrice;
            parameters[37].Value = model.plateTypeCode;
            parameters[38].Value = model.plateType;
            parameters[39].Value = model.plateColorCode;
            parameters[40].Value = model.plateColor;
            parameters[41].Value = model.vehicleBodyColor;
            parameters[42].Value = model.currentValue;
            parameters[43].Value = model.fuelRemain;
            parameters[44].Value = model.mileage;
            parameters[45].Value = model.itemsInCar;
            parameters[46].Value = model.mainCollisionPoints;
            parameters[47].Value = model.subCollisionPoints;
            parameters[48].Value = model.country;
            parameters[49].Value = model.vehicleManufMakeName;
            parameters[50].Value = model.vehicleSubModelName;
            parameters[51].Value = model.claimAttachmentsIDs;
            parameters[52].Value = model.partType;
            parameters[53].Value = model.partTypeCode;
            parameters[54].Value = model.manageRate;
            parameters[55].Value = model.laborFeeManageRate;
            parameters[56].Value = model.electricianMachinistRate;
            parameters[57].Value = model.sheetMetalRate;
            parameters[58].Value = model.paintRate;
            parameters[59].Value = model.managementFee;
            parameters[60].Value = model.multiPaintDiscountRate;
            parameters[61].Value = model.ChangeItemIDs;
            parameters[62].Value = model.RepairItemsIDs;
            parameters[63].Value = model.MaterialItemsIDs;
            parameters[64].Value = model.feeTotal_partFee;
            parameters[65].Value = model.feeTotal_laborFee;
            parameters[66].Value = model.feeTotal_materialFee;
            parameters[67].Value = model.feeTotal_entireSalvage;
            parameters[68].Value = model.feeTotal_totalSalvage;
            parameters[69].Value = model.feeTotal_depreciation;
            parameters[70].Value = model.feeTotal_manageFee;
            parameters[71].Value = model.feeTotal_estimateAmount;
            parameters[72].Value = model.feeTotal_rescueFee;
            parameters[73].Value = model.feeTotal_lossTotal;
            parameters[74].Value = model.Id;

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
            strSql.Append("select  top 1 Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal from CCCAPI_JobLossInformation ");
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
            strSql.Append("select Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
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
            strSql.Append(" Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
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

                        var strSql = new StringBuilder();
                        strSql.Append("insert into CCCAPI_JobLossInformation(");
                        strSql.Append("Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,claimAttachmentsIDs,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,ChangeItemIDs,RepairItemsIDs,MaterialItemsIDs,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal)");
                        strSql.Append(" values (");
                        strSql.Append("@Id,@senderTelNo,@senderName,@vehicleOwnerName,@vehicleOwnerTelNo,@repairOrderNo,@claimNo,@sourceType,@sendRepairFlag,@insuranceCompanyGroupCode,@insuranceCompanyGroupName,@insuranceCompanyCode,@insuranceCompanyName,@repairFactoryCode,@repairFactoryName,@repairFacilityType,@qualificationLevel,@estimatorCode,@estimatorName,@workFlowNodeCode,@workFlowNodeName,@assignDate,@estimateStartTime,@estimateEndTime,@reportNo,@reportDate,@lossVehicleTypeCode,@lossVehicleType,@plateNo,@vin,@brandModel,@engineNo,@vehicleCategoryCode,@vehicleCategory,@usingTypeCode,@usingType,@licenseFirstRegisterDate,@purchasePrice,@plateTypeCode,@plateType,@plateColorCode,@plateColor,@vehicleBodyColor,@currentValue,@fuelRemain,@mileage,@itemsInCar,@mainCollisionPoints,@subCollisionPoints,@country,@vehicleManufMakeName,@vehicleSubModelName,@claimAttachmentsIDs,@partType,@partTypeCode,@manageRate,@laborFeeManageRate,@electricianMachinistRate,@sheetMetalRate,@paintRate,@managementFee,@multiPaintDiscountRate,@ChangeItemIDs,@RepairItemsIDs,@MaterialItemsIDs,@feeTotal_partFee,@feeTotal_laborFee,@feeTotal_materialFee,@feeTotal_entireSalvage,@feeTotal_totalSalvage,@feeTotal_depreciation,@feeTotal_manageFee,@feeTotal_estimateAmount,@feeTotal_rescueFee,@feeTotal_lossTotal)");

                        var parameters =new SqlParameter[] {
                            new SqlParameter("@Id", info_Model.Id),
                            new SqlParameter("@senderTelNo", info_Model.senderTelNo),
                            new SqlParameter("@senderName", info_Model.senderName),
                            new SqlParameter("@vehicleOwnerName", info_Model.vehicleOwnerName),
                            new SqlParameter("@vehicleOwnerTelNo", info_Model.vehicleOwnerTelNo),
                            new SqlParameter("@repairOrderNo", info_Model.repairOrderNo),
                            new SqlParameter("@claimNo", info_Model.claimNo),
                            new SqlParameter("@sourceType", info_Model.sourceType),
                            new SqlParameter("@sendRepairFlag",info_Model.sendRepairFlag),
                            new SqlParameter("@insuranceCompanyGroupCode", info_Model.insuranceCompanyGroupCode),
                            new SqlParameter("@insuranceCompanyGroupName", info_Model.insuranceCompanyGroupName),
                            new SqlParameter("@insuranceCompanyCode", info_Model.insuranceCompanyCode),
                            new SqlParameter("@insuranceCompanyName", info_Model.insuranceCompanyName),
                            new SqlParameter("@repairFactoryCode", info_Model.repairFactoryCode),
                            new SqlParameter("@repairFactoryName", info_Model.repairFactoryName),
                            new SqlParameter("@repairFacilityType",info_Model.repairFacilityType),
                            new SqlParameter("@qualificationLevel", info_Model.qualificationLevel),
                            new SqlParameter("@estimatorCode", info_Model.estimatorCode),
                            new SqlParameter("@estimatorName", info_Model.estimatorName),
                            new SqlParameter("@workFlowNodeCode", info_Model.workFlowNodeCode),
                            new SqlParameter("@workFlowNodeName", info_Model.workFlowNodeName),
                            new SqlParameter("@assignDate", info_Model.assignDate),
                            new SqlParameter("@estimateStartTime", info_Model.estimateStartTime),
                            new SqlParameter("@estimateEndTime", info_Model.estimateEndTime),
                            new SqlParameter("@reportNo", info_Model.reportNo),
                            new SqlParameter("@reportDate", info_Model.reportDate),
                            new SqlParameter("@lossVehicleTypeCode", info_Model.lossVehicleTypeCode),
                            new SqlParameter("@lossVehicleType", info_Model.lossVehicleType),
                            new SqlParameter("@plateNo", info_Model.plateNo),
                            new SqlParameter("@vin", info_Model.vin),
                            new SqlParameter("@brandModel", info_Model.brandModel),
                            new SqlParameter("@engineNo", info_Model.engineNo),
                            new SqlParameter("@vehicleCategoryCode", info_Model.vehicleCategoryCode),
                            new SqlParameter("@vehicleCategory", info_Model.vehicleCategory),
                            new SqlParameter("@usingTypeCode", info_Model.usingTypeCode),
                            new SqlParameter("@usingType", info_Model.usingType),
                            new SqlParameter("@licenseFirstRegisterDate", info_Model.licenseFirstRegisterDate),
                            new SqlParameter("@purchasePrice", info_Model.purchasePrice),
                            new SqlParameter("@plateTypeCode", info_Model.plateTypeCode),
                            new SqlParameter("@plateType", info_Model.plateType),
                            new SqlParameter("@plateColorCode", info_Model.plateColorCode),
                            new SqlParameter("@plateColor", info_Model.plateColor),
                            new SqlParameter("@vehicleBodyColor", info_Model.vehicleBodyColor),
                            new SqlParameter("@currentValue", info_Model.currentValue),
                            new SqlParameter("@fuelRemain", info_Model.fuelRemain),
                            new SqlParameter("@mileage", info_Model.mileage),
                            new SqlParameter("@itemsInCar", info_Model.itemsInCar),
                            new SqlParameter("@mainCollisionPoints",info_Model.mainCollisionPoints),
                            new SqlParameter("@subCollisionPoints", info_Model.subCollisionPoints),
                            new SqlParameter("@country", info_Model.country),
                            new SqlParameter("@vehicleManufMakeName", info_Model.vehicleManufMakeName),
                            new SqlParameter("@vehicleSubModelName", info_Model.vehicleSubModelName),
                            new SqlParameter("@claimAttachmentsIDs", info_Model.claimAttachmentsIDs),
                            new SqlParameter("@partType", info_Model.partType),
                            new SqlParameter("@partTypeCode", info_Model.partTypeCode),
                            new SqlParameter("@manageRate", info_Model.manageRate),
                            new SqlParameter("@laborFeeManageRate", info_Model.laborFeeManageRate),
                            new SqlParameter("@electricianMachinistRate", info_Model.electricianMachinistRate),
                            new SqlParameter("@sheetMetalRate", info_Model.sheetMetalRate),
                            new SqlParameter("@paintRate", info_Model.paintRate),
                            new SqlParameter("@managementFee", info_Model.managementFee),
                            new SqlParameter("@multiPaintDiscountRate", info_Model.multiPaintDiscountRate),
                            new SqlParameter("@ChangeItemIDs", info_Model.ChangeItemIDs),
                            new SqlParameter("@RepairItemsIDs", info_Model.RepairItemsIDs),
                            new SqlParameter("@MaterialItemsIDs", info_Model.MaterialItemsIDs),
                            new SqlParameter("@feeTotal_partFee", info_Model.feeTotal_partFee),
                            new SqlParameter("@feeTotal_laborFee", info_Model.feeTotal_laborFee),
                            new SqlParameter("@feeTotal_materialFee", info_Model.feeTotal_materialFee),
                            new SqlParameter("@feeTotal_entireSalvage",info_Model.feeTotal_entireSalvage),
                            new SqlParameter("@feeTotal_totalSalvage", info_Model.feeTotal_totalSalvage),
                            new SqlParameter("@feeTotal_depreciation", info_Model.feeTotal_depreciation),
                            new SqlParameter("@feeTotal_manageFee", info_Model.feeTotal_manageFee),
                            new SqlParameter("@feeTotal_estimateAmount",info_Model.feeTotal_estimateAmount),
                            new SqlParameter("@feeTotal_rescueFee", info_Model.feeTotal_rescueFee),
                            new SqlParameter("@feeTotal_lossTotal", info_Model.feeTotal_lossTotal)
                        };
                        DbHelperSQL.ExecuteSql(conn, trans, strSql.ToString(), parameters);

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
