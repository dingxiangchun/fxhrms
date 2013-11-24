var pageUrl = util.getUrl();
var hash = document.location.hash.replace("#","") || "basic";

$(".quick-link button").on("click",function(){
	var rel = "#info-" + $(this).attr("rel")
	$(".info-block").hide();
	$(rel).show();
	$(this).addClass("btn-info").removeClass("btn-default").siblings().removeClass("btn-info").addClass("btn-default")
});

$(".quick-link button[rel="+hash+"]").trigger("click");

$('.date-picker').datetimepicker({"format":'yyyy-mm-dd',"autoclose":true,"minView":"month"});

$('.date-picker-month').datetimepicker({"format":'yyyy-mm',"autoclose":true,"minView":"month","startView":'year'});

// 身份证
$("input[name=Idcard]").on("blur",function(){
	var value = $(this).val(),
		length = value.length,
		y = "",
		m = "",
		d = "";
	if( length === 18 ){
		y = value.slice(6,10);
		m = value.slice(10,12);
		d = value.slice(12,14);
	}else if(length === 15){
		y = "19" + value.slice(6,8);
		m = value.slice(8,10);
		d = value.slice(10,12);
	}else{
		return;
	}
	$(this).closest("form").find("input[name=Birth]").val(y+"-"+m+"-"+d);
});

$("#addReserve").click(function(){
	var $con = $(".reserveContainer"),
		rel = $("#reserveCtl").val(),
		text = $("#reserveCtl").find("option").filter(function(){
			if(this.value === rel) return true;
		}).text(),
		value;
	if(!$con.find("span[rel="+rel+"]").length){
		$('<span type="button" class="btn btn-default btn-xs del-reserve" rel="'+rel+'"> <span class="glyphicon glyphicon-trash"></span> '+text+'</span>').appendTo($con)
	}
	value = getReserveString();
	$("input[name=Reserve]").val( value );
	return false;
});

function getReserveString(){
	var $span = $(".reserveContainer span[rel]"),
		res = [];
	$span.each(function(){
		res.push($(this).attr("rel"));
	});
	return res.join();
}

$("body").on("click",".del-reserve",function(){
	$(this).remove();
	$("input[name=Reserve]").val( getReserveString() );
})

$(".info-form").submit(function(){
	if( !$("input[name=id]",this).val() ){
		alert("必须先添加基本信息并保存，才能够继续添加其他信息");
		return false;
	}
});

$("select[data-value]").each(function(){
	var data = $(this).data("value");
	$(this).find("option").filter(function(){
		if(this.value === data) return true;
	}).prop("selected",true)
});

// 新增
$(".add-new").on("click",function(){
	var $form = $(this).closest("form"),
		$src = $form.find("tr").last(),
		$target = $src.clone();
	$target.find("input").val("");
	$target.find(".view-file").remove();
	$form.find("table").append($target);

});