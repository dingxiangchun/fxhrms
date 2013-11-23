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

    ReserveData Reserve = new ReserveData();
    tb_Reserve modelReserve = new tb_Reserve();

    positioninfoData Positon = new positioninfoData();
    tb_positioninfo modelPosition = new tb_positioninfo();

    pertypeinfoData perTypeinfo = new pertypeinfoData();
    tb_pertypeinfo modelpertype = new tb_pertypeinfo();

    IList<tb_Reserve> ReserveList;
    IList<tb_positioninfo> positionList;
    IList<tb_pertypeinfo> pertypeList;
    public perinfo()
    {
        ReserveList = Reserve.GetListAll("");
        positionList = Positon.GetListAll("");
        pertypeList = perTypeinfo.GetListAll("");
    }


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
            if (Request["action"] == "save")
            {
                Save();
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

            IList<String> Reservelist=null;
            if (list.Count > 0)
            {
                string[] Rlist = list[0].Reserve.Split(',');
                for(int i=0;i<Rlist.Length;i++)
                {
                    Reservelist.Add(Rlist[i]);
                }
            }

            vh.Put("ReserveList", Reservelist);
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
            vh.Put("ReserveList", ReserveList);
            vh.Put("positionList", positionList);
            vh.Put("pertypeList", pertypeList);
            vh.Display("addper.vm");


        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }

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

    private void Update()
    {
        try
        {
            model.id =int.Parse(Request["id"].ToString());
            model.Name = Request["Name"];
            model.Employeeid = Request["Employeeid"];
            model.Sex = Request["Sex"];
            model.Nation = Request["Nation"];
            model.Birth = Request["Birth"];
            model.Idcard = Request["Idcard"];
            model.UnitID = int.Parse(Request["UnitID"].ToString());
            model.Unit = Request["Unit"];
            model.Position = Request["Position"];
            model.Rank = Request["Rank"];
            model.Level = int.Parse(Request["Level"].ToString());
            model.Status = Request["Status"];
            model.Jobtime = Request["Jobtime"];
            model.financetime = Request["financetime"];
            model.fulltime_educ = Request["fulltime_educ"];
            model.fulltime_sch = Request["fulltime_sch"];
            model.Major = Request["Major"];
            model.Married = Request["Married"];
            model.Town = Request["Town"];
            model.Tel = Request["Tel"];
            model.final_edu = Request["final_edu"];
            model.final_sch = Request["final_sch"];
            model.Address = Request["Address"];
            model.Reserve = Request["Reserve"];
            model.Guard = Request["Guard"];
            model.Ages = 0;
            model.Class = Request["Class"];
            model.photo = Request["photo"];
            dal.Update(model);
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }

    private void Save()
    {
        model.Name = Request["Name"];
        model.Employeeid = Request["Employeeid"];
        model.Sex = Request["Sex"];
        model.Nation = Request["Nation"];
        model.Birth = Request["Birth"];
        model.Idcard = Request["Idcard"];
        model.UnitID = int.Parse(Request["UnitID"].ToString());
        model.Unit = Request["Unit"];
        model.Position = Request["Position"];
        model.Rank = Request["Rank"];
        model.Level = int.Parse(Request["Level"].ToString());
        model.Status = Request["Status"];
        model.Jobtime = Request["Jobtime"];
        model.financetime = Request["financetime"];
        model.fulltime_educ = Request["fulltime_educ"];
        model.fulltime_sch = Request["fulltime_sch"];
        model.Major = Request["Major"];
        model.Married = Request["Married"];
        model.Town = Request["Town"];
        model.Tel = Request["Tel"];
        model.final_edu = Request["final_edu"];
        model.final_sch = Request["final_sch"];
        model.Address = Request["Address"];
        model.Reserve = Request["Reserve"];
        model.Guard = Request["Guard"];
        model.Ages = 0;
        model.Class = Request["Class"];
        model.photo = Request["photo"];
        dal.Add(model);

        Add();
    }
   
}
