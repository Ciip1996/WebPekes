var flag = 0;
var Generica = {
    ObtenerCookie: function () {
        var cookieJson = JSON.parse($.cookie('Verificador'));
        return cookieJson;
    },
    ValidarCookie: function () {
        if ($.cookie('MiPrimeraCookieISSC') == null) {
             alert("No hay cookies");
            return false;
        } else {
            return true;
        }
    },
    ValidarSesion: function () {
        if ($.cookie('Verificador') != null)
        {
            var Token = this.ObtenerCookie().Token;
            var Id = this.ObtenerCookie().Credencial;
            $.ajax({
                url: "WebService.asmx/ValidarToken",
                data: "{'Id':'" + Id + "','Token':'" + Token + "'}",
                dataType: "json",
                type: "POST",
                contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
                success: function (msg) {
                    if (msg.d.Estado == 1) {
                        if (window.location.pathname == '/WebSiteMP/Login.aspx') {
                            alert("Ya existe una sesion inicidada. Si gusta cambiar de sesion cierre sesion primero.");
                            window.location.href = "BuscarProducto.aspx"
                        }
                        else {

                        }
                    }
                    else if (msg.d.Estado == 0) {
                        alert('El token de el explorador no coincide con ninguna sesion en la base de datos');
                        var cookies = document.cookie.split(";");
                        for (var i = 0; i < cookies.length; i++) {
                            var equals = cookies[i].indexOf("=");
                            var name = equals > -1 ? cookies[i].substr(0, equals) : cookies[i];
                            document.cookie = name + "=;expires=Thu, 01 Jan 1970 00:00:00 GMT";
                        }
                        window.location.href = "Login.aspx";
                    }
                    else {
                        alert('Error al intentar validar su sesion. Vuelva a loggearse');
                        Generica.CerrarSesion();
                    }
                },
                error: function (result) {
                    alert("ERROR " + result.status + ' ' + result.statusText);
                    Generica.CerrarSesion();
                }
            });
        }
        else {
            if (window.location.pathname != '/Login.aspx') {
                window.location.href = '/Login.aspx';
                alert("No tiene permiso para acceder de esta manera. Favor de Iniciar Sesion primero.");
            }
        }
    },
    /*,
    ValidarSesion: function (stringJsonSESION) {
        $.ajax({
            url: "http://localhost:89/WebSiteRepaso/WebServiceB.asmx/MandarValidarSesionBusqueda",
            data: "{'sesion': " + stringJsonSESION + "}",
            dataType: "json",
            type: "POST",
            contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
            success: function (msg) {
                debugger;
                if (msg.d == 1) {
                    return true;
                }
                else if (msg.d == 0) {
                    $.removeCookie('MiPrimeraCookieISSC', { expires: 1, path: '/' });
                    window.location.href = "Login.aspx";
                }
                else {
                    $.removeCookie('MiPrimeraCookieISSC', { expires: 1, path: '/' });
                    window.location.href = "Login.aspx";
                }
            },
            error: function (result) {
                alert("ERROR " + result.status + ' ' + result.statusText);
                $.removeCookie('MiPrimeraCookieISSC', { expires: 1, path: '/' });
                window.location.href = "Login.aspx";
            }
        });
    }*/
    CerrarSesion: function () {
        //update sesion en base de datos
        var Token = this.ObtenerCookie().Token;
        $.ajax({
            url: "WebService.asmx/CerrarSesion",
            data: "{'Token':'" + Token + "'}",
            dataType: "json",
            type: "POST",
            contentType: "application/json; utf-8",//este es el estandar universal de los navegadores web
            success: function (msg) {
                if (msg.d == 1) {
                    $.removeCookie('MiPrimeraCookieISSC', { expires: 1, path: '/' });
                    $.removeCookie('Verificador', { expires: 1, path: '/' });

                    window.location.href = "Login.aspx";
                }
                else if (msg.d == 0) {
                    alert('No hay conexion para cerrar sesion');
                }
                else {
                    alert('Error al para cerrar sesion');
                }
            },
            error: function (result) {
                alert("ERROR " + result.status + ' ' + result.statusText);
            }
        });
        //Eliminar cookie que contiene info de sesion 
    },
    MostrarLinkPedidos: function () {
        var valor = this.ValidarCookie();
        if (valor) {
            $(".linkPedidos").show();
        }
        else {
            $(".linkPedidos").hide();
        }
    }
};