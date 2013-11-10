<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ClearData.aspx.cs" Inherits="ClearData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <LINK href="Images/index/YHChannelApply.files/Style.css" type=text/css rel=stylesheet />
    <LINK href="Images/index/YHChannelApply.files/Manage.css" type=text/css rel=stylesheet />
    <style type="text/css">
        .tdclass
        {
             text-align:right;
        }
        .manageHead1 {
	BORDER-RIGHT: #cccccc 1px solid; BORDER-TOP: #cccccc 1px solid; BORDER-LEFT: #cccccc 1px solid; COLOR: #000000; BORDER-BOTTOM: #cccccc 1px solid; 
}
    </style>
    
</head>
<body>

    <form id="form1" runat="server">
    <div>
    
        <TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
              <TBODY>
              <TR>
                <TD width=15><IMG src="Images/index/YHChannelApply.files/new_019.jpg" border=0 /></TD>
                <TD width="100%" background=Images/index/YHChannelApply.files/new_020.jpg height=20></TD>
                <TD width=15><IMG src="Images/index/YHChannelApply.files/new_021.jpg" border=0 /></TD>
              </TR>
              </TBODY>
         </TABLE>

         <TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
            <TBODY>
                <TR>
                    <TD width=15 background=Images/index/YHChannelApply.files/new_022.jpg>
                        <IMG src="Images/index/YHChannelApply.files/new_022.jpg" border=0 /> 
                    </TD>
                    <TD vAlign=top width="100%" bgColor=#ffffff>
                        <TABLE cellSpacing=0 cellPadding=5 width="100%" border=0>
                            <TR>
                                <TD class=manageHead>当前位置：管理首页 &gt; 管理中心 &gt; 
                                    <asp:Label ID="lb_url" runat="server" Text="Label"></asp:Label></TD>
                            </TR>
                            <TR>    
                                <TD height=2>
                                    </TD>
                            </TR>
                        </TABLE>
                        
                        
                        <TABLE borderColor=#cccccc cellSpacing=0 cellPadding=0 width="100%" align=center border=0>
                            <TBODY>
                                <TR>
                                    <TD>
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                            <TBODY>
                                                <tr>
                                                        <TD class=manageHead1>
                                                    <TABLE width="100%" border=0>
                                                    <tr>

                                                        <TD>

                                                            
                                                            清空数据表记录:
                                                            
                                                            <asp:Panel ID="Panel1" runat="server" Width="500px">
                                                                    <br />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="部门信息" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox2" runat="server" Text="民族类别" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox3" runat="server" Text="职务类别" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox4" runat="server" Text="职称类别" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox5" runat="server" Text="员工信息表" />
                                                            
                                                                <br /><br />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox6" runat="server" Text="用户信息" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox7" runat="server" Text="家庭成员" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox8" runat="server" Text="工作简历" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox9" runat="server" Text="日常记事" />
                                                            &nbsp;&nbsp;<asp:CheckBox ID="CheckBox10" runat="server" Text="通讯信息表" />
                                                            <br /><br />
                                                            
                                                            </asp:Panel>
                                                            
                                                        </TD>
                                                        
                                                    </tr>
                                                    
                                                    <TR>
                                                        <TD>
                                                            &nbsp;<asp:Button ID="bt_del" CssClass="button" runat="server" Text="清空" Width="60px" OnClick="bt_del_Click" />&nbsp;
         <asp:Button ID="bt_back" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_back_Click" />
                                        <asp:CheckBox ID="cb_all" runat="server" Text="全选&nbsp;&nbsp;&nbsp;" OnCheckedChanged="cb_all_CheckedChanged" AutoPostBack="True" />&nbsp;
                                                           &nbsp;&nbsp;&nbsp;&nbsp;
                                                        </TD>
                                                    </TR>
                                                        </TABLE>
                                                        </TD>
                                                </tr>
                                            </TBODY>
                                        </TABLE>
                                    </TD>
                                </TR>
                            </TBODY>
                        </TABLE>
                        
                        </td>
                        
                    <TD width=15 background=Images/index/YHChannelApply.files/new_023.jpg>
                        <IMG src="Images/index/YHChannelApply.files/new_023.jpg" border=0 /> 
                    </TD>
                    </tr>
                    </TBODY>
                    </TABLE>
               
         
         
         <TABLE cellSpacing=0 cellPadding=0 width="98%" border=0>
            <TBODY>
              <TR>
                <TD width=15 style="height: 15px"><IMG src="Images/index/YHChannelApply.files/new_024.jpg" border=0 /></TD>
                <TD align="center" width="100%" background=Images/index/YHChannelApply.files/new_025.jpg style="height: 15px"></TD>
                <TD width=15 style="height: 15px"><IMG src="Images/index/YHChannelApply.files/new_026.jpg" border=0 /></TD>
              </TR>
            </TBODY>
         </TABLE>
         
    </div>
    </form>
</body>
</html>