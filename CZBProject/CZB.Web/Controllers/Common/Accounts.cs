using CZB.Common.Extensions;
using CZB.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZB.Web.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class Accounts
    {
        /// <summary>
        /// 用户登录返回信息
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public UserLoginReturn UserLogin(string phone)
        {
            var returnModel = new UserLoginReturn();
            var model = new BLL.FX_Agent().GetModelByPhone(phone);
            if (model != null)
            {
                //用户基本信息
                int level = model.AgentLevel.ToInt32();
                returnModel.userInfo = new UserInfo()
                {
                    headImg = model.FacePic,
                    id = model.AgentId.ToStringEx(),
                    level = level,
                    money = model.TotalAmout.ToStringEx(),
                    levelName = level == 1 ? "一级代理商" : level == 2 ? "二级代理商" : "三级代理商",
                    name = model.TrueName,
                    phone = model.Mobile
                };
                //中部菜单信息
                var Menulist = new List<ShowMenuList>();
                Menulist.Add(new ShowMenuList()
                {
                    showMenuName = "总收益/总保费",
                    showMenuNumber = "0/0"
                });
                var info = new BLL.FX_Policy().GetPolicyMonth(model.AgentId.ToInt32());
                string moneySaler = "";
                if (info != null && info.Tables[0] != null && info.Tables[0].Rows.Count > 0 && info.Tables[0].Rows[0]["num"] != null)
                {
                    moneySaler = info.Tables[0].Rows[0]["num"].ToStringEx();
                }

                Menulist.Add(new ShowMenuList()
                {
                    showMenuName = "当月销售/目标",
                    showMenuNumber = moneySaler + "/" + ""
                });

                if (level == 1 || level == 2)
                {
                    int parentAgentCount = 0;
                    Menulist.Add(new ShowMenuList()
                    {
                        showMenuName = "代理数/代理收益",
                        showMenuNumber = parentAgentCount + "/" + "0"
                    });
                    Menulist.Add(new ShowMenuList()
                    {
                        showMenuName = "我的积分",
                        showMenuNumber = "0"
                    });
                }
                returnModel.showMenuList = Menulist;

                //保单信息
                var orderList = new List<OrderList>();
                returnModel.orderList = orderList;
            }
            return returnModel;
        }
    }
}