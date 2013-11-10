using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 家庭实体类
    /// </summary>
    public class tb_family
    {
        public tb_family()
        { }
        #region Model
        private int _id;
        private string _perid;
        private string _leaguername;
        private string _nexus;
        private string _birthdate;
        private string _workinc;
        private string _headship;
        private string _visage;
        private string _phone;
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
        public string LeaguerName
        {
            set { _leaguername = value; }
            get { return _leaguername; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Nexus
        {
            set { _nexus = value; }
            get { return _nexus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BirthDate
        {
            set { _birthdate = value; }
            get { return _birthdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkInc
        {
            set { _workinc = value; }
            get { return _workinc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string headship
        {
            set { _headship = value; }
            get { return _headship; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string visage
        {
            set { _visage = value; }
            get { return _visage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        #endregion Model
    }
}
