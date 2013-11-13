using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class tb_Users
    {
        public tb_Users()
        { }
        
        #region Models
        private int _id;
        private string _username;
        private string _userpwd;
        private int _usergroup;

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string userName
        {
            set { _username = value; }//当给userName赋值时:userName=ss;则先执行set 
            get { return _username; }//当是从userName读取时，XX=userName则先执行get
        }
        public string userPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        public int userGroup
        {
            set { _usergroup = value; }
            get { return _usergroup; }
        }
        #endregion

    }
}
