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
using Models;//5~1^a_s&p*x

public partial class addressBookInfo : System.Web.UI.Page
{
    tb_addressBook model = new tb_addressBook();
    addressBook dal = new addressBook();
    public static string strWhere="";
         
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "通讯录";
            dataBind(strWhere);
        }
        bt_del.Attributes.Add("onclick", "javascript:return window.confirm('您确定删除吗?')");
    }
    public void dataBind(string strWhere)
    {
        GridView1.DataSource = dal.GetList(strWhere);
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void bt_query_Click(object sender, EventArgs e)
    {
        string strddl = ddl1.SelectedItem.Text.ToString();
        string strtb = tb_query.Text.Trim();
        if (strtb != "")
        {
            if (strddl == "按姓名查询")
            {
                GridView1.DataSource = dal.GetList(strtb, 1);
            }
            if (strddl == "按QQ查询")
            {
                GridView1.DataSource = dal.GetList(strtb, 2);
            }
            if (strddl == "按电子邮件查询")
            {
                GridView1.DataSource = dal.GetList(strtb, 3);
            }
        }
        dataBind(strWhere);
    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        Response.Redirect("addAddressBook.aspx");
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

                Response.Redirect("updateAddressBook.aspx" + "?id=" + id);
            }
        }
        if (!cbstate)
        {
            Response.Write("<script>alert('请选择要修改的数据.')</script>");
            return;
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
        dataBind(strWhere);
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
        dataBind(strWhere);
    }
}
