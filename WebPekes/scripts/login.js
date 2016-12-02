function Logearse() {
    var tamaño = $(window).width();
    /*Obtengo el tamaño de la ventana para evaluar si es movil o de 
        escritorio y tomar los valores de un panel u otro.*/
    if (tamaño < 767) {//si es verdadero es movil
        var nick = $('#txtUsuarioMovil').val();
        //  var pwd = hex_sha1($('#txtContraseñaEscritorio').val());
        var pwd = $('#txtContraseñaMovil').val();
    }
    else {//es escritorio 
        var nick = $('#txtUsuarioEscritorio').val();
        // var pwd = hex_sha1($('#txtUsuarioEscritorio').val());
        var pwd = $('#txtContraseñaEscritorio').val();
    }
    var datos = "{'Nick': '" + nick + "','Password': '" + pwd + "'}";//JSON para enviarlo a el webservice
        //Aqui se introduce la cadena de conexion ajax para el web service
        $.ajax({
            url: "WebService.asmx/Acceso",
            data: datos,
            dataType: "json",
            type: "POST",
            contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
            success: function (msg) {

                if (msg.d.estado == 1) {
                    var strToken = msg.d.sesionInformacion.token;
                    var IdCredencial = msg.d.sesionInformacion.identificador_Credencial;
                    var JSONToken = { Token: strToken, Credencial: IdCredencial }
                    $.cookie('Verificador', JSON.stringify(JSONToken), {
                        expires: 1, path: '/'
                    });
                    var cookieJson = JSON.parse($.cookie('Verificador'));
                    var token_ = cookieJson.Token;
                    var IdCredencial_ = cookieJson.Credencial;
                    $.cookie('MiPrimeraCookieISSC', strToken, { expires: 1, path: '/' });//creo la cookie
                    window.location.reload();
                    alert('Se ha iniciado sesion correctamente');
                }
                else {
                    alert('Error al autenticarse');
                }
            },
            error: function (result) {
                alert("ERROR " + result.status + ' ' + result.statusText);
            }
        });
};