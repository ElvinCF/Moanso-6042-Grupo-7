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
    public class datProveedor
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProveedor _instancia = new datProveedor();
        //privado para evitar la instanciación directa
        public static datProveedor Instancia
        {
            get
            {
                return datProveedor._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entProveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            List<entProveedor> lista = new List<entProveedor>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedor Cli = new entProveedor();
                    Cli.ProveedorID = Convert.ToInt32(dr["ProveedorID"]);
                    Cli.CiudadID = Convert.ToInt32(dr["CiudadID"]);
                    Cli.Ruc = dr["Ruc"].ToString();
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.RazSocial = dr["RazSocial"].ToString();
                    Cli.Telefono = dr["Telefono"].ToString();
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(Cli);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;

        }   ///InsertarProveedor

        public Boolean InsertarProveedor(entProveedor Cli)
            {
                SqlCommand cmd = null;
                Boolean inserta = false;
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar();
                    cmd = new SqlCommand("spInsertaProveedor", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CiudadID", Cli.CiudadID);
                    cmd.Parameters.AddWithValue("Ruc", Cli.Ruc);
                    cmd.Parameters.AddWithValue("Nombre", Cli.Nombre);
                    cmd.Parameters.AddWithValue("@RazSocial", Cli.RazSocial);
                    cmd.Parameters.AddWithValue("Telefono", Cli.Telefono);
                    cmd.Parameters.AddWithValue("Direccion", Cli.Direccion);
                    cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
                    cn.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        inserta = true;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally { cmd.Connection.Close(); }
                return inserta;

        }
        public Boolean EditarProveedor(entProveedor Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Cli.ProveedorID);
                cmd.Parameters.AddWithValue("@CiudadID", Cli.CiudadID);
                cmd.Parameters.AddWithValue("@Ruc", Cli.Ruc);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@RazSocial", Cli.RazSocial);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@Direccion", Cli.Direccion);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }
        public Boolean DeshabilitarProveedor(entProveedor Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProveedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProveedorID", Cli.ProveedorID);
                //cmd.Parameters.AddWithValue("@Estado", Cat.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }
        #endregion metodos

    }
}
