using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CZB.Common.Extensions;


namespace CZB.BLL
{
    public class AutoReplys
    {
        private DAL.SqlServer.AutoReply dal = new DAL.SqlServer.AutoReply();
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

        /// <summary>
        /// 根据编号获取一条数据
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        public Model.AutoReply GetModelById(string id)
        {
            return dal.GetModelById(id).Tables[0].ToEntity<Model.AutoReply>();
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.AutoReply model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 新增一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Add(Model.AutoReply model)
        {
            return dal.Add(model);
        }

    }
}
