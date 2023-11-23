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
    public class datVenta
    {
        #region singleton
        private static readonly datVenta _instancia = new datVenta();
        public static datVenta Instancia
        {
            get { return datVenta._instancia; }
        }
        #endregion singleton

        #region metodos

        public int InsertarVenta(entVenta Ped)
        {

            SqlCommand cmd = null;
            int idPed = 0;
            SqlTransaction transaction = null;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }
                transaction = cn.BeginTransaction();
                cmd = new SqlCommand("spInsertarVenta", cn, transaction);

                //cmd.Transaction= transaction;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", Ped.idCliente.ClienteID);
                cmd.Parameters.AddWithValue("@fechPedido", Ped.fechaVenta);
                cmd.Parameters.AddWithValue("@TotPedido", Ped.TotPedido);

                SqlParameter m = new SqlParameter("@retorno", DbType.Int32);
                m.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(m);

                cmd.ExecuteNonQuery();
                idPed = Convert.ToInt16(cmd.Parameters["@retorno"].Value);


                //insertarDetallePedido
                cmd = new SqlCommand("spInsertarDetPedido", cn, transaction);
                cmd.CommandType = CommandType.StoredProcedure;

                foreach (var item in Ped.DetPedidos)
                {
                    cmd.Parameters.AddWithValue("@idPedido", idPed);
                    cmd.Parameters.AddWithValue("@idProducto", item.idProducto.ProductosID);
                    cmd.Parameters.AddWithValue("@cantProducto", item.cantProducto);
                    cmd.Parameters.AddWithValue("@precProducto", item.precProducto);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();

                //cmd.Parameters.AddWithValue("@igv", dPed. );

            }
            catch (Exception e)
            {
                transaction.Rollback();
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return idPed;

        }
        #endregion

    }
}
