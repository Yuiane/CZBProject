using System.ComponentModel;

namespace CZB.Common.Enums
{
    /// <summary>
    /// 佣金枚举类型
    /// 表：IncomeRecord
    /// 字段:IncomeType
    /// IncomeRecord_IncomeType
    /// </summary>
    public enum IncomeTypeEnum
    {
        [Description("直接销售")]
        DirectSelling = 1,

        [Description("下级销售")]
        ChildSelling = 2,

        [Description("推广提成")]
        PromotionCommission = 3,

        [Description("佣金提现")]
        CommissionWithdrawal = 4,

        [Description("商品购买")]
        CommodityPurchase = 5
    }
}
