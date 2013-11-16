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
            VelocityHelper vh = new VelocityHelper();
            vh.Init();
            IList<tb_branch> list = dal.GetListAll("");
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
            model.id = int.Parse(Request["id"].ToString());
            model.branchName = Request["branchName"];
            model.branchInfo = Request["branchInfo"];
            model.branchNum = Request["branchNum"];
            model.parentid = int.Parse(Request["parentid"].ToString());
            dal.Add(model);
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
            model.id = int.Parse(Request["id"].ToString());
            model.branchName = Request["branchName"];
            model.branchInfo = Request["branchInfo"];
            model.branchNum = Request["branchNum"];
            model.parentid = int.Parse(Request["parentid"].ToString());
            dal.Update(model);
            Response.Write("{\"status\":true}");
            Response.End();
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

            if (Request["id"] == null)
            {
                vh.Put("current", null);
            }
            else
            {
                IList<tb_branch> dept = dal.GetListAll(" id="+Request["id"]);
                vh.Put("current", dept);
            }
           
            IList<tb_branch> list = dal.GetListAll("");
            vh.Put("list", list);
            vh.Display("layout/nav.vm");
            //Response.End();
        }
        catch (System.Threading.ThreadAbortException ex)
        {
        } 
    }

    public void dataBind()
    {
        GridView1.DataSource = dal.GetList("");
        GridView1.DataKeyNames = new string[] { "id" };
        GridView1.DataBind();
    }
    protected void bt_add_Click(object sender, EventArgs e)
    {
        if (tb_branch.Text != "")
        {
            model.branchName = tb_branch.Text.Trim();
            model.branchNum = tb_branch_num.Text.Trim();
            model.branchInfo = tb_branch_info.Text.Trim();
            dal.Add(model);
            tb_branch.Text = "";
            tb_branch_info.Text = "";
            tb_branch_num.Text = "";
            dataBind();
        }
    }
    protected void cb_all_CheckedChanged(object sender, EventArgs e)
    {

        if (cb_all.Checked)
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                cb.Checked = true;
            }
        }
        else
        {
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox cb = (CheckBox)GridView1.Rows[i].FindControl("CheckBox1");
                cb.Checked = false;
            }
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        dataBind();
    }
}
