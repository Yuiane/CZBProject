using System.Collections.Generic;

namespace CZB.Web.Models
{
    /// <summary>
    /// 登录接口返回参数
    /// </summary>
    public class UserLoginReturn
    {
        /// <summary>
        /// 用户基本信息
        /// </summary>
        public UserInfo userInfo { get; set; }

        /// <summary>
        /// 首页中部显示的菜单列表
        /// </summary>
        public List<ShowMenuList> showMenuList { get; set; }

        /// <summary>
        /// 订单列表
        /// </summary>
        public List<OrderList> orderList { get; set; }
    }

    /// <summary>
    /// 订单
    /// </summary>
    public class OrderList
    {
        /// <summary>
        /// 订单状态名称
        /// </summary>
        public string orderStateName { get; set; }

        /// <summary>
        /// 订单数量
        /// </summary>
        public string orderStateNumber { get; set; }
    }

    /// <summary>
    /// 首页中部显示的菜单
    /// </summary>
    public class ShowMenuList
    {
        /// <summary>
        /// 显示数值
        /// </summary>
        public string showMenuNumber { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string showMenuName { get; set; }
    }

    /// <summary>
    /// 用户基本信息
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 用户 编号
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// 用户号码
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string headImg { get; set; }
        /// <summary>
        /// 真实名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// 等级名称
        /// </summary>
        public string levelName { get; set; }

        /// <summary>
        /// 可提现金额
        /// </summary>
        public string money { get; set; }

        public string cityCode { get; set; }
    }
}
