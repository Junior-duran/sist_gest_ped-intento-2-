using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class ProdctoData
    {
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;"; // Reemplaza con tu cadena de conexión

        public string ObtenerNombreProducto(int productoId)
        {
            string nombreProducto = null;
            string query = "SELECT Nombre FROM Producto WHERE ProductoID = @ProductoID"; // Consulta SQL

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoId);
                        var resultado = cmd.ExecuteScalar(); // Ejecutar la consulta

                        if (resultado != null)
                        {
                            nombreProducto = resultado.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar el producto", ex);
            }

            return nombreProducto;
        }
    }
}
