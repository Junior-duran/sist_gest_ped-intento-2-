using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
    public class ProductoData
    {
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;";

        public Producto ObtenerProductoPorID(int productoId)
        {
            Producto producto = null;
            string query = "SELECT ProductoID, Nombre, Marca, Descripcion, Precio FROM Producto WHERE ProductoID = @ProductoID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductoID", productoId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                producto = new Producto
                                {
                                    ProductoID = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Marca = reader.GetString(2),
                                    Descripcion = reader.GetString(3),
                                    Precio = reader.GetDecimal(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el producto", ex);
            }

            return producto;
        }
    }
}

