using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_holidayrecords
    {
        public tb_holidayrecords()
        {}
        #region Model
        private int _id;
        private string _employeeid;
        private string _holiday;
        private float _days;
        private string _reason;
        private string _audit;
        private string _begintime;
        private string _Endtime;
        private float _days1;
        private string _remark;
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
        public string holiday
        {
            set { _holiday = value; }
            get { return _holiday; }
        }
        /// <summary>
        /// 
        /// </summary>
        public float days
        {
            set { _days = value; }
            get { return _days; }
        }

        public string reason
        {
            set { _reason = value; }
            get { return _reason; }
        }

        public string audit
        {
            set { _audit = value; }
            get { return _audit; }
        }

        public string begintime
        {
            set { _begintime = value; }
            get { return _begintime; }
        }

        public string Endtime
        {
            set { _Endtime = value; }
            get { return _Endtime; }
        }

        public float days1
        {
            set { _days1 = value; }
            get { return _days1; }
        }

        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }

        #endregion Model
    }
}
