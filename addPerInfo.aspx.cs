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


public partial class addPerInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
            lb_url.Text = "添加员工信息";
            ddlBind();
        }
    }
    public string strWhere = "";
    branch bradal = new branch();//部门
    folk foldal = new folk();//民族
    headship headal = new headship();//职务
    zhichen zcdal = new zhichen();//职称
    perInfo perdal = new perInfo();//员工
    family famdal = new family();//家庭
    tb_family fammodel = new tb_family();
    workResume wordal = new workResume();//工作经历
    tb_workresume workmodel = new tb_workresume();
    tb_perInfo permodel = new tb_perInfo();

    protected void ddlBind()
    {
        ddl_folk.DataSource = foldal.GetList(strWhere);
        ddl_folk.DataTextField = "folkName";
        ddl_folk.DataBind();

        ddl_branch.DataSource = bradal.GetList(strWhere);
        ddl_branch.DataTextField = "branchName";
        ddl_branch.DataBind();

        ddl_head.DataSource = headal.GetList(strWhere);
        ddl_head.DataTextField = "hName";
        ddl_head.DataBind();

        ddl_zc.DataSource = zcdal.GetList(strWhere);
        ddl_zc.DataTextField = "ZCName";
        ddl_zc.DataBind();
    }
    protected void bt_save_Click(object sender, EventArgs e)
    {
        permodel.perNum = tb_pernum.Text.Trim();
        permodel.perName = tb_pername.Text.Trim();
        permodel.folk = ddl_folk.SelectedItem.Text.ToString();
        permodel.birthday = tb_birthday.Text.Trim();
        permodel.age = int.Parse(tb_age.Text);
        permodel.kultur = ddl_kultur.SelectedItem.Text.ToString();
        permodel.marriage = ddl_marr.SelectedItem.Text.ToString();
        permodel.sex = ddl_sex.SelectedItem.Text.ToString();
        permodel.visage = ddl_vis.SelectedItem.Text.ToString();
        permodel.IDCard = tb_IDCard.Text.Trim();
        permodel.origo = tb_origo.Text.Trim();
        permodel.workDate = tb_workdate.Text.Trim();
        permodel.workLength = int.Parse(tb_worklen.Text);
        permodel.employee = ddl_emp.SelectedItem.Text.ToString();
        permodel.intoWorkDate = tb_inwork.Text.Trim();
        permodel.intoWorkLength = int.Parse(tb_inworklen.Text);
        permodel.laborageType = ddl_labtype.SelectedItem.Text.ToString();
        permodel.branch = ddl_branch.SelectedItem.Text.ToString();
        permodel.headship = ddl_head.SelectedItem.Text.ToString();
        permodel.ZhiChen = ddl_zc.SelectedItem.Text.ToString();
        permodel.phone = tb_phone.Text.Trim();
        permodel.handset = tb_handset.Text.Trim();
        permodel.address = tb_address.Text.Trim();
        permodel.school = tb_school.Text.Trim();
        permodel.speciality = tb_spe.Text.Trim();
        permodel.GraduateDate = tb_gradate.Text.Trim();
        string perphoto = FileUpload1.FileName.ToString();

        if (perphoto != "")
        {
            string photopath = Server.MapPath("Photo");
            FileUpload1.SaveAs(photopath + "\\" + perphoto);
        }
        permodel.photoImage = perphoto;
        perdal.Add(permodel);
    }
    protected void bt_exit_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRData.aspx");
    }
    protected void bt_famsave_Click(object sender, EventArgs e)
    {
        string pernum = tb_pernum.Text;
        if (pernum == "")
        {
            Response.Write("<script>alert('员工编号不能为空.')</script>");
            tb_pernum.Focus();
            return;
        }
        else
        {
            fammodel.perID = pernum;
            fammodel.LeaguerName = tb_famname.Text.Trim();
            fammodel.Nexus = tb_famnexus.Text.Trim();
            fammodel.BirthDate = tb_fambir.Text.Trim();
            fammodel.WorkInc = tb_famwork.Text.Trim();
            fammodel.headship = tb_famhead.Text.Trim();
            fammodel.visage = ddl_famvis.SelectedItem.Text.ToString();
            fammodel.phone = tb_famphone.Text.Trim();
            famdal.Add(fammodel);
        }
    }
    protected void bt_famcancel_Click(object sender, EventArgs e)
    {
        tb_famname.Text = "";
        tb_famnexus.Text = "";
        tb_famphone.Text = "";
        tb_famhead.Text = "";
        tb_fambir.Text = "";
        tb_famwork.Text = "";
    }
    protected void bt_worksave_Click(object sender, EventArgs e)
    {
        string pernum = tb_pernum.Text;
        if (pernum == "")
        {
            Response.Write("<script>alert('员工编号不能为空.')</script>");
            tb_pernum.Focus();
            return;
        }
        else
        {
            workmodel.beginDate = tb_begdate.Text.Trim();
            workmodel.endDate = tb_enddate.Text.Trim();
            workmodel.branch = tb_workbranch.Text.Trim();
            workmodel.headship = tb_workhead.Text.Trim();
            workmodel.IncName = tb_workinc.Text.Trim();
            workmodel.perID = pernum;
            wordal.Add(workmodel);
        }
    }
    protected void bt_workcancel_Click(object sender, EventArgs e)
    {
        tb_begdate.Text = "";
        tb_enddate.Text = "";
        tb_workbranch.Text = "";
        tb_workhead.Text = "";
        tb_workinc.Text = "";
    }
}
