<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="container-fluid" id="sliderIndex">
        <br />
        <div id="myCarousel" class="carousel slide carousel-fade" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                <li data-target="#myCarousel" data-slide-to="1"></li>
            </ol>
            <!-- Wrapper for slides -->
            <div class="carousel-inner sliderIndex" role="listbox">
                <div class="item active">
                    <img src="img/index/Imagen1.jpg" alt="Imagen1" class="imagenSlider" />
                </div>
                <div class="item">
                    <img src="img/index/Imagen2.jpg" alt="Imagen2" class="imagenSlider" />
                </div>
            </div>
            <!-- Left and right controls -->
            <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </section>
    <br />
    <br />
    <section class="container-fluid">
        <article class="row">
            <div class="col-sm-4">
                <div class="thumbnail">
                    <a href="img/index/Imagen1.jpg">
                        <img src="img/index/Imagen1.jpg" alt="Moustiers Sainte Marie" style="height: 150px" />
                        <%--<div class="caption">
                        <p>Moustiers-Sainte-Marie: Considered as one of the "most beautiful villages of France".</p>
                    </div>--%>
                    </a>
                </div>
            </div>

            <div class="col-sm-4">
                <div class="thumbnail">
                    <a href="img/index/Imagen2.jpg">
                        <img src="img/index/Imagen2.jpg" alt="Cinque Terre" style="height: 150px" />
                        <%--<div class="caption">
                        <p>The Cinque Terre: A rugged portion of coast in the Liguria region of Italy.</p>
                    </div>--%>
                    </a>
                </div>
            </div>
            <div class="col-sm-4">
                <!--col-sm-4-->
                <a href="img/index/Imagen1.jpg" class="thumbnail">
                    <img src="img/index/Imagen1.jpg" alt="Pulpit Rock" style="height: 150px" />
                    <%--<div class="caption">
                    <p>Pulpit Rock: A famous tourist attraction in Forsand, Ryfylke, Norway.</p>
                </div>--%>
                </a>
            </div>
        </article>
    </section>
</asp:Content>

