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
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                   
                    Cli.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    Cli.DNI = dr["DNI"].ToString();
                    Cli.MetodoPagoID = Convert.ToInt32(dr["MetodoPagoID"]);
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.Direccion = dr["Direccion"].ToString();
                    Cli.Telefono = dr["Telefono"].ToString();
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

        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("MetodopagoID", Cli.MetodoPagoID);
                cmd.Parameters.AddWithValue("Nombre", Cli.Nombre);
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
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@MetodopagoID", Cli.MetodoPagoID);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
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
        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClienteID", Cli.ClienteID);
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
        public entCliente buscarCliente(int idCliente)
        {
            SqlCommand cmd = null;
            entCliente c = new entCliente();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmIdCliente", idCliente);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    c.ClienteID = Convert.ToInt32(dr["ClienteID"]);
                    c.DNI = dr["DNI"].ToString();
                    c.Nombre = dr["Nombre"].ToString();
                    c.Direccion = dr["Direccion"].ToString();
                    c.Telefono = (dr["Telefono"].ToString());
                    c.Estado = Convert.ToBoolean(dr["Estado"]);

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
            return c;


        }
        #endregion metodos
    }
}
