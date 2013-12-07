using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using Models;
/// <summary>
///HRHelper 的摘要说明
/// </summary>
public class HRHelper
{
    users dal = new users();
    tb_Users model = new tb_Users();
	public HRHelper()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    public bool IsUserExist(string LoginName, string UserId)
    {
        if (string.IsNullOrEmpty(UserId))
            UserId = "-1";
        string strwhere = "loginname='" + LoginName + "' and id=" + UserId;
        IList<tb_Users> Userlist = dal.GetListAll(strwhere);
        if (Userlist.Count > 0)
            return true;
        else
            return false;
    }
}