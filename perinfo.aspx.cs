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

public partial class perinfo : System.Web.UI.Page
{
    perInfo dal = new perInfo();
    tb_perInfo model = new tb_perInfo();

    learninfo dalLearn = new learninfo();
    tb_learninfo modelLearn = new tb_learninfo();

    family dalFamily = new family();
    tb_family modelFamily = new tb_family();

    registerinfoData dalReg = new registerinfoData();
    tb_registerinfo modelReg = new tb_registerinfo();

    rewardinfoData dalReward = new rewardinfoData();
    tb_rewardinfo modelReward = new tb_rewardinfo();

    resumeinfoData dalWork = new resumeinfoData();
    tb_resumeinfo modelWork = new tb_resumeinfo();

    holidayrecordsData dalHoliday = new holidayrecordsData();
    tb_holidayrecords modelHoliday = new tb_holidayrecords();

    branch dalBranch = new branch();
    tb_branch modelBranch = new tb_branch();


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request["action"]))
        {
            if (Request["action"] == "del")
            {
                //Del();
            }
            if (Request["action"] == "add")
            {
                Add();
            }
            if (Request["action"] == "update")
            {
                //Update();
            }

        }
        else
        {
            string strwhere = "id=" + Request["id"];

            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_perInfo> list = dal.GetListAll(strwhere);
            IList<tb_learninfo> learn = dalLearn.GetListAll("employee" + strwhere);
            IList<tb_family> family = dalFamily.GetListAll("employee" + strwhere);
            IList<tb_registerinfo> register = dalReg.GetListAll("employee" + strwhere);
            IList<tb_rewardinfo> reward = dalReward.GetListAll("employee" + strwhere);
            IList<tb_resumeinfo> work = dalWork.GetListAll("employee" + strwhere);
            IList<tb_holidayrecords> holiday = dalHoliday.GetListAll("employee" + strwhere);
            vh.Put("list", list);
            vh.Put("learn", learn);
            vh.Put("family", family);
            vh.Put("register", register);
            vh.Put("reward", reward);
            vh.Put("work", work);
            vh.Put("holiday", holiday);
            vh.Display("perinfo.vm");
        }
        
    }

    private void Add()
    {
        try
        {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            vh.Display("addper.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }
   
}
