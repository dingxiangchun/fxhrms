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

public partial class revertData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "还原数据库";
        }
    }
    protected void bt_revert_Click(object sender, EventArgs e)
    {
        string database = "HRMS";
        string sqlpath = FileUpload1.PostedFile.FileName;
        if (sqlpath == "")
        {
            Response.Write("<script>alert('请选择备份数据库文件的路径。')</script>");
        }
        else
        {
            string SqlStr = "use master restore database " + database + " from disk='" + sqlpath + "'";
            
            int row = DbHelperSQL.ExecuteSql(SqlStr);
            if (row != 0)
            {
                Response.Write("<script language=javascript>alert('数据还原成功！');location='HRData.aspx'</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('数据还原失败！')</script>");
            }
        }
    }
    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRData.aspx");
    }
}
