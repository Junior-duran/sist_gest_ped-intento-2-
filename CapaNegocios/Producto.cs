using CapaNegocios;
using System.Data.SqlClient;

public class Producto : IEntidad
{
    public int Id { get; set; } // ID del producto
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Descripcion { get; set; }
    public decimal IdProveedor { get; set; }
    public decimal Precio { get; set; }

    // Constructor
    public Producto(int id, string nombre, string marca, string descripcion, decimal idProveedor, decimal precio)
    {
        Id = id;
        Nombre = nombre;
        Marca = marca;
        Descripcion = descripcion;
        IdProveedor = idProveedor;
        Precio = precio;
    }

    // Método ToString para mostrar la información del producto
    public override string ToString()
    {
        return $"📦 PRODUCTO ENCONTRADO\n" +
               $"ID: {Id}\n" +
               $"Nombre: {Nombre}\n" +
               $"Marca: {Marca}\n" +
               $"Descripción: {Descripcion}\n" +
               $"Precio: {Precio:C}";
    }

    public class ProductoData
    {
        public string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;"; // Cadena de conexión

        // Método que obtiene los detalles del producto por su ID
        public Producto ObtenerProductoPorID(int idProducto)
        {
            Producto producto = null;
            string query = "SELECT idProducto, Nombre, Marca, Descripcion, Precio FROM Producto WHERE idProducto = @idProducto";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Abrir conexión
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idProducto", idProducto); // Parámetro para el ID del producto
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si se encuentra un producto con el ID dado
                        if (reader.Read())
                        {
                            producto = new Producto(
                         reader.GetInt32(0),  // idProducto
                         reader.GetString(1),  // Nombre
                         reader.GetString(2),  // Marca
                         reader.GetString(3),  // Descripcion
                         reader.GetInt32(4),   // idProveedor (esto es un ejemplo, si tu consulta tiene idProveedor)
                         reader.GetDecimal(5)  // Precio
                            );


                        }
                    }
                }
            }

            return producto; // Retornar el producto encontrado
        }
    }
}
