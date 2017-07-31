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
            strSql.Append("Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,attachmentCategoryName,attachmentUrl,attachmentId,attachmentName,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,changeItems_itemId,changeItems_itemName,changeItems_manualFlag,changeItems_partNo,changeItems_partQuantity,changeItems_unitPriceAfterDiscount,changeItems_partFeeAfterDiscount,changeItems_depreciation,changeItems_salvage,changeItems_recycleFlag,repairItems_itemId,repairItems_itemName,repairItems_manualFlag,repairItems_operationType,repairItems_partNo,repairItems_laborType,repairItems_laborHourFee,repairItems_laborFeeManageRate,repairItems_paintDiscountFlag,repairItems_laborHour,repairItems_laborFeeAfterDiscount,repairItems_outerRepairFlag,repairItems_outerLaborFee,materialItems_itemId,materialItems_itemName,materialItems_manualFlag,materialItems_materialUnit,materialItems_partQuantity,materialItems_unitPrice,materialItems_partFee,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal)");
            strSql.Append(" values (");
            strSql.Append("@Id,@senderTelNo,@senderName,@vehicleOwnerName,@vehicleOwnerTelNo,@repairOrderNo,@claimNo,@sourceType,@sendRepairFlag,@insuranceCompanyGroupCode,@insuranceCompanyGroupName,@insuranceCompanyCode,@insuranceCompanyName,@repairFactoryCode,@repairFactoryName,@repairFacilityType,@qualificationLevel,@estimatorCode,@estimatorName,@workFlowNodeCode,@workFlowNodeName,@assignDate,@estimateStartTime,@estimateEndTime,@reportNo,@reportDate,@lossVehicleTypeCode,@lossVehicleType,@plateNo,@vin,@brandModel,@engineNo,@vehicleCategoryCode,@vehicleCategory,@usingTypeCode,@usingType,@licenseFirstRegisterDate,@purchasePrice,@plateTypeCode,@plateType,@plateColorCode,@plateColor,@vehicleBodyColor,@currentValue,@fuelRemain,@mileage,@itemsInCar,@mainCollisionPoints,@subCollisionPoints,@country,@vehicleManufMakeName,@vehicleSubModelName,@attachmentCategoryName,@attachmentUrl,@attachmentId,@attachmentName,@partType,@partTypeCode,@manageRate,@laborFeeManageRate,@electricianMachinistRate,@sheetMetalRate,@paintRate,@managementFee,@multiPaintDiscountRate,@changeItems_itemId,@changeItems_itemName,@changeItems_manualFlag,@changeItems_partNo,@changeItems_partQuantity,@changeItems_unitPriceAfterDiscount,@changeItems_partFeeAfterDiscount,@changeItems_depreciation,@changeItems_salvage,@changeItems_recycleFlag,@repairItems_itemId,@repairItems_itemName,@repairItems_manualFlag,@repairItems_operationType,@repairItems_partNo,@repairItems_laborType,@repairItems_laborHourFee,@repairItems_laborFeeManageRate,@repairItems_paintDiscountFlag,@repairItems_laborHour,@repairItems_laborFeeAfterDiscount,@repairItems_outerRepairFlag,@repairItems_outerLaborFee,@materialItems_itemId,@materialItems_itemName,@materialItems_manualFlag,@materialItems_materialUnit,@materialItems_partQuantity,@materialItems_unitPrice,@materialItems_partFee,@feeTotal_partFee,@feeTotal_laborFee,@feeTotal_materialFee,@feeTotal_entireSalvage,@feeTotal_totalSalvage,@feeTotal_depreciation,@feeTotal_manageFee,@feeTotal_estimateAmount,@feeTotal_rescueFee,@feeTotal_lossTotal)");
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
                    new SqlParameter("@attachmentCategoryName", SqlDbType.VarChar,50),
                    new SqlParameter("@attachmentUrl", SqlDbType.VarChar,200),
                    new SqlParameter("@attachmentId", SqlDbType.Int,4),
                    new SqlParameter("@attachmentName", SqlDbType.VarChar,100),
                    new SqlParameter("@partType", SqlDbType.VarChar,30),
                    new SqlParameter("@partTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@manageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@electricianMachinistRate", SqlDbType.Decimal,9),
                    new SqlParameter("@sheetMetalRate", SqlDbType.Decimal,9),
                    new SqlParameter("@paintRate", SqlDbType.Decimal,9),
                    new SqlParameter("@managementFee", SqlDbType.Decimal,9),
                    new SqlParameter("@multiPaintDiscountRate", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@changeItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@changeItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@changeItems_partNo", SqlDbType.VarChar,30),
                    new SqlParameter("@changeItems_partQuantity", SqlDbType.Int,4),
                    new SqlParameter("@changeItems_unitPriceAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_partFeeAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_depreciation", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_salvage", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_recycleFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@repairItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_operationType", SqlDbType.VarChar,50),
                    new SqlParameter("@repairItems_partNo", SqlDbType.VarChar,30),
                    new SqlParameter("@repairItems_laborType", SqlDbType.VarChar,30),
                    new SqlParameter("@repairItems_laborHourFee", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_paintDiscountFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_laborHour", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_laborFeeAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_outerRepairFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_outerLaborFee", SqlDbType.Decimal,9),
                    new SqlParameter("@materialItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@materialItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@materialItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@materialItems_materialUnit", SqlDbType.VarChar,20),
                    new SqlParameter("@materialItems_partQuantity", SqlDbType.Decimal,5),
                    new SqlParameter("@materialItems_unitPrice", SqlDbType.Decimal,9),
                    new SqlParameter("@materialItems_partFee", SqlDbType.Decimal,9),
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
            parameters[52].Value = model.attachmentCategoryName;
            parameters[53].Value = model.attachmentUrl;
            parameters[54].Value = model.attachmentId;
            parameters[55].Value = model.attachmentName;
            parameters[56].Value = model.partType;
            parameters[57].Value = model.partTypeCode;
            parameters[58].Value = model.manageRate;
            parameters[59].Value = model.laborFeeManageRate;
            parameters[60].Value = model.electricianMachinistRate;
            parameters[61].Value = model.sheetMetalRate;
            parameters[62].Value = model.paintRate;
            parameters[63].Value = model.managementFee;
            parameters[64].Value = model.multiPaintDiscountRate;
            parameters[65].Value = model.changeItems_itemId;
            parameters[66].Value = model.changeItems_itemName;
            parameters[67].Value = model.changeItems_manualFlag;
            parameters[68].Value = model.changeItems_partNo;
            parameters[69].Value = model.changeItems_partQuantity;
            parameters[70].Value = model.changeItems_unitPriceAfterDiscount;
            parameters[71].Value = model.changeItems_partFeeAfterDiscount;
            parameters[72].Value = model.changeItems_depreciation;
            parameters[73].Value = model.changeItems_salvage;
            parameters[74].Value = model.changeItems_recycleFlag;
            parameters[75].Value = model.repairItems_itemId;
            parameters[76].Value = model.repairItems_itemName;
            parameters[77].Value = model.repairItems_manualFlag;
            parameters[78].Value = model.repairItems_operationType;
            parameters[79].Value = model.repairItems_partNo;
            parameters[80].Value = model.repairItems_laborType;
            parameters[81].Value = model.repairItems_laborHourFee;
            parameters[82].Value = model.repairItems_laborFeeManageRate;
            parameters[83].Value = model.repairItems_paintDiscountFlag;
            parameters[84].Value = model.repairItems_laborHour;
            parameters[85].Value = model.repairItems_laborFeeAfterDiscount;
            parameters[86].Value = model.repairItems_outerRepairFlag;
            parameters[87].Value = model.repairItems_outerLaborFee;
            parameters[88].Value = model.materialItems_itemId;
            parameters[89].Value = model.materialItems_itemName;
            parameters[90].Value = model.materialItems_manualFlag;
            parameters[91].Value = model.materialItems_materialUnit;
            parameters[92].Value = model.materialItems_partQuantity;
            parameters[93].Value = model.materialItems_unitPrice;
            parameters[94].Value = model.materialItems_partFee;
            parameters[95].Value = model.feeTotal_partFee;
            parameters[96].Value = model.feeTotal_laborFee;
            parameters[97].Value = model.feeTotal_materialFee;
            parameters[98].Value = model.feeTotal_entireSalvage;
            parameters[99].Value = model.feeTotal_totalSalvage;
            parameters[100].Value = model.feeTotal_depreciation;
            parameters[101].Value = model.feeTotal_manageFee;
            parameters[102].Value = model.feeTotal_estimateAmount;
            parameters[103].Value = model.feeTotal_rescueFee;
            parameters[104].Value = model.feeTotal_lossTotal;

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
            strSql.Append("attachmentCategoryName=@attachmentCategoryName,");
            strSql.Append("attachmentUrl=@attachmentUrl,");
            strSql.Append("attachmentId=@attachmentId,");
            strSql.Append("attachmentName=@attachmentName,");
            strSql.Append("partType=@partType,");
            strSql.Append("partTypeCode=@partTypeCode,");
            strSql.Append("manageRate=@manageRate,");
            strSql.Append("laborFeeManageRate=@laborFeeManageRate,");
            strSql.Append("electricianMachinistRate=@electricianMachinistRate,");
            strSql.Append("sheetMetalRate=@sheetMetalRate,");
            strSql.Append("paintRate=@paintRate,");
            strSql.Append("managementFee=@managementFee,");
            strSql.Append("multiPaintDiscountRate=@multiPaintDiscountRate,");
            strSql.Append("changeItems_itemId=@changeItems_itemId,");
            strSql.Append("changeItems_itemName=@changeItems_itemName,");
            strSql.Append("changeItems_manualFlag=@changeItems_manualFlag,");
            strSql.Append("changeItems_partNo=@changeItems_partNo,");
            strSql.Append("changeItems_partQuantity=@changeItems_partQuantity,");
            strSql.Append("changeItems_unitPriceAfterDiscount=@changeItems_unitPriceAfterDiscount,");
            strSql.Append("changeItems_partFeeAfterDiscount=@changeItems_partFeeAfterDiscount,");
            strSql.Append("changeItems_depreciation=@changeItems_depreciation,");
            strSql.Append("changeItems_salvage=@changeItems_salvage,");
            strSql.Append("changeItems_recycleFlag=@changeItems_recycleFlag,");
            strSql.Append("repairItems_itemId=@repairItems_itemId,");
            strSql.Append("repairItems_itemName=@repairItems_itemName,");
            strSql.Append("repairItems_manualFlag=@repairItems_manualFlag,");
            strSql.Append("repairItems_operationType=@repairItems_operationType,");
            strSql.Append("repairItems_partNo=@repairItems_partNo,");
            strSql.Append("repairItems_laborType=@repairItems_laborType,");
            strSql.Append("repairItems_laborHourFee=@repairItems_laborHourFee,");
            strSql.Append("repairItems_laborFeeManageRate=@repairItems_laborFeeManageRate,");
            strSql.Append("repairItems_paintDiscountFlag=@repairItems_paintDiscountFlag,");
            strSql.Append("repairItems_laborHour=@repairItems_laborHour,");
            strSql.Append("repairItems_laborFeeAfterDiscount=@repairItems_laborFeeAfterDiscount,");
            strSql.Append("repairItems_outerRepairFlag=@repairItems_outerRepairFlag,");
            strSql.Append("repairItems_outerLaborFee=@repairItems_outerLaborFee,");
            strSql.Append("materialItems_itemId=@materialItems_itemId,");
            strSql.Append("materialItems_itemName=@materialItems_itemName,");
            strSql.Append("materialItems_manualFlag=@materialItems_manualFlag,");
            strSql.Append("materialItems_materialUnit=@materialItems_materialUnit,");
            strSql.Append("materialItems_partQuantity=@materialItems_partQuantity,");
            strSql.Append("materialItems_unitPrice=@materialItems_unitPrice,");
            strSql.Append("materialItems_partFee=@materialItems_partFee,");
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
                    new SqlParameter("@attachmentCategoryName", SqlDbType.VarChar,50),
                    new SqlParameter("@attachmentUrl", SqlDbType.VarChar,200),
                    new SqlParameter("@attachmentId", SqlDbType.Int,4),
                    new SqlParameter("@attachmentName", SqlDbType.VarChar,100),
                    new SqlParameter("@partType", SqlDbType.VarChar,30),
                    new SqlParameter("@partTypeCode", SqlDbType.VarChar,30),
                    new SqlParameter("@manageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@electricianMachinistRate", SqlDbType.Decimal,9),
                    new SqlParameter("@sheetMetalRate", SqlDbType.Decimal,9),
                    new SqlParameter("@paintRate", SqlDbType.Decimal,9),
                    new SqlParameter("@managementFee", SqlDbType.Decimal,9),
                    new SqlParameter("@multiPaintDiscountRate", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@changeItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@changeItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@changeItems_partNo", SqlDbType.VarChar,30),
                    new SqlParameter("@changeItems_partQuantity", SqlDbType.Int,4),
                    new SqlParameter("@changeItems_unitPriceAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_partFeeAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_depreciation", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_salvage", SqlDbType.Decimal,9),
                    new SqlParameter("@changeItems_recycleFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@repairItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@repairItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_operationType", SqlDbType.VarChar,50),
                    new SqlParameter("@repairItems_partNo", SqlDbType.VarChar,30),
                    new SqlParameter("@repairItems_laborType", SqlDbType.VarChar,30),
                    new SqlParameter("@repairItems_laborHourFee", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_laborFeeManageRate", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_paintDiscountFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_laborHour", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_laborFeeAfterDiscount", SqlDbType.Decimal,9),
                    new SqlParameter("@repairItems_outerRepairFlag", SqlDbType.Bit,1),
                    new SqlParameter("@repairItems_outerLaborFee", SqlDbType.Decimal,9),
                    new SqlParameter("@materialItems_itemId", SqlDbType.Int,4),
                    new SqlParameter("@materialItems_itemName", SqlDbType.VarChar,100),
                    new SqlParameter("@materialItems_manualFlag", SqlDbType.Bit,1),
                    new SqlParameter("@materialItems_materialUnit", SqlDbType.VarChar,20),
                    new SqlParameter("@materialItems_partQuantity", SqlDbType.Decimal,5),
                    new SqlParameter("@materialItems_unitPrice", SqlDbType.Decimal,9),
                    new SqlParameter("@materialItems_partFee", SqlDbType.Decimal,9),
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
            parameters[51].Value = model.attachmentCategoryName;
            parameters[52].Value = model.attachmentUrl;
            parameters[53].Value = model.attachmentId;
            parameters[54].Value = model.attachmentName;
            parameters[55].Value = model.partType;
            parameters[56].Value = model.partTypeCode;
            parameters[57].Value = model.manageRate;
            parameters[58].Value = model.laborFeeManageRate;
            parameters[59].Value = model.electricianMachinistRate;
            parameters[60].Value = model.sheetMetalRate;
            parameters[61].Value = model.paintRate;
            parameters[62].Value = model.managementFee;
            parameters[63].Value = model.multiPaintDiscountRate;
            parameters[64].Value = model.changeItems_itemId;
            parameters[65].Value = model.changeItems_itemName;
            parameters[66].Value = model.changeItems_manualFlag;
            parameters[67].Value = model.changeItems_partNo;
            parameters[68].Value = model.changeItems_partQuantity;
            parameters[69].Value = model.changeItems_unitPriceAfterDiscount;
            parameters[70].Value = model.changeItems_partFeeAfterDiscount;
            parameters[71].Value = model.changeItems_depreciation;
            parameters[72].Value = model.changeItems_salvage;
            parameters[73].Value = model.changeItems_recycleFlag;
            parameters[74].Value = model.repairItems_itemId;
            parameters[75].Value = model.repairItems_itemName;
            parameters[76].Value = model.repairItems_manualFlag;
            parameters[77].Value = model.repairItems_operationType;
            parameters[78].Value = model.repairItems_partNo;
            parameters[79].Value = model.repairItems_laborType;
            parameters[80].Value = model.repairItems_laborHourFee;
            parameters[81].Value = model.repairItems_laborFeeManageRate;
            parameters[82].Value = model.repairItems_paintDiscountFlag;
            parameters[83].Value = model.repairItems_laborHour;
            parameters[84].Value = model.repairItems_laborFeeAfterDiscount;
            parameters[85].Value = model.repairItems_outerRepairFlag;
            parameters[86].Value = model.repairItems_outerLaborFee;
            parameters[87].Value = model.materialItems_itemId;
            parameters[88].Value = model.materialItems_itemName;
            parameters[89].Value = model.materialItems_manualFlag;
            parameters[90].Value = model.materialItems_materialUnit;
            parameters[91].Value = model.materialItems_partQuantity;
            parameters[92].Value = model.materialItems_unitPrice;
            parameters[93].Value = model.materialItems_partFee;
            parameters[94].Value = model.feeTotal_partFee;
            parameters[95].Value = model.feeTotal_laborFee;
            parameters[96].Value = model.feeTotal_materialFee;
            parameters[97].Value = model.feeTotal_entireSalvage;
            parameters[98].Value = model.feeTotal_totalSalvage;
            parameters[99].Value = model.feeTotal_depreciation;
            parameters[100].Value = model.feeTotal_manageFee;
            parameters[101].Value = model.feeTotal_estimateAmount;
            parameters[102].Value = model.feeTotal_rescueFee;
            parameters[103].Value = model.feeTotal_lossTotal;
            parameters[104].Value = model.Id;

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
            strSql.Append("select  top 1 Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,attachmentCategoryName,attachmentUrl,attachmentId,attachmentName,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,changeItems_itemId,changeItems_itemName,changeItems_manualFlag,changeItems_partNo,changeItems_partQuantity,changeItems_unitPriceAfterDiscount,changeItems_partFeeAfterDiscount,changeItems_depreciation,changeItems_salvage,changeItems_recycleFlag,repairItems_itemId,repairItems_itemName,repairItems_manualFlag,repairItems_operationType,repairItems_partNo,repairItems_laborType,repairItems_laborHourFee,repairItems_laborFeeManageRate,repairItems_paintDiscountFlag,repairItems_laborHour,repairItems_laborFeeAfterDiscount,repairItems_outerRepairFlag,repairItems_outerLaborFee,materialItems_itemId,materialItems_itemName,materialItems_manualFlag,materialItems_materialUnit,materialItems_partQuantity,materialItems_unitPrice,materialItems_partFee,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal from CCCAPI_JobLossInformation ");
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
                if (row["attachmentCategoryName"] != null)
                {
                    model.attachmentCategoryName = row["attachmentCategoryName"].ToString();
                }
                if (row["attachmentUrl"] != null)
                {
                    model.attachmentUrl = row["attachmentUrl"].ToString();
                }
                if (row["attachmentId"] != null && row["attachmentId"].ToString() != "")
                {
                    model.attachmentId = int.Parse(row["attachmentId"].ToString());
                }
                if (row["attachmentName"] != null)
                {
                    model.attachmentName = row["attachmentName"].ToString();
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
                if (row["changeItems_itemId"] != null && row["changeItems_itemId"].ToString() != "")
                {
                    model.changeItems_itemId = int.Parse(row["changeItems_itemId"].ToString());
                }
                if (row["changeItems_itemName"] != null)
                {
                    model.changeItems_itemName = row["changeItems_itemName"].ToString();
                }
                if (row["changeItems_manualFlag"] != null && row["changeItems_manualFlag"].ToString() != "")
                {
                    if ((row["changeItems_manualFlag"].ToString() == "1") || (row["changeItems_manualFlag"].ToString().ToLower() == "true"))
                    {
                        model.changeItems_manualFlag = true;
                    }
                    else
                    {
                        model.changeItems_manualFlag = false;
                    }
                }
                if (row["changeItems_partNo"] != null)
                {
                    model.changeItems_partNo = row["changeItems_partNo"].ToString();
                }
                if (row["changeItems_partQuantity"] != null && row["changeItems_partQuantity"].ToString() != "")
                {
                    model.changeItems_partQuantity = int.Parse(row["changeItems_partQuantity"].ToString());
                }
                if (row["changeItems_unitPriceAfterDiscount"] != null && row["changeItems_unitPriceAfterDiscount"].ToString() != "")
                {
                    model.changeItems_unitPriceAfterDiscount = decimal.Parse(row["changeItems_unitPriceAfterDiscount"].ToString());
                }
                if (row["changeItems_partFeeAfterDiscount"] != null && row["changeItems_partFeeAfterDiscount"].ToString() != "")
                {
                    model.changeItems_partFeeAfterDiscount = decimal.Parse(row["changeItems_partFeeAfterDiscount"].ToString());
                }
                if (row["changeItems_depreciation"] != null && row["changeItems_depreciation"].ToString() != "")
                {
                    model.changeItems_depreciation = decimal.Parse(row["changeItems_depreciation"].ToString());
                }
                if (row["changeItems_salvage"] != null && row["changeItems_salvage"].ToString() != "")
                {
                    model.changeItems_salvage = decimal.Parse(row["changeItems_salvage"].ToString());
                }
                if (row["changeItems_recycleFlag"] != null && row["changeItems_recycleFlag"].ToString() != "")
                {
                    if ((row["changeItems_recycleFlag"].ToString() == "1") || (row["changeItems_recycleFlag"].ToString().ToLower() == "true"))
                    {
                        model.changeItems_recycleFlag = true;
                    }
                    else
                    {
                        model.changeItems_recycleFlag = false;
                    }
                }
                if (row["repairItems_itemId"] != null && row["repairItems_itemId"].ToString() != "")
                {
                    model.repairItems_itemId = int.Parse(row["repairItems_itemId"].ToString());
                }
                if (row["repairItems_itemName"] != null)
                {
                    model.repairItems_itemName = row["repairItems_itemName"].ToString();
                }
                if (row["repairItems_manualFlag"] != null && row["repairItems_manualFlag"].ToString() != "")
                {
                    if ((row["repairItems_manualFlag"].ToString() == "1") || (row["repairItems_manualFlag"].ToString().ToLower() == "true"))
                    {
                        model.repairItems_manualFlag = true;
                    }
                    else
                    {
                        model.repairItems_manualFlag = false;
                    }
                }
                if (row["repairItems_operationType"] != null)
                {
                    model.repairItems_operationType = row["repairItems_operationType"].ToString();
                }
                if (row["repairItems_partNo"] != null)
                {
                    model.repairItems_partNo = row["repairItems_partNo"].ToString();
                }
                if (row["repairItems_laborType"] != null)
                {
                    model.repairItems_laborType = row["repairItems_laborType"].ToString();
                }
                if (row["repairItems_laborHourFee"] != null && row["repairItems_laborHourFee"].ToString() != "")
                {
                    model.repairItems_laborHourFee = decimal.Parse(row["repairItems_laborHourFee"].ToString());
                }
                if (row["repairItems_laborFeeManageRate"] != null && row["repairItems_laborFeeManageRate"].ToString() != "")
                {
                    model.repairItems_laborFeeManageRate = decimal.Parse(row["repairItems_laborFeeManageRate"].ToString());
                }
                if (row["repairItems_paintDiscountFlag"] != null && row["repairItems_paintDiscountFlag"].ToString() != "")
                {
                    if ((row["repairItems_paintDiscountFlag"].ToString() == "1") || (row["repairItems_paintDiscountFlag"].ToString().ToLower() == "true"))
                    {
                        model.repairItems_paintDiscountFlag = true;
                    }
                    else
                    {
                        model.repairItems_paintDiscountFlag = false;
                    }
                }
                if (row["repairItems_laborHour"] != null && row["repairItems_laborHour"].ToString() != "")
                {
                    model.repairItems_laborHour = decimal.Parse(row["repairItems_laborHour"].ToString());
                }
                if (row["repairItems_laborFeeAfterDiscount"] != null && row["repairItems_laborFeeAfterDiscount"].ToString() != "")
                {
                    model.repairItems_laborFeeAfterDiscount = decimal.Parse(row["repairItems_laborFeeAfterDiscount"].ToString());
                }
                if (row["repairItems_outerRepairFlag"] != null && row["repairItems_outerRepairFlag"].ToString() != "")
                {
                    if ((row["repairItems_outerRepairFlag"].ToString() == "1") || (row["repairItems_outerRepairFlag"].ToString().ToLower() == "true"))
                    {
                        model.repairItems_outerRepairFlag = true;
                    }
                    else
                    {
                        model.repairItems_outerRepairFlag = false;
                    }
                }
                if (row["repairItems_outerLaborFee"] != null && row["repairItems_outerLaborFee"].ToString() != "")
                {
                    model.repairItems_outerLaborFee = decimal.Parse(row["repairItems_outerLaborFee"].ToString());
                }
                if (row["materialItems_itemId"] != null && row["materialItems_itemId"].ToString() != "")
                {
                    model.materialItems_itemId = int.Parse(row["materialItems_itemId"].ToString());
                }
                if (row["materialItems_itemName"] != null)
                {
                    model.materialItems_itemName = row["materialItems_itemName"].ToString();
                }
                if (row["materialItems_manualFlag"] != null && row["materialItems_manualFlag"].ToString() != "")
                {
                    if ((row["materialItems_manualFlag"].ToString() == "1") || (row["materialItems_manualFlag"].ToString().ToLower() == "true"))
                    {
                        model.materialItems_manualFlag = true;
                    }
                    else
                    {
                        model.materialItems_manualFlag = false;
                    }
                }
                if (row["materialItems_materialUnit"] != null)
                {
                    model.materialItems_materialUnit = row["materialItems_materialUnit"].ToString();
                }
                if (row["materialItems_partQuantity"] != null && row["materialItems_partQuantity"].ToString() != "")
                {
                    model.materialItems_partQuantity = decimal.Parse(row["materialItems_partQuantity"].ToString());
                }
                if (row["materialItems_unitPrice"] != null && row["materialItems_unitPrice"].ToString() != "")
                {
                    model.materialItems_unitPrice = decimal.Parse(row["materialItems_unitPrice"].ToString());
                }
                if (row["materialItems_partFee"] != null && row["materialItems_partFee"].ToString() != "")
                {
                    model.materialItems_partFee = decimal.Parse(row["materialItems_partFee"].ToString());
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
            strSql.Append("select Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,attachmentCategoryName,attachmentUrl,attachmentId,attachmentName,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,changeItems_itemId,changeItems_itemName,changeItems_manualFlag,changeItems_partNo,changeItems_partQuantity,changeItems_unitPriceAfterDiscount,changeItems_partFeeAfterDiscount,changeItems_depreciation,changeItems_salvage,changeItems_recycleFlag,repairItems_itemId,repairItems_itemName,repairItems_manualFlag,repairItems_operationType,repairItems_partNo,repairItems_laborType,repairItems_laborHourFee,repairItems_laborFeeManageRate,repairItems_paintDiscountFlag,repairItems_laborHour,repairItems_laborFeeAfterDiscount,repairItems_outerRepairFlag,repairItems_outerLaborFee,materialItems_itemId,materialItems_itemName,materialItems_manualFlag,materialItems_materialUnit,materialItems_partQuantity,materialItems_unitPrice,materialItems_partFee,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
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
            strSql.Append(" Id,senderTelNo,senderName,vehicleOwnerName,vehicleOwnerTelNo,repairOrderNo,claimNo,sourceType,sendRepairFlag,insuranceCompanyGroupCode,insuranceCompanyGroupName,insuranceCompanyCode,insuranceCompanyName,repairFactoryCode,repairFactoryName,repairFacilityType,qualificationLevel,estimatorCode,estimatorName,workFlowNodeCode,workFlowNodeName,assignDate,estimateStartTime,estimateEndTime,reportNo,reportDate,lossVehicleTypeCode,lossVehicleType,plateNo,vin,brandModel,engineNo,vehicleCategoryCode,vehicleCategory,usingTypeCode,usingType,licenseFirstRegisterDate,purchasePrice,plateTypeCode,plateType,plateColorCode,plateColor,vehicleBodyColor,currentValue,fuelRemain,mileage,itemsInCar,mainCollisionPoints,subCollisionPoints,country,vehicleManufMakeName,vehicleSubModelName,attachmentCategoryName,attachmentUrl,attachmentId,attachmentName,partType,partTypeCode,manageRate,laborFeeManageRate,electricianMachinistRate,sheetMetalRate,paintRate,managementFee,multiPaintDiscountRate,changeItems_itemId,changeItems_itemName,changeItems_manualFlag,changeItems_partNo,changeItems_partQuantity,changeItems_unitPriceAfterDiscount,changeItems_partFeeAfterDiscount,changeItems_depreciation,changeItems_salvage,changeItems_recycleFlag,repairItems_itemId,repairItems_itemName,repairItems_manualFlag,repairItems_operationType,repairItems_partNo,repairItems_laborType,repairItems_laborHourFee,repairItems_laborFeeManageRate,repairItems_paintDiscountFlag,repairItems_laborHour,repairItems_laborFeeAfterDiscount,repairItems_outerRepairFlag,repairItems_outerLaborFee,materialItems_itemId,materialItems_itemName,materialItems_manualFlag,materialItems_materialUnit,materialItems_partQuantity,materialItems_unitPrice,materialItems_partFee,feeTotal_partFee,feeTotal_laborFee,feeTotal_materialFee,feeTotal_entireSalvage,feeTotal_totalSalvage,feeTotal_depreciation,feeTotal_manageFee,feeTotal_estimateAmount,feeTotal_rescueFee,feeTotal_lossTotal ");
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

        

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}
