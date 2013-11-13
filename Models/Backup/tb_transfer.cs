using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 人事调动实体类
    /// </summary>
    public class tb_transfer
    {
        public tb_transfer()
        { }
        #region Model
        private int _id;
        private string _perid;
        private string _tradate;
        private string _tratype;
        private string _treformer;
        private string _treafter;
        private string _trewhys;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 职工编号
        /// </summary>
        public string perID
        {
            set { _perid = value; }
            get { return _perid; }
        }
        /// <summary>
        /// 调动时间
        /// </summary>
        public string traDate
        {
            set { _tradate = value; }
            get { return _tradate; }
        }
        /// <summary>
        /// 调动类别
        /// </summary>
        public string traType
        {
            set { _tratype = value; }
            get { return _tratype; }
        }
        /// <summary>
        /// 调动前
        /// </summary>
        public string treFormer
        {
            set { _treformer = value; }
            get { return _treformer; }
        }
        /// <summary>
        /// 调动后
        /// </summary>
        public string treAfter
        {
            set { _treafter = value; }
            get { return _treafter; }
        }
        /// <summary>
        /// 调动原因
        /// </summary>
        public string treWhys
        {
            set { _trewhys = value; }
            get { return _trewhys; }
        }
        #endregion Model
    }
}
