var flag = false;//esta bandera es para el boton del menu.
$(document).ready(function () { //Esta funcion oculta el boton login cuando se hace tamaño movil
    $("#btnMenu").click(function () {
        if (flag)
            flag = false;
        else
            flag = true;
        $("#PanelLogin").hide();
        $("dropdown_Cabecera_Movil").hide();
    });
    $("#toggle_InicioSesion").click(function () {
        $("#PanelLogin").hide();
        $("#btn_InicioSesion").show();
    });
    $(window).resize(function () { //Esta funcion muestra el boton login cuando se hace tamaño escritorio
        var tamaño = $(window).width();
        if (tamaño > 767) {
            $("#btn_InicioSesion").show();
            $("#PanelLogin").show();
        }
    });
    // AGREGA DESPLIEGUE HACIA ABAJO ANIMACION A UN DROPDOWN //
    $('.dropdown').on('show.bs.dropdown', function (e) {
        $(this).find('.menuLogin').first().stop(true, true).slideDown();
    });
    // AGREGA DESPLIEGUE HACIA ARRIBA ANIMACION A UN DROPDOWN //
    $('.dropdown').on('hide.bs.dropdown', function (e) {
        $(this).find('.menuLogin').first().stop(true, true).slideUp();
    });
    /**
    *   La siguiente funcion se activa cuando das clic en el boton InicioSesion en version movil,
    *   Sirve para ocultar el menu colapsable.
    */

    $('#PanelLoginMin').on('click', function () {
        if (flag) {
            $('.navbar-toggle').click() //bootstrap 
        }
    });
    /**
    * La siguiente funcion hace que al poner enu un <html data-toogle="VARIABLE"/>
    * se active el tooltip depeniendo del texto que queramos poner.
    **/
    $(document).ready(function () {
        $('[data-toggle="tooltip"]').tooltip();
    });
});
