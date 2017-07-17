using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Config
{

    public static class BaseConfig
    {
        public static BaseConfigInfo config = BaseConfigs.GetBaseConfig();
        /// <summary>
        /// 与微信公众账号后台的Token设置保持一致，区分大小写。
        /// </summary>
        public static string Token
        {
            get
            {
                if (config != null)
                    return config.Token;
                return "";
            }
        }

        /// <summary>
        /// 与微信公众账号后台的EncodingAESKey设置保持一致，区分大小写。
        /// </summary>
        public static string EncodingAESKey
        {
            get
            {
                if (config != null)
                    return config.EncodingAESKey;
                return "";
            }
        }

        /// <summary>
        /// 与微信公众账号后台的AppId设置保持一致，区分大小写。
        /// </summary>
        public static string AppId
        {
            get
            {
                if (config != null)
                    return config.AppId;
                return "";
            }
        }
        /// <summary>
        /// 与微信公众账号后台的AppSecret设置保持一致，区分大小写。
        /// </summary>
        public static string AppSecret
        {
            get
            {
                if (config != null)
                {
                    return config.AppSecret;
                }
                return "";
            }
        }

        /// <summary>
        /// 公众号默认回复消息
        /// </summary>
        public static string DefaultInfo
        {
            get
            {
                if (config != null)
                    return config.DefaultInfo;
                return "";
            }
        }
    }
}
