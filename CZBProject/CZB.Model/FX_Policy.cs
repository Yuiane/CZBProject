using System;
namespace CZB.Model
{
	/// <summary>
	/// FX_Policy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FX_Policy
	{
		public FX_Policy()
		{}
		#region Model
		private int _policyid;
		private int? _agentid;
		private int? _customerid;
		private string _vin;
		private string _drivinglicense;
		private string _drivinglicensepic;
		private int? _cartype;
		private string _organizationcode;
		private string _insurecode;
		private string _fx_policyno;
		private string _policynocompulsory;
		private string _policynobusiness;
		private int? _policytype;
		private DateTime? _createtime;
		private DateTime? _paytime;
		private DateTime? _offertime;
		private int? _offernum=0;
		private int? _policystate;
		private int? _paystate;
		private string _payurl;
		private string _payvalidatecode;
		private string _paydealcode;
		private decimal? _policyamount;
		private decimal? _compulsoryamount;
		private decimal? _businessamount;
		private decimal? _vehicleandvesseltax;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private string _citycode;
		private decimal? _discount;
		private int? _userid;
		private string _remark;
		private string _cancelremark;
		private int? _rejectnum=0;
		private DateTime? _rejecttime;
		private string _customername;
		private string _customermoblie;
		private string _customeridno;
		private string _customeridpic;
		private string _carmodel;
		private string _carno;
		private string _carengineno;
		private DateTime? _carregisterdate;
		private bool _isread= false;
		private decimal? _safetyfactor;
		private int? _dangerouscount;
		private DateTime? _inquirydate;
		private int? _comefrom=1;
		private string _czbtbcustomerid;
		/// <summary>
		/// 
		/// </summary>
		public int PolicyId
		{
			set{ _policyid=value;}
			get{return _policyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AgentId
		{
			set{ _agentid=value;}
			get{return _agentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CustomerId
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VIN
		{
			set{ _vin=value;}
			get{return _vin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DrivingLicense
		{
			set{ _drivinglicense=value;}
			get{return _drivinglicense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DrivingLicensePic
		{
			set{ _drivinglicensepic=value;}
			get{return _drivinglicensepic;}
		}
		/// <summary>
		/// 车辆类型
		/// </summary>
		public int? CarType
		{
			set{ _cartype=value;}
			get{return _cartype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrganizationCode
		{
			set{ _organizationcode=value;}
			get{return _organizationcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InsureCode
		{
			set{ _insurecode=value;}
			get{return _insurecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FX_PolicyNo
		{
			set{ _fx_policyno=value;}
			get{return _fx_policyno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PolicyNoCompulsory
		{
			set{ _policynocompulsory=value;}
			get{return _policynocompulsory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PolicyNoBusiness
		{
			set{ _policynobusiness=value;}
			get{return _policynobusiness;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PolicyType
		{
			set{ _policytype=value;}
			get{return _policytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PayTime
		{
			set{ _paytime=value;}
			get{return _paytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OfferTime
		{
			set{ _offertime=value;}
			get{return _offertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OfferNum
		{
			set{ _offernum=value;}
			get{return _offernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PolicyState
		{
			set{ _policystate=value;}
			get{return _policystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PayState
		{
			set{ _paystate=value;}
			get{return _paystate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayUrl
		{
			set{ _payurl=value;}
			get{return _payurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayValidateCode
		{
			set{ _payvalidatecode=value;}
			get{return _payvalidatecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PaydealCode
		{
			set{ _paydealcode=value;}
			get{return _paydealcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PolicyAmount
		{
			set{ _policyamount=value;}
			get{return _policyamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? CompulsoryAmount
		{
			set{ _compulsoryamount=value;}
			get{return _compulsoryamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BusinessAmount
		{
			set{ _businessamount=value;}
			get{return _businessamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? VehicleAndVesselTax
		{
			set{ _vehicleandvesseltax=value;}
			get{return _vehicleandvesseltax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CityCode
		{
			set{ _citycode=value;}
			get{return _citycode;}
		}
		/// <summary>
		/// 折扣
		/// </summary>
		public decimal? Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CancelRemark
		{
			set{ _cancelremark=value;}
			get{return _cancelremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RejectNum
		{
			set{ _rejectnum=value;}
			get{return _rejectnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RejectTime
		{
			set{ _rejecttime=value;}
			get{return _rejecttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerMoblie
		{
			set{ _customermoblie=value;}
			get{return _customermoblie;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerIdNo
		{
			set{ _customeridno=value;}
			get{return _customeridno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerIdPic
		{
			set{ _customeridpic=value;}
			get{return _customeridpic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarModel
		{
			set{ _carmodel=value;}
			get{return _carmodel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarNo
		{
			set{ _carno=value;}
			get{return _carno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CarEngineNo
		{
			set{ _carengineno=value;}
			get{return _carengineno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CarRegisterDate
		{
			set{ _carregisterdate=value;}
			get{return _carregisterdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsRead
		{
			set{ _isread=value;}
			get{return _isread;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SafetyFactor
		{
			set{ _safetyfactor=value;}
			get{return _safetyfactor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DangerousCount
		{
			set{ _dangerouscount=value;}
			get{return _dangerouscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? InquiryDate
		{
			set{ _inquirydate=value;}
			get{return _inquirydate;}
		}
		/// <summary>
		/// 1代理销售2平台自营
		/// </summary>
		public int? ComeFrom
		{
			set{ _comefrom=value;}
			get{return _comefrom;}
		}
		/// <summary>
		/// 自营车主数据
		/// </summary>
		public string CZBTbCustomerID
		{
			set{ _czbtbcustomerid=value;}
			get{return _czbtbcustomerid;}
		}
		#endregion Model

	}
}

