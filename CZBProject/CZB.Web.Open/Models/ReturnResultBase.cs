using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZB.Web.Open.Models
{
    public class ReturnResultBase
    {

        /// <summary>
        /// 响应码
        /// </summary>
        public string code { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        public string desc { get; set; }
    }
}