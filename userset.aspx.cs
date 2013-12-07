using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DAL;
using Models;

public partial class userset : System.Web.UI.Page
{
    tb_Users model = new tb_Users();
    users dal = new users();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Check())
            return;
        string msg = ""; model.id = 1;
        if (Request.Cookies["HRId"] != null)
        {
            string hrid = Request.Cookies["HRId"].Value;
            model.id = int.Parse(hrid);
        }
        if (Request["loginname"] != null && Request["loginname"] != "")
        {
            model.loginname = Request["loginname"];
        }
        if (Request["userpwd"] != null && Request["userpwd"] != "")
        {
            model.userpwd = Request["userpwd"];
            if (dal.Update(model))
                msg = "用户信息修改成功！";
            else
                msg = "用户信息修改失败！";
        }

        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("msg",msg);
        vh.Display("user.vm");
    }

     public bool  Check()
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
            if (!hrhelper.IsUserExist(loginname, hrid))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }
}
