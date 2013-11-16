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
using Models;//5~1^a_s~p_x

public partial class updatePerInfo : System.Web.UI.Page
{
    //public static string perid;
    //public static string pernum;
    //protected void Page_Load(object sender, EventArgs e)
    //{
    //    if (!IsPostBack)
    //    {
    //        perid = Request["perid"].ToString();
    //        pernum = Request["pernum"].ToString();
    //        lb_url.Text = "修改员工信息";
    //        dataBind();
    //        famdataBind();
    //        workdataBind();
    //    }
    //}
    //tb_perInfo permodel = new tb_perInfo();
    //perInfo perdal = new perInfo();
    //public void dataBind()
    //{
    //    permodel = perdal.GetModel(perid);
    //    tb_pernum.Text = permodel.perNum;
    //    tb_pername.Text = permodel.perName;
    //    tb_folk.Text = permodel.folk;
    //    tb_birthday.Text = permodel.birthday;
    //    tb_age.Text = (permodel.age).ToString();
    //    tb_kultur.Text = permodel.kultur;
    //    tb_marr.Text = permodel.marriage;
    //    tb_sex.Text = permodel.sex;
    //    tb_vis.Text = permodel.visage;
    //    tb_IDCard.Text = permodel.IDCard;
    //    tb_origo.Text = permodel.origo;
    //    tb_workdate.Text = permodel.workDate;
    //    tb_worklen.Text = (permodel.workLength).ToString();
    //    tb_emp.Text = permodel.employee;
    //    tb_inwork.Text = permodel.intoWorkDate;
    //    tb_inworklen.Text = (permodel.intoWorkLength).ToString();
    //    tb_laytype.Text = permodel.laborageType;
    //    tb_branch.Text = permodel.branch;
    //    tb_head.Text = permodel.headship;
    //    tb_zc.Text = permodel.ZhiChen;
    //    tb_phone.Text = permodel.phone;
    //    tb_handset.Text = permodel.handset;
    //    tb_address.Text = permodel.address;
    //    tb_school.Text = permodel.school;
    //    tb_spe.Text = permodel.speciality;
    //    tb_gradate.Text = permodel.GraduateDate;
    //}
    //protected void bt_update_Click(object sender, EventArgs e)
    //{
    //    permodel.id = int.Parse(perid.ToString());
    //    permodel.perNum = tb_pernum.Text.Trim();
    //    permodel.perName = tb_pername.Text.Trim();
    //    permodel.folk = tb_folk.Text.Trim();
    //    permodel.birthday = tb_birthday.Text.Trim();
    //    permodel.age = int.Parse(tb_age.Text);
    //    permodel.kultur = tb_kultur.Text.Trim();
    //    permodel.marriage = tb_kultur.Text.Trim();
    //    permodel.sex = tb_sex.Text.Trim();
    //    permodel.visage = tb_vis.Text.Trim();
    //    permodel.IDCard = tb_IDCard.Text.Trim();
    //    permodel.origo = tb_origo.Text.Trim();
    //    permodel.workDate = tb_workdate.Text.Trim();
    //    permodel.workLength = int.Parse(tb_worklen.Text);
    //    permodel.employee = tb_emp.Text.Trim();
    //    permodel.intoWorkDate = tb_inwork.Text.Trim();
    //    permodel.intoWorkLength = int.Parse(tb_inworklen.Text);
    //    permodel.laborageType = tb_laytype.Text.Trim();
    //    permodel.branch = tb_branch.Text.Trim();
    //    permodel.headship = tb_head.Text.Trim();
    //    permodel.ZhiChen = tb_zc.Text.Trim();
    //    permodel.phone = tb_phone.Text.Trim();
    //    permodel.handset = tb_handset.Text.Trim();
    //    permodel.address = tb_address.Text.Trim();
    //    permodel.school = tb_school.Text.Trim();
    //    permodel.speciality = tb_spe.Text.Trim();
    //    permodel.GraduateDate = tb_gradate.Text.Trim();
    //    string perphoto = FileUpload1.FileName.ToString();
    //    if (perphoto != "")
    //    {
    //        string photopath = Server.MapPath("Photo");
    //        FileUpload1.SaveAs(photopath + "\\" + perphoto);
    //    }
    //    permodel.photoImage = perphoto;
    //    perdal.Update(permodel);
    //}
    //protected void bt_back_Click(object sender, EventArgs e)
    //{
    //    Response.Redirect("HRData.aspx");
    //}
    //tb_family fammodel = new tb_family();
    //family famdal = new family();
    //public void famdataBind()
    //{
    //    GridView1.DataSource = famdal.GetList(pernum);
    //    GridView1.DataKeyNames = new string[] { "id" };
    //    GridView1.DataBind();
    //}
    //protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    //{
    //    fammodel.LeaguerName = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
    //    fammodel.Nexus = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
    //    fammodel.BirthDate = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
    //    fammodel.WorkInc = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
    //    fammodel.headship = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
    //    fammodel.visage = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[5].Controls[0])).Text.ToString().Trim();
    //    fammodel.phone = ((TextBox)(GridView1.Rows[e.RowIndex].Cells[6].Controls[0])).Text.ToString().Trim();
    //    fammodel.id =int.Parse(GridView1.DataKeys[e.RowIndex].Value.ToString());
    //    fammodel.perID = pernum;
    //    famdal.Update(fammodel);

    //}

    //protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView1.EditIndex = e.NewEditIndex;
    //    famdataBind();
    //}
    //protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    //{
    //    GridView1.EditIndex = -1;
    //    famdataBind();
    //}
    //tb_workresume workmodel = new tb_workresume();
    //workResume workdal = new workResume();
    //public void workdataBind()
    //{
    //    GridView2.DataSource = workdal.GetList(pernum);
    //    GridView2.DataKeyNames = new string[] { "id" };
    //    GridView2.DataBind();
    //}
    //protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    //{
    //    GridView2.EditIndex = -1;
    //    workdataBind();
    //}
    //protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    //{
    //    GridView2.EditIndex = e.NewEditIndex;
    //    workdataBind();
    //}
    //protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
    //{
    //    workmodel.beginDate = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[0].Controls[0])).Text.ToString().Trim();
    //    workmodel.endDate = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
    //    workmodel.branch = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
    //    workmodel.headship = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
    //    workmodel.IncName = ((TextBox)(GridView2.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
    //    workmodel.id = int.Parse(GridView2.DataKeys[e.RowIndex].Value.ToString());
    //    workmodel.perID=pernum;
    //    workdal.Update(workmodel);
    //}
}

