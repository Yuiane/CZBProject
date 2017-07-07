using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZB.Model
{
    /// <summary>
	/// CZB_Material:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public partial class Material
    {
        public Material()
        { }
        #region Model
        private string _id;
        private int? _replytype;
        private string _context;
        private string _imageurl;
        private string _linkurl;
        private int? _state;
        private string _creater;
        private DateTime? _createtime = DateTime.Now;
        private string _updater;
        private DateTime? _updatetime;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 0.文字 1.图片 2.图文
        /// </summary>
        public int? ReplyType
        {
            set { _replytype = value; }
            get { return _replytype; }
        }
        /// <summary>
        /// 文字 图文的标题
        /// </summary>
        public string Context
        {
            set { _context = value; }
            get { return _context; }
        }
        /// <summary>
        /// 图文URL+图片
        /// </summary>
        public string ImageUrl
        {
            set { _imageurl = value; }
            get { return _imageurl; }
        }
        /// <summary>
        /// 图文链接URL
        /// </summary>
        public string LinkUrl
        {
            set { _linkurl = value; }
            get { return _linkurl; }
        }
        /// <summary>
        /// 0-有效 1-无效
        /// </summary>
        public int? State
        {
            set { _state = value; }
            get { return _state; }
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Creater
        {
            set { _creater = value; }
            get { return _creater; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? Createtime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Updater
        {
            set { _updater = value; }
            get { return _updater; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        #endregion Model

    }
}
