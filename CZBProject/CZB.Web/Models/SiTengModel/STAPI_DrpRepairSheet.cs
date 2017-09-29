using System.Collections.Generic;

namespace CZB.Model
{
    public partial class STAPI_DrpRepairSheet
    {
        /// <summary>
        /// CCC分发给修理厂的partyId
        /// </summary>
        public string drpDeptId { set; get; }

        /// <summary>
        /// 定损单信息
        /// </summary>
        public drpRepairSheet drpRepairSheet { set; get; }

        /// <summary>
        /// 定损单更换项目
        /// </summary>
        public List<drpChangeItems> drpChangeItems { set; get; }

        /// <summary>
        /// 定损单维修项目
        /// </summary>
        public List<drpRepairItems> drpRepairItems { set; get; }

        /// <summary>
        /// 定损单辅料项目
        /// </summary>
        public List<drpMaterialItems> drpMaterialItems { set; get; }

        /// <summary>
        /// 定损单附件
        /// </summary>
        public List<drpAttachments> drpAttachments { set; get; }
    }

    public partial class drpRepairSheet
    {
        /// <summary>
        /// 联系人电话
        /// </summary>
        public string senderTelNo { set; get; }
        /// <summary>
        /// 联系人姓名
        /// </summary>
        public string senderName { set; get; }
        /// <summary>
        /// 车主
        /// </summary>
        public string vehicleOwnerName { set; get; }
        /// <summary>
        /// 车主电话
        /// </summary>
        public string vehicleOwnerTelNo { set; get; }
        /// <summary>
        /// DRP工单号
        /// </summary>
        public string repairOrderNo { set; get; }
        /// <summary>
        /// 定损单号
        /// </summary>
        public string claimNo { set; get; }
        /// <summary>
        /// 业务来源
        /// </summary>
        public string sourceType { set; get; }
        /// <summary>
        /// 送修/返修标记
        /// </summary>
        public string sendRepairFlag { set; get; }
        /// <summary>
        /// 保险公司Code
        /// </summary>
        public string insuranceCompanyGroupCode { set; get; }
        /// <summary>
        /// 保险公司名称
        /// </summary>
        public string insuranceCompanyGroupName { set; get; }
        /// <summary>
        /// 保险公司分支机构Code
        /// </summary>
        public string insuranceCompanyCode { set; get; }
        /// <summary>
        /// 保险公司分支机构名称
        /// </summary>
        public string insuranceCompanyName { set; get; }
        /// <summary>
        /// 修理厂Code
        /// </summary>
        public string repairFactoryCode { set; get; }
        /// <summary>
        /// 修理厂名称
        /// </summary>
        public string repairFactoryName { set; get; }
        /// <summary>
        /// 修理厂类型
        /// </summary>
        public string repairFacilityType { set; get; }
        /// <summary>
        /// 修理厂资质
        /// </summary>
        public string qualificationLevel { set; get; }
        /// <summary>
        /// 维修顾问账号
        /// </summary>
        public string estimatorCode { set; get; }
        /// <summary>
        /// 维修顾问姓名
        /// </summary>
        public string estimatorName { set; get; }
        /// <summary>
        /// 定损状态环节Code
        /// </summary>
        public string workFlowNodeCode { set; get; }
        /// <summary>
        /// 定损状态环节名称
        /// </summary>
        public string workFlowNodeName { set; get; }

        /// <summary>
        /// 任务分配时间
        /// </summary>
        public string assignDate { set; get; }
        /// <summary>
        /// 定损开始时间
        /// </summary>
        public string estimateStartTime { set; get; }
        /// <summary>
        /// 定损完成时间
        /// </summary>
        public string estimateEndTime { set; get; }

        /// <summary>
        /// 报案号
        /// </summary>
        public string reportNo { set; get; }
        /// <summary>
        /// 报案时间
        /// </summary>
        public string reportDate { set; get; }
        /// <summary>
        /// 损失车辆Code
        /// </summary>
        public string lossVehicleTypeCode { set; get; }
        /// <summary>
        /// 损失车辆
        /// </summary>
        public string lossVehicleType { set; get; }
        /// <summary>
        /// 车牌号
        /// </summary>
        public string plateNo { set; get; }
        /// <summary>
        /// VIN码
        /// </summary>
        public string vin { set; get; }
        /// <summary>
        /// 品牌型号
        /// </summary>
        public string brandModel { set; get; }
        /// <summary>
        /// 发动机号
        /// </summary>
        public string engineNo { set; get; }
        /// <summary>
        /// 车辆种类Code
        /// </summary>
        public string vehicleCategoryCode { set; get; }
        /// <summary>
        /// 车辆种类
        /// </summary>
        public string vehicleCategory { set; get; }
        /// <summary>
        /// 使用性质Code
        /// </summary>
        public string usingTypeCode { set; get; }
        /// <summary>
        /// 使用性质
        /// </summary>
        public string usingType { set; get; }
        /// <summary>
        /// 行驶证初次登记日期
        /// </summary>
        public string licenseFirstRegisterDate { set; get; }
        /// <summary>
        /// 新车购置价（万）
        /// </summary>
        public decimal purchasePrice { set; get; }

        /// <summary>
        /// 号牌种类Code
        /// </summary>
        public string plateTypeCode { set; get; }
        /// <summary>
        /// 号牌种类
        /// </summary>
        public string plateType { set; get; }
        /// <summary>
        /// 号牌底色Code
        /// </summary>
        public string plateColorCode { set; get; }
        /// <summary>
        /// 号牌底色
        /// </summary>
        public string plateColor { set; get; }
        /// <summary>
        /// 车身颜色
        /// </summary>
        public string vehicleBodyColor { set; get; }
        /// <summary>
        /// 车辆现值/保额（万）
        /// </summary>
        public decimal currentValue { set; get; }
        /// <summary>
        /// 剩余燃料
        /// </summary>
        public decimal fuelRemain { set; get; }
        /// <summary>
        /// 行驶里程（公里）
        /// </summary>
        public decimal mileage { set; get; }
        /// <summary>
        /// 车内物品
        /// </summary>
        public string itemsInCar { set; get; }
        /// <summary>
        /// 碰撞点-主
        /// </summary>
        public string mainCollisionPoints { set; get; }
        /// <summary>
        /// 碰撞点-次
        /// </summary>
        public string subCollisionPoints { set; get; }
        /// <summary>
        /// 车辆国别
        /// </summary>
        public string country { set; get; }
        /// <summary>
        /// 车辆厂牌名称
        /// </summary>
        public string vehicleManufMakeName { set; get; }
        /// <summary>
        /// 车辆款型
        /// </summary>
        public string vehicleSubModelName { set; get; }
        /// <summary>
        /// 配件渠道名称
        /// </summary>
        public string partType { set; get; }
        /// <summary>
        /// 配件渠道CODE
        /// </summary>
        public string partTypeCode { set; get; }
        /// <summary>
        /// 配件折扣率
        /// </summary>
        public decimal manageRate { set; get; }
        /// <summary>
        /// 工时折扣率
        /// </summary>
        public decimal laborFeeManageRate { set; get; }
        /// <summary>
        /// 机电
        /// </summary>
        public decimal electricianMachinistRate { set; get; }
        /// <summary>
        /// 钣金
        /// </summary>
        public decimal sheetMetalRate { set; get; }
        /// <summary>
        /// 喷漆
        /// </summary>
        public decimal paintRate { set; get; }
        /// <summary>
        /// 管理费率
        /// </summary>
        public decimal managementFee { set; get; }
        /// <summary>
        /// 多面喷漆折扣率
        /// </summary>
        public decimal multiPaintDiscountRate { set; get; }
        /// <summary>
        /// 配件费用
        /// </summary>
        public decimal partFee { set; get; }
        /// <summary>
        /// 工时费用
        /// </summary>
        public decimal laborFee { set; get; }
        /// <summary>
        /// 辅料费用
        /// </summary>
        public decimal materialFee { set; get; }
        /// <summary>
        /// 整单残值
        /// </summary>
        public decimal entireSalvage { set; get; }
        /// <summary>
        /// 残值总计
        /// </summary>
        public decimal totalSalvage { set; get; }
        /// <summary>
        /// 折旧费
        /// </summary>
        public decimal depreciation { set; get; }
        /// <summary>
        /// 管理费
        /// </summary>
        public decimal manageFee { set; get; }
        /// <summary>
        /// 定损金额
        /// </summary>
        public decimal estimateAmount { set; get; }
        /// <summary>
        /// 施救费
        /// </summary>
        public decimal rescueFee { set; get; }

        /// <summary>
        /// 损失金额
        /// </summary>
        public decimal lossTotal { get; set; }
    }


    public partial class drpChangeItems
    {
        /// <summary>
        /// 损失项目Id
        /// </summary>
        public string itemId { set; get; }
        /// <summary>
        /// 损失项目名称
        /// </summary>
        public string itemName { set; get; }
        /// <summary>
        /// 配件编号
        /// </summary>
        public string partNo { set; get; }
        /// <summary>
        /// 自定义配件
        /// </summary>
        public bool manualFlag { set; get; }
        /// <summary>
        /// 是否回收
        /// </summary>
        public bool recycleFlag { set; get; }
        /// <summary>
        /// 配件数量
        /// </summary>
        public decimal partQuantity { set; get; }
        /// <summary>
        /// 折后单价
        /// </summary>
        public decimal unitPriceAfterDiscount { set; get; }
        /// <summary>
        /// 折后配件费
        /// </summary>
        public decimal partFeeAfterDiscount { set; get; }
        /// <summary>
        /// 折旧费
        /// </summary>
        public decimal depreciation { set; get; }
        /// <summary>
        /// 折旧费
        /// </summary>
        public decimal salvage { set; get; }

    }




    public partial class drpRepairItems
    {
        /// <summary>
        /// 损失项目Id
        /// </summary>
        public string itemId { set; get; }
        /// <summary>
        /// 损失项目名称
        /// </summary>
        public string itemName { set; get; }
        /// <summary>
        /// 自定义配件
        /// </summary>
        public bool manualFlag { set; get; }
        /// <summary>
        /// 操作类型
        /// </summary>
        public string operationType { set; get; }
        /// <summary>
        /// 配件编号
        /// </summary>
        public string partNo { set; get; }
        /// <summary>
        /// 工种
        /// </summary>
        public string laborType { set; get; }
        /// <summary>
        /// 单位单价
        /// </summary>
        public decimal laborHourFee { set; get; }
        /// <summary>
        /// 工时折扣率
        /// </summary>
        public decimal laborFeeManageRate { set; get; }
        /// <summary>
        /// 是否参与多面喷漆折扣
        /// </summary>
        public bool paintDiscountFlag { set; get; }
        /// <summary>
        /// 工时数
        /// </summary>
        public decimal laborHour { set; get; }
        /// <summary>
        /// 折后工时费
        /// </summary>
        public decimal laborFeeAfterDiscount { set; get; }
        /// <summary>
        /// 是否外修
        /// </summary>
        public bool outerRepairFlag { set; get; }
        /// <summary>
        /// 外修费用
        /// </summary>
        public decimal outerLaborFee { set; get; }
    }


    public partial class drpMaterialItems
    {
        /// <summary>
        /// 损失项目Id
        /// </summary>
        public string itemId { set; get; }
        /// <summary>
        /// 损失项目名称
        /// </summary>
        public string itemName { set; get; }
        /// <summary>
        /// 自定义辅料
        /// </summary>
        public bool manualFlag { set; get; }
        /// <summary>
        /// 辅料单位
        /// </summary>
        public string materialUnit { set; get; }
        /// <summary>
        /// 辅料数量
        /// </summary>
        public decimal partQuantity { set; get; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal unitPrice { set; get; }
        /// <summary>
        /// 辅料费
        /// </summary>
        public decimal partFee { set; get; }


    }


    public partial class drpAttachments
    {
        /// <summary>
        /// 附件分类
        /// </summary>
        public string attachmentCategoryName { set; get; }
        /// <summary>
        /// 压缩包内附件位置
        /// </summary>
        public string attachmentUrl { set; get; }
        /// <summary>
        /// 附件ID
        /// </summary>
        public string attachmentId { set; get; }
        /// <summary>
        /// 附件文件
        /// </summary>
        public string attachmentName { set; get; }


    }


}
