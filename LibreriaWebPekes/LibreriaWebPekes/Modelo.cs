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
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
        public string TelMovil { get; set; }
        public string Fotografía { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
    public class Cliente
    {
        public int Identificador { get; set; }
        public string NombreContacto { get; set; }
        public string Categoria { get; set; }
        public Persona Persona { get; set; }
    }
    public class Empleado
    {
        public int Identificador { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Puesto { get; set; }
        public DateTime FechaEgreso { get; set; }
        public Persona Persona { get; set; }
    }
    public class Venta
    {
        public int Identificador { get; set; }
        public double Subtotal { get; set; }
        public double Descuento { get; set; }
        public double Impuestos { get; set; }
        public double Total { get; set; }
        public bool Liquidado { get; set; }
    }
    public class Pedido
    {
        public int Identificador { get; set; }
        public int Folio { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int Estado { get; set; }
        public Venta Venta { get; set; }

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
        public int Identificador { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public string AtributoExtra { get; set; }
        public bool Estatus { get; set; }
    }
    public class DetallesDePedido
    {
        public int Identificador_Pedido { get; set; }
        public int Identificador_Calzado { get; set; }
        public int Identificador_Estilo { get; set; }
        public string Suela { get; set; }
        public string Descuento { get; set; }
        public float Costo { get; set; }
        public XmlDocument Corrida { get; set; }
    }
    public class Credencial
    {
        public int Identificador { get; set; }
        public string Nombre { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public bool Estatus { get; set; }
        public int Identificador_Creador { get; set; }
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
}
