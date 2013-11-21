using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;
namespace DAL
{
    public class holidayrecordsData : POJO<tb_holidayrecords>
    {
        public holidayrecordsData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_holidayrecords model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_holidayrecords(");
            strSql.Append("employeeid,holiday,days,reason,audit,begintime,Endtime,days1,remark");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.holiday + "',");
            strSql.Append("" + model.days + ",");
            strSql.Append("'" + model.reason + "',");
            strSql.Append("'" + model.audit + "',");
            strSql.Append("'" + model.begintime + "',");
            strSql.Append("'" + model.Endtime + "',");
            strSql.Append("" + model.days1 + ",");
            strSql.Append("'" + model.remark + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_holidayrecords model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_holidayrecords set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("holiday='" + model.holiday + "',");
            strSql.Append("days=" + model.holiday + ",");
            strSql.Append("reason='" + model.reason + "',");
            strSql.Append("audit='" + model.audit + "',");
            strSql.Append("begintime='" + model.begintime + "',");
            strSql.Append("Endtime='" + model.Endtime + "',");
            strSql.Append("days1=" + model.days1 + ",");
            strSql.Append("remark='" + model.remark + "',");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_holidayrecords ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_holidayrecords ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere );
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
