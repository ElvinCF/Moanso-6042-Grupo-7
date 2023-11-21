using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProveedor
    {
        
            public int ProveedorID { get; set; }
            public int CiudadID { get; set; }

            public string Ruc { get; set; }
            public string Nombre { get; set; }
            public string RazSocial { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public Boolean Estado { get; set; }
        

    }
}
