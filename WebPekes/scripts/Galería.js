var Galeria = {
    cargarGaleria: function () {
        $.ajax({
            url: "WebService.asmx/cargarGalería",
            data: datos,
            dataType: "json",
            type: "POST",
            contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
            success: function (msg) {
                if (msg.d.Estado == 1) {
                    var strToken = msg.d.SesionInformacion.Token;
                    var IdCredencial = msg.d.SesionInformacion.IdentificadorCredencial;
                    var JSONToken = { Token: strToken, Credencial: IdCredencial } //esta es la chida
                    $.cookie('Verificador', JSON.stringify(JSONToken), {
                        expires: 1, path: '/'
                    });//Hasta aqui todo bien
                    var cookieJson = JSON.parse($.cookie('Verificador'));
                    var token_ = cookieJson.Token;
                    var IdCredencial_ = cookieJson.Credencial;
                    $.cookie('MiPrimeraCookieISSC', strToken, { expires: 1, path: '/' });//creo la cookie
                    window.location.href = "BuscarProducto.aspx";
                }
                else {
                    alert('Error al autenticarse');
                }
            },
            error: function (result) {
                alert("ERROR " + result.status + ' ' + result.statusText);
            }
        });
    }
};
