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

function MakePostCall(url, args, onsuccess, onerror) {

    if (onsuccess) {

        var host = $('#hdHost').val();
        url = host + url;

        if (onerror == null || onerror == undefined) {
            onerror = function (error) {
                alert(error);
            }
        }

        $.ajax(
        {
            type: 'POST',
            url: url,
            data: args,
            success: onsuccess,
            error: onerror
        });
    }
    else {
        alert("onsuccess is null or is not an object.");
    }
}

function destroy(element) {
    $(element).remove();
}