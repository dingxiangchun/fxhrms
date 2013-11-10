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

public partial class blotter : System.Web.UI.Page
{
    public static string id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "查看日常记事信息";
            id = Request["id"].ToString();
            databind();
        }
    }
    tb_blotter model = new tb_blotter();
    DAL.blotter dal = new DAL.blotter();
    public void databind()
    {
        model = dal.GetModel(int.Parse(id));
        lb_day.Text = model.noteDate;
        lb_title.Text = model.tTitle;
        lb_type.Text = model.noteSort;
        tb_content.Text = model.tContent;


    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("blotterInfo.aspx");
    }
}
