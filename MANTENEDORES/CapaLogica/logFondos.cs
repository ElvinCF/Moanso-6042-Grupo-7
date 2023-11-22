using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logFondos
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logFondos _instancia = new logFondos();
        //privado para evitar la instanciación directa
        public static logFondos Instancia
        {
            get
            {
                return logFondos._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ///listado

        public List<entFondos> Listarfondos()
        {
            return datFondos.Instancia.ListarFondos();
        }
        //insertar

        public void InsertarFondos(entFondos cli)
        {
            datFondos.Instancia.InsertarCapital(cli);
        }
        //edita
        public void EditarCapital(entFondos cli)
        {
            datFondos.Instancia.EditarCapital(cli);
        }

        public void DeshabilitarFondos(entFondos Cli)
        {
            datFondos.Instancia.DeshabilitarCapital(Cli);

        }

        #endregion metodos
    }
}
