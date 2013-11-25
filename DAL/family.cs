using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 家庭数据访问类
    /// </summary>
    public class family : POJO<tb_family>
    {
        public family()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_family model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_family(");
            strSql.Append("employeeid,name,relation,birth,tel,unit,status,situation,remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.name + "',");
            strSql.Append("'" + model.relation + "',");
            strSql.Append("'" + model.birth + "',");
            strSql.Append("'" + model.tel + "',");
            strSql.Append("'" + model.unit + "',");
            strSql.Append("'" + model.status + "',");
            strSql.Append("'" + model.situation + "',");
            strSql.Append("'" + model.remark + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_family model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_family set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("name='" + model.name + "',");
            strSql.Append("relation='" + model.relation + "',");
            strSql.Append("birth='" + model.birth + "',");
            strSql.Append("tel='" + model.tel + "',");
            strSql.Append("unit='" + model.unit + "',");
            strSql.Append("status='" + model.status + "',");
            strSql.Append("situation='" + model.situation + "',");
            strSql.Append("remark='" + model.remark + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_family ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

 
        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_family ");
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
