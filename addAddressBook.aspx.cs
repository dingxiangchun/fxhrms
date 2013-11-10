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

public partial class addAddressBook : System.Web.UI.Page
{
    tb_addressBook model = new tb_addressBook();
    addressBook dal = new addressBook();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "添加通讯录信息";
        }
    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        model.e_mail = tb_email.Text;
        model.phone = tb_phone.Text.Trim();
        model.QQ = tb_qq.Text.Trim();
        model.sex = ddl_sex.SelectedItem.Text.ToString();
        model.uName = tb_name.Text.Trim();
        model.workPhone = tb_workphone.Text.Trim();
        model.handset = tb_handset.Text.Trim();
        dal.Add(model);
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("addressBookInfo.aspx");
    }
}
