function MakePostCall(url, args, onsuccess, onerror) {

    if (onsuccess) {

        var host = $('#hdHost').val();
        url = host + url;

        if (onerror == null || onerror == undefined) {
            onerror = function (error) {
                ShowMessageBox(error.Message);
            }
        }

        $.ajax(
        {
            type: 'POST',
            url: url,
            data: args,
            success: function (data) {
                if (data.ResponseCode != "200") {
                    onerror(data);
                }
                else {
                    onsuccess(data.Data);
                }
            },
            error: onerror
        });
    }
    else {
        alert("onsuccess is null or is not an object.");
    }
}