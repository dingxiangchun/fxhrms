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

public partial class ClearData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "清空数据表信息";
            string usergroup = Session["group"].ToString();
            if (usergroup != "1")
            {
                
                bt_del.Enabled = false;
            }
        }
        bt_del.Attributes.Add("onclick", "javascript:return window.confirm('您确定清空所选择的数据表信息吗?')");
    }
    public static int row=0;
    protected void bt_del_Click(object sender, EventArgs e)
    {
        //int row;
        for (int i = 1; i <= 10; i++)
        {
            CheckBox cb = (CheckBox)Panel1.FindControl("CheckBox" + i);
            string cbstr = cb.ClientID.ToString();
            
            if (cb.Checked)
            {
                if (cbstr == "CheckBox1")
                {
                    string sqlstr="delete from tb_branch";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox2")
                {
                    string sqlstr = "delete from tb_folk";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox3")
                {
                    string sqlstr = "delete from tb_headship";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox4")
                {
                    string sqlstr = "delete from tb_zhichen";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox5")
                {
                    string sqlstr = "delete from tb_perInfo";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox6")
                {
                    string sqlstr = "delete from tb_Users";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox7")
                {
                    string sqlstr = "delete from tb_family";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox8")
                {
                    string sqlstr = "delete from tb_workresume";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox9")
                {
                    string sqlstr = "delete from tb_blotter";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
                if (cbstr == "CheckBox10")
                {
                    string sqlstr = "delete from tb_addressBook";
                    row = DbHelperSQL.ExecuteSql(sqlstr);
                }
            }
        }
        if (row > 0)
        {
            Response.Write("<script>alert('数据清空成功.')</script>");
        }
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRData.aspx");
    }
    protected void cb_all_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_all.Checked)
        {
            for (int i = 1; i <=10; i++)
            {
                CheckBox cb = (CheckBox)Panel1.FindControl("CheckBox" + i);
                cb.Checked = true;
            }
        }
        else
        {
            for (int i = 1; i <= 10; i++)
            {
                CheckBox cb = (CheckBox)Panel1.FindControl("CheckBox" + i);
                cb.Checked = false;
            }
        }
    }


}
