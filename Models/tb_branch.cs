using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 部门实体类
    /// </summary>
    public class tb_branch
    {
        public tb_branch()
        { }
        #region Model
        private int _id;
        private string _branchnum;
        private string _branchname;
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
        public string branchNum
        {
            set { _branchnum = value; }
            get { return _branchnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string branchName
        {
            set { _branchname = value; }
            get { return _branchname; }
        }
        #endregion Model
    }
}
