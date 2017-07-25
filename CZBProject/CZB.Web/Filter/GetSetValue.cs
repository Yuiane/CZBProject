using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CZB.Common.Extensions;
using CZB.Common;
using CZB.Common.Enums;

namespace CZB.Web.Filter
{
    public class GetSetValue
    {
        public static object SetValue(Type valueType, IEnumerable<KeyValuePair<string, string>> query)
        {
            //Type objType = Type.GetType(sender, true);
            var t = Activator.CreateInstance(valueType);
            try
            {
                //var t = new T();
                var properties = t.GetType().GetProperties();
                foreach (var property in properties)
                {
                    var keyValuePairs = query as IList<KeyValuePair<string, string>> ?? query.ToList();
                    if (query != null)
                        foreach (var keyValue in keyValuePairs)
                        {
                            //如果是List类型分开处理
                            if (t is System.Collections.IList)
                            {
                                t = keyValue.Value.SplitList();
                                break;
                            }
                            if (property.Name == keyValue.Key)
                            {
                                property.SetValue(t, Convert.ChangeType(keyValue.Value, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType), null);
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                LogHelper.WriteLog(LogEnum.Error, string.Format("参数绑定错误：{0}", ex));
            }
            return t;
        }
    }
}