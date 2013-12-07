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
using System.Reflection;
using System.ComponentModel;

public partial class check : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Check())
            return;
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Display("check.vm");
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
            if (!hrhelper.IsUserExist(loginname, hrid))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }

}