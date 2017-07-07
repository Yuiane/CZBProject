using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.IDAL
{
    /// <summary>
	/// 接口层CZB_Material
	/// </summary>
	public interface IMaterial
    {
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(string ID);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        bool Add(CZB.Model.Material model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(CZB.Model.Material model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(string ID);
        bool DeleteList(string IDlist);
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        CZB.Model.Material GetModel(string ID);
        CZB.Model.Material DataRowToModel(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere);
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
        #endregion  成员方法
        #region  MethodEx

        #endregion  MethodEx
    }
}
