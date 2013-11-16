using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_registerinfo
    {
        public tb_registerinfo()
        {}

        #region Model
        private int _id;
        private string _employeeid;
        private string _type;
        private string _cer_name;
        private string _accesstime;
        private string _issuingtime;
        private string _unit;
        private string _Class;
        private string _photo;
        private string _description;
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
        public string cer_name
        {
            set { _cer_name = value; }
            get { return _cer_name; }
        }

        public string accesstime
        {
            set { _accesstime = value; }
            get { return _accesstime; }
        }

        public string issuingtime
        {
            set { _issuingtime = value; }
            get { return _issuingtime; }
        }

        public string unit
        {
            set { _unit = value; }
            get { return _unit; }
        }

        public string Class
        {
            set { _Class = value; }
            get { return _Class; }
        }

        public string photo
        {
            set { _photo = value; }
            get { return _photo; }
        }

        public string description
        {
            set { _description = value; }
            get { return _description; }
        }
        #endregion Model
    }
}
