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

public partial class addZhiChen : System.Web.UI.Page
{
    zhichen dal = new zhichen();
    tb_zhichen model = new tb_zhichen();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "职称类别设置";
            dataBind();
        }
        bt_del.Attributes.Add("onclick", "javascript:return window.confirm('您确定删除吗?')");
    }
    public void dataBind()
    {
        GridView1.DataSource = dal.GetList("");
        GridView1.DataKeyNames = new string[] { "ZCID" };
        GridView1.DataBind();
    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        if (tb_zc.Text != "")
        {
            model.ZCName = tb_zc.Text.Trim();
            dal.Add(model);
            tb_zc.Text = "";
            dataBind();
        }
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
