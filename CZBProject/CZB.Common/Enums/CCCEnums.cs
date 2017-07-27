using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.Enums
{
    #region 接口码表映射文档
    /// <summary>
    /// 修理厂类型
    /// </summary>
    public enum RepairFactoryType
    {
        //特约维修站
        [Description("01")]
        SpecialMaintenanceStation,

        /// <summary>
        /// 修理厂
        /// </summary>
        [Description("02")]
        RepairDepot
    }

    /// <summary>
    /// 修理厂资质
    /// </summary>
    public enum QualificationLevel
    {
        /// <summary>
        /// 普通一类厂
        /// </summary>
        [Description("01")]
        GeneralOneFactory,

        /// <summary>
        /// 普通二类厂
        /// </summary>
        [Description("02")]
        GeneralTwoFactory,

        /// <summary>
        /// 普通三类厂
        /// </summary>
        [Description("03")]
        GeneralThreeFactory
    }

    /// <summary>
    /// 操作类型
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// 换件
        /// </summary>
        [Description("01")]
        Overhaul,

        /// <summary>
        /// 维修
        /// </summary>
        [Description("02")]
        Repair,

        /// <summary>
        /// 喷漆
        /// </summary>
        [Description("03")]
        Paint,

        /// <summary>
        /// 拆装
        /// </summary>
        [Description("04")]
        Disassembly,

        /// <summary>
        /// 辅料
        /// </summary>
        [Description("05")]
        Accessories,

        /// <summary>
        /// 工时扣减
        /// </summary>
        [Description("06")]
        TimeDeduction
    }

    /// <summary>
    /// 业务来源
    /// </summary>
    public enum SourceType
    {
        /// <summary>
        /// 修理厂工单
        /// </summary>
        [Description("0")]
        RepairShopWorkOrder,

        /// <summary>
        /// 保险公司付费
        /// </summary>
        [Description("1")]
        InsuranceCompaniesPay,

        /// <summary>
        /// 与保险公司没有合作协议
        /// </summary>
        [Description("2")]
        NoCooperationAgreementWithInsuranceCompany
    }

    /// <summary>
    /// 工种
    /// </summary>
    public enum LaborType
    {
        /// <summary>
        /// 机电
        /// </summary>
        [Description("M")]
        M,

        /// <summary>
        /// 钣金
        /// </summary>
        [Description("B")]
        B,

        /// <summary>
        /// 喷漆
        /// </summary>
        [Description("P")]
        P
    }

    /// <summary>
    /// 损失车辆
    /// </summary>
    public enum LossVehicleType
    {
        /// <summary>
        /// 标的车
        /// </summary>
        [Description("01")]
        TargetCar,

        /// <summary>
        /// 三者车
        /// </summary>
        [Description("02")]
        ThreePartyCar
    }

    /// <summary>
    /// 车辆种类
    /// </summary>
    public enum VehicleCategory
    {
        /// <summary>
        /// 9座以下客车
        /// </summary>
        [Description("01")]
        Passenger9CarsBelow,

        /// <summary>
        /// 其他车辆
        /// </summary>
        [Description("999")]
        OtherVehicles
    }

    /// <summary>
    /// 使用性质
    /// </summary>
    public enum UsingType
    {
        /// <summary>
        /// 家庭自用
        /// </summary>
        [Description("01")]
        HomeUse,

        /// <summary>
        /// 非营业
        /// </summary>
        [Description("02")]
        NonOperating,

        /// <summary>
        /// 营业出租
        /// </summary>
        [Description("03")]
        BusinessRent,

        /// <summary>
        /// 营业其他
        /// </summary>
        [Description("04")]
        OtherBusiness,

        /// <summary>
        /// 特种车
        /// </summary>
        [Description("05")]
        SpecialVehicle
    }

    /// <summary>
    /// 碰撞程度
    /// </summary>
    public enum LossDegree
    {
        /// <summary>
        /// 轻
        /// </summary>
        [Description("01")]
        Light,

        /// <summary>
        /// 中
        /// </summary>
        [Description("02")]
        In,

        /// <summary>
        /// 重
        /// </summary>
        [Description("03")]
        Heavy
    }

    /// <summary>
    /// 号牌种类
    /// </summary>
    public enum PlateType
    {
        /// <summary>
        /// 小型汽车号牌
        /// </summary>
        [Description("02")]
        SmallCarLicensePlate,

        /// <summary>
        /// 使馆汽车号牌
        /// </summary>
        [Description("03")]
        EmbassyCarNumberPlate,

        /// <summary>
        /// 领馆汽车号牌
        /// </summary>
        [Description("04")]
        ConsulateNumberPlate,

        /// <summary>
        /// 境外汽车号牌
        /// </summary>
        [Description("05")]
        ForeignCarLicensePlate,

        /// <summary>
        /// 外籍汽车号牌
        /// </summary>
        [Description("06")]
        ForeignNationalityCarLicensePlate,

        /// <summary>
        /// 武警号牌
        /// </summary>
        [Description("07")]
        ArmedPoliceLicensePlate,

        /// <summary>
        /// 公安号牌
        /// </summary>
        [Description("08")]
        PublicSecurityNumberPlate,

        /// <summary>
        /// 军队号牌
        /// </summary>
        [Description("09")]
        MilitaryLicensePlate,

        /// <summary>
        /// 其他号牌
        /// </summary>
        [Description("10")]
        OtherPlates
    }

    /// <summary>
    /// 碰撞点
    /// </summary>
    public enum CollisionPoints
    {
        /// <summary>
        /// 全车
        /// </summary>
        [Description("01")]
        TheWholeCar,

        /// <summary>
        /// 前部
        /// </summary>
        [Description("02")]
        Front,

        /// <summary>
        /// 左前部
        /// </summary>
        [Description("03")]
        LeftAnterior,

        /// <summary>
        /// 右前部
        /// </summary>
        [Description("04")]
        RightAnterior,

        /// <summary>
        /// 左侧
        /// </summary>
        [Description("05")]
        Left,

        /// <summary>
        /// 右侧
        /// </summary>
        [Description("06")]
        Right,

        /// <summary>
        /// 左后部
        /// </summary>
        [Description("07")]
        LeftRear,

        /// <summary>
        /// 右后部
        /// </summary>
        [Description("08")]
        RightRear,

        /// <summary>
        /// 底部
        /// </summary>
        [Description("09")]
        Bottom,

        /// <summary>
        /// 顶部
        /// </summary>
        [Description("10")]
        Top,

        /// <summary>
        /// 尾部
        /// </summary>
        [Description("11")]
        Tail,

        /// <summary>
        /// 内部
        /// </summary>
        [Description("12")]
        Inside,
    }

    /// <summary>
    /// 号牌底色
    /// </summary>
    public enum PlateColorId
    {
        /// <summary>
        /// 蓝色
        /// </summary>
        [Description("01")]
        Blue,

        /// <summary>
        /// 黑色
        /// </summary>
        [Description("02")]
        Black,

        /// <summary>
        /// 白色
        /// </summary>
        [Description("03")]
        White,

        /// <summary>
        /// 黄色
        /// </summary>
        [Description("04")]
        Yellow,

        /// <summary>
        /// 绿色
        /// </summary>
        [Description("99")]
        Green,

        /// <summary>
        /// 白蓝色
        /// </summary>
        [Description("05")]
        WhiteBlue,

        /// <summary>
        /// 其他
        /// </summary>
        [Description("999")]
        Other
    }

    /// <summary>
    /// 维修状态
    /// </summary>
    public enum RepairOrderType
    {
        /// <summary>
        /// 维修中
        /// </summary>
        [Description("60")]
        InMaintenance,

        /// <summary>
        /// 已完成
        /// </summary>
        [Description("70")]
        Completed,
    }

    /// <summary>
    /// 配件渠道
    /// </summary>
    public enum PartType
    {
        /// <summary>
        /// 4S店价
        /// </summary>
        [Description("01")]
        Shop4SPrice,

        /// <summary>
        /// 市场价
        /// </summary>
        [Description("02")]
        MarketValue
    }

    /// <summary>
    /// 消息通知发送方式
    /// </summary>
    public enum MessageSendType
    {
        /// <summary>
        /// 短信
        /// </summary>
        [Description("1")]
        Message,

        /// <summary>
        /// 微信
        /// </summary>
        [Description("2")]
        WeChat,

        /// <summary>
        /// 短信+微信
        /// </summary>
        [Description("4")]
        WeChatAndMessage
    }

    /// <summary>
    /// 定核损状态
    /// </summary>
    public enum WorkFlowNode
    {
        /// <summary>
        /// 定损
        /// </summary>
        [Description("01")]
        ToAssessTheDamage,

        /// <summary>
        /// 核损
        /// </summary>
        [Description("03")]
        NuclearDamage,

        /// <summary>
        /// 定核损结束
        /// </summary>
        [Description("04")]
        EndOfDefiniteNuclearDamage,

        /// <summary>
        /// 取消
        /// </summary>
        [Description("05")]
        Cancel,
    }
    #endregion

    #region 返回结果集

    /// <summary>
    /// 处理结果
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// 处理成功
        /// </summary>
        Success = 100,
        /// <summary>
        /// 未知异常情况
        /// </summary>
        UnknownException = 999,

        /// <summary>
        /// 必录项不能为空【{{}}不能为空】
        /// </summary>
        EntriesMustNotBeNull = 201,

        /// <summary>
        /// 数据格式不符要求【{{}}数据格式不符要求】
        /// </summary>
        DataFormatDoesNotMeetRequirements = 202,

        /// <summary>
        /// 数据长度超过限制【{{}}数据长度超过限制】
        /// </summary>
        DataLengthExceedsLimit = 203
    }

    #endregion
}
