using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common
{
    /// <summary>
    /// 发送短信
    /// </summary>
    public static class Messages
    {
        private static string UID = "chezhibao";
        private static string PWD = "bkwzadr0526";
        private static string URL = "http://service.winic.org:8009/sys_port/gateway/index.asp?";
        private static string PARAMETER = "id={0}&pwd={1}&to={2}&content={3}&time=";

        /// <summary>
        /// 发送短信
        /// </summary>
        /// <param name="phone">手机号码</param>
        /// <param name="content">发送内容</param>
        /// <returns></returns>
        public static string SendMessage(string phone, string content)
        {
            var sendContent = string.Format(PARAMETER, UID, PWD, phone, content);
            return Utils.HttpMessageRequest(URL, sendContent);
        }
    }
}
