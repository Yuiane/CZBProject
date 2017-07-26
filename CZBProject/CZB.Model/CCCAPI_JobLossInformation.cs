/**  版本信息模板在安装目录下，可自行修改。
* CCCAPI_JobLossInformation.cs
*
* 功 能： N/A
* 类 名： CCCAPI_JobLossInformation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/7/26 17:56:47   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace CZB.Model
{
    /// <summary>
    /// CCCAPI_JobLossInformation:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class CCCAPI_JobLossInformation
    {
        public CCCAPI_JobLossInformation()
        { }
        #region Model
        private string _id;
        private string _sendertelno;
        private string _sendername;
        private string _vehicleownername;
        private string _vehicleownertelno;
        private string _repairorderno;
        private string _claimno;
        private string _sourcetype;
        private string _sendrepairflag;
        private string _insurancecompanygroupcode;
        private string _insurancecompanygroupname;
        private string _insurancecompanycode;
        private string _insurancecompanyname;
        private string _repairfactorycode;
        private string _repairfactoryname;
        private string _repairfacilitytype;
        private string _qualificationlevel;
        private string _estimatorcode;
        private string _estimatorname;
        private string _workflownodecode;
        private string _workflownodename;
        private DateTime _assigndate;
        private DateTime _estimatestarttime;
        private DateTime _estimateendtime;
        private string _reportno;
        private DateTime? _reportdate;
        private string _lossvehicletypecode;
        private string _lossvehicletype;
        private string _plateno;
        private string _vin;
        private string _brandmodel;
        private string _engineno;
        private string _vehiclecategorycode;
        private string _vehiclecategory;
        private string _usingtypecode;
        private string _usingtype;
        private DateTime? _licensefirstregisterdate;
        private decimal? _purchaseprice;
        private string _platetypecode;
        private string _platetype;
        private string _platecolorcode;
        private string _platecolor;
        private string _vehiclebodycolor;
        private decimal? _currentvalue;
        private decimal? _fuelremain;
        private decimal? _mileage;
        private string _itemsincar;
        private string _maincollisionpoints;
        private string _subcollisionpoints;
        private string _country;
        private string _vehiclemanufmakename;
        private string _vehiclesubmodelname;
        private string _attachmentcategoryname;
        private string _attachmenturl;
        private int? _attachmentid;
        private string _attachmentname;
        private string _parttype;
        private string _parttypecode;
        private decimal _managerate;
        private decimal _laborfeemanagerate;
        private decimal _electricianmachinistrate;
        private decimal _sheetmetalrate;
        private decimal _paintrate;
        private decimal _managementfee;
        private decimal _multipaintdiscountrate;
        private int _changeitems_itemid;
        private string _changeitems_itemname;
        private bool _changeitems_manualflag;
        private string _changeitems_partno;
        private int _changeitems_partquantity;
        private decimal _changeitems_unitpriceafterdiscount;
        private decimal _changeitems_partfeeafterdiscount;
        private decimal? _changeitems_depreciation;
        private decimal? _changeitems_salvage;
        private bool _changeitems_recycleflag;
        private int _repairitems_itemid;
        private string _repairitems_itemname;
        private bool _repairitems_manualflag;
        private string _repairitems_operationtype;
        private string _repairitems_partno;
        private string _repairitems_labortype;
        private decimal _repairitems_laborhourfee;
        private decimal _repairitems_laborfeemanagerate;
        private bool _repairitems_paintdiscountflag;
        private decimal? _repairitems_laborhour;
        private decimal _repairitems_laborfeeafterdiscount;
        private bool _repairitems_outerrepairflag;
        private decimal? _repairitems_outerlaborfee;
        private int _materialitems_itemid;
        private string _materialitems_itemname;
        private bool _materialitems_manualflag;
        private string _materialitems_materialunit;
        private decimal _materialitems_partquantity;
        private decimal _materialitems_unitprice;
        private decimal _materialitems_partfee;
        private decimal _feetotal_partfee;
        private decimal _feetotal_laborfee;
        private decimal _feetotal_materialfee;
        private decimal _feetotal_entiresalvage;
        private decimal _feetotal_totalsalvage;
        private decimal _feetotal_depreciation;
        private decimal _feetotal_managefee;
        private decimal _feetotal_estimateamount;
        private decimal _feetotal_rescuefee;
        private decimal _feetotal_losstotal;
        /// <summary>
        /// 
        /// </summary>
        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string senderTelNo
        {
            set { _sendertelno = value; }
            get { return _sendertelno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string senderName
        {
            set { _sendername = value; }
            get { return _sendername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleOwnerName
        {
            set { _vehicleownername = value; }
            get { return _vehicleownername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleOwnerTelNo
        {
            set { _vehicleownertelno = value; }
            get { return _vehicleownertelno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairOrderNo
        {
            set { _repairorderno = value; }
            get { return _repairorderno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string claimNo
        {
            set { _claimno = value; }
            get { return _claimno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sourceType
        {
            set { _sourcetype = value; }
            get { return _sourcetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sendRepairFlag
        {
            set { _sendrepairflag = value; }
            get { return _sendrepairflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string insuranceCompanyGroupCode
        {
            set { _insurancecompanygroupcode = value; }
            get { return _insurancecompanygroupcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string insuranceCompanyGroupName
        {
            set { _insurancecompanygroupname = value; }
            get { return _insurancecompanygroupname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string insuranceCompanyCode
        {
            set { _insurancecompanycode = value; }
            get { return _insurancecompanycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string insuranceCompanyName
        {
            set { _insurancecompanyname = value; }
            get { return _insurancecompanyname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairFactoryCode
        {
            set { _repairfactorycode = value; }
            get { return _repairfactorycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairFactoryName
        {
            set { _repairfactoryname = value; }
            get { return _repairfactoryname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairFacilityType
        {
            set { _repairfacilitytype = value; }
            get { return _repairfacilitytype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string qualificationLevel
        {
            set { _qualificationlevel = value; }
            get { return _qualificationlevel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string estimatorCode
        {
            set { _estimatorcode = value; }
            get { return _estimatorcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string estimatorName
        {
            set { _estimatorname = value; }
            get { return _estimatorname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string workFlowNodeCode
        {
            set { _workflownodecode = value; }
            get { return _workflownodecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string workFlowNodeName
        {
            set { _workflownodename = value; }
            get { return _workflownodename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime assignDate
        {
            set { _assigndate = value; }
            get { return _assigndate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime estimateStartTime
        {
            set { _estimatestarttime = value; }
            get { return _estimatestarttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime estimateEndTime
        {
            set { _estimateendtime = value; }
            get { return _estimateendtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string reportNo
        {
            set { _reportno = value; }
            get { return _reportno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? reportDate
        {
            set { _reportdate = value; }
            get { return _reportdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lossVehicleTypeCode
        {
            set { _lossvehicletypecode = value; }
            get { return _lossvehicletypecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lossVehicleType
        {
            set { _lossvehicletype = value; }
            get { return _lossvehicletype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plateNo
        {
            set { _plateno = value; }
            get { return _plateno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vin
        {
            set { _vin = value; }
            get { return _vin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string brandModel
        {
            set { _brandmodel = value; }
            get { return _brandmodel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string engineNo
        {
            set { _engineno = value; }
            get { return _engineno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleCategoryCode
        {
            set { _vehiclecategorycode = value; }
            get { return _vehiclecategorycode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleCategory
        {
            set { _vehiclecategory = value; }
            get { return _vehiclecategory; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string usingTypeCode
        {
            set { _usingtypecode = value; }
            get { return _usingtypecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string usingType
        {
            set { _usingtype = value; }
            get { return _usingtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? licenseFirstRegisterDate
        {
            set { _licensefirstregisterdate = value; }
            get { return _licensefirstregisterdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? purchasePrice
        {
            set { _purchaseprice = value; }
            get { return _purchaseprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plateTypeCode
        {
            set { _platetypecode = value; }
            get { return _platetypecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plateType
        {
            set { _platetype = value; }
            get { return _platetype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plateColorCode
        {
            set { _platecolorcode = value; }
            get { return _platecolorcode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string plateColor
        {
            set { _platecolor = value; }
            get { return _platecolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleBodyColor
        {
            set { _vehiclebodycolor = value; }
            get { return _vehiclebodycolor; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? currentValue
        {
            set { _currentvalue = value; }
            get { return _currentvalue; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? fuelRemain
        {
            set { _fuelremain = value; }
            get { return _fuelremain; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? mileage
        {
            set { _mileage = value; }
            get { return _mileage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string itemsInCar
        {
            set { _itemsincar = value; }
            get { return _itemsincar; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mainCollisionPoints
        {
            set { _maincollisionpoints = value; }
            get { return _maincollisionpoints; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string subCollisionPoints
        {
            set { _subcollisionpoints = value; }
            get { return _subcollisionpoints; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string country
        {
            set { _country = value; }
            get { return _country; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleManufMakeName
        {
            set { _vehiclemanufmakename = value; }
            get { return _vehiclemanufmakename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string vehicleSubModelName
        {
            set { _vehiclesubmodelname = value; }
            get { return _vehiclesubmodelname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attachmentCategoryName
        {
            set { _attachmentcategoryname = value; }
            get { return _attachmentcategoryname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attachmentUrl
        {
            set { _attachmenturl = value; }
            get { return _attachmenturl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? attachmentId
        {
            set { _attachmentid = value; }
            get { return _attachmentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attachmentName
        {
            set { _attachmentname = value; }
            get { return _attachmentname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string partType
        {
            set { _parttype = value; }
            get { return _parttype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string partTypeCode
        {
            set { _parttypecode = value; }
            get { return _parttypecode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal manageRate
        {
            set { _managerate = value; }
            get { return _managerate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal laborFeeManageRate
        {
            set { _laborfeemanagerate = value; }
            get { return _laborfeemanagerate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal electricianMachinistRate
        {
            set { _electricianmachinistrate = value; }
            get { return _electricianmachinistrate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal sheetMetalRate
        {
            set { _sheetmetalrate = value; }
            get { return _sheetmetalrate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal paintRate
        {
            set { _paintrate = value; }
            get { return _paintrate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal managementFee
        {
            set { _managementfee = value; }
            get { return _managementfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal multiPaintDiscountRate
        {
            set { _multipaintdiscountrate = value; }
            get { return _multipaintdiscountrate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int changeItems_itemId
        {
            set { _changeitems_itemid = value; }
            get { return _changeitems_itemid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string changeItems_itemName
        {
            set { _changeitems_itemname = value; }
            get { return _changeitems_itemname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool changeItems_manualFlag
        {
            set { _changeitems_manualflag = value; }
            get { return _changeitems_manualflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string changeItems_partNo
        {
            set { _changeitems_partno = value; }
            get { return _changeitems_partno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int changeItems_partQuantity
        {
            set { _changeitems_partquantity = value; }
            get { return _changeitems_partquantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal changeItems_unitPriceAfterDiscount
        {
            set { _changeitems_unitpriceafterdiscount = value; }
            get { return _changeitems_unitpriceafterdiscount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal changeItems_partFeeAfterDiscount
        {
            set { _changeitems_partfeeafterdiscount = value; }
            get { return _changeitems_partfeeafterdiscount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? changeItems_depreciation
        {
            set { _changeitems_depreciation = value; }
            get { return _changeitems_depreciation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? changeItems_salvage
        {
            set { _changeitems_salvage = value; }
            get { return _changeitems_salvage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool changeItems_recycleFlag
        {
            set { _changeitems_recycleflag = value; }
            get { return _changeitems_recycleflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int repairItems_itemId
        {
            set { _repairitems_itemid = value; }
            get { return _repairitems_itemid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairItems_itemName
        {
            set { _repairitems_itemname = value; }
            get { return _repairitems_itemname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool repairItems_manualFlag
        {
            set { _repairitems_manualflag = value; }
            get { return _repairitems_manualflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairItems_operationType
        {
            set { _repairitems_operationtype = value; }
            get { return _repairitems_operationtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairItems_partNo
        {
            set { _repairitems_partno = value; }
            get { return _repairitems_partno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string repairItems_laborType
        {
            set { _repairitems_labortype = value; }
            get { return _repairitems_labortype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal repairItems_laborHourFee
        {
            set { _repairitems_laborhourfee = value; }
            get { return _repairitems_laborhourfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal repairItems_laborFeeManageRate
        {
            set { _repairitems_laborfeemanagerate = value; }
            get { return _repairitems_laborfeemanagerate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool repairItems_paintDiscountFlag
        {
            set { _repairitems_paintdiscountflag = value; }
            get { return _repairitems_paintdiscountflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? repairItems_laborHour
        {
            set { _repairitems_laborhour = value; }
            get { return _repairitems_laborhour; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal repairItems_laborFeeAfterDiscount
        {
            set { _repairitems_laborfeeafterdiscount = value; }
            get { return _repairitems_laborfeeafterdiscount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool repairItems_outerRepairFlag
        {
            set { _repairitems_outerrepairflag = value; }
            get { return _repairitems_outerrepairflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? repairItems_outerLaborFee
        {
            set { _repairitems_outerlaborfee = value; }
            get { return _repairitems_outerlaborfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int materialItems_itemId
        {
            set { _materialitems_itemid = value; }
            get { return _materialitems_itemid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string materialItems_itemName
        {
            set { _materialitems_itemname = value; }
            get { return _materialitems_itemname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool materialItems_manualFlag
        {
            set { _materialitems_manualflag = value; }
            get { return _materialitems_manualflag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string materialItems_materialUnit
        {
            set { _materialitems_materialunit = value; }
            get { return _materialitems_materialunit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal materialItems_partQuantity
        {
            set { _materialitems_partquantity = value; }
            get { return _materialitems_partquantity; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal materialItems_unitPrice
        {
            set { _materialitems_unitprice = value; }
            get { return _materialitems_unitprice; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal materialItems_partFee
        {
            set { _materialitems_partfee = value; }
            get { return _materialitems_partfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_partFee
        {
            set { _feetotal_partfee = value; }
            get { return _feetotal_partfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_laborFee
        {
            set { _feetotal_laborfee = value; }
            get { return _feetotal_laborfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_materialFee
        {
            set { _feetotal_materialfee = value; }
            get { return _feetotal_materialfee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_entireSalvage
        {
            set { _feetotal_entiresalvage = value; }
            get { return _feetotal_entiresalvage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_totalSalvage
        {
            set { _feetotal_totalsalvage = value; }
            get { return _feetotal_totalsalvage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_depreciation
        {
            set { _feetotal_depreciation = value; }
            get { return _feetotal_depreciation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_manageFee
        {
            set { _feetotal_managefee = value; }
            get { return _feetotal_managefee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_estimateAmount
        {
            set { _feetotal_estimateamount = value; }
            get { return _feetotal_estimateamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_rescueFee
        {
            set { _feetotal_rescuefee = value; }
            get { return _feetotal_rescuefee; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal feeTotal_lossTotal
        {
            set { _feetotal_losstotal = value; }
            get { return _feetotal_losstotal; }
        }
        #endregion Model

    }
}

