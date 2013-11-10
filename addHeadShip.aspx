<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addHeadShip.aspx.cs" Inherits="addHeadShip" %>

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
                                                    <TABLE width="100%" border=0  style="height: 247px">
                                                    <tr>
                                                    <td class=manageHead1>
                                                        <asp:GridView ID="GridView1" runat="server" Width="100%" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" Height="237px" AutoGenerateColumns="False" DataKeyNames="hid">
                                                            <HeaderStyle BackColor="#F0F0F0" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                                                                Font-Bold="True" Font-Names="Arial" Font-Size="12px" HorizontalAlign="Left" />
                                                                <PagerTemplate>
                                                 <br />
                                                 <asp:Label ID="lblPage" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
                                                 <asp:LinkButton ID="lbnFirst" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnPrev" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnNext" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnLast" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
                                                 <br />
                                             </PagerTemplate>
                                                            <Columns>
                                                                <asp:TemplateField HeaderText="职务">
                                                                    <ItemTemplate>
                                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                                            <tr>
                                                                                <td>
                                                                                    <asp:Label runat="server" ID="Label1" Text='<%# Eval("hName") %>'></asp:Label>
                                                                                </td>
                                                                            </tr>
                                                                        </table>
                                                                    </ItemTemplate>
                                                                </asp:TemplateField>
                                                                <asp:TemplateField HeaderText="操作">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:CheckBox ID="CheckBox1" runat="server" />
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                            </Columns>
                                                        </asp:GridView>
                                                    
                                                    </td>
                                                    </tr>
                                                    <TR>
                                    <TD align=right style="height: 25px">
                                        请输入职务名称:
                                        <asp:TextBox ID="tb_headship" runat="server"></asp:TextBox>&nbsp;
                                        <asp:Button ID="bt_add" CssClass="button" runat="server" Text="添加" Width="60px" OnClick="bt_add_Click" />&nbsp;
          
                                        <asp:Button ID="bt_del" CssClass="button" runat="server" Text="删除" Width="60px" OnClick="bt_del_Click" />&nbsp;
                                        <asp:CheckBox ID="cb_all" runat="server" Text="全选&nbsp;&nbsp;&nbsp;" OnCheckedChanged="cb_all_CheckedChanged" AutoPostBack="True" />
                                            
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