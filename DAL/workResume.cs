using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 工作简历数据访问类
    /// </summary>
    public class workResume : POJO<tb_workresume>
    {
        public workResume()
        { }
        #region 成员方法
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_workresume model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_workresume(");
            strSql.Append("perID,beginDate,endDate,branch,headship,IncName");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.perID + "',");
            strSql.Append("'" + model.beginDate + "',");
            strSql.Append("'" + model.endDate + "',");
            strSql.Append("'" + model.branch + "',");
            strSql.Append("'" + model.headship + "',");
            strSql.Append("'" + model.IncName + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_workresume model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_workresume set ");
            strSql.Append("perID='" + model.perID + "',");
            strSql.Append("beginDate='" + model.beginDate + "',");
            strSql.Append("endDate='" + model.endDate + "',");
            strSql.Append("branch='" + model.branch + "',");
            strSql.Append("headship='" + model.headship + "',");
            strSql.Append("IncName='" + model.IncName + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_workresume ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_workresume GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_workresume ");
            strSql.Append(" where id=" + id);
            tb_workresume model = new tb_workresume();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            model.id = id;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.perID = ds.Tables[0].Rows[0]["perID"].ToString();
                model.beginDate = ds.Tables[0].Rows[0]["beginDate"].ToString();
                model.endDate = ds.Tables[0].Rows[0]["endDate"].ToString();
                model.branch = ds.Tables[0].Rows[0]["branch"].ToString();
                model.headship = ds.Tables[0].Rows[0]["headship"].ToString();
                model.IncName = ds.Tables[0].Rows[0]["IncName"].ToString();
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
            strSql.Append("select * from tb_workresume ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where perID='" + strWhere + "'");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
