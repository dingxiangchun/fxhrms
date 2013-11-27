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

        public bool Add(tb_Users model)
        {
            try
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
                if (DbHelperSQL.ExecuteSql(strSql.ToString()) > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(tb_Users model)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update tb_Users set ");
                strSql.Append("loginname='" + model.loginname + "',");
                strSql.Append("userpwd='" + model.userpwd + "',");
                strSql.Append("username='" + model.username + "',");
                strSql.Append("userprower=" + model.userprower + ",");
                strSql.Append("Unit='" + model.Unit + "',");
                strSql.Append("remark='" + model.remark + "'");
                strSql.Append(" where id=" + model.id + "");
                if (DbHelperSQL.ExecuteSql(strSql.ToString()) > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("delete from tb_Users ");
                strSql.Append(" where id=" + id);
                if (DbHelperSQL.ExecuteSql(strSql.ToString()) > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
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
