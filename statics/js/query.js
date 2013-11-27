var pageUrl = util.getUrl();

// branchid
var branchid = util.getParam("branchid") || 0;
$("input[name=UnitID]").val(branchid);

// 刷新nav
$("nav").load( "addBranch.aspx?action=tree" );

$('.date-picker').datetimepicker({"format":'yyyy-mm-dd',"autoclose":true,"minView":"month"});

$('.date-picker-month').datetimepicker({"format":'yyyy-mm',"autoclose":true,"minView":"month","startView":'year'});
