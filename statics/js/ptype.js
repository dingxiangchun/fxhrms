var pageUrl = util.getUrl();

// 删除
$(".ptype-del").on("click",function(){
	var $tr = $(this).closest("tr"),
		pid = util.getData("tr",this,"id"),
		param,
		callback;

	param = {
		"id" : pid,
		"action" : "del"
	};

	callback = function(res){
		res = $.parseJSON(res);
		if( !!res.status ){
			window.location.href = window.location.href;
		}else{
			util.error( res.errorMsg );
		}
	}

	$.post(pageUrl,param,callback)

});

// 取消修改
$(".edit-cancel").on("click",function(){
	$(this).closest(".ptype-edit-wrap").slideUp(500);
	return false;
});

// 修改
$(".ptype-edit").on("click",function(){
	var $form = $(".ptype-edit-wrap"),
		dataObj = $(this).closest("tr").find(".link-data");
	dataObj.each(function(){
		var value = $(this).text(),
			key = $(this).attr("rel");
		$form.find("input[name='"+key+"']").val(value);
	});
	$form.slideDown(500);
});
