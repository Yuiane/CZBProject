using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.CCCModel
{
    /// <summary>
    /// 
    /// </summary>
    public class Models
    {
        public string partyId { get; set; }
        public string businessNo { get; set; }
        public ContentInfo content { get; set; }
    }

    public class ContentInfo
    {
        public Accinfo accInfo { get; set; }
        public List<Claimattachment> claimAttachments { get; set; }
        public Claiminfo claimInfo { get; set; }
        public Contact contact { get; set; }
        public Discountrate discountRate { get; set; }
        public Feetotal feeTotal { get; set; }
        public Insurancecompany insuranceCompany { get; set; }
        public Lossitem lossItem { get; set; }
        public Repairfacility repairFacility { get; set; }
        public Vehicleinfo vehicleInfo { get; set; }
        public Workflow workflow { get; set; }
    }

    public class Accinfo
    {
        public string reportDate { get; set; }
        public string reportNo { get; set; }
    }

    public class Claiminfo
    {
        public string claimNo { get; set; }
        public string claimVersion { get; set; }
        public string repairOrderNo { get; set; }
        public string sendRepairFlag { get; set; }
        public string sourceType { get; set; }
    }

    public class Contact
    {
        public string senderName { get; set; }
        public string senderTelNo { get; set; }
        public string vehicleOwnerName { get; set; }
        public string vehicleOwnerTelNo { get; set; }
    }

    public class Discountrate
    {
        public string electricianMachinistRate { get; set; }
        public string laborFeeManageRate { get; set; }
        public string manageRate { get; set; }
        public string multiPaintDiscountRate { get; set; }
        public string paintRate { get; set; }
        public string partType { get; set; }
        public string partTypeCode { get; set; }
        public string sheetMetalRate { get; set; }
    }

    public class Feetotal
    {
        public string deductionTotalLaborFee { get; set; }
        public string depreciation { get; set; }
        public string entireSalvage { get; set; }
        public string estimateAmount { get; set; }
        public string laborFee { get; set; }
        public string lossTotal { get; set; }
        public string manageFee { get; set; }
        public string materialFee { get; set; }
        public string partFee { get; set; }
        public string rescueFee { get; set; }
        public string totalSalvage { get; set; }
    }

    public class Insurancecompany
    {
        public string insuranceCompanyCode { get; set; }
        public string insuranceCompanyGroupCode { get; set; }
        public string insuranceCompanyGroupName { get; set; }
        public string insuranceCompanyName { get; set; }
    }

    public class Lossitem
    {
        public List<Changeitem> changeItems { get; set; }
        public List<Materialitem> materialItems { get; set; }
        public List<Repairitem> repairItems { get; set; }
    }

    public class Changeitem
    {
        public string depreciation { get; set; }
        public string itemId { get; set; }
        public string itemName { get; set; }
        public string manualFlag { get; set; }
        public string partFeeAfterDiscount { get; set; }
        public string partNo { get; set; }
        public string partQuantity { get; set; }
        public string recycleFlag { get; set; }
        public string salvage { get; set; }
        public string unitPriceAfterDiscount { get; set; }
    }

    public class Materialitem
    {
        public string itemId { get; set; }
        public string itemName { get; set; }
        public string manualFlag { get; set; }
        public string partFee { get; set; }
        public string partQuantity { get; set; }
        public string unitPrice { get; set; }
    }

    public class Repairitem
    {
        public string itemId { get; set; }
        public string itemName { get; set; }
        public string laborFeeAfterDiscount { get; set; }
        public string laborFeeManageRate { get; set; }
        public string laborHour { get; set; }
        public string laborHourFee { get; set; }
        public string laborType { get; set; }
        public string manualFlag { get; set; }
        public string operationType { get; set; }
        public string outerLaborFee { get; set; }
        public string outerRepairFlag { get; set; }
        public string partNo { get; set; }
        public string paintDiscountFlag { get; set; }
    }

    public class Repairfacility
    {
        public string appraiserCode { get; set; }
        public string appraiserName { get; set; }
        public string qualificationLevel { get; set; }
        public string repairFacilityCode { get; set; }
        public string repairFacilityName { get; set; }
        public string repairFacilityType { get; set; }
    }

    public class Vehicleinfo
    {
        public Baseinfo baseInfo { get; set; }
        public Lossinfo lossInfo { get; set; }
        public Vehiclemodel vehicleModel { get; set; }
    }

    public class Baseinfo
    {
        public string brandModel { get; set; }
        public string currentValue { get; set; }
        public string engineNo { get; set; }
        public string licenseFirstRegisterDate { get; set; }
        public string lossVehicleType { get; set; }
        public string lossVehicleTypeCode { get; set; }
        public string plateColor { get; set; }
        public string plateColorCode { get; set; }
        public string plateNo { get; set; }
        public string plateType { get; set; }
        public string plateTypeCode { get; set; }
        public int purchasePrice { get; set; }
        public string usingType { get; set; }
        public string usingTypeCode { get; set; }
        public string vehicleBodyColor { get; set; }
        public string vehicleCategory { get; set; }
        public string vehicleCategoryCode { get; set; }
        public string vin { get; set; }
    }

    public class Lossinfo
    {
        public string fuelRemain { get; set; }
        public string itemsInCar { get; set; }
        public string mainCollisionPoints { get; set; }
        public string mileage { get; set; }
        public string subCollisionPoints { get; set; }
    }

    public class Vehiclemodel
    {
        public string country { get; set; }
        public string vehicleManufMakeName { get; set; }
        public string vehicleSubModelName { get; set; }
    }

    public class Workflow
    {
        public string assignDate { get; set; }
        public string estimateEndTime { get; set; }
        public string estimateStartTime { get; set; }
        public string workFlowNodeCode { get; set; }
        public string workFlowNodeName { get; set; }
    }

    public class Claimattachment
    {
        public string attachmentCategoryName { get; set; }
        public string attachmentId { get; set; }
        public string attachmentName { get; set; }
        public string attachmentUrl { get; set; }
    }

}
