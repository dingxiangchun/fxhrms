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

                Add(Request["id"]);
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
            string branchid = string.IsNullOrEmpty(Request["branchid"]) ? "0" : Request["branchid"];
            string branchstr = "id=" + branchid;

            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_perInfo> list = dal.GetListAll("tb_perinfo.employeeid = " + Request["id"]);
            IList<tb_learninfo> learn = dalLearn.GetListAll("employeeid =" + Request["id"]);
            IList<tb_family> family = dalFamily.GetListAll("employeeid =" + Request["id"]);
            IList<tb_registerinfo> register = dalReg.GetListAll("employeeid =" + Request["id"]);
            IList<tb_rewardinfo> reward = dalReward.GetListAll("employeeid =" + Request["id"]);
            IList<tb_resumeinfo> work = dalWork.GetListAll("employeeid =" + Request["id"]);
            IList<tb_holidayrecords> holiday = dalHoliday.GetListAll("employeeid =" + Request["id"]);
            IList<tb_branch> branchList = dalBranch.GetListAll( branchstr );

            IList<tb_Reserve> Reservelist = new List<tb_Reserve>();
            if (list.Count > 0)
            {
                string[] Rlist = list[0].Reserve.Split(',');
                for(int i=0;i<Rlist.Length;i++)
                {
                    if (Rlist[i] != "" && Rlist[i] != null)
                    {
                        IList<tb_Reserve> perReservelisttemp = Reserve.GetListAll("id=" + Rlist[i]);
                        if (perReservelisttemp.Count > 0)
                            Reservelist.Add(perReservelisttemp[0]);
                    }
                }
            }

            vh.Put("perReserveList", Reservelist);
            vh.Put("list", list[0]);
            vh.Put("learn", learn);
            vh.Put("family", family);
            vh.Put("register", register);
            vh.Put("reward", reward);
            vh.Put("work", work);
            vh.Put("holiday", holiday);
            vh.Put("branch", branchList[0]);
            vh.Display("perinfo.vm");
        }
        
    }

    private void Add(string id)
    {
        try
        {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            string branchid = string.IsNullOrEmpty(Request["branchid"]) ? "0" : Request["branchid"];
            string branchstr = "id=" + branchid;

            IList<tb_branch> branchList = dalBranch.GetListAll(branchstr);
            if (id != "" && id != null)
            {

                IList<tb_perInfo> list = dal.GetListAll("tb_perinfo.employeeid =" + id);
                IList<tb_learninfo> learn = dalLearn.GetListAll("employeeid =" + id);
                IList<tb_family> family = dalFamily.GetListAll("employeeid =" + id);
                IList<tb_registerinfo> register = dalReg.GetListAll("employeeid =" + id);
                IList<tb_rewardinfo> reward = dalReward.GetListAll("employeeid =" + id);
                IList<tb_resumeinfo> work = dalWork.GetListAll("employeeid =" + id);
                IList<tb_holidayrecords> holiday = dalHoliday.GetListAll("employeeid =" + id);

                IList<tb_Reserve> perReservelist = new List<tb_Reserve>();
                if (list.Count > 0)
                {
                    string[] Rlist = null;
                    if ( list[0].Reserve != null )
                    {
                        Rlist = list[0].Reserve.Split(',');
                        for (int i = 0; i < Rlist.Length; i++)
                        {
                            if (Rlist[i] != "" && Rlist[i] != null)
                            {
                                IList<tb_Reserve> perReservelisttemp = Reserve.GetListAll("id=" + Rlist[i]);
                                if (perReservelisttemp.Count>0)
                                   perReservelist.Add(perReservelisttemp[0]);
                            }
                            
                        }
                    }

                    vh.Put("list", list[0]);
                   
                }

                vh.Put("perReserveList", perReservelist);
                vh.Put("learn", learn);
                vh.Put("family", family);
                vh.Put("register", register);
                vh.Put("reward", reward);
                vh.Put("work", work);
                vh.Put("holiday", holiday);
            }
           vh.Put("ReserveList", ReserveList);
           vh.Put("positionList", positionList);
           vh.Put("pertypeList", pertypeList);
           vh.Put("branch", branchList[0]);
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
            if (Request["id"] == null)
                return;

            int id = int.Parse(Request["id"].ToString());
            string type = Request["type"];
            if (Request["type"] == null || Request["type"] == "")
            {
                dal.Delete("tb_perinfo.id=" + id);
                dalFamily.Delete("employeeid="+id);
                dalReg.Delete("employeeid=" + id);
                dalLearn.Delete("employeeid="+id);
                dalHoliday.Delete("employeeid="+id);
                dalReward.Delete("employeeid="+id);
                dalWork.Delete("employeeid="+id);
            }
            else
            {
                if (Request["type"] == "study")
                {
                    dalLearn.Delete("id=" + id);
                }
                else if (Request["type"] == "family")
                {
                    dalFamily.Delete("id=" + id);
                }
                else if (Request["type"] == "register")
                {
                    dalReg.Delete("id=" + id);
                }
                else if (Request["type"] == "reward")
                {
                    dalReward.Delete("id=" + id);
                }
                else if (Request["type"] == "work")
                {
                    dalWork.Delete("id=" + id);
                }
                else if (Request["type"] == "holiday")
                {
                    dalHoliday.Delete("id=" + id);
                }
                Response.Write("{\"status\":true}");
                Response.End();
            }

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
                model.state = Request["state"];
                model.photo = Request["photo"];
                dal.Update(model);

        }
        catch (System.Threading.ThreadAbortException ex)
        {
        }
    }

    private void Save()
    {
        if (Request["type"] == "basic")
        {
            model.Name = Request["Name"];
            model.Beforename = Request["Beforename"];
            model.Employeeid = Request["Employeeid"];
            model.Sex = Request["Sex"];
            model.Nation = Request["Nation"];
            model.Birth = Request["Birth"];
            model.Idcard = Request["Idcard"];
            if (Request["UnitID"] == null || Request["UnitID"] == "")
                model.UnitID = 0;
            else
                model.UnitID = int.Parse(Request["UnitID"]);
            model.Unit = Request["Unit"];
            model.Position = Request["Position"];
            model.Rank = Request["Rank"];
            model.Level = int.Parse(Request["Level"].ToString());
            model.Status = Request["Status"];
            model.Statustime = Request["Statustime"];
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
            model.final_emajior = Request["final_emajior"];
            model.Address = Request["Address"];
            model.Reserve = Request["Reserve"];
            model.Guard = Request["Guard"];
            model.Ages = 0;
            model.state = Request["state"];
            model.employclass = Request["employclass"];
            model.Attrion = Request["Attrion"];
            model.BankcardID = Request["BankcardID"];
            model.remarks1 = Request["remarks1"];
            model.remarks2 = Request["remarks2"];
            if (Request.Files.Count > 0)
            {
                HttpFileCollection FileCollection = Request.Files;
                model.photo = SavePhoto(FileCollection[FileCollection.AllKeys[0]]);
            }

            if (Request["id"] == "")
            {
                if (dal.Exists(Request["Employeeid"]))
                {
                    Response.Write("{\"status\":false,\"errorMsg\":\"Employeeid Exist!\"}");
                    Response.End();
                    return;
                }
                dal.Add(model);
            }
            else
            {
                model.id = Convert.ToInt32(Request["id"]);
                dal.Update(model);
            }
            
            string strwhere = "Employeeid='"+Request["Employeeid"]+"'";
            IList<tb_perInfo> list = dal.GetListAll(strwhere);
            if (list.Count > 0)
            {
                Add(list[0].id.ToString());
            }
            else
            {
                Add("");
            }
        }
        else if (Request["type"] == "study")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
           // string[] list = Request.Form.GetValues("employeeid[]");
            string[] degreelist = Request.Form.GetValues("degree[]");
            string[] starttimelist = Request.Form.GetValues("starttime[]");
            string[] graduatetimelist = Request.Form.GetValues("graduatetime[]");
            string[] graduateschlist = Request.Form.GetValues("graduatesch[]");
            string[] retencelist = Request.Form.GetValues("retence[]");
            string[] professionlist = Request.Form.GetValues("profession[]");
            string[] contentlist = Request.Form.GetValues("content[]");

            for (int i = 0; i < idlist.Length; i++)
            {
                modelLearn.employeeid = employeeid;

                modelLearn.degree = degreelist[i];
                modelLearn.starttime = starttimelist[i];
                modelLearn.graduatetime = graduatetimelist[i];
                modelLearn.graduatesch = graduateschlist[i];
                modelLearn.retence = retencelist[i];
                modelLearn.profession = professionlist[i];
                modelLearn.content = contentlist[i];
                if (idlist[i] == "")
                {
                    dalLearn.Add(modelLearn);
                }
                else
                {
                    modelLearn.id = int.Parse(idlist[i]);
                    dalLearn.Update(modelLearn);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#study", false);
           // Add(employeeid);
        }
        else if (Request["type"] == "family")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
            //string[] employeeidlist = Request.Form.GetValues("employeeid[]");
            string[] namelist = Request.Form.GetValues("name[]");
            string[] relationlist = Request.Form.GetValues("relation[]");
            string[] birthlist = Request.Form.GetValues("birth[]");
            string[] tellist = Request.Form.GetValues("tel[]");
            string[] unitlist = Request.Form.GetValues("unit[]");
            string[] statuslist = Request.Form.GetValues("status[]");
            string[] situationlist = Request.Form.GetValues("situation[]");
            string[] remarklist = Request.Form.GetValues("remark[]");

            for (int i = 0; i < idlist.Length; i++)
            {
                modelFamily.employeeid = employeeid;
                modelFamily.name = namelist[i];
                modelFamily.relation = relationlist[i];
                modelFamily.birth = birthlist[i];
                modelFamily.tel = tellist[i];
                modelFamily.unit = unitlist[i];
                modelFamily.status = statuslist[i];
                modelFamily.situation = situationlist[i];
                modelFamily.remark = remarklist[i];
                if (idlist[i] == "")
                {
                    dalFamily.Add(modelFamily);
                }
                else
                {
                    modelFamily.id = int.Parse(idlist[i]);
                    dalFamily.Update(modelFamily);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#family", false);
           // Add(employeeid);
        }
        else if (Request["type"] == "register")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
            string[] employeeidlist = Request.Form.GetValues("employeeid[]");
            string[] typelist = Request.Form.GetValues("type[]");
            string[] cer_namelist = Request.Form.GetValues("cer_name[]");
            string[] accesstimelist = Request.Form.GetValues("accesstime[]");
            string[] issuingtimelist = Request.Form.GetValues("issuingtime[]");
            string[] unitlist = Request.Form.GetValues("unit[]");
            string[] Classlist = Request.Form.GetValues("Class[]");
            //string[] photolist = Request.Form.GetValues("photo[]");
            string[] descriptionlist = Request.Form.GetValues("description[]");
            HttpFileCollection FileColl = Request.Files;

            for (int i = 0; i < idlist.Length; i++)
            {
                modelReg.employeeid = employeeid;
                modelReg.type = typelist[i];
                modelReg.cer_name = cer_namelist[i];
                modelReg.accesstime = accesstimelist[i];
                modelReg.issuingtime = issuingtimelist[i];
                modelReg.unit = unitlist[i];
                modelReg.Class = Classlist[i];
                modelReg.photo = SavePhoto(FileColl[i]);

                modelReg.description = descriptionlist[i];
                if (idlist[i] == "")
                {
                    dalReg.Add(modelReg);
                }
                else
                {
                    modelReg.id = int.Parse(idlist[i].ToString());
                    dalReg.Update(modelReg);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#register", false);
           // Add(employeeid);
        }
        else if (Request["type"] == "reward")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
            string[] employeeidlist = Request.Form.GetValues("employeeid[]");
            string[] typelist = Request.Form.GetValues("type[]");
            string[] timelist = Request.Form.GetValues("time[]");
            string[] contentlist = Request.Form.GetValues("content[]");
            string[] departmentlist = Request.Form.GetValues("department[]");
            string[] auditlist = Request.Form.GetValues("audit[]");
            string[] Classlist = Request.Form.GetValues("Class[]");
            string[] unitlist = Request.Form.GetValues("unit[]");
            string[] descriptionlist = Request.Form.GetValues("description[]");
            //string[] Filelist = Request.Form.GetValues("File[]");
            HttpFileCollection FileColl = Request.Files;

            for (int i = 0; i < idlist.Length; i++)
            {
                modelReward.employeeid = employeeid;
                modelReward.type = typelist[i];
                modelReward.time = timelist[i];
                modelReward.content = contentlist[i];
                modelReward.department = departmentlist[i];
                modelReward.audit = auditlist[i];
                modelReward.Class = Classlist[i];
                modelReward.unit = unitlist[i];
                modelReward.description = descriptionlist[i];
                modelReward.File = SavePhoto(FileColl[i]);
                if (idlist[i] == "")
                {
                    dalReward.Add(modelReward);
                }
                else
                {
                    modelReward.id = int.Parse(idlist[i].ToString());
                    dalReward.Update(modelReward);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#reward", false);
            //Add(employeeid);
        }
        else if (Request["type"] == "work")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
            string[] employeeidlist = Request.Form.GetValues("employeeid[]");
            string[] attacktimelist = Request.Form.GetValues("attacktime[]");
            string[] quittimelist = Request.Form.GetValues("quittime[]");
            string[] positionlist = Request.Form.GetValues("position[]");
            string[] unitlist = Request.Form.GetValues("unit[]");
            string[] reasonlist = Request.Form.GetValues("reason[]");
            string[] contentlist = Request.Form.GetValues("content[]");
            for (int i = 0; i < idlist.Length; i++)
            {
                modelWork.employeeid = employeeid;

                modelWork.attacktime = attacktimelist[i];
                modelWork.quittime = quittimelist[i];
                modelWork.position = positionlist[i];
                modelWork.unit = unitlist[i];
                modelWork.reason = reasonlist[i];
                modelWork.content = contentlist[i];

                if (idlist[i] == "")
                {
                    dalWork.Add(modelWork);
                }
                else
                {
                    modelWork.id = int.Parse(idlist[i].ToString());
                    dalWork.Update(modelWork);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#work", false);
            //Add(employeeid);
        }
        else if (Request["type"] == "holiday")
        {
            string employeeid = Request["id"];
            string[] idlist = Request.Form.GetValues("iid[]");
            string[] employeeidlist = Request.Form.GetValues("employeeid[]");
            string[] holidaylist = Request.Form.GetValues("holiday[]");
            string[] dayslist = Request.Form.GetValues("days[]");
            string[] reasonlist = Request.Form.GetValues("reason[]");
            string[] auditlist = Request.Form.GetValues("audit[]");
            string[] begintimelist = Request.Form.GetValues("begintime[]");
            string[] Endtimelist = Request.Form.GetValues("Endtime[]");
            string[] days1list = Request.Form.GetValues("days1[]");
            string[] remarklist = Request.Form.GetValues("remark[]");

            for (int i = 0; i < idlist.Length; i++)
            {
                modelHoliday.employeeid = employeeid;
                modelHoliday.holiday = holidaylist[i];
                if (dayslist[i] == "")
                {
                    modelHoliday.days = 0;
                }
                else
                {
                    modelHoliday.days = int.Parse(dayslist[i]);
                }

                modelHoliday.reason = reasonlist[i];
                modelHoliday.audit = auditlist[i];
                modelHoliday.begintime = begintimelist[i];
                modelHoliday.Endtime = Endtimelist[i];
                if (days1list[i] == "")
                {
                    modelHoliday.days1 = 0;
                }
                else
                {
                    modelHoliday.days1 = int.Parse(days1list[i]);
                }

                modelHoliday.remark = remarklist[i];
                if (idlist[i] == "")
                {
                    dalHoliday.Add(modelHoliday);
                }
                else
                {
                    modelHoliday.id = int.Parse(idlist[i].ToString());
                    dalHoliday.Update(modelHoliday);
                }
            }
            Response.Redirect("perinfo.aspx?action=add&id=" + employeeid + "#holiday", false);
           // Add(employeeid);
        }
    }

    private string SavePhoto(HttpPostedFile PhotoFile)
    {
        string webUrl = "";
        try
        {
            if (PhotoFile != null&&PhotoFile.ContentLength>0)
            {
                DateTime now = DateTime.Now;
                string filename = now.ToFileTimeUtc().ToString()+System.IO.Path.GetExtension(PhotoFile.FileName);
                string strpath = System.Web.HttpContext.Current.Server.MapPath("./") + "Photo\\" + filename;
                webUrl = "/Photo/" + filename;
                PhotoFile.SaveAs(strpath);
                //HttpFileCollection photodata = Request.Files;
                //for (int i = 0; i < photodata.Count; i++)
                //{
                //    photodata[photodata.AllKeys[i]].SaveAs(strpath);
                //}
            }
        }
        catch (System.Threading.ThreadAbortException ex)
        {}

        return webUrl;
    }
   
}
