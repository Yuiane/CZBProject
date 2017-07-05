using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZB.Common.Extensions;


namespace CZB.BLL
{
    public class AutoReply
    {
        public DAL.SqlServer.AutoReply dal = new DAL.SqlServer.AutoReply();
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获取回复信息
        /// 关键词为空获取关注回复信息
        /// </summary>
        /// <param name="keyWord">关键词</param>
        /// <returns></returns>
        public DataSet GetAutoReplyList(string keyWord)
        {
            if (keyWord.IsNotNullOrWhiteSpace())
            {
                return GetAutoReplyListBykeyWord(keyWord);
            }
            else
            {
                return GetSubscribeInfo();
            }
        }

        /// <summary>
        /// 获取关注回复信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetSubscribeInfo()
        {
            return dal.GetSubscribeInfo();
        }

        /// <summary>
        /// 获取关键词回复信息
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        public DataSet GetAutoReplyListBykeyWord(string keyWord)
        {
            return dal.GetAutoReplyListBykeyWord(keyWord);
        }


    }
}
