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

public partial class HRData : System.Web.UI.Page
{
    perInfo dal = new perInfo();
    tb_perInfo model = new tb_perInfo();

    branch dalBranch = new branch();
    tb_branch modelBranch = new tb_branch();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "del")
            {
                //Del();
            }
            if (Request["action"] == "add")
            {
                //Add();
            }
            if (Request["action"] == "update")
            {
                //Update();
            }
            if (Request["action"] == "tree")
            {
                Tree();
            }

        }
        else
        {
            string strwhere = "1=1";
            if (Request["branchid"] != null && Request["branchid"] != "0")
            {
                strwhere += " and UnitID=" + Request["branchid"];
            }

            if (Request["name"] != null)
            {
                strwhere += " and Name='" + Request["name"] + "'";
            }
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_perInfo> list = dal.GetListAll(strwhere);
            vh.Put("list", list);
            vh.Display("perlist.vm");
        }
    }

    private void Tree()
    {
        try
        {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dalBranch.GetListAll("");
            vh.Put("list", list);
            vh.Display("layout/nav.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }
   
}
