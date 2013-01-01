function LoadUsers() {
    LoadUserName("Nuria");
    LoadUserName("Marc");
    LoadUserName("Pablo");
    LoadUserName("Ray");
    LoadUserName("Steff");
}

function LoadUserName(userName) {

    var args = { Args: userName };
    MakePostCall('/WebClient/Users/' + userName, args, function (data) {
        $('#' + data.Id).html('<label onclick="destroy(this);">' + data.Name + '</label>');
    });
}

function destroy(element) {
    $(element).remove();
}