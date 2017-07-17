using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Config
{
    /// <summary>
    /// 基本设置描述类, 加[Serializable]标记为可序列化
    /// </summary>
    [Serializable]
    public class BaseConfigInfo : IConfigInfo
    {

        #region 私有字段
        private string m_dbconnectstring = "Data Source=;User ID=;Password=;Initial Catalog=FixAutoInsurance;Pooling=true";		// 数据库连接串-格式(中文为用户修改的内容)：Data Source=数据库服务器sAddress;User ID=您的数据库用户名;Password=您的数据库用户密码;Initial Catalog=数据库名称;Pooling=true
        private string m_tableprefix = "";		// 数据库中表的前缀
        private string m_dbtype = "";
        private string _language = ""; //语言
        private string _skin = string.Empty;//皮肤
        private string token = "";
        private string appid = "";
        private string encodingAESKey = "";
        private string defaultInfo = "";
        private string appSecret = "";
        #endregion

        #region 属性

        /// <summary>
        /// 数据库连接串
        /// 格式(中文为用户修改的内容)：
        ///    Data Source=数据库服务器sAddress;
        ///    User ID=您的数据库用户名;
        ///    Password=您的数据库用户密码;
        ///    Initial Catalog=数据库名称;Pooling=true
        /// </summary>
        public string Dbconnectstring
        {
            get { return m_dbconnectstring; }
            set { m_dbconnectstring = value; }
        }
      

        /// <summary>
        /// 微信公众号消息无响应时候回复
        /// </summary>
        public string DefaultInfo
        {
            get { return defaultInfo; }
            set { defaultInfo = value; }
        }

        public string EncodingAESKey
        {
            get { return encodingAESKey; }
            set { encodingAESKey = value; }
        }

        public string AppId
        {
            get { return appid; }
            set { appid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string AppSecret
        {
            get { return appSecret; }
            set { appSecret = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Token
        {
            get { return token; }
            set { token = value; }
        }

        /// <summary>
        /// 数据库中表的前缀
        /// </summary>
        public string Tableprefix
        {
            get { return m_tableprefix; }
            set { m_tableprefix = value; }
        }


        /// <summary>
        /// 数据库类型
        /// </summary>
        public string Dbtype
        {
            get { return m_dbtype; }
            set { m_dbtype = value; }
        }


        /// <summary>
        /// 语言
        /// </summary>
        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        /// <summary>
        /// 默认皮肤
        /// </summary>
        public string Skin
        {
            get { return _skin; }
            set { _skin = value; }
        }


        #endregion
    }
}
