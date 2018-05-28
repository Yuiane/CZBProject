using CZB.Common.Shengda.Enum;
using CZB.Common;
using System;
using System.Collections.Generic;
using CZB.Common.Extensions;
using System.Linq;
using System.Web;
using CZB.Common.Helpers;

namespace CZB.Web.Open.Models
{
    /// <summary>
    /// 上年投保信息查询
    /// </summary>
    public class RenewalReturn : ReturnResultBase
    {

        /// <summary>
        /// 上年投保公司
        /// </summary>
        public string LastCompanyCode { get; set; }



        /// <summary>
        /// 车牌号
        /// </summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 上年交强险截止
        /// </summary>
        public string CiEndTime { get; set; }

        /// <summary>
        /// 上年商业险截止
        /// </summary>
        public string BiEndTime { get; set; }

        /// <summary>
        /// 品牌型号
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 车主名称
        /// </summary>
        public string Owners { get; set; }

        /// <summary>
        /// 是否获取到数据
        /// </summary>
        public int IsGetData { get; set; }

        /// <summary>
        /// 上年投保险种
        /// </summary>
        public List<InsurancesDetail> Insurances { get; set; }


        #region 拓展字段
        /// <summary>
        /// 上年投保公司
        /// </summary>
        public string LastCompanyName
        {
            get
            {
                if (LastCompanyCode == LastCompanyEnum.CPIC.GetName())
                {
                    return LastCompanyEnum.CPIC.GetDescription();
                }
                else if (LastCompanyCode == LastCompanyEnum.PAIC.GetName())
                {
                    return LastCompanyEnum.PAIC.GetDescription();
                }
                else if (LastCompanyCode == LastCompanyEnum.PICC.GetName())
                {
                    return LastCompanyEnum.PICC.GetDescription();
                }
                return string.Empty;
            }
        }
        #endregion


    }

    /// <summary>
    /// 上年投保险种明细
    /// </summary>
    public class InsurancesDetail
    {
        /// <summary>
        /// 险种code
        /// </summary>
        public string InsCode { get; set; }

        /// <summary>
        /// 险种名称
        /// </summary>
        public string InsName { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        ///  非金额型保额 code
        /// </summary>
        public string ModelCode { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        public string Premium { get; set; }
    }
}