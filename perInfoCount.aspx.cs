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
using System.IO;
using DAL;
using Models;

public partial class perInfoCount : System.Web.UI.Page
{
    tb_Count model = new tb_Count();
    perInfo dal = new perInfo();
    int m_power = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
            if (!Check())
            return;
            VelocityHelper vh = new VelocityHelper();
            IList<tb_Count> PositionCountlist = util.GetAll<tb_Count>(dal.GetCountList("Position"));
            IList<tb_Count> branchCountlist = util.GetAll<tb_Count>(dal.GetCountList("branch"));
            IList<tb_Count> edcCountlist = util.GetAll<tb_Count>(dal.GetCountList("edc"));
            IList<tb_Count> StatusCountlist = util.GetAll<tb_Count>(dal.GetCountList("Status"));
            IList<tb_Count> ageCountlist = util.GetAll<tb_Count>(dal.GetCountList("age"));
            IList<tb_Count> perageCountlist = util.GetAll<tb_Count>(dal.GetCountList("perage"));
            vh.Init();
            vh.Put("perage", perageCountlist);
            vh.Put("Position", PositionCountlist);
            vh.Put("branch", branchCountlist);
            vh.Put("edc", edcCountlist);
            vh.Put("Status", StatusCountlist);
            vh.Put("age", ageCountlist);
            vh.Put("role", m_power);
            vh.Display("count.vm");
    }

    public bool Check()
    {
        HRHelper hrhelper = new HRHelper();
        if (Request.Cookies["HRLoginName"] == null || Request.Cookies["HRId"] == null)
        {
            Response.Redirect("login.aspx");
            return false;
        }
        else
        {
            string loginname = Request.Cookies["HRLoginName"].Value;
            string hrid = Request.Cookies["HRId"].Value;
            if (!hrhelper.IsUserExist(loginname, hrid,ref m_power))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }
}
