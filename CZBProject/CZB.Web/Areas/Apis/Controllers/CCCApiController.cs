using CZB.Common.CCCModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CZB.Web.Areas.Apis.Controllers
{
    ///            佛祖保佑                     永无BUG
    ///                            _ooOoo_  
    ///                           o8888888o  
    ///                           88" . "88  
    ///                           (| -_- |)  
    ///                            O\ = /O  
    ///                        ____/`---'\____  
    ///                      .   ' \\| |// `.  
    ///                       / \\||| : |||// \  
    ///                     / _||||| -:- |||||- \  
    ///                       | | \\\ - /// | |  
    ///                     | \_| ''\---/'' | |  
    ///                      \ .-\__ `-` ___/-. /  
    ///                   ___`. .' /--.--\ `. . __  
    ///               | | : `- \`.;`\ _ /`;.`/ - ` : | |  
    ///                 \ \ `-. \_ __\ /__ _/ .-` / /  
    ///         ======`-.____`-.___\_____/___.-`____.-'======  
    ///                            `=---='  
    ///             佛祖保佑                     永无BUG
    /// <summary>
    /// 
    /// </summary>
    [AllowAnonymous]
    [RoutePrefix("api/CCCApi")]
    public class CCCApiController : ApiController
    {
        /// <summary>
        /// CCC将工单定损信息传回汽修厂系统
        /// </summary>
        [AllowAnonymous]
        [Route("ClaimInfoNotification")]
        [AcceptVerbs("Get", "Post")]
        public ReturnResult GetPost()
        {
            return null;
        }
    }
}
