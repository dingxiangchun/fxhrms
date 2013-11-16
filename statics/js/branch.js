var pageUrl = util.getUrl();

// branchid
var branchid = util.getParam("branchid") || 0;
$("input[name=parentid]").val(branchid);
$("#branch-form,#branch-edit-form").attr("action",document.location.href);


// 刷新nav
$("nav").load( util.getUrl()+"?action=tree" );


// 删除
$(".branch-del").on("click",function(){
	var $tr = $(this).closest("tr"),
		bid = util.getData("tr",this,"id"),
		param,
		callback;

	param = {
		"id" : bid,
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
	$(this).closest(".branch-edit-wrap").slideUp(500);
	return false;
});

// 修改
$(".branch-edit").on("click",function(){
	var $form = $(".branch-edit-wrap"),
		dataObj = $(this).closest("tr").find(".link-data");
	dataObj.each(function(){
		var value = $(this).text(),
			key = $(this).attr("rel");
		$form.find("input[name='"+key+"']").val(value);
	});
	$form.slideDown(500);
});
