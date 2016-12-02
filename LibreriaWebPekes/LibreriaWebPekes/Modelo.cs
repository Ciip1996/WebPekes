using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibreriaWebPekes.Modelo
{
    public class Persona
    {
        public int identificador { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string rfc { get; set; }
        public string curp { get; set; }
        public string domicilio { get; set; }
        public string ciudad { get; set; }
        public string email { get; set; }
        public string telMovil { get; set; }
        public string fotografía { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
    public class Cliente
    {
        public int identificador { get; set; }
        public string folioCliente { get; set; }
        public string nombreContacto { get; set; }
        public string categoria { get; set; }
        public Persona persona { get; set; }
    }
    public class Empleado
    {
        public int identificador { get; set; }
        public DateTime fechaIngreso { get; set; }
        public string puesto { get; set; }
        public DateTime fechaEgreso { get; set; }
        public Persona persona { get; set; }
    }
    public class Venta
    {
        public int identificador { get; set; }
        public double subtotal { get; set; }
        public double descuento { get; set; }
        public double impuestos { get; set; }
        public double total { get; set; }
        public int liquidado { get; set; }
        public Cliente cliente { get; set; }
    }
    public class Pedido
    {
        public int identificador { get; set; }
        public int folio { get; set; }
        public DateTime fechaSolicitud { get; set; }
        public DateTime fechaEntrega { get; set; }
        public int estado { get; set; }
        public Venta venta { get; set; }

    }
    public class Calzado
    {
        public int identificador { get; set; }
        public string codigo { get; set; }
        public string marca { get; set; }
        public string especificaciones { get; set; }
        public string foto { get; set; }
        public string preciosXML { get; set; }
        public int estatus { get; set; }
    }
    public class Estilo
    {
        public int identificador { get; set; }
        public string material { get; set; }
        public string color { get; set; }
        public string atributoExtra { get; set; }
        public bool estatus { get; set; }
    }
    public class DetallesDePedido
    {
        public int identificador_Pedido { get; set; }
        public int identificador_Calzado { get; set; }
        public int identificador_Estilo { get; set; }
        public string suela { get; set; }
        public string descuento { get; set; }
        public float costo { get; set; }
        public XmlDocument corrida { get; set; }
    }
    public class Credencial
    {
        public int identificador { get; set; }
        public string nombre { get; set; }
        public string nick { get; set; }
        public string password { get; set; }
        public bool estatus { get; set; }
        public int identificador_Creador { get; set; }
    }
    public class Sesion
    {
        public int identificador { get; set; }
        public int identificador_Credencial { get; set; }
        public string token { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime ultimaActividad { get; set; }
        public DateTime fechaFinal { get; set; }
        public bool estatus { get; set; }
    }
    public class Galeria
    {
        public int identificador { get; set; }
        public String codigo { get; set; }
        public String foto { get; set; }
        public String descripcion { get; set; }
        public int status { get; set; }
    }
}
