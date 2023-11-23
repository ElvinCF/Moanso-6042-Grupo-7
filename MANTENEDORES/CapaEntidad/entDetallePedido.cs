using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entDetallePedido
    {
        public int idDetPedido { get; set; }
        public int idPedido { get; set; }
        public int cantProducto { get; set; }
        public Decimal precProducto { get; set; }
        public entProducto idProducto { get; set; }
    }
}
