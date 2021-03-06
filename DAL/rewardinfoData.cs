﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class rewardinfoData : POJO<tb_rewardinfo>
    {
        public rewardinfoData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_rewardinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_rewardinfo(");
            strSql.Append("employeeid,type,time,content,department,audit,Class,level,unit,description,mark,File");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.type + "',");
            strSql.Append("'" + model.time + "',");
            strSql.Append("'" + model.content + "',");
            strSql.Append("'" + model.department + "',");
            strSql.Append("'" + model.audit + "',");
            strSql.Append("'" + model.Class + "',");
            strSql.Append("'" + model.level + "',");
            strSql.Append("'" + model.unit + "',");
            strSql.Append("'" + model.description + "',");
            strSql.Append("" + model.mark + ",");
            strSql.Append("'" + model.File + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_rewardinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_rewardinfo set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("type='" + model.type + "',");
            strSql.Append("time='" + model.time + "',");
            strSql.Append("content='" + model.content + "',");
            strSql.Append("department='" + model.department + "',");
            strSql.Append("audit='" + model.audit + "',");
            strSql.Append("Class='" + model.Class + "',");
            strSql.Append("level='" + model.level + "',");
            strSql.Append("unit='" + model.unit + "',");
            strSql.Append("description='" + model.description + "',");
            strSql.Append("mark=" + model.mark + ",");
            strSql.Append("File='" + model.File + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_rewardinfo ");
            strSql.Append(" where " + strwhere);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_rewardinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere + "");
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetListWithName(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb_rewardinfo.*,tb_perinfo.Name As employeename from tb_rewardinfo,tb_perinfo where tb_rewardinfo.employeeid=tb_perinfo.Employeeid ");
            if (strwhere.Trim() != "")
            {
                strSql.Append(strwhere);
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public void UpdateMark(int mark, string audit, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_rewardinfo set ");
            strSql.Append("audit='" + audit + "',");
            strSql.Append("mark=" + mark + "");
            strSql.Append(" where id=" + id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        #endregion
    }
}
