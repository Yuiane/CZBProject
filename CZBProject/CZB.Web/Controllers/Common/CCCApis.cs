using CZB.Common;
using CZB.Common.Enums;
using CZB.Common.Extensions;

namespace CZB.Web.Common
{
    public class CCCApis
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="postJson"></param>
        public void SendToSiTeng(string postJson)
        {
            //userName=dsbp&passWord=666666&clientId=AW0001
            var postValue1 = "userName=automan&passWord=c655ab48d02e4edcaddc7bc81661d35e&clientId=AW0001";
            var _value = Utils.HttpRequestSiTeng("http://wechat.51sten.com/autoOpen/api/drp/login", RequestType.POST, postValue1);
            LogHelper.WriteLog(LogEnum.SiTengApi, "login:" + _value);
            SiTengReturn model = _value.JsonToObj<SiTengReturn>();
            if (model != null && model.restCode == 0)
            {
                var postValue2 = string.Format("token={0}&clientId={1}&drpData={2}", model.token, "AW0001", postJson);
                var _value2 = Utils.HttpRequestSiTeng("http://wechat.51sten.com/autoOpen/api/drp/addDrpRepairSheet", RequestType.POST, postValue2);
                LogHelper.WriteLog(LogEnum.SiTengApi, "addDrpRepairSheet:" + _value2 + "参数:" + postValue2);
            }
        }
    }


    public class SiTengReturn
    {
        public int restCode { get; set; }
        public string restContent { get; set; }
        public string resTime { get; set; }
        public string token { get; set; }
    }
}
