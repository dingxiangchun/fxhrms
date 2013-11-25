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
        private string _employeeid;
        private string _name;
        private string _relation;
        private string _birth;
        private string _tel;
        private string _unit;
        private string _status;
        private string _situation;
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

        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string relation
        {
            set { _relation = value; }
            get { return _relation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string birth
        {
            set { _birth = value; }
            get { return _birth; }
        }

        public string tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string status
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string situation
        {
            set { _situation = value; }
            get { return _situation; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion Model
    }
}
