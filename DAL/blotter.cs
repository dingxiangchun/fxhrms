using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 记事本数据访问类
    /// </summary>
    public class blotter : POJO<tb_blotter>
    {
        public blotter()
        { }
        #region 成员方法
         
        public void Add(tb_blotter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_blotter(");
            strSql.Append("noteDate,noteSort,tTitle,tContent");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.noteDate + "',");
            strSql.Append("'" + model.noteSort + "',");
            strSql.Append("'" + model.tTitle + "',");
            strSql.Append("'" + model.tContent + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public void Update(tb_blotter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_blotter set noteDate='" + model.noteDate + "',noteSort='" + model.noteSort + "',tTitle='" + model.tTitle + "',");
            strSql.Append("tContent='" + model.tContent + "' where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_blotter ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public tb_blotter GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_blotter where id=" + id);
            tb_blotter model = new tb_blotter();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            if (dt.Rows.Count > 0)
            {
                model.noteDate = dt.Rows[0]["noteDate"].ToString();
                model.noteSort = dt.Rows[0]["noteSort"].ToString();
                model.tTitle = dt.Rows[0]["tTitle"].ToString();
                model.tContent = dt.Rows[0]["tContent"].ToString();
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
            strSql.Append("select * from tb_blotter ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
         public DataSet GetList(string strWhere, int i)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_blotter ");
            if (i== 1)
            {
                strSql.Append(" where noteDate like '%" + strWhere+"%'");
            }
            if (i == 2)
            {
                strSql.Append(" where noteSort like '%" + strWhere + "%'");
            }
            if (i == 3)
            {
                strSql.Append(" where tTitle like '%" + strWhere + "%'");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion
    }
}
