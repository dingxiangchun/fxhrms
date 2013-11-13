using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 赏罚实体类
    /// </summary>
    public class tb_RandP
    {
        public tb_RandP()
        { }
        #region Model
        private int _id;
        private string _perid;
        private string _rpkind;
        private string _rpdate;
        private string _confirmman;
        private string _quashdate;
        private string _quashwhys;
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
        public string RPKind
        {
            set { _rpkind = value; }
            get { return _rpkind; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RPDate
        {
            set { _rpdate = value; }
            get { return _rpdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string confirmMan
        {
            set { _confirmman = value; }
            get { return _confirmman; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QuashDate
        {
            set { _quashdate = value; }
            get { return _quashdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QuashWhys
        {
            set { _quashwhys = value; }
            get { return _quashwhys; }
        }
        #endregion Model
    }
}
