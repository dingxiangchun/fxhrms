using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;
namespace DAL
{
    public class workchange : POJO<tb_workchange>
    {
        public workchange()
        { }
        #region 成员方法
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(tb_workchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_workchange(");
            strSql.Append("resumeid,positionid,unitid,attacktime");
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append( model.resumeid + ",");
            strSql.Append( model.positionid + ",");
            strSql.Append(model.unitid + ",");
            strSql.Append("'" + model.attacktime + "'");
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(tb_workchange model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_workchange set ");
            strSql.Append("resumeid=" + model.resumeid + ",");
            strSql.Append("positionid=" + model.positionid + ",");
            strSql.Append("unitid=" + model.unitid + ",");
            strSql.Append("attacktime='" + model.attacktime + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_workchange ");
            strSql.Append(" where " + strwhere);
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t1.name as employeename,t1.Employeeid as Employeeid, t2.branchName as OldUnitName,t3.name as OldPositionName,t5.resumeid,t4.reason ,t4.content,t5.attacktime,(select branchName from tb_branch where id=t5.unitid  ) as NewUnitName,(select name  from tb_positioninfo where id = t5.positionid ) as NewPositionName from tb_perinfo t1, tb_branch t2 , tb_positioninfo t3,tb_resumeinfo t4 ,tb_workchange t5 where t1.unitid = t2.id  and t1.POSITION=t3.id and t1.employeeid = t4.employeeid and t4.id =t5.resumeid");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" and " + strWhere + "");
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetListWithName(string strwhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select tb_workchange.*,tb_perinfo.Name As employeename,tb_positioninfo.name As positionname from tb_workchange,tb_perinfo,tb_positioninfo where tb_workchange.employeeid=tb_perinfo.Employeeid and  tb_positioninfo.id=tb_workchange.position ");
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
            strSql.Append("update tb_workchange set ");
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
                strSql.Append("update tb_perinfo  tp SET tp.UnitID=(select tw.unitid from tb_workchange tw where tw.resumeid =" + id + "),tp.Position=(select positionid from  tb_workchange where resumeid =" + id + ")");
                strSql.Append(" where exists (select 1 from tb_workchange tw,tb_resumeinfo tr  where tp.Employeeid=  tr.employeeid and tw.resumeid = tr.id AND tr.id ="+id+")");
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
