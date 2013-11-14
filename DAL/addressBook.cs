using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 通讯录数据访问类
    /// </summary>
    public class addressBook : POJO<tb_addressBook>
    {
        public addressBook()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_addressBook model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_addressBook(");
            strSql.Append("uName,sex,phone,handset,workPhone,QQ,e_mail");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.uName + "',");
            strSql.Append("'" + model.sex + "',");
            strSql.Append("'" + model.phone + "',");
            strSql.Append("'" + model.handset + "',");
            strSql.Append("'" + model.workPhone + "',");
            strSql.Append("'" + model.QQ + "',");
            strSql.Append("'" + model.e_mail + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_addressBook model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_addressBook set ");
            strSql.Append("uName='" + model.uName + "',");
            strSql.Append("sex='" + model.sex + "',");
            strSql.Append("phone='" + model.phone + "',");
            strSql.Append("handset='" + model.handset + "',");
            strSql.Append("workPhone='" + model.workPhone + "',");
            strSql.Append("QQ='" + model.QQ + "',");
            strSql.Append("e_mail='" + model.e_mail + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_addressBook ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public tb_addressBook GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_addressBook ");
            strSql.Append(" where id=" + id);
            tb_addressBook model = new tb_addressBook();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            model.id = id;
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.uName = ds.Tables[0].Rows[0]["uName"].ToString();
                model.sex = ds.Tables[0].Rows[0]["sex"].ToString();
                model.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                model.handset = ds.Tables[0].Rows[0]["handset"].ToString();
                model.workPhone = ds.Tables[0].Rows[0]["workPhone"].ToString();
                model.QQ = ds.Tables[0].Rows[0]["QQ"].ToString();
                model.e_mail = ds.Tables[0].Rows[0]["e_mail"].ToString();
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
            strSql.Append("select * from tb_addressBook ");
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
            strSql.Append("select * from tb_addressBook ");
            if (i==1)
            {
                strSql.Append(" where uName like '%" + strWhere + "%'");
            }
            if (i == 2)
            {
                strSql.Append(" where QQ like '%" + strWhere + "%'");
            }
            if (i == 3)
            {
                strSql.Append(" where e_mail like '%" + strWhere + "%'");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion
    }
}
