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
    int m_power = -1;
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
            if (!hrhelper.IsUserExist(loginname, hrid,ref m_power))
            {
                Response.Redirect("login.aspx");
                return;
            }

            if (m_power != 0)
            {
                VelocityHelper vh1 = new VelocityHelper();
                vh1.Init();
                vh1.Display("nopower.vm");
                return ;
            }
        }

        string msg="";
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "update")
            {
                if (Update())
                {
                    Response.Write("{\"status\":true}");
                }
                else
                {
                    Response.Write("{\"status\":false,\"errorMsg\":\"更新失败！!\"}");
                }
                Response.End();
                return;
            }
            if (Request["action"] == "del")
            {
                if (Del())
                {
                    Response.Write("{\"status\":true}");
                }
                else
                {
                    Response.Write("{\"status\":false,\"errorMsg\":\"删除失败！!\"}");
                }
                Response.End();
                return;
            }
            if (Request["action"] == "add")
            {
                if (Add(ref msg))
                    msg = "用户添加成功！";
            }
        }
        IList<tb_Users> list = dal.GetListAll("");
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("list", list);
        vh.Put("msg", msg);
        vh.Put("role", m_power);
        vh.Display("auth.vm");

    }

    public bool Add(ref string msg)
    {
        if (Request["id"] != null && Request["id"] != "")
        {
            model.id = int.Parse(Request["id"]);
        }
        if (!string.IsNullOrEmpty(Request["loginname"]))
        {
            model.loginname = Request["loginname"];
            if (dal.GetListAll("loginname='" + model.loginname + "'").Count > 0)
            {
                msg = "该登录名已存在";
                return false;
            }
        }
        else
        {
            msg = "登录名不能为空！";
            return false;
        }
        if (!string.IsNullOrEmpty(Request["userpwd"]))
        {
            model.userpwd = Request["userpwd"];
        }
        else
        {
            msg = "密码不能为空！";
            return false;
        }
        if (!string.IsNullOrEmpty(Request["userprower"]))
        {
            model.userprower = int.Parse(Request["userprower"]);
        }
        else
        {
            msg = "权限不能为空！";
            return false;
        }
        if (!string.IsNullOrEmpty(Request["username"]))
        {
            model.username = Request["username"];
        }
        else
        {
            msg = "用户名不能为空！";
            return false;
        }

        if (Request["Unit"] != null && Request["Unit"] != "")
        {
            model.Unit = Request["Unit"];
        }
        if (Request["remark"] != null && Request["remark"] != "")
        {
            model.remark = Request["remark"];
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
        if (dal.ChangeUserPower(model))
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
