using CZB.Common.Extensions;
using CZB.Config;
using Senparc.Weixin.MP.Containers;
using System;

namespace CZB.Web.WeXin.CommonService
{
    public class Base
    {
        // GET: Adm1n_L0g1n/Base
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <returns></returns>
        public string GetAccessToken()
        {
            var model = new BLL.WXBasePara().GetAccessTokenModel(BaseConfig.AppId);
            if (model != null)
            {
                if (model.BaseTokenStartTime.Value.AddHours(1) < DateTime.Now)
                {
                    var result = AccessTokenContainer.TryGetAccessToken(BaseConfig.AppId, BaseConfig.AppSecret);
                    if (result.IsNotNullOrWhiteSpace())
                    {
                        model.BaseAccessToken = result;
                        model.BaseTokenStartTime = DateTime.Now;
                        new BLL.WXBasePara().Update(model);
                    }
                }
                return model.BaseAccessToken;
            }
            return string.Empty;
        }
    }
}
