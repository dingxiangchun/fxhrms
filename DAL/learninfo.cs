using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class learninfo : POJO<tb_learninfo>
    {
        public learninfo()
        { }
        #region 成员方法

        public void Add(tb_learninfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_learninfo(");
            strSql.Append("employeeid,degree,starttime,graduatetime,graduatesch,retence,profession,content");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.degree + "',");
            strSql.Append("'" + model.starttime + "',");
            strSql.Append("'" + model.graduatetime + "',");
            strSql.Append("'" + model.graduatesch + "',");
            strSql.Append("'" + model.retence + "',");
            strSql.Append("'" + model.profession + "',");
            strSql.Append("'" + model.content + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Update(tb_learninfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_learninfo set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("degree='" + model.degree + "',");
            strSql.Append("starttime='" + model.starttime + "',");
            strSql.Append("graduatetime='" + model.graduatetime + "',");
            strSql.Append("graduatesch='" + model.graduatesch + "',");
            strSql.Append("retence='" + model.retence + "',");
            strSql.Append("profession='" + model.profession + "',");
            strSql.Append("content='" + model.content + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Delete(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_learninfo ");
            strSql.Append(" where " + strwhere);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
 
        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_learninfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where " + strWhere + "");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
