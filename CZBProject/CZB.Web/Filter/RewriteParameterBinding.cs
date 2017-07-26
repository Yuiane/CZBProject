using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Metadata;
using CZB.Common.Extensions;
using Newtonsoft.Json;
using CZB.Common;

namespace CZB.Web.Filter
{
    /// <summary>
    /// 重写参数绑定
    /// </summary>
    public class RewriteParameterBinding : HttpParameterBinding
    {


        //private  object BindArrayModel(HttpActionContext actionContext, Type parameterType, string prefix)
        //{
        //    var viewP = new System.Web.Http.ValueProviders.Providers.QueryStringValueProvider(actionContext,
        //        CultureInfo.CurrentCulture);

        //    IList list = new List<object>();
        //    if (viewP.ContainsPrefix(prefix))
        //    {
        //        IEnumerable enumerable = viewP.GetValue(prefix).ConvertTo(parameterType) as IEnumerable;
        //        if (null != enumerable)
        //        {
        //            foreach (var value in enumerable)
        //            {
        //                list.Add(value);
        //            }
        //        }
        //    }
        //    Array array = Array.CreateInstance(parameterType.GetElementType(), list.Count);
        //    list.CopyTo(array, 0);
        //    return array;
        //}


        private const string MultipleBodyParameters = "MultipleBodyParameters";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="descriptor"></param>
        public RewriteParameterBinding(HttpParameterDescriptor descriptor) : base(descriptor) { }

        /// <summary>
        /// 检查请求。根据对应的请求解析上下文参数
        /// </summary>
        /// <param name="metadataProvider"></param>
        /// <param name="actionContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task ExecuteBindingAsync(ModelMetadataProvider metadataProvider, HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            string stringValue = null;
            object value = null;
            try
            {
                //如果是Post请求
                if (actionContext.Request.Method == HttpMethod.Post)
                {
                    NameValueCollection col = TryReadBody(actionContext.Request);
                    if (col != null)
                        stringValue = col[Descriptor.ParameterName];

                    //复杂类型处理
                    if (stringValue == null)
                    {
                        if (col != null)
                        {
                            var keyList = col.Keys;

                            var query = new List<KeyValuePair<string, string>>();
                            foreach (string key in keyList)
                            {
                                var keyValue = new KeyValuePair<string, string>(key, col[key]);
                                query.Add(keyValue);
                            }
                            Type valueType = Descriptor.ParameterType;
                            value = GetSetValue.SetValue(valueType, query);
                        }
                    }//简单类型处理
                    else
                    {
                        value = StringToType(stringValue);
                    }
                }
                //如果是Get请求
                if (actionContext.Request.Method == HttpMethod.Get)
                {
                    var query = actionContext.Request.GetQueryNameValuePairs();
                    if (query != null)
                    {
                        //简单类型处理
                        var matches = query.Where(kv => kv.Key.ToLower() == Descriptor.ParameterName.ToLower());
                        if (matches.Any())
                        {
                            stringValue = matches.First().Value;
                            value = StringToType(stringValue);
                        }//复杂类型处理
                        else
                        {
                            Type valueType = Descriptor.ParameterType;
                            value = GetSetValue.SetValue(valueType, query);
                            //value = StringToType(stringValue);
                        }
                    }
                }
                // 在上下文绑定参数 给字段挨个赋值
                SetValue(actionContext, value);

                // 定义一个没有返回的异步
                TaskCompletionSource<AsyncVoid> tcs = new TaskCompletionSource<AsyncVoid>();
                //
                tcs.SetResult(default(AsyncVoid));
                return tcs.Task;
            }
            catch (Exception ex)
            {
                throw ex;
                return null;
            }
        }





        /// <summary>
        /// 绑定规则。
        /// </summary>
        /// <example>
        /// GlobalConfiguration.Configuration.
        ///       .ParameterBindingRules
        ///       .Insert(0,SimplePostVariableParameterBinding.HookupParameterBinding);
        /// </example>    
        /// <param name="descriptor"></param>
        /// <returns></returns>
        public static HttpParameterBinding HookupParameterBinding(HttpParameterDescriptor descriptor)
        {
            try
            {
                //注释 这一块可以根据请求类型和请求参数的类型做匹配规则
                //var supportedMethods = descriptor.ActionDescriptor.SupportedHttpMethods;
                // Only apply this binder on POST operations
                //if (supportedMethods.Contains(HttpMethod.Post))
                //{
                //var supportedTypes = new Type[]
                //{
                //    typeof(string),
                //    typeof(int),
                //    typeof(long),
                //    typeof(long?),
                //    typeof(decimal),
                //    typeof(double),
                //    typeof(bool),
                //    typeof(DateTime),
                //    typeof(byte[]),

                //};
                //if (supportedTypes.Any(typ => typ == descriptor.ParameterType))
                return new RewriteParameterBinding(descriptor);
                //}


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }


        private object StringToType(string stringValue)
        {
            object value = null;
            try
            {
                if (stringValue == null)
                    value = null;
                else if (Descriptor.ParameterType == typeof(string))
                    value = stringValue;
                else if (Descriptor.ParameterType == typeof(int))
                    value = int.Parse(stringValue, CultureInfo.CurrentCulture);
                else if (Descriptor.ParameterType == typeof(Int32))
                    value = Int32.Parse(stringValue, CultureInfo.CurrentCulture);
                else if (Descriptor.ParameterType == typeof(Int64))
                    value = Int64.Parse(stringValue, CultureInfo.CurrentCulture);

                else if (Descriptor.ParameterType == typeof(int?))
                    value = stringValue.ConvertTo(typeof(int?));

                else if (Descriptor.ParameterType == typeof(decimal))
                    value = decimal.Parse(stringValue, CultureInfo.CurrentCulture);
                else if (Descriptor.ParameterType == typeof(double))
                    value = double.Parse(stringValue, CultureInfo.CurrentCulture);
                else if (Descriptor.ParameterType == typeof(DateTime))
                    value = DateTime.Parse(stringValue, CultureInfo.CurrentCulture);
                else if (Descriptor.ParameterType == typeof(bool))
                {
                    value = false;
                    if (stringValue == "true" || stringValue == "on" || stringValue == "1")
                        value = true;
                }
                else
                    value = stringValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return value;
        }

        /// <summary>
        /// 检查Post请求内的参数  缓存
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static NameValueCollection TryReadBody(HttpRequestMessage request)
        {
            object result = null;
            try
            {
                //获取
                if (!request.Properties.TryGetValue(MultipleBodyParameters, out result))
                {
                    var jsonStr = request.Content.ReadAsStringAsync().Result;//{"Name":"tongl","Age":22}
                    var json = JsonConvert.DeserializeObject<IDictionary<string, string>>(jsonStr);
                    if (json != null && json.Count > 0)
                    {
                        var nvc = new NameValueCollection();
                        foreach (var item in json)
                        {
                            nvc.Add(item.Key, item.Value);
                        }
                        result = nvc;
                    }
                    request.Properties.Add(MultipleBodyParameters, result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result as NameValueCollection;
        }

        private struct AsyncVoid
        {
        }
    }
}