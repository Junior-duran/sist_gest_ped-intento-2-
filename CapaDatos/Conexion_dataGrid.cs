using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    class Conexion_dataGrid
    {
        public class ProductoData
        {
            private string connectionString = "Server=.;Sist_Gest_Ventas=;Trusted_Connection=True;";

            public DataTable ObtenerProducto()
            {
                DataTable tabla = new DataTable();

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Producto";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        adaptador.Fill(tabla);
                    }
                }

                return tabla;
            }
        }
    }
}
