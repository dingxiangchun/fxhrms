using System;
using System.Web;
using System.IO;
using NVelocity;
using NVelocity.App;
using NVelocity.Context;
using NVelocity.Runtime;
using Commons.Collections;

/// 
/// NVelocity模板工具类 VelocityHelper
/// 
public class VelocityHelper
{
    private VelocityEngine velocity = null;
    private IContext context = null;
    /// 
    /// 构造函数
    /// 
    ///
    //模板文件夹路径
    public VelocityHelper(string templatDir)
    {
        Init(templatDir);
    }
    /// 
    /// 无参数构造函数
    /// 
    public VelocityHelper() { ;}
    /// 
    /// 初始话NVelocity模块
    /// 
    ///
    //模板文件夹路径
    public void Init(string templatDir = @"vm")
    {
        //创建VelocityEngine实例对象
        velocity = new VelocityEngine();
        //使用设置初始化VelocityEngine
        ExtendedProperties props = new ExtendedProperties();
        props.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");
        props.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH, HttpContext.Current.Server.MapPath(templatDir));
        props.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");
        props.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "utf-8");
        velocity.Init(props);
        //为模板变量赋值
        context = new VelocityContext();
    }
    /// 
    /// 给模板变量赋值
    /// 
    ///
    //模板变量
    ///
    //模板变量值
    public void Put(string key, object value)
    {
        if (context == null)
            context = new VelocityContext();
        context.Put(key, value);
    }
    /// 
    /// 显示模板
    /// 
    ///
    //模板文件名
    public void Display(string templatFileName)
    {
        //从文件中读取模板
        Template template = velocity.GetTemplate(templatFileName);
        //合并模板
        StringWriter writer = new StringWriter();
        template.Merge(context, writer);
        //输出
        HttpContext.Current.Response.Clear();
        HttpContext.Current.Response.Write(writer.ToString());
        HttpContext.Current.Response.Flush();
        HttpContext.Current.Response.End();
    }
}