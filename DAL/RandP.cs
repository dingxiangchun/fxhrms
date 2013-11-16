using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 赏罚数据访问类
    /// </summary>
    public class RandP : POJO<tb_RandP>
    {
        public RandP()
        { }
        #region 成员方法
        tb_RandP model = new tb_RandP();
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_RandP(");
            strSql.Append("perID,RPKind,RPDate,confirmMan,QuashDate,QuashWhys");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.perID + "',");
            strSql.Append("'" + model.RPKind + "',");
            strSql.Append("'" + model.RPDate + "',");
            strSql.Append("'" + model.confirmMan + "',");
            strSql.Append("'" + model.QuashDate + "',");
            strSql.Append("'" + model.QuashWhys + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_RandP set ");
            strSql.Append("perID='" + model.perID + "',");
            strSql.Append("RPKind='" + model.RPKind + "',");
            strSql.Append("RPDate='" + model.RPDate + "',");
            strSql.Append("confirmMan='" + model.confirmMan + "',");
            strSql.Append("QuashDate='" + model.QuashDate + "',");
            strSql.Append("QuashWhys='" + model.QuashWhys + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_RandP ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_RandP GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_RandP ");
            strSql.Append(" where id=" + id);
            tb_RandP model = new tb_RandP();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            model.id = id;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.perID = ds.Tables[0].Rows[0]["perID"].ToString();
                model.RPKind = ds.Tables[0].Rows[0]["RPKind"].ToString();
                model.RPDate = ds.Tables[0].Rows[0]["RPDate"].ToString();
                model.confirmMan = ds.Tables[0].Rows[0]["confirmMan"].ToString();
                model.QuashDate = ds.Tables[0].Rows[0]["QuashDate"].ToString();
                model.QuashWhys = ds.Tables[0].Rows[0]["QuashWhys"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_RandP ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
