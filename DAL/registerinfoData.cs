using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class registerinfoData : POJO<tb_registerinfo>
    {
        public registerinfoData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_registerinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_registerinfo(");
            strSql.Append("employeeid,type,cer_name,accesstime,issuingtime,unit,Class,photo,description");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.type + "',");
            strSql.Append("'" + model.cer_name + "',");
            strSql.Append("'" + model.accesstime + "',");
            strSql.Append("'" + model.issuingtime + "',");
            strSql.Append("'" + model.unit + "',");
            strSql.Append("'" + model.Class + "',");
            strSql.Append("'" + model.photo + "',");
            strSql.Append("'" + model.description + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_registerinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_registerinfo set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("type='" + model.type + "',");
            strSql.Append("cer_name='" + model.cer_name + "',");
            strSql.Append("accesstime='" + model.accesstime + "',");
            strSql.Append("issuingtime='" + model.issuingtime + "',");
            strSql.Append("unit='" + model.unit + "',");
            strSql.Append("Class='" + model.Class + "',");
            strSql.Append("photo='" + model.photo + "',");
            strSql.Append("description='" + model.description + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_registerinfo ");
            strSql.Append(" where " + strwhere);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_registerinfo ");
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
