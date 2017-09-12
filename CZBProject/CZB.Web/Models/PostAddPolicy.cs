namespace CZB.Web.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PostAddPolicy
    {
        public string cityCode;

        public int agentId { get; set; }

        public string customerName { get; set; }

        public string customerPhone { get; set; }

        public string codeType { get; set; }

        public string codeTypeValue { get; set; }

        public string _1_image_path { get; set; }

        public string _2_image_path { get; set; }

        public string notifications { get; set; }

        public string timeStarts { get; set; }

        public string timeEnd { get; set; }

        public string insureListSelectedString { get; set; }

        public string textarea { get; set; }
    }
}
