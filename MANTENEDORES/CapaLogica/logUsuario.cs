using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUsuario _instancia = new logUsuario();
        //privado para evitar la instanciación directa
        public static logUsuario Instancia
        {
            get
            {
                return logUsuario._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public entUsuario Login(String usuario, String password)
        {
            return datUsuario.Instancia.Login(usuario, password);
        }
        #endregion
    }
}
