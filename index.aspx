<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>人力资源管理系统</title>
</head>
<%--.NET 不支持创建或编辑框架集 看运行结果,框架页面可以在Dreamwaver中打开查看--%>
<frameset>
<FRAMESET frameSpacing=0 rows=80,* frameBorder=0>
	<FRAME name=top src="HRTop.aspx" frameBorder=0 noResize scrolling=no>
	<FRAMESET frameSpacing=0 frameBorder=0 cols=220,*>
	    <FRAME name=menu src="HRMenu.aspx" frameBorder=0 noResize>
	    <FRAME name=dmMain src="HRData.aspx" frameBorder=0>
    </FRAMESET>
    <NOFRAMES>
            <p>
                This page requires frames, but your browser does not support them.</p>
    </NOFRAMES>
</FRAMESET>
</frameset>
</html>


