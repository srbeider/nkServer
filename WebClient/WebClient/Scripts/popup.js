function GetNumPopUps() {
    return $('#hdNumPopUps').val();
}

function SetNumPopUps(num) {
    $('#hdNumPopUps').val(num);
}

function ShowMessageBox(message) {
    var numPopUps = parseInt(GetNumPopUps());
    numPopUps++;

    var popUp = $('#hiddenContent').find('#popUp').clone();
    popUp[0].id = popUp[0].id + numPopUps;
    var button = popUp.find('#okButton');
    button[0].onclick = function () { ClosePopUp(numPopUps); };
    var cancelButton = popUp.find('#cancelButton');
    cancelButton.remove();
    var divmessage = popUp.find('#message');
    divmessage.html(message);
    $('#popUpContainer').append(popUp);

    SetNumPopUps(numPopUps);
}

function ClosePopUp(numPopUps) {
    $('#popUp' + numPopUps).remove();
    numPopUps--;
    SetNumPopUps(numPopUps);
}