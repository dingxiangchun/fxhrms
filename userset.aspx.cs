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
        string msg = ""; model.id = 1;
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
}
