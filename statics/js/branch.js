var pageUrl = util.getUrl();

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
			$tr.remove();
		}else{
			util.error( res.errorMsg );
		}
	}

	$.post(pageUrl,param,callback)

});