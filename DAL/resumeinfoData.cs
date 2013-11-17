using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class resumeinfoData : POJO<tb_resumeinfo>
    {
        public resumeinfoData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_resumeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_resumeinfo(");
            strSql.Append("employeeid,attacktime,quittime,position,unit,reason,content");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.attacktime + "',");
            strSql.Append("'" + model.quittime + "',");
            strSql.Append("'" + model.position + "',");
            strSql.Append("'" + model.unit + "',");
            strSql.Append("'" + model.reason + "',");
            strSql.Append("'" + model.content + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_resumeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_resumeinfo set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("attacktime='" + model.attacktime + "',");
            strSql.Append("quittime='" + model.quittime + "',");
            strSql.Append("position='" + model.position + "',");
            strSql.Append("unit='" + model.unit + "',");
            strSql.Append("reason='" + model.reason + "',");
            strSql.Append("content='" + model.content + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_resumeinfo ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_resumeinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere + "");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
