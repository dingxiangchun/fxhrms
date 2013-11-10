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

public partial class updateAddressBook : System.Web.UI.Page
{
    tb_addressBook model = new tb_addressBook();
    addressBook dal = new addressBook();
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "修改通讯录信息";
            id = int.Parse(Request["id"].ToString());
            databind();
        }
    }
    public void databind()
    {
        model = dal.GetModel(id);
        tb_email.Text = model.e_mail;
        tb_handset.Text = model.handset;
        tb_name.Text = model.uName;
        tb_phone.Text = model.phone;
        tb_qq.Text = model.QQ;
        ddl_sex.Text = model.sex;
        tb_workphone.Text = model.workPhone;
    }
    protected void bt_update_Click(object sender, EventArgs e)
    {
        model.e_mail = tb_email.Text;
        model.handset = tb_handset.Text.Trim();
        model.phone = tb_phone.Text.Trim();
        model.uName = tb_name.Text.Trim();
        model.QQ = tb_qq.Text.Trim();
        model.sex = ddl_sex.SelectedItem.Text.ToString();
        model.workPhone = tb_workphone.Text.Trim();
        model.id = id;
        dal.Update(model);
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("addressBookInfo.aspx");
    }
}
