using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CZB.Common
{
    public class RequestHandler
    {
        public RequestHandler()
            : this(null)
        {
        }

        public RequestHandler(HttpContext httpContext)
        {
            Parameters = new Hashtable();
            this.HttpContext = httpContext ?? HttpContext.Current;

        }

        /// <summary>
        /// 请求的参数
        /// </summary>
        protected Hashtable Parameters;

        protected HttpContext HttpContext;

        protected virtual string GetCharset()
        {
            if (this.HttpContext == null)
            {
                return Encoding.UTF8.BodyName;
            }

            return this.HttpContext.Request.ContentEncoding.BodyName;
        }


        /// <summary>
        /// 设置参数值
        /// </summary>
        /// <param name="parameter"></param>
        /// <param name="parameterValue"></param>
        public void SetParameter(string parameter, string parameterValue)
        {
            if (parameter != null && parameter != "")
            {
                if (Parameters.Contains(parameter))
                {
                    Parameters.Remove(parameter);
                }

                Parameters.Add(parameter, parameterValue);
            }
        }

        /// <summary>
        /// 创建md5摘要,规则是:按参数名称a-z排序,遇到空值的参数不参加签名
        /// </summary>
        /// <param name="key">参数名</param>
        /// <param name="value">参数值</param>
        /// key和value通常用于填充最后一组参数
        /// <returns></returns>
        public virtual string CreateMd5Sign(string key, string value)
        {
            StringBuilder sb = new StringBuilder();

            ArrayList akeys = new ArrayList(Parameters.Keys);
            akeys.Sort();

            foreach (string k in akeys)
            {
                string v = (string)Parameters[k];
                if (null != v && "".CompareTo(v) != 0
                    && "sign".CompareTo(k) != 0
                    //&& "sign_type".CompareTo(k) != 0
                    && "key".CompareTo(k) != 0)
                {
                    sb.Append(k + "=" + v + "&");
                }
            }
            if (string.IsNullOrWhiteSpace(key))
                sb.Append(value);
            else
                sb.Append(key + "=" + value);
            string sign = EncryptHelper.GetMD5(sb.ToString(), GetCharset()).ToLower();

            return sign;
        }
    }
}
