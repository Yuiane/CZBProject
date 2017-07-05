using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.IDAL
{
    public interface IAutoReply
    {

        #region  AutoReply
        /// <summary>
        /// 增加一条数据
        /// </summary>
        bool Add(Model.AutoReply model);

        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(Model.AutoReply model);

        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete();

        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);

        int GetRecordCount(string strWhere);


        /// <summary>
        /// 获取关注回复信息
        /// </summary>
        /// <returns></returns>
        DataSet GetSubscribeInfo();


        /// <summary>
        /// 获取关键词回复
        /// </summary>
        /// <param name="keyWord"></param>
        /// <returns></returns>
        DataSet GetAutoReplyListBykeyWord(string keyWord);

        #endregion

    }
}
