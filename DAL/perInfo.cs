using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using Models;

namespace DAL
{
    /// <summary>
    /// 员工数据访问类
    /// </summary>
    public class perInfo : POJO<tb_perInfo>
    {
        public perInfo()
        { }
        #region 成员方法
        //tb_perInfo model = new tb_perInfo();
        /// <summary>
        /// 是否存在该员工
        /// </summary>
        /// <param name="pernum"></param>
        /// <returns></returns>
        public bool Exists(string pernum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from tb_perInfo where Employeeid='" + pernum + "'");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            int cmdresult;
            if ((object.Equals(obj, null)) || (object.Equals(obj, System.DBNull.Value))||int.Parse(obj.ToString())==0)
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = 1;
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Add(tb_perInfo model)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("insert into tb_perInfo(Name,Beforename,Employeeid,Sex,Nation,Birth,Idcard,UnitID,Unit,Position,Rank,Level,Status,Statustime,");
                strSql.Append("Jobtime,financetime,fulltime_educ,fulltime_sch,Major,Married,Town,Tel,final_sch,");
                strSql.Append("final_edu,final_emajior,Address,Reserve,Guard,Ages,state,employclass,photo,Attrion,BankcardID,remarks1,remarks2) values (");
                strSql.Append("'" + model.Name + "','" + model.Beforename + "','" + model.Employeeid + "','" + model.Sex + "','" + model.Nation + "','" + model.Birth + "','" + model.Idcard + "',");
                strSql.Append("" + model.UnitID + ",'" + model.Unit + "','" + model.Position + "','" + model.Rank + "'," + model.Level + ",");
                strSql.Append("'" + model.Status + "','" + model.Statustime + "','" + model.Jobtime + "','" + model.financetime + "','" + model.fulltime_educ + "','" + model.fulltime_sch + "',");
                strSql.Append("'" + model.Major + "','" + model.Married + "','" + model.Town + "','" + model.Tel + "',");
                strSql.Append("'" + model.final_sch + "','" + model.final_edu + "','" + model.final_emajior + "','" + model.Address + "','" + model.Reserve + "','" + model.Guard + "',");
                strSql.Append(model.Ages + ",'" + model.state + "','" + model.employclass + "','" + model.photo + "','" + model.Attrion + "','" + model.BankcardID + "','" + model.remarks1 + "','" + model.remarks2 + "')");
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
        public bool Update(tb_perInfo model)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("update tb_perInfo set ");
                strSql.Append("Name='" + model.Name + "',");
                strSql.Append("Beforename='" + model.Beforename + "',");
                strSql.Append("Employeeid='" + model.Employeeid + "',");
                strSql.Append("Sex='" + model.Sex + "',");
                strSql.Append("Nation='" + model.Nation + "',");
                strSql.Append("Birth='" + model.Birth + "',");
                strSql.Append("Idcard='" + model.Idcard + "',");
                strSql.Append("UnitID=" + model.UnitID + ",");
                strSql.Append("Unit='" + model.Unit + "',");
                strSql.Append("Position='" + model.Position + "',");
                strSql.Append("Rank='" + model.Rank + "',");
                strSql.Append("Level=" + model.Level + ",");
                strSql.Append("Status='" + model.Status + "',");
                strSql.Append("Statustime='" + model.Statustime + "',");
                strSql.Append("Jobtime='" + model.Jobtime + "',");
                strSql.Append("financetime='" + model.financetime + "',");
                strSql.Append("fulltime_educ='" + model.fulltime_educ + "',");
                strSql.Append("fulltime_sch='" + model.fulltime_sch + "',");
                strSql.Append("Major='" + model.Major + "',");
                strSql.Append("Married='" + model.Married + "',");
                strSql.Append("Town='" + model.Town + "',");
                strSql.Append("Tel='" + model.Tel + "',");
                strSql.Append("final_sch='" + model.final_sch + "',");
                strSql.Append("final_edu='" + model.final_edu + "',");
                strSql.Append("final_emajior='" + model.final_emajior + "',");
                strSql.Append("Address='" + model.Address + "',");
                strSql.Append("Reserve='" + model.Reserve + "',");
                strSql.Append("Guard='" + model.Guard + "',");
                strSql.Append("Ages=" + model.Ages + ",");
                strSql.Append("state='" + model.state + "',");
                strSql.Append("employclass='" + model.employclass + "',");
                strSql.Append("Attrion='" + model.Attrion + "',");
                strSql.Append("BankcardID='" + model.BankcardID + "',");
                strSql.Append("remarks1='" + model.remarks1 + "',");
                strSql.Append("remarks2='" + model.remarks2 + "'");
                if (model.photo != "")
                {
                    strSql.Append(",photo='" + model.photo + "'");
                }

                strSql.Append(" where id=" + model.id + "");
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
        public void Delete(string strwhere)
        {
            string strSql = "delete from tb_perInfo where "+strwhere;
            int cmdresult=DbHelperSQL.ExecuteSql(strSql);
        }


        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_perInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where "+strWhere+" ");
            }
            strSql.Append("order by id");
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }
         public DataSet GetList(string strWhere,int i)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_perInfo ");
            if (strWhere.Trim() != "" && i == 1)
            {
                strSql.Append("where branch='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 2)
            {
                strSql.Append("where headship='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 3)
            {
                strSql.Append("where ZhiChen='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 4)
            {
                strSql.Append("where perName='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 5)
            {
                strSql.Append("where employee='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 6)
            {
                strSql.Append("where sex='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 7)
            {
                strSql.Append("where marriage='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 8)
            {
                strSql.Append("where visage='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 9)
            {
                strSql.Append("where kultur='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 10)
            {
                strSql.Append("where folk='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 11)
            {
                strSql.Append("where origo='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 12)
            {
                strSql.Append("where school='" + strWhere + "' ");
            }
            if (strWhere.Trim() != "" && i == 13)
            {
                strSql.Append("where speciality='" + strWhere + "' ");
            }
            strSql.Append("order by id");
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }
        public DataSet GetList(string strWhere,string endage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_perInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where age between " + strWhere + " and " + endage + " ");
            }
            strSql.Append("order by id");
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }
        public DataSet GetListBind(string item_field,string item_value)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select "+item_field+" as '"+item_value+"',count('"+item_field+"') as '人数' from tb_perInfo ");
            
            strSql.Append("group by "+item_field+"");
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }

        public DataSet GetCountList(string countname)
        { 
            StringBuilder strSql = new StringBuilder();
            switch(countname)
            {
                case "Position":
                    strSql.Append("SELECT tb_positioninfo.`name` as CountName,COUNT(tb_perinfo.id) as Count from tb_positioninfo,tb_perinfo WHERE tb_positioninfo.id=tb_perinfo.Position GROUP BY tb_positioninfo.`name`");
                    break;
                case "branch":
                    strSql.Append("SELECT tb_branch.branchName as CountName,COUNT(tb_perinfo.id) as Count from tb_branch,tb_perinfo WHERE tb_branch.id=tb_perinfo.UnitID GROUP BY tb_branch.branchName");
                    break;
                case "edc":
                    strSql.Append("SELECT tb_perinfo.fulltime_educ as CountName,COUNT(tb_perinfo.id) as Count from tb_perinfo  GROUP BY tb_perinfo.fulltime_educ");
                    break;
                case "Status":
                    strSql.Append("SELECT tb_perinfo.Status as CountName,COUNT(tb_perinfo.id) as Count from tb_perinfo  GROUP BY tb_perinfo.Status");
                    break;
                case "age":
                    strSql.Append("SELECT  COUNT(tb_perinfo.id) as Count,concat((YEAR(CURDATE())-YEAR(STR_TO_DATE(tb_perinfo.Jobtime,\"%Y-%m-%d\"))) - (RIGHT(CURDATE(),5)<RIGHT(tb_perinfo.Jobtime,5)),'') AS CountName  FROM tb_perinfo GROUP BY CountName");
                    break;
                case "perage":
                    strSql.Append("SELECT  COUNT(tb_perinfo.id) as Count,concat((YEAR(CURDATE())-YEAR(STR_TO_DATE(tb_perinfo.Birth,\"%Y-%m-%d\"))) - (RIGHT(CURDATE(),5)<RIGHT(tb_perinfo.Birth,5)),'') AS CountName  FROM tb_perinfo GROUP BY CountName");
                    break;

            }
            DataSet ds = new DataSet();
            ds = DbHelperSQL.Query(strSql.ToString());
            return ds;
        }

        #endregion
    }
}
