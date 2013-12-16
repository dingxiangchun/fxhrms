var util={};

// 获取dom数据
util.getData = function( type, obj, data ){
	return ( typeof type === 'string' ? $(obj).closest("tr").data(data) : $(obj).data(data) ) || "" ;
}

// 获取当前地址
util.getUrl = function(){
	return document.location.pathname;
}

// 打印错误
util.error = function( msg ){
	alert( msg || "未知错误");
}

// 获取url参数
util.getParam = function( name ){
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = window.location.search.substr(1).match(reg);
    if (r != null) return unescape(r[2]); return null;
}

// 获取cookie
util.getCookie = function( key ){
	var arrStr = decodeURI(document.cookie).split("; ");
 	for(var i = 0;i < arrStr.length;i ++){
 		var temp = arrStr[i].split("=");
 		if(temp[0] == key) return unescape(temp[1]);
	}
}

// 删除cookie
util.delCookie = function( key ){
	document.cookie = key+"=;expires="+(new Date(0)).toGMTString();
}



