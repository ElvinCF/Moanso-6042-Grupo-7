using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entFondos
    {
        public int FondosID { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
        public Boolean Estado { get; set; }
    }
}
