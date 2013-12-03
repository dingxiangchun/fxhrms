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
        worksheet1.Cells[1, 1] = "序号";
        worksheet1.Cells[1, 2] = "姓名";
        worksheet1.Cells[1, 3] = "身份证号码";
        worksheet1.Cells[1, 4] = "性别";
        worksheet1.Cells[1, 5] = "政治面貌";
        worksheet1.Cells[1, 6] = "加入党团时间";
        worksheet1.Cells[1, 7] = "出生日期";
        worksheet1.Cells[1, 8] = "参加工作时间";
        worksheet1.Cells[1, 9] = "金融工作时间";
        worksheet1.Cells[1, 10] = "全日制学历毕业院校";
        worksheet1.Cells[1, 11] = "全日制历所学专业";
        worksheet1.Cells[1, 12] = "最终学历院校";
        worksheet1.Cells[1, 13] = "最终学历专业";
        worksheet1.Cells[1, 14] = "全日制学历";
        worksheet1.Cells[1, 15] = "全日制学位";
        worksheet1.Cells[1, 16] = "在职教育学历";
        worksheet1.Cells[1, 17] = "在职教育学位";
        worksheet1.Cells[1, 18] = "专业技术资格";
        worksheet1.Cells[1, 19] = "工作单位";
        worksheet1.Cells[1, 20] = "工作岗位";
        worksheet1.Cells[1, 21] = "用工类别";
        worksheet1.Cells[1, 22] = "后备人才库类别";

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
        //byte[] Buffer = new Byte[10000];    //存放欲发送数据的缓冲区    
        //int ByteToRead;                     //每次实际读取的字节数    
        //while (Length > 0)
        //{
        //    //剩余字节数不为零，继续传送    
        //    if (Response.IsClientConnected)
        //    {
        //        //客户端浏览器还打开着，继续传送    
        //        ByteToRead = Reader.Read(Buffer, 0, 10000); //往缓冲区读入数据    
        //        HttpContext.Current.Response.OutputStream.Write(Buffer, 0, ByteToRead); //把缓冲区的数据写入客户端浏览器    
        //        HttpContext.Current.Response.Flush();   //立即写入客户端    
        //        Length -= ByteToRead;   //剩余字节数减少    
        //    }
        //    else
        //    {
        //        //客户端浏览器已经断开，阻止继续循环    
        //        Length = -1;
        //    }
        //}
        //关闭该文件    
       // Reader.Close();
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
