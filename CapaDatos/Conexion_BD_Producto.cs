using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ProductoDatos
    {
        public class Producto
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public string Marca { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;"; // Reemplazar con tu cadena de conexión

        public Producto ObtenerProductoPorId(int idProducto)
        {
            string query = "SELECT Nombre, Marca, Descripcion, Precio FROM Producto WHERE idProducto = @idProducto";
            Producto producto = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idProducto", idProducto);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si se encuentra el producto
                            {
                                producto = new Producto
                                {
                                    IdProducto = idProducto,
                                    Nombre = reader["Nombre"].ToString(),
                                    Marca = reader["Marca"].ToString(),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Precio = Convert.ToDecimal(reader["Precio"])
                                };
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al obtener el producto: " + ex.Message);
                    }
                }
            }

            return producto;
        }
    }
}
