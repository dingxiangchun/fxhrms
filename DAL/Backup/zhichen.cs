using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 职称数据访问类
    /// </summary>
    public class zhichen
    {
        public zhichen()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_zhichen model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_zhichen(");
            strSql.Append("ZCName");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.ZCName + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_zhichen model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_zhichen set ");
            strSql.Append("ZCName='" + model.ZCName + "'");
            strSql.Append(" where ZCID=" + model.ZCID + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ZCID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_zhichen ");
            strSql.Append(" where ZCID=" + ZCID);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_zhichen ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by ZCID ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
