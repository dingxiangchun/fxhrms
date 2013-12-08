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
    int m_power = -1;
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
            vh.Put("role", m_power);
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
            string msg="添加成功";
            do{
                if (string.IsNullOrEmpty(Request["ReserveType"]))
                {
                    msg = "后备人才类型不能为空！";
                    break;
                }
                model.ReserveType = Request["ReserveType"];
                dal.Add(model);
            }while(false);

            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", msg);
            vh.Put("role", m_power);
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
            string msg="修改成功";
            do {
                if (string.IsNullOrEmpty(Request["ReserveType"]))
                {
                    msg = "后备人才类型不能为空！";
                    break;
                }
                model.id = int.Parse(Request["id"].ToString());
                model.ReserveType = Request["ReserveType"];
                dal.Update(model);
            } while (false);

            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Put("msg", msg);
            vh.Put("role", m_power);
            vh.Display("reserve.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
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


            if (m_power != 0)
            {
                VelocityHelper vh1 = new VelocityHelper();
                vh1.Init();
                vh1.Display("nopower.vm");
                return false;
            }
        }

        return true;
    }

}