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

public partial class perInfoQuery : System.Web.UI.Page
{
    //perInfo dal = new perInfo();
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (!IsPostBack)
    //    {
    //        lb_url.Text = "查询员工信息";
    //        ddlBind();
    //    }
    //}
    //public string strWhere = "";
    //branch bradal = new branch();//部门
    //folk foldal = new folk();//民族
    //headship headal = new headship();//职务
    //zhichen zcdal = new zhichen();//职称
    //tb_perInfo permodel = new tb_perInfo();

    //protected void ddlBind()
    //{
    //    ddl_folk.DataSource = foldal.GetList(strWhere);
    //    ddl_folk.DataTextField = "folkName";
    //    ddl_folk.DataBind();

    //    ddl_branch.DataSource = bradal.GetList(strWhere);
    //    ddl_branch.DataTextField = "branchName";
    //    ddl_branch.DataBind();

    //    ddl_head.DataSource = headal.GetList(strWhere);
    //    ddl_head.DataTextField = "hName";
    //    ddl_head.DataBind();

    //    ddl_zc.DataSource = zcdal.GetList(strWhere);
    //    ddl_zc.DataTextField = "ZCName";
    //    ddl_zc.DataBind();
    //}
    //protected void bt_save_Click(object sender, EventArgs e)
    //{
    //    string selone = "请选择";
    //    string name = tb_pername.Text.Trim();//姓名
    //    string headship = ddl_head.SelectedItem.Text.ToString();//职务
    //    string zc = ddl_zc.SelectedItem.Text.ToString();//职称
    //    string branch = ddl_branch.SelectedItem.Text.ToString();//部门
    //    string emp = ddl_emp.SelectedItem.Text.ToString();//员工类型
    //    string labtype = ddl_labtype.SelectedItem.Text.ToString();//工资类别
    //    string beginage = tb_age.Text.Trim();
    //    string endage = tb_endage.Text.Trim();
    //    string sex = ddl_sex.SelectedItem.Text.ToString();
    //    string marr = ddl_marr.SelectedItem.Text.ToString();
    //    string folk = ddl_folk.SelectedItem.Text.ToString();
    //    string kultur = ddl_kultur.SelectedItem.Text.ToString();
    //    string vis = ddl_vis.SelectedItem.Text.ToString();
    //    string origo = tb_origo.Text.Trim();
    //    string school = tb_school.Text.Trim();
    //    string spe = tb_spe.Text.Trim();//专业
    //    //string gradate = tb_gradate.Text.Trim();//毕业时间
    //    if (name != "")
    //    {
    //        GridView1.DataSource = dal.GetList(name, 4);
    //        GridView1.DataBind();
    //        tb_pername.Text = "";
    //        return;
    //    }
    //    if (headship !=selone)
    //    {
    //        GridView1.DataSource = dal.GetList(headship, 2);
    //        GridView1.DataBind();
    //        ddl_head.Text = "请选择";
    //        return;
    //    }
    //    if (zc != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(zc, 3);
    //        GridView1.DataBind();
    //        ddl_zc.Text = "请选择";
    //        return;
    //    }
    //    if (branch != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(branch, 1);
    //        GridView1.DataBind();
    //        ddl_branch.Text = "请选择";
    //        return;
    //    }
    //    if (emp != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(emp, 5);
    //        GridView1.DataBind();
    //        ddl_emp.Text = "请选择";
    //        return;
    //    }
    //    if (labtype != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(labtype, 6);
    //        GridView1.DataBind();
    //        ddl_labtype.Text = "请选择";
    //        return;
    //    }
    //    if (beginage != "" && endage != "")
    //    {
    //        GridView1.DataSource = dal.GetList(beginage, endage);
    //        GridView1.DataBind();
    //        tb_age.Text = "";
    //        tb_endage.Text = "";
    //        return;
    //    }
    //    if (sex != "")
    //    {
    //        GridView1.DataSource = dal.GetList(sex, 6);
    //        GridView1.DataBind();
    //        ddl_sex.Text = "";
    //        return;
    //    }
    //    if (marr != "")
    //    {
    //        GridView1.DataSource = dal.GetList(marr,7);
    //        GridView1.DataBind();
    //        ddl_marr.Text = "";
    //        return;
    //    }
    //    if (folk != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(folk, 10);
    //        GridView1.DataBind();
    //        ddl_folk.Text = "请选择";
    //        return;
    //    }
    //    if (kultur != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(kultur, 9);
    //        GridView1.DataBind();
    //        ddl_kultur.Text = "请选择";
    //        return;
    //    }
    //    if (vis != selone)
    //    {
    //        GridView1.DataSource = dal.GetList(vis, 8);
    //        GridView1.DataBind();
    //        ddl_vis.Text = "请选择";
    //        return;
    //    }
    //    if (origo != "")
    //    {
    //        GridView1.DataSource = dal.GetList(origo, 11);
    //        GridView1.DataBind();
    //        tb_origo.Text = "";
    //        return;
    //    }
    //    if (school != "")
    //    {
    //        GridView1.DataSource = dal.GetList(school,12);
    //        GridView1.DataBind();
    //        tb_school.Text = "";
    //        return;
    //    }
    //    if (spe != "")
    //    {
    //        GridView1.DataSource = dal.GetList(spe,13);
    //        GridView1.DataBind();
    //        tb_spe.Text = "";
    //        return;
    //    }

    //}
    //protected void bt_cancel_Click(object sender, EventArgs e)
    //{
    //    tb_pername.Text = "";
    //    tb_school.Text = "";
    //    tb_spe.Text = "";
    //    tb_origo.Text = "";
    //    //tb_gradate.Text = "";
    //    tb_age.Text = "";
    //    tb_endage.Text = "";
    //}
    //protected void bt_exit_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("HRData.aspx");
    //}
    //protected void cb_all_CheckedChanged(object sender, EventArgs e)
    //{
    //    if (cb_all.Checked)
    //    {
    //        dataBind();
    //    }
    //}
    //protected void dataBind()
    //{
    //    GridView1.DataSource = dal.GetList("");
    //    GridView1.DataBind();
    //}
    //protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    //{
    //    GridView1.PageIndex = e.NewPageIndex;
    //    dataBind();
    //}
}
