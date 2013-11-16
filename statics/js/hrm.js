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