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
})
