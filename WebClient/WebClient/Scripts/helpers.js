function LoadUsers() {
    LoadUserName("1");
    LoadUserName("2");
    LoadUserName("3");
    LoadUserName("4");
    LoadUserName("5");
}

function LoadUserName(userName) {

    var args = { RequestId: new Date().getTime(), Args: userName };
    MakePostCall('/WebClient/Users/GetUserById', args, function (data) {
        $('#' + data.Id).html('<label onclick="$(this).remove();">' + data.Name + '</label>');
    });
}