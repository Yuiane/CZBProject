using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Common.CCCModel
{

    public class PostModel
    {
        public string partyId { get; set; }
        public string businessNo { get; set; }
        public PostBaseModel content { get; set; }
    }

    public class PostBaseModel
    {
        public string repairOrderNo { get; set; }
        public string repairOrderTypeCode { get; set; }
        public string modifyDate { get; set; }
        public string vehicleOwnerName { get; set; }
        public string vehicleOwnerTelNo { get; set; }
        public string messageSendTypeCode { get; set; }
        public string estimatePickCarDate { get; set; }
        public string pickCarDate { get; set; }
    }

}
