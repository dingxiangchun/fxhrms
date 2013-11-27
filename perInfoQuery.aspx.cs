using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DAL;
using Models;

public partial class perInfoQuery : System.Web.UI.Page
{
    perInfo dal = new perInfo();
    tb_perInfo model = new tb_perInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        string strwhere = "1=1";
        if (Request["branchid"] != null && Request["branchid"] != "0")
        {
            strwhere += " and UnitID=" + Request["branchid"];
        }

        if (Request["name"] != null&&Request["name"] != "")
        {
            strwhere += " and Name='" + Request["name"] + "'";
        }

        if (Request["Employeeid"] != null&&Request["Employeeid"] !="")
        {
            strwhere += " and Employeeid='" + Request["Employeeid"]+"'";
        }

        if (Request["age"] != null&&Request["age"] !="")
        {
            strwhere += " and (YEAR(CURDATE())-YEAR(STR_TO_DATE(tb_perinfo.Jobtime,\"%Y-%m-%d\"))) - (RIGHT(CURDATE(),5)<RIGHT(tb_perinfo.Jobtime,5))=" + Request["age"];
        }

        if (Request["Birth"] != null && Request["Birth"] != "")
        {
            strwhere += " and Birth='" + Request["Birth"] + "'";
        }

        if (Request["Rank"] != null && Request["Rank"] != "")
        {
            strwhere += " and Rank='" + Request["Rank"] + "'";
        }

        if (Request["Level"] != null && Request["Level"] != "")
        {
            strwhere += " and Level=" + Request["Rank"];
        }

        if (Request["fulltime_educ"] != null && Request["fulltime_educ"] != "")
        {
            strwhere += " and fulltime_educ='" + Request["fulltime_educ"]+"'";
        }

        if (Request["Guard"] != null && Request["Guard"] != "")
        {
            strwhere += " and Guard='" + Request["Guard"] + "'";
        }

        IList<tb_perInfo> list = dal.GetListAll(strwhere);
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("list", list);
        vh.Display("query.vm");
    }
}
