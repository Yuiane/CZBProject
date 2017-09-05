using CZB.Common.Extensions;
using System.Data;

namespace CZB.BLL
{
    /// <summary>
    /// FX_InsureCode
    /// </summary>
    public partial class FX_InsureCode
    {
        private readonly DAL.SqlServer.DataProvider.FX_InsureCode dal = new DAL.SqlServer.DataProvider.FX_InsureCode();
        public FX_InsureCode()
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
        public bool Exists(int InsureCodeId)
        {
            return dal.Exists(InsureCodeId);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(CZB.Model.FX_InsureCode model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(CZB.Model.FX_InsureCode model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int InsureCodeId)
        {

            return dal.Delete(InsureCodeId);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string InsureCodeIdlist)
        {
            return dal.DeleteList(InsureCodeIdlist);
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

        ///根据编号获取保险公司名称
        public string GetInsureName(string insureCode)
        {
            var model = GetInsure(insureCode).Tables[0].ToEntity<Model.FX_InsureCode>();
            if (model != null)
                return model.InsureName;
            return string.Empty;
        }

        /// <summary>
        /// 根据编号获取一条数据
        /// </summary>
        /// <param name="insureCode"></param>
        /// <returns></returns>
        public DataSet GetInsure(string insureCode)
        {
            return dal.GetInsureName(insureCode);
        }


        /// <summary>
        /// 获取保险公司返点列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInsureList()
        {
            return dal.GetInsureList();
        }

        /// <summary>
        /// 获取险种类型列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetInsuranceList()
        {
            return dal.GetInsuranceList();
        }

        #endregion  ExtensionMethod
    }
}
