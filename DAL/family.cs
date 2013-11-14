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
            strSql.Append("perID,LeaguerName,Nexus,BirthDate,WorkInc,headship,visage,phone");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.perID + "',");
            strSql.Append("'" + model.LeaguerName + "',");
            strSql.Append("'" + model.Nexus + "',");
            strSql.Append("'" + model.BirthDate + "',");
            strSql.Append("'" + model.WorkInc + "',");
            strSql.Append("'" + model.headship + "',");
            strSql.Append("'" + model.visage + "',");
            strSql.Append("'" + model.phone + "'");
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
            strSql.Append("perID='" + model.perID + "',");
            strSql.Append("LeaguerName='" + model.LeaguerName + "',");
            strSql.Append("Nexus='" + model.Nexus + "',");
            strSql.Append("BirthDate='" + model.BirthDate + "',");
            strSql.Append("WorkInc='" + model.WorkInc + "',");
            strSql.Append("headship='" + model.headship + "',");
            strSql.Append("visage='" + model.visage + "',");
            strSql.Append("phone='" + model.phone + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_family ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_family GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_family ");
            strSql.Append(" where id=" + id);
            tb_family model = new tb_family();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            model.id = id;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.perID = ds.Tables[0].Rows[0]["perID"].ToString();
                model.LeaguerName = ds.Tables[0].Rows[0]["LeaguerName"].ToString();
                model.Nexus = ds.Tables[0].Rows[0]["Nexus"].ToString();
                model.BirthDate = ds.Tables[0].Rows[0]["BirthDate"].ToString();
                model.WorkInc = ds.Tables[0].Rows[0]["WorkInc"].ToString();
                model.headship = ds.Tables[0].Rows[0]["headship"].ToString();
                model.visage = ds.Tables[0].Rows[0]["visage"].ToString();
                model.phone = ds.Tables[0].Rows[0]["phone"].ToString();
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
            strSql.Append("select * from tb_family ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where perID='"+ strWhere+"'");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
