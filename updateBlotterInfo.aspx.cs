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
public partial class updateBlotterInfo : System.Web.UI.Page
{
    public static string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "修改日常记事信息";
            id = Request["id"].ToString();
            databind();
        }
    }
    public void databind()
    {
        model = dal.GetModel(int.Parse(id));
        tb_day.Text = model.noteDate;
        tb_content.Text = model.tContent;
        tb_title.Text = model.tTitle;
        tb_type.Text = model.noteSort;
    }
    DAL.blotter dal = new DAL.blotter();
    tb_blotter model = new tb_blotter();
    protected void bt_update_Click(object sender, EventArgs e)
    {
        model.noteDate = tb_day.Text.Trim();
        model.noteSort = tb_type.Text;
        model.tContent = tb_content.Text;
        model.tTitle = tb_title.Text;
        model.id = int.Parse(id.ToString());
        dal.Update(model);
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("blotterInfo.aspx");
    }
}
