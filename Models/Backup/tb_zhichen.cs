using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 职称实体类
    /// </summary>
    public class tb_zhichen
    {
        public tb_zhichen()
        { }
        #region Model
        private int _zcid;
        private string _zcname;
        /// <summary>
        /// 
        /// </summary>
        public int ZCID
        {
            set { _zcid = value; }
            get { return _zcid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZCName
        {
            set { _zcname = value; }
            get { return _zcname; }
        }
        #endregion Model
    }
}
