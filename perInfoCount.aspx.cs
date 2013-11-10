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

public partial class perInfoCount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "人事资料统计";
            dataBind();
        }
    }
    perInfo dal = new perInfo();
    public static string Item_Field = "folk,age,kultur,marriage,sex,visage,workLength,employee,headship,laborageType,branch,ZhiChen,school,speciality";
    public static string Item_Value = "民族类别,年龄,文化程度,婚姻,性别,政治面貌,工龄,职工类别,职务类别,工资类别,部门类别,职称类别,毕业学校,主修专业";
    public static string[] A_Field = Item_Field.Split(Convert.ToChar(','));
    public static string[] A_Value = Item_Value.Split(Convert.ToChar(','));
    protected void dataBind()
    {
        ListBox1.Items.Clear();
        for (int i = 0; i < A_Value.Length; i++)
        {
            ListBox1.Items.Add("按" + A_Value[i] + "统计");
        }
        dataGrid(0);
    }
    public void dataGrid(int n)
    {
        string field = A_Field[n].ToString();
        string value = A_Value[n].ToString();
        GridView1.DataSource = dal.GetListBind(field, value);
        GridView1.DataBind();

    }
    public int page;
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        page = ListBox1.SelectedIndex;
        dataGrid(page);
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        dataGrid(page);
    }

}
