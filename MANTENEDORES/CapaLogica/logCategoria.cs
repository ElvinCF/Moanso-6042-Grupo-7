using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logCategoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCategoria _instancia = new logCategoria();
        //privado para evitar la instanciación directa
        public static logCategoria Instancia
        {
            get
            {
                return logCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entCategoria> ListarCategoria()
        {
            return datCategoria.Instancia.ListarCategoria();
        }
        //insertar
        
        public void InsertarCategoria(entCategoria cli)
        {
            datCategoria.Instancia.InsertarCategoria(cli);
        }
        //edita
        public void EditarCategoria(entCategoria Cli)
        {
            datCategoria.Instancia.EditarCategoria(Cli);
        }

        public void DeshabilitarCategoria(entCategoria Cli)
        {
            datCategoria.Instancia.DeshabilitarCategoria(Cli);

        }
       
        #endregion metodos
    }

}