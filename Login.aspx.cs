﻿using System;
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


public partial class Login : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Check();
        tb_txtName.Focus();
    }
    DAL.users dal = new DAL.users();
    tb_Users model = new tb_Users();
    protected void ib_login_Click(object sender, ImageClickEventArgs e)
    {
        string uid = tb_txtName.Text;
        string pwd = tb_txtPwd.Text;
        bool pass = dal.Exists(uid, pwd);
            if (pass)
            {
                string strWhere = "loginname = '" + uid + "'";
                IList<tb_Users> ds = dal.GetListAll(strWhere);
                if (ds.Count > 0)
                {
                    HttpCookie LoginName = new HttpCookie("HRLoginName");
                    HttpCookie UserId = new HttpCookie("HRId");
                    HttpCookie UserName = new HttpCookie("HRUserName");
                    //设置Cookie
                    LoginName.Value = ds[0].loginname;
                    UserId.Value = ds[0].id.ToString();
                    UserName.Value = HttpUtility.UrlEncode(ds[0].username);

                    Response.AppendCookie(LoginName);
                    Response.AppendCookie(UserId);
                    Response.AppendCookie(UserName);
                    if (ds[0].userprower == 0)
                    {
                        Response.Redirect("HRData.aspx");//用户类型为0时则代表的是管理员登录
                    }
                    else if (ds[0].userprower == 1)
                    {
                        Response.Redirect("HRData.aspx");//用户类型为1时则代表的是录入员登录
                        //Response.Write("<script>alert('你只是普通用户,只能对数据进行浏览.');window.open('HRData.aspx','_self')</script>");
                    }
                    else if (ds[0].userprower == 2)//用户类型为2时则代表的是审核员登录
                    {
                       Response.Redirect("check.aspx");
                    }
                    else if (ds[0].userprower == 3)//用户类型为0时则代表的是普通登录
                    {
                        Response.Redirect("perInfoQuery.aspx");
                    }

                }
                else
                {
                    Response.Write("<script language='javascript'>alert('用户名或密码错误!');</script>");
                }

            }
            else
            {
                Response.Write("<script language='javascript'>alert('用户名或密码错误!');</script>");//5^1^a~s_p~x
            }
    }
    public bool Check()
    {
        HRHelper hrhelper = new HRHelper();
        if (Request.Cookies["HRLoginName"] == null || Request.Cookies["HRId"] == null)
        {

        }
        else
        {
            string loginname = Request.Cookies["HRLoginName"].Value;
            string hrid = Request.Cookies["HRId"].Value;
            int power = -1;
            if (!hrhelper.IsUserExist(loginname, hrid,ref power))
            {
                //Response.Redirect("login.aspx");
                //return false;
                return false;
            }

            string strWhere = "loginname = '" + loginname + "'";
            IList<tb_Users> ds = dal.GetListAll(strWhere);
            if (ds.Count > 0)
            {
                if (ds[0].userprower == 0)
                {
                    Response.Redirect("HRData.aspx");//用户类型为0时则代表的是管理员登录
                }
                else if (ds[0].userprower == 1)
                {
                    Response.Redirect("HRData.aspx");//用户类型为1时则代表的是录入员登录
                    //Response.Write("<script>alert('你只是普通用户,只能对数据进行浏览.');window.open('HRData.aspx','_self')</script>");
                }
                else if (ds[0].userprower == 2)//用户类型为2时则代表的是审核员登录
                {
                    Response.Redirect("check.aspx");
                }
                else if (ds[0].userprower == 3)//用户类型为0时则代表的是普通登录
                {
                    Response.Redirect("perInfoQuery.aspx");
                }
            }
        }

        return true;
    }
}
