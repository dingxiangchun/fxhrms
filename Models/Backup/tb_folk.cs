using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 民族实体类
    /// </summary>
    public class tb_folk
    {
        public tb_folk()
        { }
        #region Model
        private int _fid;
        private string _folkname;
        /// <summary>
        /// 
        /// </summary>
        public int fid
        {
            set { _fid = value; }
            get { return _fid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string folkName
        {
            set { _folkname = value; }
            get { return _folkname; }
        }
        #endregion Model
    }
}
