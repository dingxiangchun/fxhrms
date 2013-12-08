var pageUrl = util.getUrl();

var branchid = util.getParam("branchid") || 0;
$("input[name=branchid]").val(branchid);

// 刷新nav
$("nav").load( util.getUrl()+"?action=tree" );

$(".addper").attr("href","perinfo.aspx?action=add&branchid="+branchid );

$("#perlist-form").submit(function () {
    if (!$("#name").val()) {
        $("#name").focus();
        return false;
    }
});

$(".del-per").on("click", function () {
    var $tr = $(this).closest("tr"),
        pid = $tr.data("id"),
        param = {};
    param.action = "del";
    param.id = pid;
    $.post("HRData.aspx", param, function (res) {
        res = $.parseJSON(res);
        if (!!res.status) {
            $tr.remove();
        } else {
            util.error(res.errorMsg);
        }
    });

})



