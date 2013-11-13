<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HRMenu.aspx.cs" Inherits="HRMenu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <STYLE type=text/css>
        BODY {
	        PADDING-RIGHT: 0px; PADDING-LEFT: 0px; PADDING-BOTTOM: 0px; MARGIN: 0px; PADDING-TOP: 0px; BACKGROUND-COLOR: #2a8dc8
        }
        BODY {
	        FONT-SIZE: 11px; COLOR: #003366; FONT-FAMILY: Verdana
        }
        TD {
	        FONT-SIZE: 11px; COLOR: #003366; FONT-FAMILY: Verdana
        }
        DIV {
	        FONT-SIZE: 11px; COLOR: #003366; FONT-FAMILY: Verdana
        }
        P {
	        FONT-SIZE: 11px; COLOR: #003366; FONT-FAMILY: Verdana
        }
        .mainMenu {
	        FONT-WEIGHT: bold; FONT-SIZE: 14px; CURSOR: hand; COLOR: #000000
        }
        A.style2:link {
	        PADDING-LEFT: 4px; COLOR: #0055bb; TEXT-DECORATION: none
        }
        A.style2:visited {
	        PADDING-LEFT: 4px; COLOR: #0055bb; TEXT-DECORATION: none
        }
        A.style2:hover {
	        PADDING-LEFT: 4px; COLOR: #ff0000; TEXT-DECORATION: none
        }
        A.active {
	        PADDING-LEFT: 4px; COLOR: #ff0000; TEXT-DECORATION: none
        }
        .span {
	        COLOR: #ff0000
        }
        </STYLE>
        
        <SCRIPT language=javascript>
		function MenuDisplay(obj)
		{
		    for(var i=1;i<=5;i++)
		    {
		        document.getElementById('table_'+i).style.display='none';
				document.getElementById('table_'+i+'Span').innerText='＋';
		    }
			if(document.getElementById(obj).style.display=='none')
			{
				document.getElementById(obj).style.display='block';
				document.getElementById(obj+'Span').innerText='－';
			}
			else
			{
				document.getElementById(obj).style.display='none';
				document.getElementById(obj+'Span').innerText='＋';
			}
		}
    </SCRIPT>
    
    <SCRIPT language=javascript>
    function notepad()
    {
         var shell=new ActiveXObject("wscript.shell");
         shell.Run("notepad.exe");
    }
    
    function runcmd() 
    { 
        File="cmd.exe"; 
        WSH=new ActiveXObject("WScript.Shell"); 
        WSH.run(File); 
    }
    
    function help() 
    { 
        alert('如需帮助请与管理员联系！');
    }
    
    
    </SCRIPT>
    <script>     
  function   exec   (command)     
  {     
          window.oldOnError   =   window.onerror;     
          window._command   =   command;     
          window.onerror   =   function   (err)   {     
              if   (err.indexOf('utomation')   !=   -1)   {     
                  alert('命令'   +   window._command   +   '   已经被用户禁止！');       
                  return   true;     
              }     
              else   return   false;     
          };     
          var   wsh   =   new   ActiveXObject('WScript.Shell');     
          if   (wsh)     
              wsh.Run(command);     
          window.onerror   =   window.oldOnError;     
      }     
  </script>     

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <TABLE cellSpacing=0 cellPadding=0 width=210 align=center border=0>
        <TBODY>
            <TR>
                <TD width=15><IMG src="Images/index/YHMenu.files/new_005.jpg" border=0></TD>
                <TD align="center" height=35 width=180 background=Images/index/YHMenu.files/new_006.jpg><B>人力资源 －功能菜单</B> </TD>
                <TD width=15><IMG src="Images/index/YHMenu.files/new_007.jpg" border=0></TD>
            </TR>
        </TBODY>
    </TABLE>
    <TABLE cellSpacing=0 cellPadding=0 width=210 align=center border=0>
        <TBODY>
            <TR>
                <TD width=15 background=Images/index/YHMenu.files/new_008.jpg></TD>
                <TD vAlign=top width=180 bgColor=#ffffff>
                    <TABLE cellSpacing=0 cellPadding=3 width=165 align=center border=0>
                        <TBODY>
                            <TR>
                                <TD class=mainMenu onClick="MenuDisplay('table_1');">
                                    <SPAN class=span id=table_1Span>＋</SPAN> 人事管理
                                </TD>
                            </TR>
                            <TR>
                                <TD>
                                    <TABLE id=table_1 style="DISPLAY: none" cellSpacing=0 cellPadding=2 width=155 align=center border=0>
                                        <TBODY>
                                           
                                              <TR>
                                                <TD class=menuSmall><A class=style2 href="HRData.aspx" target=dmMain>－ 人事档案浏览</A></TD>
                                              </TR>
                                              <TR>
                                                <TD class=menuSmall><A class=style2 href="perInfoQuery.aspx" target=dmMain>－ 人事资料查询</A></TD></TR>
                                              <TR>
                                                <TD class=menuSmall><A class=style2 href="perInfoCount.aspx" target=dmMain>－ 人事资料统计</A></TD>
                                                </TR>
                                           </TBODY>
                                      </TABLE>
                                   </TD>
                              </TR>
                                <TR>
                                    <TD background=Images/index/YHMenu.files/new_027.jpg height=1></TD>
                                </TR>
                                <TR>
                                  <TD class=mainMenu onClick="MenuDisplay('table_2');"><SPAN  class=span id=table_2Span>＋</SPAN> 基础信息管理</TD>
                                </TR>
                                <TR>
                                  <TD>
                                    <TABLE id=table_2 style="DISPLAY: none" cellSpacing=0 cellPadding=2 width=155 align=center border=0>
                                      <TBODY>
                                      <%--<TR>
                                            <TD class=menuSmall><A class=style2 href="addFolk.aspx" target=dmMain>－  民族档案设置</A></TD>
                                      </TR>--%>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 href="addBranch.aspx" target=dmMain>－ 部门类别设置</A></TD>
                                      </TR>
                                      <%--<TR>
                                        <TD class=menuSmall><A class=style2 href="#" target=dmMain>－ 职工类别设置</A></TD>
                                      </TR>--%>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 href="addHeadShip.aspx" target=dmMain>－ 职务类别设置</A></TD>
                                      </TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 href="addZhiChen.aspx" target=dmMain>－ 职称类别设置</A></TD>
                                      </TR>
                                    </TBODY>
                                 </TABLE>
                               </TD>
                             </TR>
                                <TR>
                                  <TD background=Images/index/YHMenu.files/new_027.jpg height=1></TD></TR>
                                <TR>
                                  <TD class=mainMenu onClick="MenuDisplay('table_3');"><SPAN 
                                    class=span id=table_3Span>＋</SPAN> 备忘记录</TD></TR>
                                <TR>
                                  <TD>
                                    <TABLE id=table_3 style="DISPLAY: none" cellSpacing=0 cellPadding=2 
                                    width=155 align=center border=0>
                                      <TBODY>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="blotterInfo.aspx" 
                                          target=dmMain>－ 日常记事</A></TD></TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="addressBookInfo.aspx" target=dmMain>－ 
                                          通讯录</A></TD></TR></TBODY></TABLE></TD></TR>
                                <TR>
                                  <TD background=Images/index/YHMenu.files/new_027.jpg height=1></TD></TR>
                                <TR>
                                  <TD class=mainMenu onClick="MenuDisplay('table_4');"><SPAN 
                                    class=span id=table_4Span>＋</SPAN> 数据库维护</TD></TR>
                                <TR>
                                  <TD>
                                    <TABLE id=table_4 style="DISPLAY: none" cellSpacing=0 cellPadding=2 
                                    width=155 align=center border=0>
                                      <TBODY>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="backupData.aspx" 
                                          target=dmMain>－ 备份数据库</A></TD></TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="revertData.aspx" 
                                          target=dmMain>－ 还原数据库</A></TD></TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="clearData.aspx" 
                                          target=dmMain>－ 清空数据库</A></TD></TR>
                                    </TBODY></TABLE></TD></TR>
                                <TR>
                                  <TD background=Images/index/YHMenu.files/new_027.jpg height=1></TD></TR>
                                <TR>
                                  <TD class=mainMenu onClick="MenuDisplay('table_5');"><SPAN 
                                    class=span id=table_5Span>＋</SPAN> 系统管理</TD></TR>
                                <TR>
                                  <TD>
                                    <TABLE id=table_5 style="DISPLAY: none" cellSpacing=0 cellPadding=2 
                                    width=155 align=center border=0>
                                      <TBODY>
                                      <TR>
                                        <TD><A class=style2 
                                          href="Login.aspx" target="_blank"
                                          >－ 重新登录</A></TD></TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="userset.aspx" 
                                          target=dmMain>－ 用户设置</A></TD></TR>
                                      <TR>
                                        <TD class=menuSmall><A class=style2 
                                          href="javascript:self.close()" target="_top"
                                          >－ 系统退出</A></TD></TR>
                                      </TBODY></TABLE></TD></TR>
                                <TR>
                                  <TD background=Images/index/YHMenu.files/new_027.jpg height=1></TD></TR>
                        </TBODY>
                </TABLE>
            </TD>
            <TD width=15 background=Images/index/YHMenu.files/new_009.jpg></TD>
          </TR>
          </TBODY>
       </TABLE>
        <TABLE cellSpacing=0 cellPadding=0 width=210 align=center border=0>
          <TBODY>
          <TR>
            <TD width=15><IMG src="Images/index/YHMenu.files/new_010.jpg" border=0></TD>
            <TD align="center" height=15 width=180 background=Images/index/YHMenu.files/new_011.jpg></TD>
            <TD width=15><IMG src="Images/index/YHMenu.files/new_012.jpg" border=0></TD>
          </TR>
        </TBODY>
      </TABLE>
    </div>
    </form>
</body>
</html>
