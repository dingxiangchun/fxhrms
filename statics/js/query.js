var pageUrl = util.getUrl();

// branchid
var branchid = util.getParam("branchid") || 0;
$("input[name=UnitID]").val(branchid);

// 刷新nav
$("nav").load( "addBranch.aspx?action=tree" );

$('.date-picker').datetimepicker({"format":'yyyy-mm-dd',"autoclose":true,"minView":"month"});

$('.date-picker-month').datetimepicker({"format":'yyyy-mm',"autoclose":true,"minView":"year","startView":'year'});

// check
$(".check-all").on("change",function(){
	var isCheck = $(this).is(":checked");
	$(".check-one").prop("checked",isCheck);
});

$("select[data-value]").each(function(){
	var data = $(this).data("value");
	$(this).find("option").filter(function(){
		if(this.value === data) return true;
	}).prop("selected",true)
});

// export
$("#exportCheck").on("click",function(){
	var param = {};
	param.action = "excel";
	param.ids = [];
	$(".check-one:checked").map(function(){
		param.ids.push(this.value);
	});
	if(!param.ids.length){
		return false;
	}
	param.ids = param.ids.join();
	$.post(pageUrl,param);
});

$("#exportAll").on("click",function(){
	var param = $("#query-form").serialize();
	$.post(pageUrl+"?"+param+"&action=excelAll")
});