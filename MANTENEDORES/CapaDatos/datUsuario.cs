using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class datUsuario
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datUsuario _instancia = new datUsuario();
        //privado para evitar la instanciación directa
        public static datUsuario Instancia
        {
            get
            {
                return datUsuario._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////Login
        public entUsuario Login(String usuario, String password)
        {
            SqlCommand cmd = null;
            entUsuario u = new entUsuario();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SELECT IDUSUARIO, PASSWORD, ESTADO, USR_NOMBRES, USR_INCIALES, ES_ADMIN, SERIE_BOL, SERIE_FAC FROM USUARIO WHERE IDUSUARIO = @usuario AND PASSWORD = @password", cn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    u.IDUSUARIO = dr["IDUSUARIO"].ToString();
                    u.ESTADO = Convert.ToInt32(dr["ESTADO"]);
                    u.NOMBRE = dr["USR_NOMBRES"].ToString();
                    u.INICIALES = dr["USR_INCIALES"].ToString();
                    u.ADMIN = Convert.ToInt32(dr["ES_ADMIN"]);
                    u.SERIE_BOL = dr["SERIE_BOL"].ToString();
                    u.SERIE_FAC = dr["SERIE_FAC"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return u;
        }
        #endregion
    }
}
