<%@ Page Language="C#" AutoEventWireup="true" CodeFile="perInfoQuery.aspx.cs" Inherits="perInfoQuery" %>

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
                                    <TD class=manageHead1>&nbsp; 部门信息
                                    <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                    <TBODY>
                                    <tr>
                                        
                                        <TD class=tdclass>姓名:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_pername" runat="server" CssClass="textbox" MaxLength="50" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>职务:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_head" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
                                        </TD>
                                        <TD  class=tdclass>职称:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_zc" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
                                        </TD>
                                    </tr>
                                    <tr>
                                        <TD class=tdclass>部门:</TD>
                                        <TD>
                                            <asp:DropDownList ID="ddl_branch" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
                                        </TD>
                                        <TD class=tdclass>员工类型:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_emp" runat="server">
                                               <asp:ListItem Selected="True">请选择</asp:ListItem>
                                               <asp:ListItem>临时员工</asp:ListItem>
                                               <asp:ListItem>正式员工</asp:ListItem>
                                               <asp:ListItem>合同员工</asp:ListItem>
                                               <asp:ListItem>停薪留职</asp:ListItem>
                                                <asp:ListItem>离职员工</asp:ListItem>
                                            </asp:DropDownList>
                                        </TD>
                                        <TD class=tdclass>工资类别:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_labtype" runat="server">
                                               <asp:ListItem Selected="True">请选择</asp:ListItem>
                                               <asp:ListItem>普通工资</asp:ListItem>
                                               <asp:ListItem>中级工资</asp:ListItem>
                                               <asp:ListItem>高级工资</asp:ListItem>
                                            </asp:DropDownList>
                                        </TD>
                                    </tr>
                                    
                                   
                                    </TBODY>
                                    </TABLE>
                                    </TD>
                                </TR>
                               <TR>    
                                <TD height=2>
                                    </TD>
                                </TR>
                                <TR>    
                                    <TD  class=manageHead1>
                                    &nbsp; 个人信息
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" align="left" border=0>
                                        <TBODY>
                                        <tr>
                                            <TD class=tdclass>
                                           
                                                年龄范围:</td>
                                                <td>
                                                <asp:TextBox ID="tb_age" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>至
                                                <asp:TextBox ID="tb_endage" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                                            </TD>
                                                
                                            <TD  class=tdclass>性别:</TD>
                                            <TD>
                                                <asp:DropDownList ID="ddl_sex" runat="server" Width="50px">
                                                    <asp:ListItem Selected="True"></asp:ListItem>
                                                    <asp:ListItem Value="0">男</asp:ListItem>
                                                    <asp:ListItem Value="1">女</asp:ListItem>
                                                </asp:DropDownList>
                                                &nbsp;&nbsp;婚姻:
                                                <asp:DropDownList ID="ddl_marr" runat="server" Width="50px">
                                                    <asp:ListItem></asp:ListItem>
                                                    <asp:ListItem Value="0">否</asp:ListItem>
                                                    <asp:ListItem Value="1">是</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
                                            
                                            <TD class=tdclass>民族:</TD>
                                            <TD>
                                                <asp:DropDownList ID="ddl_folk" runat="server" Width="100px">
                                                    
                                                </asp:DropDownList>
                                            </TD>
                                         </tr>
                                         <tr>
                                            <TD class=tdclass>
                                            文化程度:</td>
                                            <td>
                                            <asp:DropDownList ID="ddl_kultur" runat="server">
                                                <asp:ListItem>请选择</asp:ListItem>
                                                <asp:ListItem>高中</asp:ListItem>
                                                <asp:ListItem>大专</asp:ListItem>
                                                <asp:ListItem>本科</asp:ListItem>
                                                <asp:ListItem>硕士</asp:ListItem>
                                                <asp:ListItem>博士</asp:ListItem>
                                            </asp:DropDownList></TD>
                                            <TD class=tdclass>政治面貌:</TD>
                                            <TD>
                                               <asp:DropDownList ID="ddl_vis" runat="server">
                                                   <asp:ListItem>请选择</asp:ListItem>
                                                   <asp:ListItem>群众</asp:ListItem>
                                                   <asp:ListItem>团员</asp:ListItem>
                                                   <asp:ListItem>党员</asp:ListItem>
                                                   <asp:ListItem>其它党派人士</asp:ListItem>
                                                </asp:DropDownList>
                                            </TD>
                                            <TD class=tdclass>
                                                籍贯:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_origo" runat="server" CssClass="textbox"></asp:TextBox>
                                            </TD>
                                         </tr>
                                         <tr>
                                            <TD class=tdclass>毕业学校:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_school" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>专业:</TD>
                                            <TD>
                                               <asp:TextBox ID="tb_spe" runat="server" CssClass="textbox" Width="90px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                                </TD>
                                            <TD>
                                               
                                            </TD>
                                            
                                        </tr>
                                          <TR>
                                    <TD align=right height=25 colspan="8">
                                        
                                        <asp:Button ID="bt_save" CssClass="button" runat="server" Text="查询" Width="60px" OnClick="bt_save_Click" />&nbsp;
                                        <asp:Button ID="bt_cancel" CssClass="button" runat="server" Text="清空" Width="60px" OnClick="bt_cancel_Click" />&nbsp;
                                        <asp:Button ID="bt_exit" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_exit_Click" />&nbsp;
                                        <asp:CheckBox ID="cb_all" runat="server" Text="显示全部&nbsp;&nbsp;&nbsp;" AutoPostBack="True" OnCheckedChanged="cb_all_CheckedChanged" />
                                        &nbsp;&nbsp;&nbsp;&nbsp;
                                    </TD>
                                </TR>
                                         </TBODY>
                                         </TABLE>
                                    </TD>
                                </TR>
                                
                                <TR>    
                                <TD height=2>
                                    </TD>
                                </TR>
                                <TR>    
                                    <TD>
                                        &nbsp; 查询结果
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                        <TBODY>
                                        <tr>
                                            <TD class=tdclass>
                                                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" Width="100%"  DataKeyNames="id,perNum" PageSize="5" OnPageIndexChanging="GridView1_PageIndexChanging">
                                            <Columns>
                                                <asp:TemplateField HeaderText="员工编号">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label1" Text='<%# Eval("perNum") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" Width="80px" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="姓名">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label2" Text='<%# Eval("perName") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" Width="70px" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="民族">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label3" Text='<%# Eval("folk") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="出生年月">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label4" Text='<%# Eval("birthday") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="学历">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label5" Text='<%# Eval("kultur") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="性别">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label6" Text='<%# Eval("sex") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" Width="60px" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="所在部门">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label7" Text='<%# Eval("branch") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="职务">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label8" Text='<%# Eval("headship") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="职称">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
                                                                    <asp:Label runat="server" ID="Label9" Text='<%# Eval("ZhiChen") %>'></asp:Label>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="详细">
                                                    <ItemTemplate>
                                                        <table border="0" cellpadding="0" cellspacing="0">
                                                            <tr>
                                                                <td>
 <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "perinfo.aspx?id="+Eval("id").ToString()+"&&pernum="+Eval("perNum").ToString() %>'>查看</asp:HyperLink>                                                   
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </ItemTemplate>
                                                    <ItemStyle
                                                        Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                </asp:TemplateField>
                                                
                                            </Columns>
                                            <PagerTemplate>
                                                 <br />
                                                 <asp:Label ID="lblPage" runat="server" Text='<%# "第" + (((GridView)Container.NamingContainer).PageIndex + 1)  + "页/共" + (((GridView)Container.NamingContainer).PageCount) + "页" %> '></asp:Label>
                                                 <asp:LinkButton ID="lbnFirst" runat="Server" Text="首页"  Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="First" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnPrev" runat="server" Text="上一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != 0 %>' CommandName="Page" CommandArgument="Prev"  ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnNext" runat="Server" Text="下一页" Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Next" ></asp:LinkButton>
                                                 <asp:LinkButton ID="lbnLast" runat="Server" Text="尾页"   Enabled='<%# ((GridView)Container.NamingContainer).PageIndex != (((GridView)Container.NamingContainer).PageCount - 1) %>' CommandName="Page" CommandArgument="Last" ></asp:LinkButton>
                                                 <br />
                                             </PagerTemplate>
                                        </asp:GridView>
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
                <TD width=15><IMG src="Images/index/YHChannelApply.files/new_024.jpg" border=0 /></TD>
                <TD align="center" width="100%" background=Images/index/YHChannelApply.files/new_025.jpg height=15></TD>
                <TD width=15><IMG src="Images/index/YHChannelApply.files/new_026.jpg" border=0 /></TD>
              </TR>
            </TBODY>
         </TABLE>
    </div>
    </form>
</body>
</html>
