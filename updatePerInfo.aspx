<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatePerInfo.aspx.cs" Inherits="updatePerInfo" %>
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
                    <TD width=15 background=Images/index/YHChannelApply.files/new_022.jpg style="height: 574px">
                        <IMG src="Images/index/YHChannelApply.files/new_022.jpg" border=0 /> 
                    </TD>
                    <TD vAlign=top width="100%" bgColor=#ffffff style="height: 574px">
                        <TABLE cellSpacing=0 cellPadding=5 width="100%" border=0>
                            <TR>
                                <TD class=manageHead>当前位置：管理首页 &gt; 管理中心 &gt; 
                                    <asp:Label ID="lb_url" runat="server" Text="Label"></asp:Label></TD>
                            </TR>
                            <TR>    
                                <TD height=2></TD>
                            </TR>
                        </TABLE>
                        
                        
                        <TABLE borderColor=#cccccc cellSpacing=0 cellPadding=0 width="100%" align=center border=0>
                            <TBODY>
                                <TR>
                                    <TD style="height: 216px">
                                    <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                    <TBODY>
                                    <tr>
                                        <TD class=tdclass>
                                            编号:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_pernum" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>姓名:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_pername" runat="server" CssClass="textbox" MaxLength="50" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>民族:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_folk" CssClass="textbox" runat="server" Width="100px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>
                                            出生日期:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_birthday" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                        </TD>
                                        
                                    </tr>
                                    <tr>
                                        <TD class=tdclass>
                                           
                                            年龄:</td>
                                            <td>
                                            <asp:TextBox ID="tb_age" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>
                                            学历:</td>
                                            <td>
                                                <asp:TextBox ID="tb_kultur" CssClass="textbox" runat="server" Width="50px"></asp:TextBox>
                                            </TD>
                                            <TD  class=tdclass>婚姻:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_marr" CssClass="textbox" runat="server" Width="50px"></asp:TextBox>
                                        </TD>
                                        <TD  class=tdclass style="width: 78px">性别:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_sex" CssClass="textbox" runat="server" Width="50px"></asp:TextBox>
                                        </TD>
                                    </tr>
                                    <tr>
                                        
                                        <TD colspan="2">政治面貌:<asp:TextBox ID="tb_vis" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD  class=tdclass>
                                            身份证号:</TD>
                                        <TD colspan="2">
                                            <asp:TextBox ID="tb_IDCard" CssClass="textbox" runat="server" Width="141px"></asp:TextBox>
                                        </TD>
                                        <TD colspan="3">
                                            &nbsp;籍贯:
                                            <asp:TextBox ID="tb_origo" runat="server" CssClass="textbox"></asp:TextBox>
                                        </TD>
                                        
                                    </tr>
                                    <tr>
                                        <TD  class=tdclass>
                                            工作时间:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_workdate" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD  class=tdclass>工龄:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_worklen" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                                        </TD>
                                        <TD colspan="2">员工类型:
                                           <asp:TextBox ID="tb_emp" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD colspan="2">进本单位时间:
                                            <asp:TextBox ID="tb_inwork" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        
                                    </tr>
                                    <tr>
                                        <TD colspan="2">本单位工龄:
                                           <asp:TextBox ID="tb_inworklen" runat="server" CssClass="textbox" Width="30px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>工资类别:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_laytype" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>部门:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_branch" CssClass="textbox" runat="server" Width="100px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>职务:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_head" CssClass="textbox" runat="server" Width="100px"></asp:TextBox>
                                        </TD>
                                    </tr>
                                    <tr>
                                        
                                        <TD  class=tdclass>职称:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_zc" CssClass="textbox" runat="server" Width="100px"></asp:TextBox>
                                        </TD>
                                        <TD  class=tdclass>电话:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_phone" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>手机:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_handset" runat="server" CssClass="textbox" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>
                                            地址:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_address" runat="server" CssClass="textbox" Width="149px"></asp:TextBox>
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
                                            毕业时间:</TD>
                                        <TD>
                                           <asp:TextBox ID="tb_gradate" runat="server" CssClass="textbox" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>
                                            照片:</TD>
                                        <TD colspan="5">
                                           <asp:FileUpload ID="FileUpload1" runat="server" />
                                        </TD>
                                    </tr>
                                    <TR>
                                        <TD align=right height=25 colspan="8">
                                            
                                            <asp:Button ID="bt_update" CssClass="button" runat="server" Text="修改" Width="60px" OnClick="bt_update_Click" />&nbsp;
                                            <asp:Button ID="bt_back" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_back_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                                        </TD>
                                    </TR>
                                    </TBODY>
                                    </TABLE>
                                  </TD>
                                </TR>
                                <TR>    
                                <TD style="height: 2px">
                                    </TD>
                                </TR>
                                <TR>    
                                    <TD class=manageHead1>
                                    &nbsp; 家庭成员
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" align="left" border=0>
                                        <TBODY>
                                        <tr>
                                            <td style="height: 119px">
                                                <asp:GridView ID="GridView1" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="id" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" Width="100%">
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
                                                <asp:CommandField ShowEditButton="True" HeaderText="修改" >
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                </asp:CommandField>
                                            </Columns>
                                            
                                        </asp:GridView>
                                            </td>
                                        </tr>
                                        
                                         </TBODY>
                                         </TABLE>
                                    </TD>
                                </TR>
                                
                                <TR>    
                                <TD style="height: 2px">
                                    </TD>
                                </TR>
                                <TR>    
                                    <TD class=manageHead1>
                                        &nbsp; 工作经历
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                        <TBODY>
                                        <tr>
                                            <td style="height: 119px">
                                                <asp:GridView ID="GridView2" runat="server" GridLines="None" AutoGenerateColumns="False" DataKeyNames="id" OnRowEditing="GridView2_RowEditing" OnRowUpdating="GridView2_RowUpdating" OnRowCancelingEdit="GridView2_RowCancelingEdit" Width="100%">
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
                                                
                                                <asp:CommandField ShowEditButton="True" HeaderText="修改" >
                                                    <HeaderStyle BackColor="#F0F0F0" HorizontalAlign="Left" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Font-Names="Arial" Font-Size="12px" />
                                                    <ItemStyle  BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"  Font-Bold="False" HorizontalAlign="Left" Font-Names="Arial" />
                                                </asp:CommandField>
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
                    </TD>
                    <TD width=15 background=Images/index/YHChannelApply.files/new_023.jpg style="height: 574px">
                        <IMG src="Images/index/YHChannelApply.files/new_023.jpg" border=0 /> 
                    </TD>
                </TR>
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