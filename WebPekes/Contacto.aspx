<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contacto.aspx.cs" Inherits="Contacto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <section class="row">
        <article class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <form class="form-horizontal form-contacto">
                <div class="form-group">
                    <label class="control-label col-sm-5" for="email">Correo Electronico:</label>
                    <div class="col-sm-7">
                        <input type="email" class="form-control" id="email" placeholder="correo@ejemplo.com" />
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5" for="pwd">Datos Personales:</label>
                    <div class="col-sm-7">
                        <div>
                            <input id="txtNombre" type="text" placeholder="Escriba sus Nombre(s)" class="form-control" />
                        </div>
                        <div>
                            <input id="txtApellidos" type="text" placeholder="Escriba sus Apellidos(s)" class="form-control" />
                        </div>
                        <div>
                            <select name="estados" class="form-control">
                                <option value="0">Seleccione un Estado*</option>
                                <option value="1">Aguascalientes</option>
                                <option value="2">Baja California</option>
                                <option value="3">Baja California Sur</option>
                                <option value="4">Campeche</option>
                                <option value="5">Coahuila de Zaragoza</option>
                                <option value="6">Colima</option>
                                <option value="7">Chiapas</option>
                                <option value="8">Chihuahua</option>
                                <option value="9">Distrito Federal</option>
                                <option value="10">Durango</option>
                                <option value="11">Guanajuato</option>
                                <option value="12">Guerrero</option>
                                <option value="13">Hidalgo</option>
                                <option value="14">Jalisco</option>
                                <option value="15">México</option>
                                <option value="16">Michoacán de Ocampo</option>
                                <option value="17">Morelos</option>
                                <option value="18">Nayarit</option>
                                <option value="19">Nuevo León</option>
                                <option value="20">Oaxaca</option>
                                <option value="21">Puebla</option>
                                <option value="22">Querétaro</option>
                                <option value="23">Quintana Roo</option>
                                <option value="24">San Luis Potosí</option>
                                <option value="25">Sinaloa</option>
                                <option value="26">Sonora</option>
                                <option value="27">Tabasco</option>
                                <option value="28">Tamaulipas</option>
                                <option value="29">Tlaxcala</option>
                                <option value="30">Veracruz de Ignacio de la Llave</option>
                                <option value="31">Yucatán</option>
                                <option value="32">Zacatecas</option>
                            </select>
                        </div>
                        <div>
                            <input id="txtCiudad" type="text" placeholder="Ciudad" class="form-control" />
                        </div>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-5" for="pwd">Si tiene alguna duda haganos saber:</label>
                    <div class="col-sm-7">
                        <textarea id="txtMensaje" placeholder="Escriba un mensaje, pregunta o comentario aqui." class="form-control"></textarea>
                    </div>
                    <br />
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <button type="submit" class="btn btn-pekes pull-right">Enviar</button>
                    </div>
                </div>
            </form>
        </article>
        <article class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="container-fluid" style="text-align:center">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d232.61453807180592!2d-101.69824850662673!3d21.119238702687923!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x842bbf79a81dd7d9%3A0x913679e13daaef1!2sBlvrd+Algeciras+604%2C+Arbide%2C+37360+Le%C3%B3n%2C+Gto.!5e0!3m2!1ses!2smx!4v1480358929642" id="mapa"></iframe>
            </div>
        </article>
    </section>
</asp:Content>

