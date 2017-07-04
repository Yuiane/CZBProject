using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.DAL
{
    public interface IDataProvider
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
        
        #endregion  

    }
}
