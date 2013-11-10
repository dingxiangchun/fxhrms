using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 民族数据访问类
    /// </summary>
    public class folk
    {
        public folk()
        { }
        #region 成员方法
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_folk model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_folk(");
            strSql.Append("folkName");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.folkName + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_folk model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_folk set ");
            strSql.Append("folkName='" + model.folkName + "'");
            strSql.Append(" where fid=" + model.fid + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int fid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_folk ");
            strSql.Append(" where fid=" + fid);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_folk ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by fid ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
