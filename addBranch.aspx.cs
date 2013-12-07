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

public partial class addBranch : System.Web.UI.Page
{
    branch dal = new branch();
    tb_branch model = new tb_branch();
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
            if (Request["action"] == "tree")
            {
                Tree();
            }
        }else{
            string strwhere = "";
            if (Request["branchid"] != null)
            {
                strwhere = "parentid=" + Request["branchid"];
            }
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dal.GetListAll(strwhere);
            vh.Put("list", list);
            vh.Display("addBranch.vm");
        }
    }
    
    //删除
    private void Del() {
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

    private void Add() {
        try
        {
            int parentid = int.Parse(Request["parentid"].ToString());
            model.branchName = Request["branchName"];
            model.tel = Request["tel"];
            model.person = Request["person"];
            model.branchInfo = Request["branchInfo"];
            model.branchNum = Request["branchNum"];
            model.parentid = parentid;
            dal.Add(model);
            string strwhere = "";
            if ( parentid > 0 )
            {
                strwhere = "parentid=" + parentid;
            }
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dal.GetListAll(strwhere);
            vh.Put("list", list);
            vh.Put("msg","添加部门成功");
            vh.Display("addBranch.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        } 
    }

    private void Update()
    {
        try
        {
            int parentid = int.Parse(Request["parentid"].ToString());
            model.id = int.Parse(Request["id"].ToString());
            model.branchName = Request["branchName"];
            model.branchInfo = Request["branchInfo"];
            model.branchNum = Request["branchNum"];
            model.tel = Request["tel"];
            model.person = Request["person"];
            dal.Update(model);
            string strwhere = "";
            if (parentid > 0)
            {
                strwhere = "parentid=" + parentid;
            }
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dal.GetListAll(strwhere);
            vh.Put("list", list);
            vh.Put("msg", "修改部门成功");
            vh.Display("addBranch.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        } 
    }

    private void Tree()
    {
        try
        {
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Display("layout/nav.vm");
        }
        catch (System.Threading.ThreadAbortException ex)
        {
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
            if (!hrhelper.IsUserExist(loginname, hrid))
            {
                Response.Redirect("login.aspx");
                return false;
            }
        }

        return true;
    }

}
