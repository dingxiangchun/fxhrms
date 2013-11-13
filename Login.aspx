<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>用户登录</title>
    <STYLE type=text/css>
        BODY {
	        FONT-SIZE: 12px; COLOR: #ffffff; FONT-FAMILY: 宋体
        }
        TD {
	        FONT-SIZE: 12px; COLOR: #ffffff; FONT-FAMILY: 宋体
        }
    </STYLE>
    
    
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
       <!--<asp:PostBackTrigger ControlID="ib_login" />ib_login就是下面那个需要在ib_login_Click事件里使用Response.Write()的按钮ID--> 
        <asp:UpdatePanel ID="tUpdatePanel1" runat="server">
        <Triggers> 
                     <asp:PostBackTrigger  ControlID="ib_login" />    
         </Triggers>
        <ContentTemplate>
        
       <DIV>
            <TABLE cellSpacing=0 cellPadding=0 width=900 align=center border=0>
              <TBODY>
              <TR>
                <TD style="HEIGHT: 105px"><IMG src="Images/login_files/login_1.gif" border=0></TD>
              </TR>
              <TR>
                <TD background=Images/login_files/login_2.jpg height=300>
                  <TABLE height=300 cellPadding=0 width=900 border=0>
                    <TBODY>
                    <TR>
                      <TD colSpan=2 height=35></TD></TR>
                    <TR>
                      <TD width=360></TD>
                      <TD>
                        <TABLE cellSpacing=0 cellPadding=2 border=0>
                          <TBODY>
                          <TR>
                            <TD style="HEIGHT: 28px" width=80>登 录 名：</TD>
                            <TD style="HEIGHT: 28px" width=150>
                                <asp:TextBox ID="tb_txtName" runat="server" Width="130px"></asp:TextBox>
				            </TD>
                            <TD style="HEIGHT: 28px" width=370>
	                            <SPAN>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="请输入登录名" Font-Bold="True" ForeColor="White" ControlToValidate="tb_txtName"></asp:RequiredFieldValidator></SPAN>		
				            </TD></TR>
                          <TR>
                            <TD style="HEIGHT: 28px">登录密码：</TD>
                            <TD style="HEIGHT: 28px">
				                <asp:TextBox ID="tb_txtPwd" runat="server" Width="130px" TextMode="Password"></asp:TextBox>
				            </TD>
                            <TD style="HEIGHT: 28px">
				                <SPAN>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入密码" Font-Bold="True" ForeColor="White" ControlToValidate="tb_txtPwd"></asp:RequiredFieldValidator></SPAN>            
				            </TD>
				            </TR>
                          <TR>
                            <TD style="HEIGHT: 18px"></TD>
                            <TD style="HEIGHT: 18px"></TD>
                            <TD style="HEIGHT: 18px"></TD></TR>
                          <TR>
                            <TD></TD>
                            <TD>
                                <asp:ImageButton ID="ib_login" runat="server" ImageUrl="~/Images/login_files/login_button.gif" OnClick="ib_login_Click" />
                            </TD>
                          </TR>
                        </TBODY>
                      </TABLE>
                    </TD>
                  </TR>
                </TBODY>
              </TABLE>
            </TD>
          </TR>
          <TR>
              <TD>
                  <IMG src="Images/login_files/login_3.jpg" border=0>
              </TD>
          </TR>
        </TBODY>
      </TABLE>
    </DIV>
  </ContentTemplate>
  </asp:UpdatePanel>

    </form>
</body>
</html>
