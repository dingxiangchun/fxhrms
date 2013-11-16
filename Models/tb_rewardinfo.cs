using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_rewardinfo
    {
        public tb_rewardinfo()
        { }
        #region Model
        private int _id;
        private string _employeeid;
        private string _type;
        private string _time;
        private string _content;
        private string _department;
        private string _audit;
        private string _Class;
        private string _unit;
        private string _description;
        private string _File;
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
        public string type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string time
        {
            set { _time = value; }
            get { return _time; }
        }

        public string content
        {
            set { _content = value; }
            get { return _content; }
        }

        public string department
        {
            set { _department = value; }
            get { return _department; }
        }

        public string audit
        {
            set { _audit = value; }
            get { return _audit; }
        }

        public string Class
        {
            set { _Class = value; }
            get { return _Class; }
        }

        public string unit
        {
            set { _unit = value; }
            get { return _unit; }
        }

        public string description
        {
            set { _description = value; }
            get { return _description; }
        }

        public string File
        {
            set { _File = value; }
            get { return _File; }
        }
        #endregion Model
    }
}
