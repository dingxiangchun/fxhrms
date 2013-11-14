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
            strSql.Append("select count(*) from tb_perInfo where perNum='"+pernum+"'");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            int cmdresult;
            if ((object.Equals(obj, null)) || (object.Equals(obj, System.DBNull.Value)))
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
        public void Add(tb_perInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_perInfo(perNum,perName,folk,birthday,age,kultur,marriage,sex,visage,IDCard,origo,");
            strSql.Append("workDate,workLength,employee,intoWorkDate,intoWorkLength,laborageType,branch,headship,ZhiChen,");
            strSql.Append("phone,handset,school,speciality,GraduateDate,");
            //strSql.Append("M_Pay,bankNum,");
            strSql.Append("address,photoImage) values (");
            strSql.Append("'"+model.perNum+"','"+model.perName+"','"+model.folk+"','"+model.birthday+"',"+model.age+",'"+model.kultur+"',");
            strSql.Append("'" + model.marriage + "','" + model.sex + "','" + model.visage + "','" + model.IDCard + "','" + model.origo + "',");
            strSql.Append("'"+model.workDate+"',"+model.workLength+",'"+model.employee+"','"+model.intoWorkDate+"',"+model.intoWorkLength+",");
            strSql.Append("'" + model.laborageType + "','" + model.branch + "','" + model.headship + "','" + model.ZhiChen + "',");
            strSql.Append("'"+model.phone+"','"+model.handset+"','"+model.school+"','"+model.speciality+"','"+model.GraduateDate+"',");
            //strSql.Append("" + model.M_Pay + ",'" + model.bankNum + "',");
            strSql.Append("'" + model.address + "','" + model.photoImage + "')");
            int cmdresult = DbHelperSQL.ExecuteSql(strSql.ToString());

        }
        public void Update(tb_perInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_perInfo set ");
            strSql.Append("perNum='" + model.perNum + "',");
            strSql.Append("perName='" + model.perName + "',");
            strSql.Append("folk='" + model.folk + "',");
            strSql.Append("birthday='" + model.birthday + "',");
            strSql.Append("age=" + model.age + ",");
            strSql.Append("kultur='" + model.kultur + "',");
            strSql.Append("marriage='" + model.marriage + "',");
            strSql.Append("sex='" + model.sex + "',");
            strSql.Append("visage='" + model.visage + "',");
            strSql.Append("IDCard='" + model.IDCard + "',");
            strSql.Append("origo='" + model.origo + "',");
            strSql.Append("workDate='" + model.workDate + "',");
            strSql.Append("workLength=" + model.workLength + ",");
            strSql.Append("employee='" + model.employee + "',");
            strSql.Append("intoWorkDate='" + model.intoWorkDate + "',");
            strSql.Append("intoWorkLength=" + model.intoWorkLength + ",");
            strSql.Append("laborageType='" + model.laborageType + "',");
            strSql.Append("branch='" + model.branch + "',");
            strSql.Append("headship='" + model.headship + "',");
            strSql.Append("ZhiChen='" + model.ZhiChen + "',");
            strSql.Append("phone='" + model.phone + "',");
            strSql.Append("handset='" + model.handset + "',");
            strSql.Append("school='" + model.school + "',");
            strSql.Append("speciality='" + model.speciality + "',");
            strSql.Append("GraduateDate='" + model.GraduateDate + "',");
            //strSql.Append("M_Pay=" + model.M_Pay + ",");
            //strSql.Append("bankNum='" + model.bankNum + "',");
            strSql.Append("address='" + model.address + "',");
            strSql.Append("photoImage='" + model.photoImage + "'");
            strSql.Append(" where id=" + model.id + "");
            DbHelperSQL.ExecuteSql(strSql.ToString());

        }
        public void Delete(int perid)
        {
            string strSql = "delete tb_perInfo where id="+perid+"";
            int cmdresult=DbHelperSQL.ExecuteSql(strSql);
        }
        public tb_perInfo GetModel(string pernum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_perInfo where id="+pernum+"");
            tb_perInfo model = new tb_perInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            
            if (dt.Rows.Count > 0)
            {
                model.perNum = dt.Rows[0]["perNum"].ToString();
                model.perName = dt.Rows[0]["perName"].ToString();
                model.folk = dt.Rows[0]["folk"].ToString();
                if (dt.Rows[0]["birthday"].ToString() != "")
                {
                    model.birthday = dt.Rows[0]["birthday"].ToString();
                }
                if (dt.Rows[0]["age"].ToString() != "")
                {
                    model.age =int.Parse(dt.Rows[0]["age"].ToString());
                }
                model.kultur = dt.Rows[0]["kultur"].ToString();
                model.marriage = dt.Rows[0]["marriage"].ToString();
                model.sex = dt.Rows[0]["sex"].ToString();
                model.visage = dt.Rows[0]["visage"].ToString();
                model.IDCard = dt.Rows[0]["IDCard"].ToString();
                model.origo = dt.Rows[0]["origo"].ToString();
                model.workDate = dt.Rows[0]["workDate"].ToString();
                if (dt.Rows[0]["workLength"].ToString() != "")
                {
                    model.workLength =int.Parse(dt.Rows[0]["workLength"].ToString());
                }
                model.employee = dt.Rows[0]["employee"].ToString();
                if (dt.Rows[0]["intoWorkDate"].ToString() != "")
                {
                    model.intoWorkDate =dt.Rows[0]["intoWorkDate"].ToString();
                }
                if (dt.Rows[0]["intoWorkLength"].ToString()!="")
                {
                    model.intoWorkLength =int.Parse(dt.Rows[0]["intoWorkLength"].ToString());
                }
                model.laborageType = dt.Rows[0]["laborageType"].ToString();
                model.branch = dt.Rows[0]["branch"].ToString();
                model.headship = dt.Rows[0]["headship"].ToString();
                model.ZhiChen = dt.Rows[0]["ZhiChen"].ToString();
                model.phone = dt.Rows[0]["phone"].ToString();
                model.handset = dt.Rows[0]["handset"].ToString();
                model.school = dt.Rows[0]["school"].ToString();
                model.speciality = dt.Rows[0]["speciality"].ToString();
                model.GraduateDate = dt.Rows[0]["GraduateDate"].ToString();
                model.address = dt.Rows[0]["address"].ToString();
                model.photoImage = dt.Rows[0]["photoImage"].ToString();
                return model;
            }
            else
            {
                return null;
            }

        }

        override public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from tb_perInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append("where perNum='"+strWhere+"' ");
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

        #endregion
    }
}
