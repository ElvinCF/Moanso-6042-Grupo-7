using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logVenta
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logVenta _instancia = new logVenta();
        //privado para evitar la instanciación directa
        public static logVenta Instancia
        {
            get
            {
                return logVenta._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public int InsertarVenta(entVenta Ped)
        {
            return datVenta.Instancia.InsertarVenta(Ped);
        }
        #endregion
    }
}
