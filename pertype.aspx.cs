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
using DAL;
using Models;

public partial class pertype : System.Web.UI.Page
{
    pertypeinfoData dal = new pertypeinfoData();
    tb_pertypeinfo model = new tb_pertypeinfo();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "del")
            {
                Del();
            }
            if (Request["action"] == "add")
            {
                Add();
            }
            if (Request["action"] == "update")
            {
                Update();
            }

        }
        else
        {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_pertypeinfo> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Display("pertype.vm");
        }
    }

    //删除
    private void Del()
    {
        try
        {
            int id = int.Parse(Request["id"].ToString());
            dal.Delete(id);
            Response.Write("{\"status\":true}");
            Response.End();
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }
    private void Add()
    {
        try
        {
            model.name = Request["name"];
            model.info = Request["info"];
            dal.Add(model);
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_pertypeinfo> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", "添加成功");
            vh.Display("pertype.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }
    private void Update()
    {
        try
        {
            model.id = int.Parse(Request["id"].ToString());
            model.name = Request["name"];
            model.info = Request["info"];
            dal.Update(model);
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_pertypeinfo> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", "修改成功");
            vh.Display("pertype.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }

}
