using CZB.Common.Enums;
using CZB.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CZB.Web.Models
{
    public class FundChangeRecordReturn
    {
        /// <summary>
        /// 总支出
        /// </summary>
        public string outMoney
        {
            get
            {
                if (this.list != null)
                {
                    return this.list.Where(exp => exp.type == 1 || exp.type == 2 || exp.type == 3).Sum(exp => exp.money).ToString();
                }
                return "0";
            }
        }

        /// <summary>
        /// 总收入
        /// </summary>
        public string inMoney
        {
            get
            {
                if (this.list != null)
                {
                    return this.list.Where(exp => exp.type == 4 || exp.type == 5).Sum(exp => exp.money).ToString();
                }
                return "0";
            }
        }

        /// <summary>
        /// 列表
        /// </summary>
        public List<FundChangeRecordDetail> list { get; set; }
    }

    public class FundChangeRecordDetail
    {
        public string name { get; set; }

        public string headImg { get; set; }

        public int type { get; set; }

        public string typeName
        {
            get
            {
                if (type == IncomeTypeEnum.ChildSelling.GetHashCode())
                {
                    return IncomeTypeEnum.ChildSelling.GetDescription();
                }
                if (type == IncomeTypeEnum.CommissionWithdrawal.GetHashCode())
                {
                    return IncomeTypeEnum.CommissionWithdrawal.GetDescription();
                }
                if (type == IncomeTypeEnum.CommodityPurchase.GetHashCode())
                {
                    return IncomeTypeEnum.CommodityPurchase.GetDescription();
                }
                if (type == IncomeTypeEnum.DirectSelling.GetHashCode())
                {
                    return IncomeTypeEnum.DirectSelling.GetDescription();
                }
                if (type == IncomeTypeEnum.PromotionCommission.GetHashCode())
                {
                    return IncomeTypeEnum.PromotionCommission.GetDescription();
                }
                return "";
            }
        }

        public int insureType { get; set; }

        public string insuranceName
        {
            get
            {
                if (insureType == 1)
                {
                    return "交强险";
                }
                else
                {
                    return "商业险";
                }
            }
        }

        public DateTime createTime { get; set; }

        public string createTimeStr
        {
            get
            {
                return createTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        public decimal money { get; set; }

        public string PolicyNo { get; set; }
    }
}
