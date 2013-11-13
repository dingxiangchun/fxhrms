using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 工作简历实体类
    /// </summary>
    public class tb_workresume
    {
        public tb_workresume()
        { }
        #region Model
        private int _id;
        private string _perid;
        private string _begindate;
        private string _enddate;
        private string _branch;
        private string _headship;
        private string _incname;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string perID
        {
            set { _perid = value; }
            get { return _perid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beginDate
        {
            set { _begindate = value; }
            get { return _begindate; }
        }
        /// <summary>
        /// 结束时间
        /// </summary>
        public string endDate
        {
            set { _enddate = value; }
            get { return _enddate; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string branch
        {
            set { _branch = value; }
            get { return _branch; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public string headship
        {
            set { _headship = value; }
            get { return _headship; }
        }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string IncName
        {
            set { _incname = value; }
            get { return _incname; }
        }
        #endregion Model
    }
}
