﻿using CZB.Common.CCCModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.Extensions
{
    public static class ExtJson
    {
        /// <summary>
        /// Json 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Json 序列化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJsonRemoveNull(this object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented,
                new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }


        /// <summary>
        /// Json反序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static T JsonToObj<T>(this string json) where T : class, new()
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T Param<T>(this HttpRequestMessage request)
        {
            try
            {
                var jsonStr = request.Content.ReadAsStringAsync().Result;//{"Name":"tongl","Age":22}
                jsonStr = jsonStr.Replace("\"{", "{").Replace("}\"", "}").Replace(@"\", "");
                LogHelper.WriteLog(Enums.LogEnum.CCCApiJson, jsonStr);
                return JsonConvert.DeserializeObject<T>(jsonStr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}