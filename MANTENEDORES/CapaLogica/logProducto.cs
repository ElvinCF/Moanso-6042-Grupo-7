using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logProducto _instancia = new logProducto();
        //privado para evitar la instanciación directa
        public static logProducto Instancia
        {
            get
            {
                return logProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }
        //insertar

        public void InsertarProducto(entProducto cli)
        {
            datProducto.Instancia.InsertarProducto(cli);
        }
        //edita
        public void EditarProducto(entProducto Cli)
        {
            datProducto.Instancia.EditarProducto(Cli);
        }

        public void DeshabilitarProducto(entProducto Cli)
        {
            datProducto.Instancia.DeshabilitarProducto(Cli);

        }
        public entProducto buscarProducto(int idProducto)
        {
            return datProducto.Instancia.buscarProducto(idProducto);
        }

        #endregion metodos
    }
}
