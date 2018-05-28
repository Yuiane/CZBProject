using System;

namespace CZB.Model
{
    /// <summary>
    /// TB_Czb_CarOwner:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class TB_Czb_CarOwner
    {
        public TB_Czb_CarOwner()
        { }
        #region Model
        private string _id = "newid";
        private string _name;
        private string _nickname;
        private string _openid;
        private string _phonenumber;
        private string _pinyin;
        private string _pinyinshort;
        private string _idcard;
        private string _idcardimage;
        private bool _iscertificate;
        private bool _isvip;
        private bool _isenable;
        private bool _isvalid;
        private string _creator;
        private DateTime _createtime = DateTime.Now;
        private string _modifier;
        private DateTime? _modifytime;
        private string _headimage;
        private string _citycode;
        private int? _comefrom;
        private string _storeid;
        private decimal? _amount = 0M;
        private int? _isrecommend;
        private string _recommender;
        private string _app_headimage;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NickName
        {
            set { _nickname = value; }
            get { return _nickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OpenId
        {
            set { _openid = value; }
            get { return _openid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PhoneNumber
        {
            set { _phonenumber = value; }
            get { return _phonenumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PinYin
        {
            set { _pinyin = value; }
            get { return _pinyin; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PinYinShort
        {
            set { _pinyinshort = value; }
            get { return _pinyinshort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDCard
        {
            set { _idcard = value; }
            get { return _idcard; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDCardImage
        {
            set { _idcardimage = value; }
            get { return _idcardimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCertificate
        {
            set { _iscertificate = value; }
            get { return _iscertificate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsVip
        {
            set { _isvip = value; }
            get { return _isvip; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsEnable
        {
            set { _isenable = value; }
            get { return _isenable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsValid
        {
            set { _isvalid = value; }
            get { return _isvalid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Creator
        {
            set { _creator = value; }
            get { return _creator; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Modifier
        {
            set { _modifier = value; }
            get { return _modifier; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ModifyTime
        {
            set { _modifytime = value; }
            get { return _modifytime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HeadImage
        {
            set { _headimage = value; }
            get { return _headimage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CityCode
        {
            set { _citycode = value; }
            get { return _citycode; }
        }
        /// <summary>
        /// 5.客服直接录入车主信息 6.门店渠道录入潜在客户信息
        /// </summary>
        public int? ComeFrom
        {
            set { _comefrom = value; }
            get { return _comefrom; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string StoreID
        {
            set { _storeid = value; }
            get { return _storeid; }
        }
        /// <summary>
        /// 账户余额，自营保单分佣
        /// </summary>
        public decimal? Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsRecommend
        {
            set { _isrecommend = value; }
            get { return _isrecommend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Recommender
        {
            set { _recommender = value; }
            get { return _recommender; }
        }
        /// <summary>
        /// app用户头像
        /// </summary>
        public string App_HeadImage
        {
            set { _app_headimage = value; }
            get { return _app_headimage; }
        }
        #endregion Model

    }
}
