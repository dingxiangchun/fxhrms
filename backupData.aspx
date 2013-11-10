<%@ Page Language="C#" AutoEventWireup="true" CodeFile="backupData.aspx.cs" Inherits="backupData" %>

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
                                    <OBJECT id = "dirselect1" name = "dirselect1"  codebase="setup.exe" classid = "clsid:ebca8d01-6b80-4e94-84de-c1c5ae15e564" >
            </OBJECT>
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
                                                            <asp:RadioButton ID="rb_default" runat="server" AutoPostBack="True" Checked="True" GroupName="radio" Text="默认路径:" />
                                                            
                                                            <asp:TextBox ID="tb_default" runat="server" Enabled="False" Width="200px">\bar</asp:TextBox>
                                                        </TD>
                                                        <TD>
                                                            <asp:RadioButton ID="rb_other" runat="server" AutoPostBack="True" GroupName="radio" Text="其它:" />
                                                            
                                                            <asp:TextBox ID="tb_other" runat="server" Width="300px"></asp:TextBox>
                                                         <%--   <input id="Hidden1" type="hidden" runat="server" />--%>

                                        <input type = button class="button" style="width:100px"  value = "选择文件夹" onClick ="doScript(); ">
                                    
                                                        </TD>
                                                        
                                                    </tr>
                                                    
                                                    <TR>
                                                        <TD align=right height=25 colspan="4">
                                            <asp:Button ID="bt_backup" CssClass="button" runat="server" Text="备份" Width="60px" OnClick="bt_backup_Click" />&nbsp;
                                                            <asp:Button ID="bt_back" CssClass="button" runat="server" Text="返回" Width="60px" OnClick="bt_back_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
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
    <script language = "javascript">
        function doScript()
        {
             var t = dirselect1.showDlg();
//             alert(t);
             if(t!="")
             {
                  var str=dirselect1.GetSelctedDir();
                  //alert(str);
                  document.getElementById("tb_other").innerText=str;
                  
//                  var i=0;
//                  // 返回该文件夹下所有文件数目
//                  var cnt = dirselect1.GetFilesCount();
//                  alert(cnt);  
//      
//                  //返回该文件夹下所有文件路径
//                  var array = new Array(cnt);
//                  for(i;i<3;i++)
//                  {
//                       array[i] = dirselect1.GetFile(i);
//                       alert(array[i]);
//                  }
             }
        }
    </script>

</html>