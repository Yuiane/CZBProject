using Newtonsoft.Json;
namespace CZB.Common.OpenWeChat
{

    /// <summary>
    /// 微信开放平台
    /// </summary>
    public class OpenApi
    {
        //微信开放平台
        public string appId = "wx1cdbeb9e794cb54a";
        public string appSecret = "163d9e5f797eb07a36a5984fb7cb4106";

        /// <summary>
        /// 获取access_token的接口
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public AccessToken GetAccess_token(string code)
        {
            try
            {
                string urlFormat = string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", appId, appSecret, code);
                string _value = Utils.HttpPostRequest(urlFormat, "");
                return JsonConvert.DeserializeObject<AccessToken>(_value);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(AccessToken _model)
        {
            try
            {
                if (_model != null)
                {
                    string urlFormat = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}", _model.access_token, _model.openid);
                    string _value = Utils.HttpPostRequest(urlFormat, "");
                    return JsonConvert.DeserializeObject<UserInfo>(_value);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="_model"></param>
        /// <returns></returns>
        public UserInfo GetUserInfo(string code)
        {
            try
            {
                var _model = GetAccess_token(code);
                if (_model != null)
                {
                    string urlFormat = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}", _model.access_token, _model.openid);
                    string _value = Utils.HttpPostRequest(urlFormat, "");
                    return JsonConvert.DeserializeObject<UserInfo>(_value);
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}
