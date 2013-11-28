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
        private string _employeeid;
        private string _attacktime;
        private string _quittime;
        private string _position;
        private string _unit;
        private string _reason;
        private string _content;
        private int _mark;
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
        #endregion Model
    }
}
