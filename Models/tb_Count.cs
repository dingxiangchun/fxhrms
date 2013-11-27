using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_Count
    {
        public tb_Count()
        { }
        #region Model
        private string _CountName;
        private Int64 _Count;

        public string CountName
        {
            set { _CountName = value; }
            get { return _CountName; }
        }

        public Int64 Count
        {
            set { _Count = value; }
            get { return _Count; }
        }
        #endregion Model
    }
}
