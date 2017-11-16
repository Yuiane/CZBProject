using System;
namespace CZB.Model
{
    /// <summary>
    /// FX_Agent:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FX_Agent
    {
        public FX_Agent()
        { }
        #region Model
        private int _agentid;
        private string _truename;
        private string _idno;
        private string _mobile;
        private string _useraccountnumer;
        private string _password;
        private string _openid;
        private string _wxname;
        private string _facepic;
        private int? _provid;
        private int? _cityid;
        private string _address;
        private int? _parentid;
        private string _parentlist;
        private int? _agentlevel;
        private decimal? _totalamout;
        private decimal? _availableamount;
        private string _citycode;
        private DateTime? _createtime;
        private bool _isdelete;
        private bool _isuse;
        private int? _roletypeid;
        private int? _sharerate = 1;
        private string _shareurl;
        private int? _comefrom = 1;
        private string _thirdOpenId;

        public string ThirdOpenId
        {
            set { _thirdOpenId = value; }
            get { return _thirdOpenId; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AgentId
        {
            set { _agentid = value; }
            get { return _agentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TrueName
        {
            set { _truename = value; }
            get { return _truename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IDNO
        {
            set { _idno = value; }
            get { return _idno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set { _mobile = value; }
            get { return _mobile; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserAccountNumer
        {
            set { _useraccountnumer = value; }
            get { return _useraccountnumer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
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
        public string WXName
        {
            set { _wxname = value; }
            get { return _wxname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FacePic
        {
            set { _facepic = value; }
            get { return _facepic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ProvId
        {
            set { _provid = value; }
            get { return _provid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CityId
        {
            set { _cityid = value; }
            get { return _cityid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ParentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ParentList
        {
            set { _parentlist = value; }
            get { return _parentlist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? AgentLevel
        {
            set { _agentlevel = value; }
            get { return _agentlevel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TotalAmout
        {
            set { _totalamout = value; }
            get { return _totalamout; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? AvailableAmount
        {
            set { _availableamount = value; }
            get { return _availableamount; }
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
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDelete
        {
            set { _isdelete = value; }
            get { return _isdelete; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsUse
        {
            set { _isuse = value; }
            get { return _isuse; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RoleTypeID
        {
            set { _roletypeid = value; }
            get { return _roletypeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ShareRate
        {
            set { _sharerate = value; }
            get { return _sharerate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ShareUrl
        {
            set { _shareurl = value; }
            get { return _shareurl; }
        }
        /// <summary>
        /// 代理销售来源 1自营 
        /// </summary>
        public int? ComeFrom
        {
            set { _comefrom = value; }
            get { return _comefrom; }
        }
        #endregion Model

    }
}
