using System.Collections.Generic;

namespace CZB.Web.Api.Models
{
    public class IntroduceReturn
    {
        /// <summary>
        /// 当前代理商等级
        /// </summary>
        public int agentLevel { get; set; }

        /// <summary>
        /// 代理商本身信息
        /// </summary>
        public IntroduceDetail agentInfo { get; set; }

        /// <summary>
        /// 下级信息
        /// </summary>
        public List<IntroduceDetail> childAgentList { get; set; }

        /// <summary>
        /// 上级信息
        /// </summary>
        public IntroduceDetail parentAgentInfo { get; set; }
    }

    public class IntroduceDetail
    {
        /// <summary>
        /// 代理商编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 代理商父级编号
        /// </summary>
        public int parentId { get; set; }

        /// <summary>
        /// 代理商名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 代理商手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 代理商头像图片
        /// </summary>
        public string picUrl { get; set; }

        /// <summary>
        /// 月保费
        /// </summary>
        public decimal policyAmout { get; set; }
    }
}
