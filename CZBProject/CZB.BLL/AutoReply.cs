using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CZB.BLL
{
    public class AutoReply
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataSet GetList(string strWhere)
        {
            return new DAL.SqlServer.AutoReply().GetList(strWhere);
        }
    }
}
