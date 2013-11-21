var pageUrl = util.getUrl();
var hash = document.location.hash.replace("#","") || "basic";

$(".quick-link button").on("click",function(){
	var rel = "#info-" + $(this).attr("rel")
	$(".info-block").hide();
	$(rel).show();
	$(this).addClass("btn-info").removeClass("btn-default").siblings().removeClass("btn-info").addClass("btn-default")
});

$(".quick-link button[rel="+hash+"]").trigger("click");

