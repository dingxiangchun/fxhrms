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
using Models;//5~1^a_s_p_x

public partial class userset : System.Web.UI.Page
{
    tb_Users model = new tb_Users();
    users dal = new users();
    public static string strWhere = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string usergroup = Session["group"].ToString();
            if (usergroup != "1")
            {
                bt_add.Enabled = false;
                bt_update.Enabled = false;
                bt_del.Enabled = false;
            }
            lb_url.Text = "用户设置";
            dataBind();
        }
        bt_del.Attributes.Add("onclick", "javascript:return window.confirm('您确定删除吗?')");
    }
    public void dataBind()
    {
        GridView1.DataSource = dal.GetList(strWhere);
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        model.userName = tb_username.Text.Trim();
        model.userPwd = tb_pwd.Text;
        dal.Add(model);
        dataBind();
        tb_pwd.Text = "";
        tb_username.Text = "";
    }
    protected void bt_update_Click(object sender, EventArgs e)
    {
        bool cbstate = false;
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (cb.Checked)
            {
                cbstate = true;
                int id = int.Parse(GridView1.DataKeys[i].Value.ToString());
                tb_Users model = new tb_Users();
                model = dal.GetModel(id);
                int ugroup = model.userGroup;
                if (ugroup == 1)
                {
                    ugroup = 0;
                }
                else
                {
                    ugroup = 1;
                }
                model.id = id;
                model.userGroup = ugroup;
                dal.Update(model);
            }
        }
        if (!cbstate)
        {
            Response.Write("<script>alert('请选择要设置的数据.')</script>");
            return;
        }
        dataBind();
    }
    protected void bt_del_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
            if (cb.Checked)
            {
                int id = int.Parse(GridView1.DataKeys[i].Value.ToString());
                dal.Delete(id);
            }
        }
        dataBind();
    }
    protected void cb_all_CheckedChanged(object sender, EventArgs e)
    {
        if (cb_all.Checked)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                cb.Checked = true;
            }
        }
        else
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                cb.Checked = false;
            }
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        dataBind();
    }
}
