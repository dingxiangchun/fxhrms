var pageUrl = util.getUrl();
var hash = document.location.hash.replace("#","") || "basic";

$(".quick-link a").on("click",function(){
	var rel = "#info-" + $(this).attr("rel");
	$(".info-block").hide();
	$(rel).show();
	$(this).addClass("btn-info").removeClass("btn-default").siblings().removeClass("btn-info").addClass("btn-default")
});

$(".quick-link a[rel="+hash+"]").trigger("click");

function dateInit(that){
$('.date-picker',that).datetimepicker({"format":'yyyy-mm-dd',"autoclose":true,"minView":"month"});

$('.date-picker-month',that).datetimepicker({"format":'yyyy-mm',"autoclose":true,"minView":"year","startView":'year'});

}
dateInit(document);

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
	dateInit($target);
});

// 工龄计算
$(".cal-age").each(function(){
	var rel = $(this).attr("rel"),
		year;
	if(!!rel && rel.indexOf("-") > 0 ){
		year = rel.split("-")[0];
		$(this).text( new Date().getFullYear() - year +"年")
	}
});

// form
$("form").submit(function(){
	var req = $(this).find("[data-required]").filter(function(){
		if($(this).val() === '') return true;
	});
	if(req.length){
		alert("请填写完整信息再保存。")
		return false;
	}
});
$("body").on("click",".del-item",function(){
	var $tr = $(this).closest("tr"),
		iid = $tr.find("input[name='iid[]']").val();
	if(!!iid){
		var param = {
			action:"del",
			type: document.location.hash.replace("#",""),
			id:iid
		}
		$.post("perInfo.aspx",param,function( res ){
			res = $.parseJSON(res);
			if( !!res.status ){
				if( $tr.closest("table").find("tr").index($tr) > 1 ){
					$tr.remove();
				}else{
					window.location.reload();
				}
			}else{
				util.error( res.errorMsg );
			}
		});
	}else{
		if( $tr.closest("table").find("tr").index($tr) > 1 ){
			$tr.remove();
		}
	}
	return false;
})