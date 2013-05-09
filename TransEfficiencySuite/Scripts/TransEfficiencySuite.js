function addSign() {
    
    currentSign = $('input[id="signID"]').val();
    signArea = $('input[id="Height"]').val() * $('input[id="Width"]').val() / 144;
    signHeight = $('input[id="Height"]').val();
    
    selectorIndex = document.getElementById('functionalClassification').selectedIndex;
    diamondChecked = "false";
    
    if($('input[id="IsDiamond"]').attr('checked')){
        diamondChecked = "true";
    }
    
    var JsonSignData = {
        "Classification": selectorIndex,
        "Area": signArea,
        "DiamondOrientation": diamondChecked,
        "Height": signHeight
    };
    
    $.ajax({
        url: $("#myUrl").val(),
        datatype: 'json',
        type: 'POST',
        data: JsonSignData,
        success: function (data) { changeUserProvidedSignID(data) },
        error: function () { alert("Url Not Found") }
    });

}

function changeUserProvidedSignID(data) {
    var $li = ('<li class="sign">' + '<div class="signList">' + currentSign + '</div><div class="signList">' + data.PostLength + '</div><div class="signList">' + data.PostType + '</div></li>');
    $("#UserProvidedSignID").append($li);
}

function RemoveAll() {
    $('#UserProvidedSignID').empty();
}
