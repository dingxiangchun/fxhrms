using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 通信录实体类
    /// </summary>
    public class tb_addressBook
    {
        public tb_addressBook()
        { }

        #region Models
        private int _id;
        private string _uname;
        private string _sex;
        private string _phone;
        private string _handset;
        private string _workphone;
        private string _qq;
        private string _e_mail;
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
        public string uName
        {
            set { _uname = value; }
            get { return _uname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string handset
        {
            set { _handset = value; }
            get { return _handset; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string workPhone
        {
            set { _workphone = value; }
            get { return _workphone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string e_mail
        {
            set { _e_mail = value; }
            get { return _e_mail; }
        }
        #endregion Model
    }
}
