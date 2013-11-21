var pageUrl = util.getUrl();

var branchid = util.getParam("branchid") || 0;
$("input[name=branchid]").val(branchid);

// 刷新nav
$("nav").load( util.getUrl()+"?action=tree" );

$(".addper").attr("href","perinfo.aspx?action=add&branchid="+branchid )



