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
using System.IO;
using System.Diagnostics;
using DAL;

public partial class backupData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lb_url.Text = "备份数据库";
        }
    }
    //DbHelperSQL db = new DbHelperSQL();
    protected void bt_backup_Click(object sender, EventArgs e)
    {
        //string sqlip = "C3CEEEAF1052413";
        //string logname = "sa";
        //string sqlpwd = "sa";
        string database = "HRMS";

        string sqlstr = "";
        string nowdate = Time_Format(System.DateTime.Now.ToString());
        if (rb_other.Checked)
        {
            if (tb_other.Text != "")
            {
                string strother = tb_other.Text.ToString();
                                     
                //SQLBACK(sqlip, logname, sqlpwd, database, strother);
                sqlstr = "backup database " + database + " to disk='" + strother+"\\"+nowdate + ".bak'";
                int row=DbHelperSQL.ExecuteSql(sqlstr);
                if (row != 0)
                {
                    Response.Write("<script language=javascript>alert('备份数据成功！');location='HRData.aspx'</script>");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('备份数据失败！')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('请选择备份数据库文件的路径。')</script>");
            }
        }
        else
        {
            string defstr = System.Environment.CurrentDirectory + "\\bar\\";
            sqlstr = "backup database " + database + " to disk='" + defstr + nowdate + ".bak'";
            int row = DbHelperSQL.ExecuteSql(sqlstr);
            if (row != 0)
            {
                Response.Write("<script language=javascript>alert('备份数据成功！');location='HRData.aspx'</script>");
            }
            else
            {
                Response.Write("<script language=javascript>alert('备份数据失败！')</script>");
            }
        }

    }
    #region  将时间转换成指定的格式
    /// <summary>
    /// 将时间转换成yyyy-mm-dd格式.
    /// </summary>
    /// <param name="NDate">日期</param>
    /// <returns>返回String对象</returns>
    public string Time_Format(string NDate)
    {
        string sh, sm, se,ss;
        int year,month,day,hh;
        try
        {
            year = Convert.ToDateTime(NDate).Year;
            month = Convert.ToDateTime(NDate).Month;
            day = Convert.ToDateTime(NDate).Day;
            hh = Convert.ToDateTime(NDate).Hour;

        }
        catch
        {
            return "";
        }
        sh = Convert.ToString(year);
        if (sh.Length < 2)
            sh = "0" + sh;
        sm = Convert.ToString(month);
        if (sm.Length < 2)
            sm = "0" + sm;
        se = Convert.ToString(day);
        if (se.Length < 2)
            se = "0" + se;
        ss = Convert.ToString(hh);
        if (ss.Length < 2)
            ss = "0" + ss;
        return sh + sm + se+ss;
    }
    #endregion
    #region SQL数据库备份
    /// <summary>
    /// SQL数据库备份
    /// </summary>
    /// <param name="ServerIP">SQL服务器IP或(Localhost)</param>
    /// <param name="LoginName">数据库登录名</param>
    /// <param name="LoginPass">数据库登录密码</param>
    /// <param name="DBName">数据库名</param>
    /// <param name="BackPath">备份到的路径</param>
    public static void SQLBACK(string ServerIP, string LoginName, string LoginPass, string DBName, string BackPath)
    {
        SQLDMO.Backup oBackup = new SQLDMO.BackupClass();// SQLDMO.BackupClass();
       
        SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
        try
        {
            oSQLServer.LoginSecure = false;
            oSQLServer.Connect(ServerIP, LoginName, LoginPass);
            oBackup.Database = DBName;
            oBackup.Files = BackPath;
            oBackup.BackupSetName = DBName;
            oBackup.BackupSetDescription = "数据库备份";
            oBackup.Initialize = true;
            oBackup.SQLBackup(oSQLServer);

        }
        catch (Exception e)
        {
            throw new Exception(e.ToString());
        }
        finally
        {
            oSQLServer.DisConnect();
        }
    }
    #endregion

    #region SQL恢复数据库
    /// <summary>
    /// SQL恢复数据库
    /// </summary>
    /// <param name="ServerIP">SQL服务器IP或(Localhost)</param>
    /// <param name="LoginName">数据库登录名</param>
    /// <param name="LoginPass">数据库登录密码</param>
    /// <param name="DBName">要还原的数据库名</param>
    /// <param name="BackPath">数据库备份的路径</param>

    public static void SQLDbRestore(string ServerIP, string LoginName, string LoginPass, string DBName, string BackPath)
    {

        SQLDMO.Restore orestore = new SQLDMO.RestoreClass();
        SQLDMO.SQLServer oSQLServer = new SQLDMO.SQLServerClass();
        try
        {
            oSQLServer.LoginSecure = false;
            oSQLServer.Connect(ServerIP, LoginName, LoginPass);
            orestore.Action = SQLDMO.SQLDMO_RESTORE_TYPE.SQLDMORestore_Database;
            orestore.Database = DBName;
            orestore.Files = BackPath;
            orestore.FileNumber = 1;
            orestore.ReplaceDatabase = true;
            orestore.SQLRestore(oSQLServer);

        }
        catch (Exception e)
        {
            throw new Exception(e.ToString());
        }
        finally
        {
            oSQLServer.DisConnect();
        }
    }


    #endregion

    protected void bt_back_Click(object sender, EventArgs e)
    {
        Response.Redirect("HRData.aspx");
    }//5~1^a_s~p*x



}
