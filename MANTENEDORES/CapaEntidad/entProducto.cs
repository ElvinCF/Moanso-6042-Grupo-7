using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entProducto
    {
        public int ProductosID { get; set; }
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int Precio { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public Boolean Estado { get; set; }
    }
}
