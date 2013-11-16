var pageUrl = util.getUrl();

// branchid
var branchid = util.getParam("branchid") || 0;
$("input[name=parentid]").val(branchid);
$("#branch-form").attr("action",document.location.href);


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
			window.location.reload();
		}else{
			util.error( res.errorMsg );
		}
	}

	$.post(pageUrl,param,callback)

});
