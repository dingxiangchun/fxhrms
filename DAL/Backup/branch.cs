﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 部门数据访问类
    /// </summary>
    public class branch
    {
        public branch()
        { }
        #region 成员方法
        
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_branch model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_branch(");
            strSql.Append("branchName");
            strSql.Append(")");
            strSql.Append(" values (");
            //strSql.Append("'" + model.branchNum + "',");
            strSql.Append("'" + model.branchName + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_branch model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_branch set ");
            strSql.Append("branchNum='" + model.branchNum + "',");
            strSql.Append("branchName='" + model.branchName + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tb_branch ");
            strSql.Append(" where id=" + id);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_branch ");
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
