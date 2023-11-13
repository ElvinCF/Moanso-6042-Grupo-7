using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProveedor _instancia = new logProveedor();
        //privado para evitar la instanciación directa
        public static logProveedor Instancia
        {
            get
            {
                return logProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        ///listado

        public List<entProveedor> ListarProveedor()
        {
            return datProveedor.Instancia.ListarProveedor();
        }
        //insertar

        public void InsertarProveedor(entProveedor cli)
        {
            datProveedor.Instancia.InsertarProveedor(cli);
        }
        //edita
        public void EditarProveedor(entProveedor Cli)
        {
            datProveedor.Instancia.EditarProveedor(Cli);
        }
        public void DeshabilitarProveedor(entProveedor Cli)
        {
            datProveedor.Instancia.DeshabilitarProveedor(Cli);

        }
        #endregion metodos
    }
}
