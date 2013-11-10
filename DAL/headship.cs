using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 职务数据访问类
    /// </summary>
    public class headship
    {
        public headship()
        { }
        #region 成员方法
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_headship model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_headship(");
            strSql.Append("hName");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.hName + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_headship model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_headship set ");
            strSql.Append("hName='" + model.hName + "'");
            strSql.Append(" where hid=" + model.hid + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int hid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_headship ");
            strSql.Append(" where hid=" + hid);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_headship ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by hid ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
