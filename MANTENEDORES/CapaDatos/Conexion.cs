using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-VN4K60G; Initial Catalog = SistemadeVentas;" +//"User ID=sa; Password = 123";
            "Integrated Security=true";

            return cn;
        }

    }
}
