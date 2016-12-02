using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using pekes.conexion;
using System.Xml;
using System.Configuration;
using LibreriaWebPekes.Modelo;
using LibreriaWebPekes.Objeto;
/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
[System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    public WebService()
    {
        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

     [WebMethod]
    public Cliente ConsultaCliente(int Folio)
    {
        try
        {
            pekes.conexion.SqlConexion sql = new pekes.conexion.SqlConexion();
            bool conectar = sql.Conectar(pekes.estatic.ConnectionStatic.ReturnConectionString());
            List<SqlParameter> _Parametros = new List<SqlParameter>();
            _Parametros.Add(new SqlParameter("@FolioCliente", Folio));
            sql.PrepararProcedimiento("dbo.pa_Consulta_Cliente", _Parametros);
            DataTable _dt = sql.EjecutarTable();
            string Mensaje = string.Empty;
            DataTableReader dtr = _dt.CreateDataReader();
            while (dtr.Read())
            {
                Mensaje = dtr[0].ToString();
            }
            sql.Desconectar();
            sql.Dispose();
        }
        catch (Exception e)
        {
            string mensaje = e.Message;
        }
        Cliente cliente = new Cliente();
        return cliente;
    }
    [WebMethod]
    public Cliente ConsultaClienteNombre(string Nombre)
    {
        //Logica de base de datos
        Cliente cliente = new Cliente();
        return cliente;
    }
    [WebMethod]
    public EstadoRespuesta Acceso(string Nick, string Password)
    {
        SqlConexion sql = new SqlConexion();
        sql.Conectar(ConfigurationManager.ConnectionStrings["ServidorBD"].ToString());
        List<SqlParameter> _Parametros = new List<SqlParameter>();
        _Parametros.Add(new SqlParameter("@Nick", Nick));
        _Parametros.Add(new SqlParameter("@Pwd", Password));
        sql.PrepararProcedimiento("dbo.pa_AutenticarCredencial", _Parametros);
        DataTable _dt = sql.EjecutarTable();
        string Mensaje = string.Empty;
        DataTableReader dtr = _dt.CreateDataReader();
        while (dtr.Read())
        {
            Mensaje = dtr[0].ToString();
        }
        EstadoRespuesta state = new EstadoRespuesta();
        XmlDocument xdoc = new XmlDocument();
        XmlDocument xmlJava = new XmlDocument();
        xdoc.LoadXml(Mensaje);
        if (int.Parse(xdoc["Usuarios"]["Sesion"]["Valido"].InnerText) == 1)
        {
            state.estado = TiposEstado.Aceptado;
            state.sesionInformacion = new Sesion();
            state.sesionInformacion.identificador = int.Parse(xdoc["Usuarios"]["Sesion"]["SesionInfo"]["pk_IdSesion"].InnerText);
            state.sesionInformacion.token = xdoc["Usuarios"]["Sesion"]["SesionInfo"]["Token"].InnerText;
            state.mensaje = xdoc["Usuarios"]["Sesion"]["Mensaje"].InnerText;
            state.sesionInformacion.identificador_Credencial = int.Parse(xdoc["Usuarios"]["Sesion"]["SesionInfo"]["IdUsuario"].InnerText);
        }
        else
        {
            state.estado = TiposEstado.NoAceptado;
            state.mensaje = xdoc["Usuarios"]["Sesion"]["Mensaje"].InnerText;
        }
        sql.Desconectar();
        sql.Dispose();
        //XmlResponse xmlResponse = new XmlResponse();
        //xmlResponse.estadoRespuesta = state;
        return state;
    }

    [WebMethod(EnableSession = true)]
    public List<Calzado> GetAllCalzado()
    {
        SqlConexion sql = new SqlConexion();
        sql.Conectar(ConfigurationManager.ConnectionStrings["ServidorBD"].ToString());
        List<SqlParameter> _Parametros = new List<SqlParameter>();
        sql.PrepararProcedimiento("dbo.pa_java_ConsultaTodoElCalzado", _Parametros);
        DataTable _dt = sql.EjecutarTable();
        string Mensaje = string.Empty;
        List<Calzado> lista = new List<Calzado>();
        foreach (DataRow renglon in _dt.Rows)
        {
            Calzado c = new Calzado();
            c.codigo = (renglon["Codigo"].ToString());
            c.especificaciones = (renglon["Especificaciones"].ToString());
            c.estatus = int.Parse(renglon["Estatus"].ToString());
            c.identificador = int.Parse(renglon["pk_IdCalzado"].ToString());
            c.foto = "";
            c.marca = "";
            c.preciosXML = "";
            lista.Add(c);
        }
        /*
       XmlDocument xdoc = new XmlDocument();
       xdoc.LoadXml("<xml></xml>");

       for (int i = 0; i < 3; i++)
       {
           Calzado c = new Calzado();
           c.codigo = "Codigo";
           c.especificaciones = "Especificaiones";
           c.estatus = 1;
           c.foto = "";
           c.identificador = i;
           c.marca = "Pekes";
           c.preciosXML = xdoc;
           lista.Add(c);
       }*/
        return lista;
    }
    [WebMethod(EnableSession = true)]
    public void InsertarCalzado(Calzado calzado)
    {
        try
        {
            calzado = new Calzado();
            SqlConexion sql = new SqlConexion();
            sql.Conectar(ConfigurationManager.ConnectionStrings["ServidorBD"].ToString());
            List<SqlParameter> _Parametros = new List<SqlParameter>();
            _Parametros.Add(new SqlParameter("@Codigo", calzado.codigo));
            _Parametros.Add(new SqlParameter("@Especificaciones", calzado.especificaciones));
            _Parametros.Add(new SqlParameter("@Marca", calzado.marca));
            _Parametros.Add(new SqlParameter("@PreciosXML", calzado.preciosXML));
            _Parametros.Add(new SqlParameter("@Estatus", calzado.estatus));
            _Parametros.Add(new SqlParameter("@Foto_Codigo", ""));
            _Parametros.Add(new SqlParameter("@Foto_foto", ""));
            _Parametros.Add(new SqlParameter("@Foto_Descripcion", ""));
            sql.PrepararProcedimiento("dbo.pa_java_InsertarCalzado", _Parametros);
            DataTable _dt = sql.EjecutarTable();
            string Mensaje = string.Empty;
            DataTableReader dtr = _dt.CreateDataReader();
            while (dtr.Read())
            {
                Mensaje = dtr[0].ToString();
            }
            /* return new EstadoRespuesta()
             {
                 mensaje = Mensaje,
                 estado = TiposEstado.Aceptado,
             };*/
        }
        catch (Exception ex)
        {
            /* return new EstadoRespuesta()
             {
                 mensaje = ex.Message,
                 estado = TiposEstado.Error,
             };*/
        }
    }
}
