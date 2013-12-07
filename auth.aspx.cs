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

public partial class auth : System.Web.UI.Page
{
    tb_Users model = new tb_Users();
    users  dal= new users();
    HRHelper hrhelper = new HRHelper();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["HRLoginName"] == null || Request.Cookies["HRId"] == null)
        {
            Response.Redirect("login.aspx");
            return;
        }
        else
        {
            string loginname = Request.Cookies["HRLoginName"].Value;
            string hrid = Request.Cookies["HRId"].Value;
            if (!hrhelper.IsUserExist(loginname, hrid))
            {
                Response.Redirect("login.aspx");
                return;
            }
        }

        string msg="";
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "update")
            {
                if (Update())
                    msg = "用户信息更新成功！";
                else
                    msg = "用户信息更新失败！";
            }
            if (Request["action"] == "del")
            {
                if (Del())
                    msg = "用户删除成功！";
                else
                    msg = "用户删除失败！";
            }
            if (Request["action"] == "add")
            {
                if (Add())
                    msg = "用户添加成功！";
                else
                    msg = "用户添加失败！";
            }
        }
        IList<tb_Users> list = dal.GetListAll("");
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("list", list);
        vh.Put("msg", msg);
        vh.Display("auth.vm");

    }

    public bool Add()
    {
        if (Request["id"] != null && Request["id"] != "")
        {
            model.id = int.Parse(Request["id"]);
        }
        if (Request["loginname"] != null && Request["loginname"] != "")
        {
            model.loginname = Request["loginname"];
        }
        if (Request["userpwd"] != null && Request["userpwd"] != "")
        {
            model.userpwd = Request["userpwd"];
        }
        if (Request["userprower"] != null && Request["userprower"] != "")
        {
            model.userprower = int.Parse(Request["userprower"]);
        }
        if (dal.Add(model))
            return true;
        else
            return false;
    }

    public bool Update()
    {
        if (Request["id"] != null && Request["id"] != "")
        {
            model.id = int.Parse(Request["id"]);
        }
        if (Request["loginname"] != null && Request["loginname"] != "")
        {
            model.loginname = Request["loginname"];
        }
        if (Request["userprower"] != null && Request["userprower"] != "")
        {
            model.userprower = int.Parse(Request["userprower"]);
        }
        if (dal.Update(model))
            return true;
        else
            return false;
    }

    public bool Del()
    {
        if (Request["id"] != null && Request["id"] != "")
        {
            if (!dal.Delete(int.Parse(Request["id"])))
                return false;
        }
        else
        {
            return false;
        }
        return true;
    }
}
