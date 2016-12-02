using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de LoginStatic
/// </summary>
/// 
namespace pekes.estatic
{
    public class ConnectionStatic
    {
        public static string ReturnConectionString()
        {
            return ConfigurationManager.ConnectionStrings["ServidorBD"].ToString();//el servidorBD uno lo confugura como quiera
        }
    }

}