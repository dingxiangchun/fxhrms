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
using Models;//5~1^a^s~p_x

public partial class addBlotterInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "添加日常记事信息";
            
        }
    }
    DAL.blotter dal = new DAL.blotter();
    tb_blotter model = new tb_blotter();

    protected void bt_add_Click(object sender, EventArgs e)
    {
        model.noteDate = tb_day.Text.Trim();
        model.noteSort = tb_type.Text.Trim();
        model.tContent = tb_content.Text.ToString();
        model.tTitle = tb_title.Text;
        dal.Add(model);
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("blotterInfo.aspx");
    }
}
