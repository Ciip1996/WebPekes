using LibreriaWebPekes.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaWebPekes.Objeto
{
    public class XmlResponse
    {
        public EstadoRespuesta estadoRespuesta { get; set; }
    }
    public class EstadoRespuesta
    {
        public TiposEstado estado { get; set; }
        public string mensaje { get; set; }
        public Sesion sesionInformacion { get; set; }
    }
    public enum TiposEstado : int
    {
        Aceptado = 1,
        NoAceptado = 2,
        Nada = 0,
        Error = -1
    }
}
