using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class pertypeinfoData:POJO<tb_pertypeinfo>
    {
        public pertypeinfoData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_pertypeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_pertypeinfo(");
            strSql.Append("name,info");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.name + "',");
            strSql.Append("'" + model.info + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_pertypeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_pertypeinfo set ");
            strSql.Append("name='" + model.name + "',");
            strSql.Append("info='" + model.info + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_pertypeinfo ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_pertypeinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where id=" + strWhere + "");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
