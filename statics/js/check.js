var pageUrl = util.getUrl();
var hash = document.location.hash.replace("#","") || "workcheck";

$(".quick-link a").on("click",function(){
	var rel = "#info-" + $(this).attr("rel");
	$(".info-block").hide();
	$(rel).show();
	$(this).addClass("btn-info").removeClass("btn-default").siblings().removeClass("btn-info").addClass("btn-default")
});

$(".quick-link a[rel="+hash+"]").trigger("click");


// 审核
$(".vali-pass,.vali-no-pass").on("click",function(){
	var val = $(this).hasClass("vali-no-pass") ? "2" :"1",
		type = $(this).attr("rel"),
		param = {};
	param.mark = val;
	param.id = $(this).data("id");
	param.action = "check";
	param.type = type;
	$.post("perinfo.aspx",param);
	$(this).closest("tr").remove();
});
