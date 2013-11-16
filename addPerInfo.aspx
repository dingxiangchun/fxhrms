<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addPerInfo.aspx.cs" Inherits="addPerInfo" %>
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
                                    <TD style="height: 216px" class=manageHead1>&nbsp; 基本信息
                                    <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                    <TBODY>
                                    <tr>
                                        <TD class=tdclass>
                                            员工号:</TD>
                                        <TD  height=25>
                                            <asp:TextBox ID="tb_pernum" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>姓名:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_pername" runat="server" CssClass="textbox" MaxLength="50" Width="90px"></asp:TextBox>
                                        </TD>
                                        <TD class=tdclass>民族:</TD>
                                        <TD>
                                            <asp:DropDownList ID="ddl_folk" runat="server" Width="100px">
                                                
                                            </asp:DropDownList>
                                        </TD>
                                        <TD class=tdclass>
                                            出生日期:</TD>
                                        <TD>
                                            <asp:TextBox ID="tb_birthday" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
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
                                            <asp:DropDownList ID="ddl_kultur" runat="server">
                                                <asp:ListItem>高中</asp:ListItem>
                                                <asp:ListItem>大专</asp:ListItem>
                                                <asp:ListItem>本科</asp:ListItem>
                                                <asp:ListItem>硕士</asp:ListItem>
                                                <asp:ListItem>博士</asp:ListItem>
                                                
                                            </asp:DropDownList></TD>
                                            <TD  class=tdclass>婚姻:</TD>
                                        <TD>
                                            <asp:DropDownList ID="ddl_marr" runat="server" Width="50px">
                                                <asp:ListItem Selected="True" Value="0">否</asp:ListItem>
                                                <asp:ListItem Value="1">是</asp:ListItem>
                                                
                                            </asp:DropDownList>
                                        </TD>
                                        <TD  class=tdclass>性别:</TD>
                                        <TD>
                                            <asp:DropDownList ID="ddl_sex" runat="server" Width="50px">
                                                <asp:ListItem Selected="True" Value="0">男</asp:ListItem>
                                                <asp:ListItem Value="1">女</asp:ListItem>
                                                
                                            </asp:DropDownList>
                                        </TD>
                                    </tr>
                                    <tr>
                                        
                                        <TD colspan="2">政治面貌:
                                           <asp:DropDownList ID="ddl_vis" runat="server">
                                               <asp:ListItem>群众</asp:ListItem>
                                               <asp:ListItem>团员</asp:ListItem>
                                               <asp:ListItem>党员</asp:ListItem>
                                               <asp:ListItem>其它党派人士</asp:ListItem>
                                            </asp:DropDownList>
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
                                           <asp:DropDownList ID="ddl_emp" runat="server">
                                               <asp:ListItem>临时员工</asp:ListItem>
                                               <asp:ListItem>正式员工</asp:ListItem>
                                               <asp:ListItem>合同员工</asp:ListItem>
                                               <asp:ListItem>停薪留职</asp:ListItem>
                                                <asp:ListItem>离职员工</asp:ListItem>
                                            </asp:DropDownList>
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
                                           <asp:DropDownList ID="ddl_labtype" runat="server">
                                               <asp:ListItem>普通工资</asp:ListItem>
                                               <asp:ListItem>中级工资</asp:ListItem>
                                               <asp:ListItem>高级工资</asp:ListItem>
                                            </asp:DropDownList>
                                        </TD>
                                        <TD class=tdclass>部门:</TD>
                                        <TD>
                                            <asp:DropDownList ID="ddl_branch" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
                                        </TD>
                                        <TD class=tdclass>职务:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_head" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
                                        </TD>
                                    </tr>
                                    <tr>
                                        
                                        <TD  class=tdclass>职称:</TD>
                                        <TD>
                                           <asp:DropDownList ID="ddl_zc" runat="server" Width="100px">
                                               
                                            </asp:DropDownList>
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
                                        
                                        <asp:Button ID="bt_save" CssClass="button" runat="server" Text="保存" Width="60px" OnClick="bt_save_Click" />&nbsp;
                                        <asp:Button ID="bt_exit" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_exit_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
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
                                    <TD class=manageHead1>
                                    &nbsp; 家庭成员
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" align="left" border=0>
                                        <TBODY>
                                        <tr>
                                            <TD class=tdclass>
                                                姓名:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_famname" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                                与本人关系:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_famnexus" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                            出生日期:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_fambir" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                            工作单位:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_famwork" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                            
                                         </tr>
                                         <tr>
                                            <TD class=tdclass>
                                            职务:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_famhead" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                                <TD colspan="2">政治面貌:
                                                   <asp:DropDownList ID="ddl_famvis" runat="server">
                                                       <asp:ListItem>群众</asp:ListItem>
                                                       <asp:ListItem>团员</asp:ListItem>
                                                       <asp:ListItem>党员</asp:ListItem>
                                                       <asp:ListItem>其它党派人士</asp:ListItem>
                                                    </asp:DropDownList>
                                                </TD>
                                            <TD  class=tdclass>联系电话:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_famphone" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                         </tr>
                                         <tr>
                                            <TD align=right height=25 colspan="8">
                                        
                                        <asp:Button ID="bt_famsave" CssClass="button" runat="server" Text="保存" Width="60px" OnClick="bt_famsave_Click" />&nbsp;
                                        <asp:Button ID="bt_famcancel" CssClass="button" runat="server" Text="取消" Width="60px" OnClick="bt_famcancel_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
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
                                    <TD class=manageHead1>
                                        &nbsp; 工作经历
                                        <TABLE cellSpacing=1 cellPadding=2 width="100%" border=0>
                                        <TBODY>
                                        <tr>
                                            <TD class=tdclass>
                                                开始时间:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_begdate" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                                结束时间:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_enddate" CssClass="textbox" runat="server" Width="80px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                            部门:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_workbranch" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                            <TD class=tdclass>
                                            职务:</TD>
                                            <TD>
                                                <asp:TextBox ID="tb_workhead" CssClass="textbox" runat="server" Width="90px"></asp:TextBox>
                                            </TD>
                                            
                                         </tr>
                                         <tr>
                                            
                                                
                                            <TD  class=tdclass>公司名称:</TD>
                                            <TD colspan="2">
                                                <asp:TextBox ID="tb_workinc" CssClass="textbox" runat="server" Width="176px"></asp:TextBox>
                                            </TD>
                                         </tr>
                                         <tr>
                                            <TD align=right height=25 colspan="8">
                                        
                                        <asp:Button ID="bt_worksave" CssClass="button" runat="server" Text="保存" Width="60px" OnClick="bt_worksave_Click" />&nbsp;
                                        <asp:Button ID="bt_workcancel" CssClass="button" runat="server" Text="取消" Width="60px" OnClick="bt_workcancel_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
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
--%>