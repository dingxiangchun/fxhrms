using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_workchange
    {
        public tb_workchange()
        { }
        #region Model
        private int _id;
        private int _resumeid;
        private int _positionid;
        private int _unitid;
        private string _attacktime;
        private string _employeename;
        private string _Employeeid;
        private string _OldPositionName;
        private string _NewPositionName;
        private string _OldUnitName;
        private string _NewUnitName;
        private string _reason;
        private string _content;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }

        public int resumeid
        {
            set { _resumeid = value; }
            get { return _resumeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int positionid
        {
            set { _positionid = value; }
            get { return _positionid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int unitid
        {
            set { _unitid = value; }
            get { return _unitid; }
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
        public string employeename
        {
            set { _employeename = value; }
            get { return _employeename; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Employeeid
        {
            set { _Employeeid = value; }
            get { return _Employeeid; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OldPositionName
        {
            set { _OldPositionName = value; }
            get { return _OldPositionName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NewPositionName
        {
            set { _NewPositionName = value; }
            get { return _NewPositionName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string OldUnitName
        {
            set { _OldUnitName = value; }
            get { return _OldUnitName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string NewUnitName
        {
            set { _NewUnitName = value; }
            get { return _NewUnitName; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string reason
        {
            set { _reason = value; }
            get { return _reason; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        #endregion Model
    }
}
