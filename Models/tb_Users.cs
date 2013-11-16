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
        private string _loginname;
        private string _userpwd;
        private string _username;
        private int _userprower;
        private string _Unit;
        private string _remark;

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string loginname
        {
            set { _loginname = value; }//当给userName赋值时:userName=ss;则先执行set 
            get { return _loginname; }//当是从userName读取时，XX=userName则先执行get
        }
        public string userpwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        public int userprower
        {
            set { _userprower = value; }
            get { return _userprower; }
        }
        public string Unit
        {
            set { _Unit = value; }
            get { return _Unit; }
        }
        public string remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        #endregion

    }
}
