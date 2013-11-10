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
        private string _pernum;
        private string _pername;
        private string _folk;
        private string _birthday;
        private int _age;
        private string _kultur;
        private string _marriage;
        private string _sex;
        private string _visage;
        private string _idcard;
        private string _origo;
        private string _workdate;
        private int _worklength;
        private string _employee;
        private string _intoworkdate;
        private int _intoworklength;
        private string _laboragetype;
        private string _branch;
        private string _headship;
        private string _zhichen;
        private string _phone;
        private string _handset;
        private string _school;
        private string _speciality;
        private string _graduatedate;
        private int _m_pay;
        private string _banknum;
        private string _address;
        private string _photoimage;
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
        public string perNum
        {
            set { _pernum = value; }
            get { return _pernum; }
        }
        /// <summary>
        /// 职工姓名
        /// </summary>
        public string perName
        {
            set { _pername = value; }
            get { return _pername; }
        }
        /// <summary>
        /// 民族
        /// </summary>
        public string folk
        {
            set { _folk = value; }
            get { return _folk; }
        }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 年龄
        /// </summary>
        public int age
        {
            set { _age = value; }
            get { return _age; }
        }
        /// <summary>
        /// 文化程度
        /// </summary>
        public string kultur
        {
            set { _kultur = value; }
            get { return _kultur; }
        }
        /// <summary>
        /// 婚姻
        /// </summary>
        public string marriage
        {
            set { _marriage = value; }
            get { return _marriage; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 政治面貌
        /// </summary>
        public string visage
        {
            set { _visage = value; }
            get { return _visage; }
        }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IDCard
        {
            set { _idcard = value; }
            get { return _idcard; }
        }
        /// <summary>
        /// 籍贯
        /// </summary>
        public string origo
        {
            set { _origo = value; }
            get { return _origo; }
        }
        /// <summary>
        /// 参加工作时间
        /// </summary>
        public string workDate
        {
            set { _workdate = value; }
            get { return _workdate; }
        }
        /// <summary>
        /// 工龄
        /// </summary>
        public int workLength
        {
            set { _worklength = value; }
            get { return _worklength; }
        }
        /// <summary>
        /// 职工类型
        /// </summary>
        public string employee
        {
            set { _employee = value; }
            get { return _employee; }
        }
        /// <summary>
        /// 进本单位时间
        /// </summary>
        public string intoWorkDate
        {
            set { _intoworkdate = value; }
            get { return _intoworkdate; }
        }
        /// <summary>
        /// 本单位工龄
        /// </summary>
        public int intoWorkLength
        {
            set { _intoworklength = value; }
            get { return _intoworklength; }
        }
        /// <summary>
        /// 工资类别
        /// </summary>
        public string laborageType
        {
            set { _laboragetype = value; }
            get { return _laboragetype; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string branch
        {
            set { _branch = value; }
            get { return _branch; }
        }
        /// <summary>
        /// 职务
        /// </summary>
        public string headship
        {
            set { _headship = value; }
            get { return _headship; }
        }
        /// <summary>
        /// 职称
        /// </summary>
        public string ZhiChen
        {
            set { _zhichen = value; }
            get { return _zhichen; }
        }
        /// <summary>
        /// 电话
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 手机
        /// </summary>
        public string handset
        {
            set { _handset = value; }
            get { return _handset; }
        }
        /// <summary>
        /// 毕业学校
        /// </summary>
        public string school
        {
            set { _school = value; }
            get { return _school; }
        }
        /// <summary>
        /// 专业
        /// </summary>
        public string speciality
        {
            set { _speciality = value; }
            get { return _speciality; }
        }
        /// <summary>
        /// 毕业时间
        /// </summary>
        public string GraduateDate
        {
            set { _graduatedate = value; }
            get { return _graduatedate; }
        }
        /// <summary>
        /// 月工资
        /// </summary>
        public int M_Pay
        {
            set { _m_pay = value; }
            get { return _m_pay; }
        }
        /// <summary>
        /// 银行帐号
        /// </summary>
        public string bankNum
        {
            set { _banknum = value; }
            get { return _banknum; }
        }
        /// <summary>
        /// 地址
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 照片
        /// </summary>
        public string photoImage
        {
            set { _photoimage = value; }
            get { return _photoimage; }
        }
        #endregion Model
    }
}
