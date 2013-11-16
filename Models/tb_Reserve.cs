using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
   public class tb_Reserve
    {
        public tb_Reserve()
        { }
        
        #region Models
        private int _id;
        private string _ReserveType;
        private string _ReserveInfo;
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string ReserveType
        {
            set { _ReserveType = value; }//当给userName赋值时:userName=ss;则先执行set 
            get { return _ReserveType; }//当是从userName读取时，XX=userName则先执行get
        }
        public string ReserveInfo
        {
            set { _ReserveInfo = value; }
            get { return _ReserveInfo; }
        }

        #endregion
    }
}
