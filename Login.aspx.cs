using System;
using System.Data;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using DAL;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tb_txtName.Focus();
    }
    DAL.users dal = new DAL.users();
    protected void ib_login_Click(object sender, ImageClickEventArgs e)
    {
        string uid = tb_txtName.Text;
        string pwd = tb_txtPwd.Text;
        bool pass = dal.Exists(uid, pwd);
        string code = tb_txtcode.Text.Trim().ToLower().ToString();
        if (code != Request.Cookies["CheckCode"].Value.ToLower().ToString())//5_1^a_s_p~x
        {
            //UpdatePanel里面的控件不要使用Response.Write()使用即出错 
            Response.Write("<script language='javascript'>alert('验证码错误!');</script>");

            //使用微软的Ajax框架后不要用response.write()弹出提示框,用下面这个:
            //ScriptManager.RegisterStartupScript(tUpdatePanel1, this.GetType(), "codeerror", "alert('验证码错误.');", true);
        }
        else
        {
            if (pass)
            {
                Session["uid"] = tb_txtName.Text;
                DataSet ds = dal.GetList(uid);
                int usergroup = int.Parse(ds.Tables[0].Rows[0][3].ToString());
                Session["group"] = usergroup;
                if (usergroup == 1)
                {
                    Response.Redirect("index.aspx");//用户类型为1时则代表的是管理员登录
                }
                else
                {
                    Response.Write("<script>alert('你只是普通用户,只能对数据进行浏览.');window.open('index.aspx','_self')</script>");
                }
            }
            else
            {
                Response.Write("<script language='javascript'>alert('用户名或密码错误!');</script>");//5^1^a~s_p~x
            }
        }
    }
}
