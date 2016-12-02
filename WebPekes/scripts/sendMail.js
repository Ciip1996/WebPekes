jQuery(document).ready(function () {
    $('#btnEnviar').click(function () {
        var prmCorreo = $('#txtCorreo').val == null ? "" : $('#txtCorreo').val();
        var prmAsunto = $('#txtAsunto').val == null ? "" : $('#txtAsunto').val();
        var prmBody = $('#txtBody').val == null ? "" : $('#txtBody').val();
        if(prmCorreo != "" && prmAsunto != "" && prmBody != "" ){
            EnviarCorreo(prmCorreo, prmAsunto, prmBody);
        }
        else {
            debugger;
            $('#TextoModal').empy();
            $('#TextoModal').append("Falta un dato por capturar");
        }
    });
});


function EnviarCorreo(prmCorreo, prmAsunto, prmBody) {
    for (var i = 0; i < 1; i++) {
        EnviarCorreoAjax(prmCorreo, prmAsunto + " " + i, prmBody + " " + i);
    }
}
function EnviarCorreoAjax(prmCorreo, prmAsunto, prmBody) {
    var objJson = {
        "Correo": prmCorreo,
        "Asunto": prmAsunto,
        "Body": prmBody
    };
    var stringJsonMAIL = JSON.stringify(objJson);
    $.ajax({
        url: "WebService.asmx/enviarCorreo",
        data: "{'Correo': " + stringJsonMAIL + "}",
        dataType: "json",
        type: "POST",
        contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
        success: function (msg) {
            if (msg.d = true) {
                $('#txtCorreo').empty();
                $('#txtAsunto').empty();
                $('#txtBody').empty();
                $('#TextoModal').empty();
                $('#TextoModal').append("Correo Enviado");
            }
            else {
                alert('Error ');
            }
        },
        error: function (result) {
            alert("ERROR " + result.status + ' ' + result.statusText);
        }
    });
}