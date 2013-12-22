using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using Word = Microsoft.Office.Interop.Word;
using DAL;
using Models;
using OfficeControl;

public partial class perInfoQuery : System.Web.UI.Page
{
    pertypeinfoData dalpertype = new pertypeinfoData();
    perInfo dal = new perInfo();
    tb_perInfo model = new tb_perInfo();
    tb_pertypeinfo modelpertype = new tb_pertypeinfo();
    ReserveData Resdal = new ReserveData();
    IList<tb_Reserve> ReserveList;

    int m_power = -1;
    public perInfoQuery()
    {
        ReserveList = Resdal.GetListAll("");
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Check())
            return;

        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "excel")
            {
                if (!string.IsNullOrEmpty(Request["ids"]))
                {
                    string strwhere = "(1=0";
                    string[] idlist = Request["ids"].Split(',');
                    for (int i = 0; i < idlist.Length; i++)
                    {
                        strwhere += " or tb_perInfo.id=" + idlist[i];
                    }
                    strwhere += ")";
                    IList<tb_perInfo> list = dal.GetListAll(strwhere);
                    ChangeReserve(ref list);
                    ExportExcel(list);
                }

            }
            if (Request["action"] == "excelAll")
            {
                IList<tb_perInfo> list;
                GetSearchData(out list);
                ChangeReserve(ref list);
                ExportExcel(list);
            }
        }
        else
        {
            Search();
        }
    }

    public bool ExportExcel(IList<tb_perInfo> list)
    {
        Excel.Application excel = new Excel.Application();
        excel.DisplayAlerts = false;
        Excel.Workbook workbook1 = excel.Workbooks.Add(Type.Missing);
        excel.Visible = false;
        Excel.Worksheet worksheet1 = (Excel.Worksheet)workbook1.Worksheets["sheet1"];
        
        Excel.Range rangeTitle = worksheet1.get_Range(worksheet1.Cells[1, 1], worksheet1.Cells[1, 22]) as Excel.Range;//合并一行两列
        rangeTitle.Merge(true);
        rangeTitle.Columns.ColumnWidth = 20;
        rangeTitle.Rows.RowHeight = 50;
        rangeTitle.HorizontalAlignment = 3;    //居中
        rangeTitle.Value2 = "花名册";
        rangeTitle.Font.Size = 20;

        (worksheet1.get_Range(worksheet1.Cells[2, 1], worksheet1.Cells[3, 1]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 1] = "序号";
        (worksheet1.get_Range(worksheet1.Cells[2, 2], worksheet1.Cells[3, 2]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 2] = "姓名";
        (worksheet1.get_Range(worksheet1.Cells[2, 3], worksheet1.Cells[3, 3]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 3] = "身份证号码";
        (worksheet1.get_Range(worksheet1.Cells[2, 4], worksheet1.Cells[3, 4]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 4] = "性别";
        (worksheet1.get_Range(worksheet1.Cells[2, 5], worksheet1.Cells[3, 5]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 5] = "政治面貌";
        (worksheet1.get_Range(worksheet1.Cells[2, 6], worksheet1.Cells[3, 6]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 6] = "加入党团时间";
        (worksheet1.get_Range(worksheet1.Cells[2, 7], worksheet1.Cells[3, 7]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 7] = "出生日期";
        (worksheet1.get_Range(worksheet1.Cells[2, 8], worksheet1.Cells[3, 8]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 8] = "参加工作时间";
        (worksheet1.get_Range(worksheet1.Cells[2, 9], worksheet1.Cells[3, 9]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 9] = "金融工作时间";
        (worksheet1.get_Range(worksheet1.Cells[2, 10], worksheet1.Cells[3, 10]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 10] = "全日制学历毕业院校";
        (worksheet1.get_Range(worksheet1.Cells[2, 11], worksheet1.Cells[3, 11]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 11] = "全日制历所学专业";
        (worksheet1.get_Range(worksheet1.Cells[2, 12], worksheet1.Cells[3, 12]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 12] = "最终学历院校";
        (worksheet1.get_Range(worksheet1.Cells[2, 13], worksheet1.Cells[3, 13]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 13] = "最终学历专业";
        (worksheet1.get_Range(worksheet1.Cells[2, 14], worksheet1.Cells[2, 15]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 14] = "全日制教育";
        worksheet1.Cells[3, 14] = "学历";
        worksheet1.Cells[3, 15] = "学位";
        (worksheet1.get_Range(worksheet1.Cells[2, 16], worksheet1.Cells[2, 17]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 16] = "在职教育";
        worksheet1.Cells[3, 16] = "学历";
        worksheet1.Cells[3, 17] = "学位";
        (worksheet1.get_Range(worksheet1.Cells[2, 18], worksheet1.Cells[3, 18]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 18] = "专业技术资格";
        (worksheet1.get_Range(worksheet1.Cells[2, 19], worksheet1.Cells[3, 19]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 19] = "工作单位";
        (worksheet1.get_Range(worksheet1.Cells[2, 20], worksheet1.Cells[3, 20]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 20] = "工作岗位";
        (worksheet1.get_Range(worksheet1.Cells[2, 21], worksheet1.Cells[3, 21]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 21] = "用工类别";
        (worksheet1.get_Range(worksheet1.Cells[2, 22], worksheet1.Cells[3, 22]) as Excel.Range).Merge(0);
        worksheet1.Cells[2, 22] = "后备人才库类别";

        Excel.Range rangehead= worksheet1.get_Range(worksheet1.Cells[2, 1], worksheet1.Cells[3, 22]);
        rangehead.Columns.ColumnWidth = 20;
        rangehead.Rows.RowHeight = 20;
        rangehead.HorizontalAlignment = 3;    //居中
        rangehead.Font.Size = 15;
        int i = 0;
        for (; i < list.Count; i++)
        {
            worksheet1.Cells[4+i, 1] = list[i].id.ToString();
            worksheet1.Cells[4+i, 2] = list[i].Name;
            worksheet1.get_Range(worksheet1.Cells[4 + i, 3], worksheet1.Cells[4 + i, 3]).NumberFormatLocal = "@";
            worksheet1.Cells[4+i, 3] = list[i].Idcard.ToString();
            worksheet1.Cells[4+i, 4] = list[i].Sex;
            worksheet1.Cells[4+i, 5] = list[i].Status;
            worksheet1.get_Range(worksheet1.Cells[4 + i, 6], worksheet1.Cells[4 + i, 6]).NumberFormatLocal = "@";
            worksheet1.Cells[4+i, 6] = list[i].Statustime;
            worksheet1.get_Range(worksheet1.Cells[4 + i, 7], worksheet1.Cells[4 + i, 7]).NumberFormatLocal = "@";
            worksheet1.Cells[4+i, 7] = list[i].Birth;
            worksheet1.get_Range(worksheet1.Cells[4 + i, 8], worksheet1.Cells[4 + i, 8]).NumberFormatLocal = "@";
            worksheet1.Cells[4+i, 8] = list[i].Jobtime;
            worksheet1.get_Range(worksheet1.Cells[4 + i, 9], worksheet1.Cells[4 + i, 9]).NumberFormatLocal = "@";
            worksheet1.Cells[4+i, 9] = list[i].financetime;
            worksheet1.Cells[4+i, 10] = list[i].fulltime_sch;
            worksheet1.Cells[4+i, 11] = list[i].Major;
            worksheet1.Cells[4+i, 12] = list[i].final_sch;
            worksheet1.Cells[4+i, 13] = list[i].final_emajior;
            worksheet1.Cells[4+i, 14] = list[i].fulltime_educ;
            worksheet1.Cells[4 + i, 15] = "";
            worksheet1.Cells[4+i, 16] = list[i].final_edu;
            worksheet1.Cells[4 + i, 17] = "";
            worksheet1.Cells[4 + i, 18] = "";
            worksheet1.Cells[4+i, 19] = list[i].Unit;
            worksheet1.Cells[4+i, 20] = list[i].PositionName;
            worksheet1.Cells[4+i, 21] = list[i].employclass;
            worksheet1.Cells[4 + i, 22] = list[i].Reserve;

        }  

        Excel.Range rangebody= worksheet1.get_Range(worksheet1.Cells[4, 1], worksheet1.Cells[4+i, 22]);
        rangebody.HorizontalAlignment = 3;    //居中

        string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
        string filePath = Server.MapPath("~/File/" + fileName);
        workbook1.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        excel.Workbooks.Close();
        excel.Quit();
        int generation = GC.GetGeneration(excel);
        System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        excel = null;
        GC.Collect(generation);
        //打开要下载的文件，并把该文件存放在FileStream中    
        System.IO.FileStream Reader = System.IO.File.OpenRead(filePath);
        //文件传送的剩余字节数：初始值为文件的总大小    
        long Length = Reader.Length;
        HttpContext.Current.Response.Buffer = false;
        HttpContext.Current.Response.Charset = "GB2312";
        HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
        HttpContext.Current.Response.AddHeader("Connection", "Keep-Alive");
        HttpContext.Current.Response.ContentType = "application/ms-excel";
        HttpContext.Current.Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
        HttpContext.Current.Response.AddHeader("Content-Length", Length.ToString());
        Response.TransmitFile(filePath); 
        Reader.Close();
        if (System.IO.File.Exists(filePath))
            System.IO.File.Delete(filePath); 
        return true;
    }

    public bool GetSearchData(out IList<tb_perInfo> list)
    {
        string strwhere = "1=1";
        if (Request["branchid"] != null && Request["branchid"] != "0")
        {
            strwhere += " and tb_perInfo.UnitID=" + Request["branchid"];
        }

        if (Request["name"] != null && Request["name"] != "")
        {
            strwhere += " and tb_perInfo.Name='" + Request["name"] + "'";
        }

        if (Request["Employeeid"] != null && Request["Employeeid"] != "")
        {
            strwhere += " and tb_perInfo.Employeeid='" + Request["Employeeid"] + "'";
        }

        if (Request["age"] != null && Request["age"] != "")
        {
            strwhere += " and (YEAR(CURDATE())-YEAR(STR_TO_DATE(tb_perinfo.Jobtime,\"%Y-%m-%d\"))) - (RIGHT(CURDATE(),5)<RIGHT(tb_perinfo.Jobtime,5))=" + Request["age"];
        }

        if (Request["Birth"] != null && Request["Birth"] != "")
        {
            strwhere += " and tb_perInfo.Birth='" + Request["Birth"] + "'";
        }

        if (Request["Rank"] != null && Request["Rank"] != "")
        {
            strwhere += " and tb_perInfo.Rank='" + Request["Rank"] + "'";
        }

        if (Request["Level"] != null && Request["Level"] != "")
        {
            strwhere += " and tb_perInfo.Level=" + Request["Rank"];
        }

        if (Request["fulltime_educ"] != null && Request["fulltime_educ"] != "")
        {
            strwhere += " and tb_perInfo.fulltime_educ='" + Request["fulltime_educ"] + "'";
        }

        if (Request["Guard"] != null && Request["Guard"] != "")
        {
            strwhere += " and tb_perInfo.Guard='" + Request["Guard"] + "'";
        }

        if (Request["perStatus"] != null && Request["perStatus"] != "")
        {
            strwhere += " and tb_perInfo.state='" + Request["perStatus"] + "'";
        }
        list = dal.GetListAll(strwhere);
        return true;
    }

    public bool Search()
    {
        IList<tb_perInfo> list;
        GetSearchData(out list);
        ChangeReserve(ref list);
        IList<tb_pertypeinfo> pertTypeList = dalpertype.GetListAll("");
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("list", list);
        vh.Put("perStatusList", pertTypeList);
        vh.Put("role", m_power);
        vh.Display("query.vm");
        return true;
    }

    public bool ChangeReserve(ref IList<tb_perInfo> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Reserve != "")
            {
                string strReslist = "";
                string[] residlist = list[i].Reserve.Split(',');
                for (int j = 0; j < residlist.Length; j++)
                {
                    for (int n = 0; n < ReserveList.Count; n++)
                    {
                        if (ReserveList[n].id == int.Parse(residlist[j]))
                            strReslist += ReserveList[n].ReserveType + ",";
                    }
                }

                list[i].Reserve = strReslist.Remove(strReslist.LastIndexOf(","), 1);
            }
        }
        return true;
    }

    public bool  Check()
    {
        HRHelper hrhelper = new HRHelper();
        if (Request.Cookies["HRLoginName"] == null || Request.Cookies["HRId"] == null)
        {
            Response.Redirect("login.aspx");
            return false;
        }
        else
        {
            string loginname = Request.Cookies["HRLoginName"].Value;
            string hrid = Request.Cookies["HRId"].Value;
            if (!hrhelper.IsUserExist(loginname, hrid,ref m_power))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }
}
