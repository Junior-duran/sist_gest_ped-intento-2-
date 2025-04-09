using CapaNegocios;
using System.Data.SqlClient;
using CapaDatos;

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
        // Esta línea debe estar aquí (fuera de los métodos)
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;";

        public List<Producto> ObtenerTodosLosProductos()
        {
            List<Producto> productos = new List<Producto>();
            string query = "SELECT idProducto, Nombre, Marca, Descripcion, idProveedor, Precio FROM Producto";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productos.Add(new Producto(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetDecimal(4),
                                reader.GetDecimal(5)
                            ));
                        }
                    }
                }
            }

            return productos;
        }
    }


}
