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
using System.IO;
using DAL;
using Models;

public partial class perInfoCount : System.Web.UI.Page
{
    tb_Count DalCount = new tb_Count();

    protected void Page_Load(object sender, EventArgs e)
    {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            vh.Display("count.vm");
    }
    

}
