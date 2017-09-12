using System.Data;
namespace CZB.BLL
{
    /// <summary>
    /// FX_InsureParaDetail
    /// </summary>
    public partial class FX_InsureParaDetail
    {
        private readonly CZB.DAL.SqlServer.DataProvider.FX_InsureParaDetail dal = new DAL.SqlServer.DataProvider.FX_InsureParaDetail();
        public FX_InsureParaDetail()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InsureParaDetailsId)
        {
            return dal.Exists(InsureParaDetailsId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_InsureParaDetail model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_InsureParaDetail model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int InsureParaDetailsId)
        {

            return dal.Delete(InsureParaDetailsId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string InsureParaDetailsIdlist)
        {
            return dal.DeleteList(InsureParaDetailsIdlist);
        }





        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod

        /// <summary>
        /// 根据城市编码和保险公司编号 获取列表
        /// </summary>
        /// <param name="insurecode">保险公司编号</param>
        /// <param name="citycode">城市编码</param>
        /// <returns></returns>
        public DataSet GetList(string insurecode, string citycode)
        {
            return dal.GetList(insurecode, citycode);
        }
        #endregion  ExtensionMethod
    }
}
