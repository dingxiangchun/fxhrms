using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DAL;

public partial class HRData : System.Web.UI.Page
{
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (!IsPostBack)
    //    {

    //        string hrefurl = Request.Url.PathAndQuery;

    //        if (hrefurl.Substring(6).ToString() == "HRData.aspx")
    //        {
    //            lb_url.Text = "人事档案浏览";
    //        }
    //        string usergroup = Session["group"].ToString();
    //        if (usergroup != "1")
    //        {
    //            bt_add.Enabled = false;
    //            bt_update.Enabled = false;
    //            bt_del.Enabled = false;
    //        }

    //        dataBind();
    //    }
    //    bt_del.Attributes.Add("onclick", "javascript:return window.confirm('您确定删除吗?')");
    //}
    //perInfo dal = new perInfo();
    //public string strWhere="";
    //protected void dataBind()
    //{
    //    DataSet ds = new DataSet();
    //    ds = dal.GetList(strWhere);
    //    GridView1.DataSource = ds.Tables[0];
    //    GridView1.DataKeyNames = new string[] { "id", "perNum" };
    //    GridView1.DataBind();
    //}
    //protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewPageIndex;
    //    dataBind();
    //}
    //branch brdal = new branch();
    //headship hsdal = new headship();
    //zhichen zc = new zhichen();
    //protected void ddl1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    DataSet ds=new DataSet();
    //    string txt = ddl1.SelectedItem.Text.Trim();
    //    if (txt == "按工作部门查询")
    //    {
    //        ds=brdal.GetList("");
    //        ddl2.DataSource = ds.Tables["ds"].DefaultView;
    //        ddl2.DataTextField = "branchName";
    //        ddl2.DataValueField = "id";
    //        ddl2.DataBind();
    //    }
    //    if (txt == "按员工职务查询")
    //    {
    //        ds = hsdal.GetList("");
    //        ddl2.DataSource = ds.Tables["ds"].DefaultView;
    //        ddl2.DataTextField = "hName";
    //        ddl2.DataValueField = "hid";
    //        ddl2.DataBind();
    //    }
    //    if (txt == "按员工职称查询")
    //    {
    //        ds = zc.GetList("");
    //        ddl2.DataSource = ds.Tables["ds"].DefaultView;
    //        ddl2.DataTextField = "ZCName";
    //        ddl2.DataValueField = "ZCID";
    //        ddl2.DataBind();
    //    }
    //}
    //protected void bt_query_Click(object sender, EventArgs e)
    //{
    //    string strddl1 = ddl1.SelectedItem.Text.Trim();
    //    string strddl2 = ddl2.SelectedItem.Text.ToString();
    //    string strname = tb_pername.Text.Trim();
    //    string strnum = tb_pernum.Text.Trim();
    //    if (strddl1 == "按工作部门查询" && strname == "" && strnum == "")
    //    {

    //        GridView1.DataSource = dal.GetList(strddl2, 1);
    //    }
    //    if (strddl1 == "按员工职务查询" && strname == "" && strnum == "")
    //    {
    //        GridView1.DataSource = dal.GetList(strddl2, 2);
    //    }
    //    if (strddl1 == "按员工职称查询" && strname == "" && strnum == "")
    //    {
    //        GridView1.DataSource = dal.GetList(strddl2, 3);
    //    }
    //    if (strname != ""&&strddl2=="请选择")
    //    {
    //        GridView1.DataSource = dal.GetList(strnum,4);
    //    }
    //    if (strnum != "" && strddl2 == "请选择")
    //    {
    //        GridView1.DataSource = dal.GetList(strnum);
    //    }
    //    GridView1.DataBind();
    //}
    //protected void bt_add_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("addPerInfo.aspx");
    //}
    //protected void bt_update_Click(object sender, EventArgs e)
    //{
    //    bool cbstate = false;
    //    for (int i = 0; i < GridView1.Rows.Count; i++)
    //    {
    //        CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
    //        if (cb.Checked)
    //        {
    //            cbstate = true;
    //            int perid = int.Parse(GridView1.DataKeys[i].Value.ToString());
    //            string pernum = GridView1.DataKeys[i][1].ToString();
    //            Response.Redirect("updatePerInfo.aspx" +"?perid="+ perid+"&&pernum="+pernum);
    //        }
    //    }
    //    if (!cbstate)
    //    {
    //        Response.Write("<script>alert('请选择要修改的数据.')</script>");
    //        return;
    //    }
        
    //}
    //protected void bt_del_Click(object sender, EventArgs e)
    //{
    //    for (int i = 0; i < GridView1.Rows.Count; i++)
    //    {
    //        CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
    //        if (cb.Checked)
    //        {
    //            int strid =int.Parse(GridView1.DataKeys[i].Value.ToString());
    //            dal.Delete(strid);
    //        }
    //    }
    //    dataBind();
    //}
    //protected void cb_all_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (cb_all.Checked)
    //    {
    //        for (int i = 0; i < GridView1.Rows.Count; i++)
    //        {
    //            CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
    //            cb.Checked = true;
    //        }
    //    }
    //    else
    //    {
    //        for (int i = 0; i < GridView1.Rows.Count; i++)
    //        {
    //            CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
    //            cb.Checked = false;
    //        }
    //    }
    //}
}
