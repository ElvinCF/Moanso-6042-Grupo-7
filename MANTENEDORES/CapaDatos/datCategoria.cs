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
    public class datCategoria
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datCategoria _instancia = new datCategoria();
        //privado para evitar la instanciación directa
        public static datCategoria Instancia
        {
            get
            {
                return datCategoria._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entCategoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            List<entCategoria> lista = new List<entCategoria>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCategoria c = new entCategoria();
                    c.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    c.NombreCategoria = dr["NombreCategoria"].ToString();
                    c.Descripcion = dr["Descripcion"].ToString();
                    c.Estado = Convert.ToBoolean(dr["Estado"]);
                    lista.Add(c);
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

            
        }

        ///InsertarCategoria

        public Boolean InsertarCategoria(entCategoria Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCategoria", Cli.NombreCategoria);
                cmd.Parameters.AddWithValue("@Descripcion", Cli.Descripcion);
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
        public Boolean EditarCategoria(entCategoria Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
                cmd.Parameters.AddWithValue("@NombreCategoria", Cli.NombreCategoria);
                cmd.Parameters.AddWithValue("@Descripcion", Cli.Descripcion);
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
        public Boolean DeshabilitarCategoria(entCategoria Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
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
