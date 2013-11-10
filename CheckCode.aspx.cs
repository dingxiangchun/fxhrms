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
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Text;

public partial class CheckCode : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.CreateCheckCodeImage(CreateCheckCodeString());
    }

    /// <summary>
    /// 生成验证码字符串
    /// </summary>
    /// <returns></returns>
    private string CreateCheckCodeString()
    {
        //定义用于验证码的字符数组
        char[] allCharArray ={ '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        //定义验证码字符串
        string randomCode = "";
        Random rand = new Random();
        //生成4位验证码字符串
        for (int i = 0; i < 4; i++)
        {
            randomCode += allCharArray[rand.Next(allCharArray.Length)];
        }
        
        //Cookie传值:参数1为Cookie的名称，第二个为Cookie的值
        HttpCookie cookie = new HttpCookie("CheckCode", randomCode);
        Response.Cookies.Add(cookie);
        cookie.Expires = DateTime.Now.AddSeconds(60);//该Cookie60秒后过期
        return randomCode;
    }
    /// <summary>
    /// 生成验证码图片
    /// </summary>
    /// <param name="sFilePath"></param>
    public void CreateCheckCodeImage(string checkCode)
    {
        //定义图片的宽高度
        int iWidth = 58;
        int iHeight = 22;

        //定义大小为12pt的Arial加粗字体，用于绘制文字
        Font font = new Font("Arial", 12, FontStyle.Bold);

        
        StringFormat stringFormat = new StringFormat();
        stringFormat.Alignment = StringAlignment.Center;
        stringFormat.LineAlignment = StringAlignment.Center;

        //定义黑色的单色画笔，用于绘制文字
        SolidBrush brush = new SolidBrush(Color.Black);

        //定义钢笔，用于绘制干扰线
        Pen pen1 = new Pen(Color.Gray, 0);//注意这里直接获得了一个现有的Color对象
        Pen pen2 = new Pen(Color.FromArgb(255, 100, 100, 100), 0);//这里是根据RGB的值获得一个Color对象

        //创建一个px*20px的图像
        Bitmap image = new Bitmap(iWidth, iHeight);

        //从图象获取一个绘图面
        Graphics g = Graphics.FromImage(image);

        //消除整个绘图画面并以指定颜色填充
        g.Clear(ColorTranslator.FromHtml("#FFF"));//注意这里从HTML颜色代码获得了Color对象

        //定义文字的绘制矩形区域
        //RectangleF rect = new RectangleF(5, 2, iWidth, iHeight);
        RectangleF rect = new RectangleF(0, 2, iWidth, iHeight);

        //定义一个随机数对象，用于绘制干扰线
        Random rand = new Random();

        ////生成两条横向的干扰线
        //for (int i = 0; i < 2; i++)
        //{
        //    //定义起点
        //    Point p1 = new Point(0, rand.Next(iHeight));
        //    //定义终点
        //    Point p2 = new Point(iWidth, rand.Next(iHeight));
        //    //绘制直线
        //    g.DrawLine(pen1, p1, p2);
        //}
        ////生成4条纵向的干扰线
        //for (int i = 0; i < 4; i++)
        //{
        //    //定义起点
        //    Point p1 = new Point(rand.Next(iWidth), 0);
        //    //定义终点
        //    Point p2 = new Point(rand.Next(iWidth), iHeight);
        //    //绘制直线
        //    g.DrawLine(pen2, p1, p2);
        //}
        //绘制验证码文，参数：验证码字符串，字体大小样式，黑色的单色画笔，文字的矩形区域
        g.DrawString(checkCode, font, brush, rect,stringFormat);
        System.IO.MemoryStream ms = new System.IO.MemoryStream();//创建存储区为内存流
        //保存图片为Jpge格式
        image.Save(ms, ImageFormat.Jpeg);
        Response.ClearContent();//清除缓冲区中的内容
        Response.ContentType = "image/Jpeg";
        Response.BinaryWrite(ms.ToArray());
        //释放对象
        g.Dispose();
        image.Dispose();
    }
}
