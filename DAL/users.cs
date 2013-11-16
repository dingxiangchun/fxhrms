using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 用户数据访问类
    /// </summary>
    public class users : POJO<tb_Users>
    {
        public users()
        { }
        #region 成员方法
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Exists(string uid,string pwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tb_Users");
            strSql.Append(" where loginname=@username and userpwd=@userpwd");//此SQL语句只返回结果0或1
            MySqlParameter[] parms ={ new MySqlParameter("@username", MySqlDbType.VarChar, 20), new MySqlParameter("@userpwd", MySqlDbType.VarChar, 20) };
            parms[0].Value = uid;
            parms[1].Value = pwd;
            bool pass = DbHelperSQL.Exists(strSql.ToString(), parms);
            return pass;
        }

        public void Add(tb_Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_Users(");
            strSql.Append("loginname,userpwd,username,userprower,Unit,remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.loginname + "',");
            strSql.Append("'" + model.userpwd + "',");
            strSql.Append("'" + model.username + "',");
            strSql.Append("" + model.userprower + ",");
            strSql.Append("'" + model.Unit + "',");
            strSql.Append("'" + model.remark + "',");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Update(tb_Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Users set ");
            strSql.Append("username='" + model.username + "'");
            strSql.Append("userprower=" + model.userprower + "");
            strSql.Append("Unit='" + model.Unit + "'");
            strSql.Append("remark='" + model.remark + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Users ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
 
        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_Users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where userName='" + strWhere + "'");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
