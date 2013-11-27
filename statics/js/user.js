var pageUrl = util.getUrl();

$("#account-form").submit(function(){
	var name = $("#loginname").val(),
		pass = $("#userpwd").val(),
		pass2 = $("#userpwd-confirm").val();
	if( !name || !pass ){
		alert("用户名密码不能为空");
		return false;
	}
	if( pass !== pass2 ){
		alert("两次密码输入不一致");
		return false;
	}
	return true;
});

$(".auth-edit").on("click",function(){
	var $tr = $(this).closest("tr"),
		iid = $tr.find("input[name=id]").val(),
		name = $tr.find("input[name=loginname]").val(),
		auth = $tr.find("[name=userprower]").val(),
		param,callback;
	param = {
		"id": iid,
		"action" : "update",
		"loginname": name,
		"userprower": auth
	};
	callback = function(res){
		res = $.parseJSON(res);
		if( !!res.status ){
			alert("权限修改成功")
		}else{
			util.error( res.errorMsg );
		}
	}
	$.post(pageUrl,param,callback);
});

$(".auth-del").on("click",function(){
	var $tr = $(this).closest("tr"),
		iid = $tr.find("input[name=id]").val(),
		param,callback;
	param = {
		"id": iid,
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
	$.post(pageUrl,param,callback);
});
