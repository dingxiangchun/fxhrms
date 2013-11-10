using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 记事簿实体类
    /// </summary>
    public class tb_blotter
    {
        public tb_blotter()
        { }
        #region Model
        private int _id;
        private string _notedate;
        private string _notesort;
        private string _ttitle;
        private string _tcontent;
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
        public string noteDate
        {
            set { _notedate = value; }
            get { return _notedate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string noteSort
        {
            set { _notesort = value; }
            get { return _notesort; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tTitle
        {
            set { _ttitle = value; }
            get { return _ttitle; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tContent
        {
            set { _tcontent = value; }
            get { return _tcontent; }
        }
        #endregion Model
    }
}
