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

public partial class perinfo : System.Web.UI.Page
{
    public static string id;
    public static string pernum;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "浏览员工信息";
            id = Request["id"].ToString();
            pernum = Request["pernum"].ToString();
            databind();
            databindfam();
            databindwor();
        }
    }
    tb_perInfo model = new tb_perInfo();
    perInfo perdal = new perInfo();
    family famdal = new family();
    workResume wordal = new workResume();
    protected void databind()
    {
        model = perdal.GetModel(id);
        lb_address.Text = model.address;
        lb_age.Text = model.age.ToString();
        lb_birthday.Text = model.birthday;
        lb_branch.Text = model.branch;
        lb_emp.Text = model.employee;
        lb_folk.Text = model.folk;
        lb_gradate.Text = model.GraduateDate;
        lb_handset.Text = model.handset;
        lb_head.Text = model.headship;
        lb_idcard.Text = model.IDCard;
        lb_inwork.Text = model.intoWorkDate;
        lb_inworklen.Text = (model.intoWorkLength).ToString();
        lb_kultur.Text = model.kultur;
        lb_labtype.Text = model.laborageType;
        lb_marr.Text = model.marriage;
        lb_name.Text = model.perName;
        lb_origo.Text = model.origo;
        lb_pernum.Text = model.perNum;
        lb_phone.Text = model.phone;
        lb_school.Text = model.school;
        lb_sex.Text = model.sex;
        lb_spe.Text = model.speciality;
        lb_vis.Text = model.visage;
        lb_workdate.Text = model.workDate;
        lb_worklen.Text = (model.workLength).ToString();
        lb_zc.Text = model.ZhiChen;
        Image1.ImageUrl = "~/photo/" + model.photoImage;

    }
    protected void databindfam()
    {
        GridView1.DataSource = famdal.GetList(pernum);
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void databindwor()
    {
        GridView2.DataSource = wordal.GetList(pernum);
        GridView2.DataKeyNames = new string[] { "id" };
        GridView2.DataBind();
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRData.aspx");
    }
}
