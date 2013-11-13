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
