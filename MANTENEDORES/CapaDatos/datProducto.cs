using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class datProducto
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly datProducto _instancia = new datProducto();
        //privado para evitar la instanciación directa
        public static datProducto Instancia
        {
            get
            {
                return datProducto._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto c = new entProducto();
                    c.ProductosID = Convert.ToInt32(dr["ProductosID"]);
                    c.CategoriaID = Convert.ToInt32(dr["CategoriaID"]);
                    c.Nombre = dr["Nombre"].ToString();
                    c.Descripcion = dr["Descripcion"].ToString();
                    c.Stock = Convert.ToInt32(dr["Stock"]);
                    c.Precio = Convert.ToInt32(dr["Precio"]);
                    c.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);
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

        public Boolean InsertarProducto(entProducto Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Cli.Descripcion);
                cmd.Parameters.AddWithValue("@Stock", Cli.Stock);
                cmd.Parameters.AddWithValue("@Precio", Cli.Precio);
                cmd.Parameters.AddWithValue("@FechaVencimiento", Cli.FechaVencimiento);
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
        
            public Boolean EditarProducto(entProducto Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditaProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductosID", Cli.ProductosID);
                cmd.Parameters.AddWithValue("@CategoriaID", Cli.CategoriaID);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Cli.Descripcion);
                cmd.Parameters.AddWithValue("@Stock", Cli.Stock);
                cmd.Parameters.AddWithValue("@Precio", Cli.Precio);
                cmd.Parameters.AddWithValue("@FechaVencimiento", Cli.FechaVencimiento);
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
        public Boolean DeshabilitarProducto(entProducto Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductosID", Cli.ProductosID);
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
        public entProducto buscarProducto(int idProducto)
        {
            SqlCommand cmd = null;
            entProducto c = new entProducto();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spBuscarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductosID", idProducto);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    c.ProductosID = Convert.ToInt32(dr["ProductoID"]);
                    c.Nombre = dr["Nombre"].ToString();
                    c.Stock = Convert.ToInt32(dr["Stock"]);
                    c.FechaVencimiento = Convert.ToDateTime(dr["FechaVencimiento"]);


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



