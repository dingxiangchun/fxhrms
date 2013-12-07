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
public partial class Reserve : System.Web.UI.Page
{
    ReserveData dal = new ReserveData();
    tb_Reserve model = new tb_Reserve();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Check())
            return;
       if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "del") {
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

        }else{
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Display("reserve.vm");
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
            model.ReserveType = Request["ReserveType"];
            dal.Add(model);
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", "添加成功");
            vh.Display("reserve.vm");
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
            model.ReserveType = Request["ReserveType"];
            dal.Update(model);
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", "修改成功");
            vh.Display("reserve.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }

    public bool  Check()
    {
        HRHelper hrhelper = new HRHelper();
        if (Response.Cookies["HRLoginName"] == null || Response.Cookies["HRId"] == null)
        {
            Response.Write("请重新登录！");
            return false;
        }
        else
        {
            if (!hrhelper.IsUserExist(Request.Cookies["HRLoginName"].Value, Request.Cookies["HRId"].Value))
            {
                Response.Write("请重新登录！");
                return false;
            }
        }

        return true;
    }

}