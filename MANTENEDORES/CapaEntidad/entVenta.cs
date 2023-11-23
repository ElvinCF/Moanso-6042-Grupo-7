using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entVenta
    {
        public int VentaId { get; set; }
        public DateTime fechaVenta { get; set; }

        public entCliente idCliente { get; set; }

        public double TotPedido { get; set; }

        public List<entDetallePedido> DetPedidos { get; set; }
    }
}
