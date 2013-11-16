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
      
       if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "del") {
              //  Del();
            }
            if (Request["action"] == "add")
            {
              //  Add();
            }
            if (Request["action"] == "update")
            {
              //  Update();
            }

        }else{
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_Reserve> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Display("addBranch.vm");
        }
    }
}