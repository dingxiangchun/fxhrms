using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_pertypeinfo
    {
        public tb_pertypeinfo()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _info;
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
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string info
        {
            set { _info = value; }
            get { return _info; }
        }
        #endregion Model
    }
}
