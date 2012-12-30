function LoadUserName(userName) {

    var host = $('#hdHost').val();
    var url = host + '/WebClient/Service/GetUserName';
    var args = { Args: userName };

    $.ajax(
    {
        type: 'POST',
        url: url,
        data: args,
        success: function (data) {
            alert(data);
        },
        error: function (error) {
            alert(error);
        }
    });
}