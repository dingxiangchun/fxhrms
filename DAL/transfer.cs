using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 人事调动数据访问类
    /// </summary>
    public class transfer : POJO<tb_transfer>
    {
        public transfer()
        { }
        #region 成员方法
        tb_transfer model = new tb_transfer();
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_transfer(");
            strSql.Append("perID,traDate,traType,treFormer,treAfter,treWhys");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.perID + "',");
            strSql.Append("'" + model.traDate + "',");
            strSql.Append("'" + model.traType + "',");
            strSql.Append("'" + model.treFormer + "',");
            strSql.Append("'" + model.treAfter + "',");
            strSql.Append("'" + model.treWhys + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_transfer set ");
            strSql.Append("perID='" + model.perID + "',");
            strSql.Append("traDate='" + model.traDate + "',");
            strSql.Append("traType='" + model.traType + "',");
            strSql.Append("treFormer='" + model.treFormer + "',");
            strSql.Append("treAfter='" + model.treAfter + "',");
            strSql.Append("treWhys='" + model.treWhys + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_transfer ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_transfer GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_transfer ");
            strSql.Append(" where id=" + id);
            tb_transfer model = new tb_transfer();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            model.id = id;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.perID = ds.Tables[0].Rows[0]["perID"].ToString();
                model.traDate = ds.Tables[0].Rows[0]["traDate"].ToString();
                model.traType = ds.Tables[0].Rows[0]["traType"].ToString();
                model.treFormer = ds.Tables[0].Rows[0]["treFormer"].ToString();
                model.treAfter = ds.Tables[0].Rows[0]["treAfter"].ToString();
                model.treWhys = ds.Tables[0].Rows[0]["treWhys"].ToString();
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
            strSql.Append("select * from tb_transfer ");
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
