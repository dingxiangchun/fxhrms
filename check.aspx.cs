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
using System.Reflection;
using System.ComponentModel;

public partial class check : System.Web.UI.Page
{
    resumeinfoData resumedal = new resumeinfoData();
    rewardinfoData rewarddal = new rewardinfoData();
    workchange changedal = new workchange();
    int m_power = -1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Check())
            return;
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            CheckData();
            return;
        }
        else
        {
            VelocityHelper vh = new VelocityHelper();
            IList<tb_resumeinfo> resumelist = util.GetAll<tb_resumeinfo>(resumedal.GetListWithName("and mark=0"));
            IList<tb_rewardinfo> rewardlist = util.GetAll<tb_rewardinfo>(rewarddal.GetListWithName("and mark=0"));
            IList<tb_workchange> changelist = changedal.GetListAll("");
            vh.Init();
            vh.Put("work", changelist);
            vh.Put("reward", rewardlist);
            vh.Put("role", m_power);
            vh.Display("check.vm");
        }
    }

    public bool Check()
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

            if (m_power != 0 && m_power != 2)
            {
                VelocityHelper vh1 = new VelocityHelper();
                vh1.Init();
                vh1.Display("nopower.vm");
                return false;
            }
        }

        return true;
    }

    public bool CheckData()
    {
        if (!string.IsNullOrEmpty(Request["type"]))
        {
            string HRUserName = HttpUtility.UrlDecode(Request.Cookies["HRUserName"].Value);
            
            if (Request["type"] == "work")
            {
                string time = "";
                string employeeid="";
                IList<tb_workchange> changeList = changedal.GetListAll("t5.resumeid=" + Request["id"]);
                if (changeList.Count > 0)
                {
                    time = changeList[0].attacktime;
                    employeeid = changeList[0].Employeeid;
                }

                resumedal.UpdateMark(int.Parse(Request["mark"]),HRUserName, int.Parse(Request["id"]));
                if (int.Parse(Request["mark"]) == 1)
                {

                    changedal.ChangePerInfoUnit(int.Parse(Request["id"]));
                }

                IList<tb_resumeinfo> resulist = resumedal.GetListAll("tb_resumeinfo.employeeid='" + employeeid + "'");
                if (resulist.Count > 0)
                {
                    resumedal.Updatequittime(time, resulist[resulist.Count-2].id.ToString());
                }
                changedal.Delete("resumeid=" + Request["id"]);
            }
            else if (Request["type"] == "reward")
            {
                rewarddal.UpdateMark(int.Parse(Request["mark"]),HRUserName, int.Parse(Request["id"]));
            }
        }
        return true;
    }

}
