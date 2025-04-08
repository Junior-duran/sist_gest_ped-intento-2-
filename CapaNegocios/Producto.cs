using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using CapaNegocios;

namespace ENT
{
    public class Producto : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public int IdProveedor { get; set; }
        public decimal Precio { get; set; }
        public int IdProducto { get; set; }

        public Producto(int id, string nombre, string marca, string descripcion, int idProveedor, int idProducto)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Descripcion = descripcion;
            IdProveedor = idProveedor;
            IdProducto = idProducto;
        }

        public override string ToString()
        {
            return $"Producto: {Nombre}, Marca: {Marca}, Descripción: {Descripcion}, Proveedor ID: {IdProveedor}, idProducto: {IdProducto}";
        }

        // ⬇️ MÉTODO ESTÁTICO PARA OBTENER UN PRODUCTO CON ID FIJO
        public static Producto ObtenerProductoFijo()
        {
            Producto producto = null;

            // Reemplaza por tu string de conexión real
            string connectionString = "Data Source=SERVIDOR;Initial Catalog=TU_BASE;Integrated Security=True;";
            string query = "SELECT Id, Nombre, Marca, Descripcion, IdProveedor, IdProducto FROM Producto WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Id", 5); // ID fijo

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        producto = new Producto(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5)
                        );
                    }
                }
            }

            return producto;
        }
    }
}
