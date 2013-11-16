<%@ Page Language="C#" AutoEventWireup="true" CodeFile="perinfo.aspx.cs" Inherits="perinfo" %>
<%--
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
	BORDER-RIGHT: #cccccc 1px solid; BORDER-TOP: #cccccc 1px solid; BORDER-LEFT: #cccccc 1px solid; COLOR: #000000; BORDER-BOTTOM: #cccccc 1px solid; BACKGROUND-COLOR: #f4f4f4
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
                                    <TD style="height: 216px">&nbsp; 基本信息
                                    <TABLE cellSpacing=1 cellPadding=2 width="100%" border="1px" bordercolor="#CCCCCC">
                                    <TBODY>
                                    <tr>
                                        <TD class=tdclass>
                                            编号:</TD>
                                        <TD  height=25>
                                            <asp:Label ID="lb_pernum" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>姓名:</TD>
                                        <TD>
                                            <asp:Label ID="lb_name" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>民族:</TD>
                                        <TD>
                                            <asp:Label ID="lb_folk" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>
                                            出生日期:</TD>
                                        <TD>
                                            <asp:Label ID="lb_birthday" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <td rowspan="4">
                                            <asp:Image ID="Image1" runat="server" ImageAlign="Middle" /></td>
                                        
                                    </tr>
                                    <tr>
                                        <TD class=tdclass>
                                           
                                            年龄:</td>
                                            <td>
                                            <asp:Label ID="lb_age" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>
                                            学历:</td>
                                            <td>
                                                <asp:Label ID="lb_kultur" runat="server" Text="Label"></asp:Label>
                                            </TD>
                                            <TD  class=tdclass>婚姻:</TD>
                                        <TD>
                                            <asp:Label ID="lb_marr" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD  class=tdclass>性别:</TD>
                                        <TD>
                                            <asp:Label ID="lb_sex" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                     
                                    </tr>
                                    <tr>
                                        
                                        <TD class=tdclass>政治面貌:</TD>
                                        <TD>   
                                           <asp:Label ID="lb_vis" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD  class=tdclass>
                                            身份证号:</TD>
                                        <TD colspan="2">
                                            <asp:Label ID="lb_idcard" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD colspan="3">
                                            &nbsp;籍贯:
                                            <asp:Label ID="lb_origo" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        
                                    </tr>
                                    <tr>
                                        <TD  class=tdclass>
                                            工作时间:</TD>
                                        <TD>
                                            <asp:Label ID="lb_workdate" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD  class=tdclass>工龄:</TD>
                                        <TD>
                                           <asp:Label ID="lb_worklen" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>员工类型:</TD>
                                        <TD>
                                           <asp:Label ID="lb_emp" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>进本单位时间:</TD>
                                        <TD>
                                            <asp:Label ID="lb_inwork" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        
                                    </tr>
                                    <tr>
                                        <TD class=tdclass>本单位工龄:</TD>
                                        <TD>
                                           <asp:Label ID="lb_inworklen" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>工资类别:</TD>
                                        <TD>
                                           <asp:Label ID="lb_labtype" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>部门:</TD>
                                        <TD>
                                           <asp:Label ID="lb_branch" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>职务:</TD>
                                        <TD colspan="2">
                                           <asp:Label ID="lb_head" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                    </tr>
                                    <tr>
                                        
                                        <TD  class=tdclass>职称:</TD>
                                        <TD>
                                           <asp:Label ID="lb_zc" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD  class=tdclass>电话:</TD>
                                        <TD>
                                            <asp:Label ID="lb_phone" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>手机:</TD>
                                        <TD>
                                           <asp:Label ID="lb_handset" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>
                                            地址:</TD>
                                        <TD colspan="2">
                                           <asp:Label ID="lb_address" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                    </tr>
                                    <tr>
                                        <TD class=tdclass>毕业学校:</TD>
                                        <TD colspan="2">
                                            <asp:Label ID="lb_school" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>专业:</TD>
                                        <TD colspan="2">
                                           <asp:Label ID="lb_spe" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        <TD class=tdclass>
                                            毕业时间:</TD>
                                        <TD colspan="2">
                                           <asp:Label ID="lb_gradate" runat="server" Text="Label"></asp:Label>
                                        </TD>
                                        
                                    </tr>
                                   <TR>
                                        <TD align=right height=25 colspan="8">
                                            
                                            <asp:Button ID="bt_back" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_back_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
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
                                    &nbsp; 家庭成员
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" align="left" border=0>
                                        <TBODY>
                                        <tr>
                                            <td style="height: 119px">
                                                <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="id" Width="100%">
                                            <Columns>
                                                
                                                <asp:BoundField HeaderText="成员姓名" DataField="LeaguerName">
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="60px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="与本人关系" DataField="Nexus">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"   Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="70px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="出生年月" DataField="BirthDate">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="60px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="工作单位" DataField="WorkInc">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial"  />
                                                    <ControlStyle Width="100px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="职务" DataField="headship">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px"  />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="60px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="政治面貌" DataField="visage">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"   Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="70px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="联系电话" DataField="phone">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="80px" />
                                                </asp:BoundField>
                                                
                                            </Columns>
                                            
                                        </asp:GridView>
                                            </td>
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
                                    <TD style="height: 155px">
                                        &nbsp; 工作经历
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                        <TBODY>
                                        <tr>
                                            <td style="height: 119px">
                                                <asp:GridView ID="GridView2" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="id" Width="100%">
                                            <Columns>
                                                
                                                <asp:BoundField HeaderText="开始时间" DataField="beginDate">
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="70px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="结束时间" DataField="endDate">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"   Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="70px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="所在部门" DataField="branch">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="80px" />
                                                </asp:BoundField>
                                                
                                                <asp:BoundField HeaderText="职务" DataField="headship">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px"  />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="80px" />
                                                </asp:BoundField>
                                                <asp:BoundField HeaderText="公司名称" DataField="IncName">
                                                
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial"  Font-Size="12px" />
                                                    <ItemStyle BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"   Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                    <ControlStyle Width="100px" />
                                                </asp:BoundField>
                                                
                                                
                                            </Columns>
                                            
                                        </asp:GridView>
                                            </td>
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
--%>