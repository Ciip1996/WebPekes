using LibreriaWebPekes.Conexion;
using LibreriaWebPekes.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Manejadores
/// </summary>
public class ManejadorVenta
{
    public List<Venta> getAllVentas()
    {
        List<Venta> ventas = new List<Venta>();

        Venta venta = new Venta();

        string cadena = ConfigurationManager.ConnectionStrings["ServidorBD"].ConnectionString;

        SqlConexion sql = new SqlConexion();

        List<SqlParameter> lstParametros = new List<SqlParameter>();

        try
        {
            sql.Conectar(cadena);

            sql.PrepararProcedimiento("dbo.pa_java_ConsultarVentas_PorNombreCliente", lstParametros);


            DataTable dt = sql.EjecutarTable();

            foreach (DataRow row in dt.Rows)
            {
                venta = new Venta();
                Cliente cliente = new Cliente();
                venta.identificador = int.Parse(row["pk_IdVenta"].ToString());
                venta.subtotal = Double.Parse(row["Subtotal"].ToString());
                venta.descuento = Double.Parse(row["Descuento"].ToString());
                venta.impuestos = Double.Parse(row["Impuestos"].ToString());
                venta.total = Double.Parse(row["Total"].ToString());
                venta.liquidado = int.Parse(row["Liquidado"].ToString());
                cliente.nombreContacto = row["NombreContacto"].ToString();
                cliente.folioCliente = row["FolioCliente"].ToString();
                venta.cliente = cliente;
                ventas.Add(venta);
            }


        }
        catch (Exception ex)
        {
            ex.StackTrace.ToString();
        }


        sql.Desconectar();
        sql.Dispose();

        return ventas;
    }
    public List<Venta> getVentasByClientName()
    {
        List<Venta> ventas = new List<Venta>();

        Venta venta = new Venta();

        string cadena = ConfigurationManager.ConnectionStrings["ServidorBD"].ConnectionString;

        SqlConexion sql = new SqlConexion();

        List<SqlParameter> lstParametros = new List<SqlParameter>();

        try
        {
            sql.Conectar(cadena);

            sql.PrepararProcedimiento("dbo.pa_java_ConsultarVentas", lstParametros);

            lstParametros.Add(new SqlParameter("@NombreContacto", venta.cliente.nombreContacto));
            DataTable dt = sql.EjecutarTable();

            foreach (DataRow row in dt.Rows)
            {
                venta = new Venta();
                Cliente cliente = new Cliente();
                venta.identificador = int.Parse(row["pk_IdVenta"].ToString());
                venta.subtotal = Double.Parse(row["Subtotal"].ToString());
                venta.descuento = Double.Parse(row["Descuento"].ToString());
                venta.impuestos = Double.Parse(row["Impuestos"].ToString());
                venta.total = Double.Parse(row["Total"].ToString());
                venta.liquidado = int.Parse(row["Liquidado"].ToString());
                cliente.nombreContacto = row["NombreContacto"].ToString();
                cliente.folioCliente = row["FolioCliente"].ToString();
                venta.cliente = cliente;
                ventas.Add(venta);
            }


        }
        catch (Exception ex)
        {
            ex.StackTrace.ToString();
        }


        sql.Desconectar();
        sql.Dispose();

        return ventas;
    }
}

public class ManejadorGaleria
{
    public List<Galeria> getAllGalerias()
    {
        List<Galeria> galerias = new List<Galeria>();

        Galeria galeria = new Galeria();

        string cadena = ConfigurationManager.ConnectionStrings["ServidorBD"].ConnectionString;

        SqlConexion sql = new SqlConexion();

        List<SqlParameter> lstParametros = new List<SqlParameter>();

        try
        {
            sql.Conectar(cadena);

            sql.PrepararProcedimiento("dbo.pa_java_ConsultarGaleria", lstParametros);


            DataTable dt = sql.EjecutarTable();

            foreach (DataRow row in dt.Rows)
            {
                galeria = new Galeria();
                Cliente cliente = new Cliente();
                galeria.identificador = int.Parse(row["pk_IdGaleria"].ToString());
                galeria.codigo = row["Codigo"].ToString();
                galeria.descripcion = row["Descripcion"].ToString();
                galeria.foto = row["Foto"].ToString();
                galeria.status = int.Parse(row["Estatus"].ToString());

                galerias.Add(galeria);
            }


        }
        catch (Exception ex)
        {
            ex.StackTrace.ToString();
        }


        sql.Desconectar();
        sql.Dispose();

        return galerias;
    }
    public void insertGaleria(Galeria galeria)
    {


        string cadena = ConfigurationManager.ConnectionStrings["ServidorBD"].ConnectionString;

        SqlConexion sql = new SqlConexion();

        List<SqlParameter> lstParametros = new List<SqlParameter>();
        lstParametros.Add(new SqlParameter("@Codigo", galeria.codigo));
        lstParametros.Add(new SqlParameter("@Descripcion", galeria.descripcion));
        lstParametros.Add(new SqlParameter("@Foto", galeria.foto));
        lstParametros.Add(new SqlParameter("@Estatus", galeria.status));
        try
        {
            sql.Conectar(cadena);

            sql.PrepararProcedimiento("dbo.pa_InsertarFotografia", lstParametros);
            sql.EjecutarProcedimiento();

        }
        catch (Exception ex)
        {
            ex.StackTrace.ToString();
        }


        sql.Desconectar();
        sql.Dispose();
    }
    public void updateGaleria(Galeria galeria)
    {


        string cadena = ConfigurationManager.ConnectionStrings["ServidorBD"].ConnectionString;

        SqlConexion sql = new SqlConexion();

        List<SqlParameter> lstParametros = new List<SqlParameter>();
        lstParametros.Add(new SqlParameter("@Identificador", galeria.identificador));
        lstParametros.Add(new SqlParameter("@Codigo", galeria.codigo));
        lstParametros.Add(new SqlParameter("@Foto", galeria.foto));
        lstParametros.Add(new SqlParameter("@Descripcion", galeria.descripcion));
        lstParametros.Add(new SqlParameter("@Estatus", galeria.status));
        try
        {
            sql.Conectar(cadena);

            sql.PrepararProcedimiento("dbo.pa_java_ActualizarGaleria", lstParametros);
            sql.EjecutarProcedimiento();

        }
        catch (Exception ex)
        {
            ex.StackTrace.ToString();
        }


        sql.Desconectar();
        sql.Dispose();
    }
}
