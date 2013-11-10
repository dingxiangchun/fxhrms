using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 职务实体类
    /// </summary>
    public class tb_headship
    {
        public tb_headship()
        { }
        #region Model
        private int _hid;
        private string _hname;
        /// <summary>
        /// 
        /// </summary>
        public int hid
        {
            set { _hid = value; }
            get { return _hid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string hName
        {
            set { _hname = value; }
            get { return _hname; }
        }
        #endregion Model
    }
}
