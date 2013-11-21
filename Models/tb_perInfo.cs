using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    /// <summary>
    /// 员工信息实体类
    /// </summary>
    public class tb_perInfo
    {
        public tb_perInfo()
        { }
        #region Model
        private int _id;
        private string _name;
        private string _Employeeid;
        private string _Sex;
        private string _Nation;
        private string _Birth;
        private string _Idcard;
        private int _UnitID;
        private string _Unit;
        private string _Position;
        private string _Rank;
        private int _Level;
        private string _Status;
        private string _Jobtime;
        private string _financetime;
        private string _fulltime_educ;
        private string _fulltime_sch;
        private string _Major;
        private string _Married;
        private string _Town;
        private string _Tel;
        private string _final_sch;
        private string _final_edu;
        private string _Address;
        private string _Reserve;
        private string _Guard;
        private int _Ages;
        private string _Class;
        private string _photo;
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
        public string Employeeid
        {
            set { _Employeeid = value; }
            get { return _Employeeid; }
        }
        /// <summary>
        /// 职工姓名
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex
        {
            set { _Sex = value; }
            get { return _Sex; }
        }
        /// <summary>
        /// 民族
        /// </summary>
        public string Nation
        {
            set { _Nation = value; }
            get { return _Nation; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public string Birth
        {
            set { _Birth = value; }
            get { return _Birth; }
        }
        /// <summary>
        ///身份证号
        /// </summary>
        public string Idcard
        {
            set { _Idcard = value; }
            get { return _Idcard; }
        }

        /// <summary>
        /// 单位ID
        /// </summary>
        public int UnitID
        {
            set { _UnitID = value; }
            get { return _UnitID; }
        }

        /// <summary>
        /// 单位
        /// </summary>
        public string Unit
        {
            set { _Unit = value; }
            get { return _Unit; }
        }
        /// <summary>
        /// 岗位
        /// </summary>
        public string Position
        {
            set { _Position = value; }
            get { return _Position; }
        }
        /// <summary>
        /// 职级
        /// </summary>
        public string Rank
        {
            set { _Rank = value; }
            get { return _Rank; }
        }
        /// <summary>
        /// 档次
        /// </summary>
        public int Level
        {
            set { _Level = value; }
            get { return _Level; }
        }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string Status
        {
            set { _Status = value; }
            get { return _Status; }
        }
        /// <summary>
        /// 参加工作时间
        /// </summary>
        public string Jobtime
        {
            set { _Jobtime = value; }
            get { return _Jobtime; }
        }
        /// <summary>
        /// 金融从业时间
        /// </summary>
        public string financetime
        {
            set { _financetime = value; }
            get { return _financetime; }
        }
        /// <summary>
        /// 全日制学历
        /// </summary>
        public string fulltime_educ
        {
            set { _fulltime_educ = value; }
            get { return _fulltime_educ; }
        }
        /// <summary>
        /// 全日制毕业院校
        /// </summary>
        public string fulltime_sch
        {
            set { _fulltime_sch = value; }
            get { return _fulltime_sch; }
        }
        /// <summary>
        /// 学习专业
        /// </summary>
        public string Major
        {
            set { _Major = value; }
            get { return _Major; }
        }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string Town
        {
            set { _Town = value; }
            get { return _Town; }
        }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public string Married
        {
            set { _Married = value; }
            get { return _Married; }
        }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Tel
        {
            set { _Tel = value; }
            get { return _Tel; }
        }
        /// <summary>
        /// 最终学历毕业学校
        /// </summary>
        public string final_sch
        {
            set { _final_sch = value; }
            get { return _final_sch; }
        }
        /// <summary>
        ///最终学历专业
        /// </summary>
        public string final_edu
        {
            set { _final_edu = value; }
            get { return _final_edu; }
        }
        /// <summary>
        /// 家庭住址
        /// </summary>
        public string Address
        {
            set { _Address = value; }
            get { return _Address; }
        }
        /// <summary>
        ///后备人才库
        /// </summary>
        public string Reserve
        {
            set { _Reserve = value; }
            get { return _Reserve; }
        }
        /// <summary>
        /// 用工类别
        /// </summary>
        public string Guard
        {
            set { _Guard = value; }
            get { return _Guard; }
        }
        /// <summary>
        /// 工龄
        /// </summary>
        public int Ages
        {
            set { _Ages = value; }
            get { return _Ages; }
        }
        /// <summary>
        /// 员工类型
        /// </summary>
        public string Class
        {
            set { _Class = value; }
            get { return _Class; }
        }
        /// <summary>
        /// 照片
        /// </summary>
        public string photo
        {
            set { _photo = value; }
            get { return _photo; }
        }
        #endregion Model
    }
}
