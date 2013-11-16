using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class tb_learninfo
    {
        public tb_learninfo()
        { }
        #region Models
        private int _id;
        private string _employeeid;
        private string _degree;
        private string _starttime;
        private string _graduatetime;
        private string _graduatesch;
        private string _retence;
        private string _profession;
        private string _content;

        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        public string employeeid
        {
            set { _employeeid = value; }//当给userName赋值时:userName=ss;则先执行set 
            get { return _employeeid; }//当是从userName读取时，XX=userName则先执行get
        }
        public string degree
        {
            set { _degree = value; }
            get { return _degree; }
        }
        public string starttime
        {
            set { _starttime = value; }
            get { return _starttime; }
        }
        public string graduatetime
        {
            set { _graduatetime = value; }
            get { return _graduatetime; }
        }
        public string graduatesch
        {
            set { _graduatesch = value; }
            get { return _graduatesch; }
        }
        public string retence
        {
            set { _retence = value; }
            get { return _retence; }
        }
        public string profession
        {
            set { _profession = value; }
            get { return _profession; }
        }
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        #endregion
    }
}
