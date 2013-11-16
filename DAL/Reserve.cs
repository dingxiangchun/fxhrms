using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class Reserve : POJO<tb_Reserve>
    {
        public Reserve()
        { }
        #region 成员方法
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public void Add(tb_Reserve model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_Reserve(");
            strSql.Append("ReserveType,ReserveInfo");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.ReserveType + "',");
            strSql.Append("'" + model.ReserveInfo + "',");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Update(tb_Reserve model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Reserve set ");
            strSql.Append("ReserveType='" + model.ReserveType + "'");
            strSql.Append("ReserveInfo=" + model.ReserveInfo + "");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_Reserve ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_Reserve ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where " + strWhere);
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
