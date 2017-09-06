using System;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace CZB.Common
{
    public class Utils
    {

        /// <summary>
        /// 得到当前访问的路径[http://www.baidu.com?pIdx=2]
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUrl()
        {
            return HttpContext.Current.Request.Url.ToString();
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int ObjectToInt(object expression)
        {
            return ObjectToInt(expression, 0);
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int ObjectToInt(object expression, int defValue)
        {
            if (expression != null)
                return StrToInt(expression.ToString(), defValue);

            return defValue;
        }

        /// <summary>
        /// 将对象转换为Int32类型
        /// </summary>
        /// <param name="str">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static int StrToInt(string str, int defValue)
        {
            if (string.IsNullOrEmpty(str) || str.Trim().Length >= 11 || !Regex.IsMatch(str.Trim(), @"^([-]|[0-9])[0-9]*(\.\w*)?$"))
                return defValue;

            int rv;
            if (Int32.TryParse(str, out rv))
                return rv;

            return Convert.ToInt32(StrToFloat(str, defValue));
        }

        /// <summary>
        /// string型转换为float型
        /// </summary>
        /// <param name="strValue">要转换的字符串</param>
        /// <param name="defValue">缺省值</param>
        /// <returns>转换后的int类型结果</returns>
        public static float StrToFloat(string strValue, float defValue)
        {
            if ((strValue == null) || (strValue.Length > 10))
                return defValue;

            float intValue = defValue;
            if (strValue != null)
            {
                bool IsFloat = Regex.IsMatch(strValue, @"^([-]|[0-9])[0-9]*(\.\w*)?$");
                if (IsFloat)
                    float.TryParse(strValue, out intValue);
            }
            return intValue;
        }

        /// <summary>
        /// http 请求  Get
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns></returns>
        public static string HttpGetRequest(string url)
        {
            return HttpRequest(url, RequestType.GET, "");
        }

        /// <summary>
        /// http 请求  Get,POST
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public static string HttpPostRequest(string url, string param)
        {
            return HttpRequest(url, RequestType.POST, param);
        }

        /// <summary>
        /// http 请求  Get/Post
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="requestType">Get/Post</param>
        /// <param name="param">Post 请求参数</param>
        /// <returns></returns>
        private static string HttpRequest(string url, RequestType enumType, string param)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = enumType.ToString();

            //request.ContentType = "application/x-www-form-urlencoded";
            //request.Accept = "*/*";

            request.ContentType = "application/json";
            request.Accept = "application/json";

            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                if (enumType == RequestType.POST)
                {
                    requestStream = new StreamWriter(request.GetRequestStream());
                    requestStream.Write(param);
                    requestStream.Close();
                }
                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(Enums.LogEnum.Error, e.Message);
                return string.Empty;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }
            return responseStr;
        }


        /// <summary>
        /// http 请求  Get/Post
        /// </summary>
        /// <param name="url">请求路径</param>
        /// <param name="requestType">Get/Post</param>
        /// <param name="param">Post 请求参数</param>
        /// <returns></returns>
        public static string HttpRequestSiTeng(string url, RequestType enumType, string param)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = enumType.ToString();

            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";

            request.Timeout = 15000;
            request.AllowAutoRedirect = false;

            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                if (enumType == RequestType.POST)
                {
                    requestStream = new StreamWriter(request.GetRequestStream());
                    requestStream.Write(param);
                    requestStream.Close();
                }
                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(Enums.LogEnum.Error, e.Message);
                return string.Empty;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }
            return responseStr;
        }

        /// <summary>
        /// 发送短信验证码
        /// </summary>
        /// <param name="purl"></param>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string HttpMessageRequest(string purl, string str)
        {
            try
            {
                byte[] data = System.Text.Encoding.GetEncoding("GB2312").GetBytes(str);
                // 准备请求 
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(purl);

                //设置超时
                req.Timeout = 30000;
                req.Method = "Post";
                req.ContentType = "application/x-www-form-urlencoded";
                req.ContentLength = data.Length;
                Stream stream = req.GetRequestStream();
                // 发送数据 
                stream.Write(data, 0, data.Length);
                stream.Close();

                HttpWebResponse rep = (HttpWebResponse)req.GetResponse();
                Stream receiveStream = rep.GetResponseStream();
                Encoding encode = System.Text.Encoding.GetEncoding("GB2312");
                // Pipes the stream to a higher level stream reader with the required encoding format. 
                StreamReader readStream = new StreamReader(receiveStream, encode);

                Char[] read = new Char[256];
                int count = readStream.Read(read, 0, 256);
                StringBuilder sb = new StringBuilder("");
                while (count > 0)
                {
                    String readstr = new String(read, 0, count);
                    sb.Append(readstr);
                    count = readStream.Read(read, 0, 256);
                }

                rep.Close();
                readStream.Close();

                return sb.ToString();

            }
            catch (Exception ex)
            {
                return "posterror";
                // ForumExceptions.Log(ex);
            }
        }
    }
}
