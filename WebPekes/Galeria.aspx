<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Galeria.aspx.cs" Inherits="Galeria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="css/toggleButton.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="col-xs-12 col-sm-3 col-md-3 col-lg-3">
        <nav class="hidden-xs visible-sm visible-lg visible-md" id="bs-navbar-escritorio-filtrar">
            <div class="list-group">
                <button class="list-group-item"><i class="fa fa-home fa-2x"></i>&nbsp;&nbsp;Plataforma</button>
                <button class="list-group-item"><i class="fa fa-book fa-2x"></i>&nbsp;&nbsp;Tacón</button>
                <button class="list-group-item"><i class="fa fa-bold fa-2x"></i>&nbsp;&nbsp;Bota</button>
                <button class="list-group-item"><i class="fa fa-cog fa-2x"></i>&nbsp;&nbsp;Sandalia</button>
                <button class="list-group-item"><i class="fa fa-adn fa-2x"></i>&nbsp;&nbsp;Mocasín</button>
            </div>
        </nav>
        <nav class="visible-xs hidden-sm hidden-lg hidden-md navbar-fixed-top" id="contenedorBarraBotonesFiltro">
            <div class="btn-group btn-group-justified">

                 <div class="btn-group">
                     <a id="btnPekes" href="#btnPekes" class="btn btn-default btn-filtro toggleSwitch">Pekes</a>
                 </div>
                 <div class="btn-group">
                     <a id="btnWI" href="#btnWI" class="btn btn-default btn-filtro toggleSwitch">Women Intuition</a>
                 </div>
                 <div class="btn-group">
                     <a id="btnPicolin" href="#btnPicolin" class="btn btn-default btn-filtro toggleSwitch">Picolin</a>
                 </div>
             </div>
             <div class="btn-group btn-group-justified">
                 <div class="btn-group">
                     <a id="btnPlataforma" href="#btnPlataforma" class="btn btn-default btn-filtro" data-toggle="tooltip" title="Plataforma" data-placement="bottom"><i class="fa fa-home" ></i></a>
                 </div>
                 <div class="btn-group">
                     <a id="btnTacon" href="#btnTacon" class="btn btn-default btn-filtro" data-toggle="tooltip" title="Tacón" data-placement="bottom"><i class="fa fa-book"></i></a>
                 </div>
                 <div class="btn-group">
                     <a id="btnBota" href="#btnBota" class="btn btn-default btn-filtro" data-toggle="tooltip" title="Bota" data-placement="bottom"><i class="fa fa-bold"></i></a>
                 </div>
                 <div class="btn-group">
                     <a id="btnSandalia" href="#btnSandalia" class="btn btn-default btn-filtro" data-toggle="tooltip" title="Sandalia" data-placement="bottom"><i class="fa fa-cog"></i></a>
                 </div>
                 <div class="btn-group">
                     <a id="btnMocasin" href="#btnMocasin" class="btn btn-default btn-filtro" data-toggle="tooltip" title="Mocasín" data-placement="bottom"><i class="fa fa-adn"></i></a>
                 </div>
             </div>
         </nav>

    </div>
    <section id="contenedorGaleria" class="col-xs-12 col-sm-9 col-md-9 col-lg-9">
        <div class="row" id="galeria">
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2" >
                <a class="thumbnail" href="#" >
                    <img class="img-responsive" src="http://placehold.it/400x300" alt=""/>
                </a>
                <div class="clear"></div>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#" data-toggle="modal" data-target="#modalImagen">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
            <div class="col-xs-3 col-sm-3 col-md-2 col-lg-2">
                <a class="thumbnail" href="#" data-toggle="modal" data-target="#modalImagen">
                    <img class="img-responsive" src="http://placehold.it/400x300" alt="" />
                </a>
            </div>
        </div>
    </section>
    <!--MODAL-->
    <div id="modalImagen" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title">>-Modelo Aqui-<</h4>
                </div>
                <div class="modal-body">
                    <img src="http://placehold.it/400x300" class="img-responsive" />
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-pekes">Anterior</button>
                    <button type="button" class="btn btn-pekes">Siguiente</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

