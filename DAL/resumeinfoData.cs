using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    public class resumeinfoData : POJO<tb_resumeinfo>
    {
        public resumeinfoData()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_resumeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_resumeinfo(");
            strSql.Append("employeeid,attacktime,quittime,position,unitid,unit,mark,reason,content,audit");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append("'" + model.employeeid + "',");
            strSql.Append("'" + model.attacktime + "',");
            strSql.Append("'" + model.quittime + "',");
            strSql.Append("'" + model.position + "',");
            strSql.Append("" + model.unitid + ",");
            strSql.Append("'" + model.unit + "',");
            strSql.Append("" + model.mark + ",");
            strSql.Append("'" + model.reason + "',");
            strSql.Append("'" + model.content + "',");
            strSql.Append("'" + model.audit + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_resumeinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_resumeinfo set ");
            strSql.Append("employeeid='" + model.employeeid + "',");
            strSql.Append("attacktime='" + model.attacktime + "',");
            strSql.Append("quittime='" + model.quittime + "',");
            strSql.Append("position='" + model.position + "',");
            if(string.IsNullOrEmpty(model.unit))
            {
                strSql.Append("unitid=" + model.unitid + ",");
                strSql.Append("unit='" + model.unit + "',");
            }
            strSql.Append("reason='" + model.reason + "',");
            strSql.Append("content='" + model.content + "',");
            strSql.Append("audit='" + model.audit + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Updatequittime(string time,string id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_resumeinfo set ");
            strSql.Append("quittime='" + time + "'");
            strSql.Append(" where id=" + id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_resumeinfo ");
            strSql.Append(" where " + strwhere);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb_resumeinfo.*,tb_positioninfo.name As positionname,tb_branch.branchName as unitname from tb_resumeinfo,tb_positioninfo,tb_branch where tb_positioninfo.id=tb_resumeinfo.position and (tb_resumeinfo.unitid=tb_branch.id or tb_resumeinfo.unitid<0)");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere + "");
            }
            strSql.Append(" group by tb_resumeinfo.id");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetListWithName(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb_resumeinfo.*,tb_perinfo.Name As employeename,tb_positioninfo.name As positionname from tb_resumeinfo,tb_perinfo,tb_positioninfo where tb_resumeinfo.employeeid=tb_perinfo.Employeeid and  tb_positioninfo.id=tb_resumeinfo.position ");
            if (strwhere.Trim() != "")
            {
                strSql.Append(strwhere);
            }
            strSql.Append(" order by id ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public void UpdateMark(int mark,string audit, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_resumeinfo set ");
            strSql.Append("audit='" + audit + "',");
            strSql.Append("mark=" + mark + "");
            strSql.Append(" where id=" + id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        public bool ChangePerInfoUnit(int id)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update tb_perinfo  tp SET tp.UnitID=(select tr.unitid from tb_resumeinfo tr where tr.id ="+id+")");
                strSql.Append("where exists (select 1 from tb_resumeinfo tr where tp.Employeeid=  tr.employeeid and tr.id =" + id + ")");
                if (DbHelperSQL.ExecuteSql(strSql.ToString()) > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
