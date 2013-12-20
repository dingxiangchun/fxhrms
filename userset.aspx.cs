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

public partial class userset : System.Web.UI.Page
{
    tb_Users model = new tb_Users();
    users dal = new users();
    int m_power = -1;
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
        if (Request["username"] != null && Request["username"] != "")
        {
            model.username = Request["username"];
        }
        if (Request["Unit"] != null && Request["Unit"] != "")
        {
            model.Unit = Request["Unit"];
        }
        if (Request["loginname"] != null && Request["loginname"] != "")
        {
            model.loginname = Request["loginname"];
        }
        if (Request["userprower"] != null && Request["userprower"] != "")
        {
            model.userprower = int.Parse(Request["userprower"]);
        }
        if (Request["userpwd"] != null && Request["userpwd"] != "")
        {
            model.userpwd = Request["userpwd"];
            if (dal.Update(model))
                msg = "用户信息修改成功！";
            else
                msg = "用户信息修改失败！";
        }


        IList<tb_Users> list = dal.GetListAll("id=" + Request.Cookies["HRId"].Value);


        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("msg",msg);
        vh.Put("user", list[0]);
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
            if (!hrhelper.IsUserExist(loginname, hrid,ref m_power))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }
}
