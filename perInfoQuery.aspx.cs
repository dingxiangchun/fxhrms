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

public partial class perInfoQuery : System.Web.UI.Page
{
    branch dal = new branch();
    tb_branch model = new tb_branch();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        VelocityHelper vh = new VelocityHelper();
        vh.Init();
        vh.Display("query.vm");
    }
}
