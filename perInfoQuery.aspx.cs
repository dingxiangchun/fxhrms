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
using DAL;
using Models;

public partial class perInfoQuery : System.Web.UI.Page
{
    perInfo dal = new perInfo();
    tb_perInfo model = new tb_perInfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "excel")
            { 
                IList<tb_perInfo> list;
                GetSearchData(out list);
                ExportExcel(list);

            }
            if (Request["action"] == "excelAll")
            {
 
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
        rangeTitle.HorizontalAlignment = 3;    //居中
        rangeTitle.Value2 = "花名册";

        worksheet1.Cells[2, 1] = "序号";
        worksheet1.Cells[2, 2] = "姓名";
        worksheet1.Cells[2, 3] = "身份证号码";
        worksheet1.Cells[2, 4] = "性别";
        worksheet1.Cells[2, 5] = "政治面貌";
        worksheet1.Cells[2, 6] = "加入党团时间";
        worksheet1.Cells[2, 7] = "出生日期";
        worksheet1.Cells[2, 8] = "参加工作时间";
        worksheet1.Cells[2, 9] = "金融工作时间";
        worksheet1.Cells[2, 10] = "全日制学历毕业院校";
        worksheet1.Cells[2, 11] = "全日制历所学专业";
        worksheet1.Cells[2, 12] = "最终学历院校";
        worksheet1.Cells[2, 13] = "最终学历专业";
        worksheet1.Cells[2, 14] = "全日制学历";
        worksheet1.Cells[2, 15] = "全日制学位";
        worksheet1.Cells[2, 16] = "在职教育学历";
        worksheet1.Cells[2, 17] = "在职教育学位";
        worksheet1.Cells[2, 18] = "专业技术资格";
        worksheet1.Cells[2, 19] = "工作单位";
        worksheet1.Cells[2, 20] = "工作岗位";
        worksheet1.Cells[2, 21] = "用工类别";
        worksheet1.Cells[2, 22] = "后备人才库类别";
        string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".xls";
        string filePath = Server.MapPath("~/" + fileName);
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

        list = dal.GetListAll(strwhere);
        return true;
    }

    public bool Search()
    {
        IList<tb_perInfo> list;
        GetSearchData(out list);
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Put("list", list);
        vh.Display("query.vm");
        return true;
    }
}
