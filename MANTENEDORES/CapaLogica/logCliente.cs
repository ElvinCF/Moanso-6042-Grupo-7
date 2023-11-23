using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado
        ///listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }
        //insertar

        public void InsertarCliente(entCliente cli)
        {
            datCliente.Instancia.InsertarCliente(cli);
        }
        //edita
        public void EditarCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }
        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);

        }
        public entCliente buscarCliente(int idCliente)
        {
            return datCliente.Instancia.buscarCliente(idCliente);
        }
        #endregion metodos

    }
}
