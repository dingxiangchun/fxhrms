using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_resumeinfo
    {
        public tb_resumeinfo()
        { }
        #region Model
        private int _id;
        private string _employeename;
        private string _employeeid;
        private string _attacktime;
        private string _quittime;
        private string _position;
        private string _positionname;
        private int _unitid;
        private string _unit;
        private string _reason;
        private string _content;
        private int _mark;
        private string _audit;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string employeename
        {
            set { _employeename = value; }
            get { return _employeename; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string employeeid
        {
            set { _employeeid = value; }
            get { return _employeeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string attacktime
        {
            set { _attacktime = value; }
            get { return _attacktime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string quittime
        {
            set { _quittime = value; }
            get { return _quittime; }
        }

        public string position
        {
            set { _position = value; }
            get { return _position; }
        }

        public string positionname
        {
            set { _positionname = value; }
            get { return _positionname; }
        }

        public int unitid
        {
            set { _unitid = value; }
            get { return _unitid; }
        }

        public string unit
        {
            set { _unit = value; }
            get { return _unit; }
        }

        public string reason
        {
            set { _reason = value; }
            get { return _reason; }
        }

        public string content
        {
            set { _content = value; }
            get { return _content; }
        }

        public int mark
        {
            set { _mark = value; }
            get { return _mark; }
        }

        public string audit
        {
            set { _audit = value; }
            get { return _audit; }
        }
        #endregion Model
    }
}
