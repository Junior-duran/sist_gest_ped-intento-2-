using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    // Capa de Datos
    public class ProductoData
    {
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Trusted_Connection=True;";

        // Método para obtener los productos
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

        // Método para insertar un producto en la base de datos
        public bool InsertarProducto(int id, string nombre, string marca, string descripcion, decimal precio)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    // Consulta SQL para insertar el producto
                    string query = "INSERT INTO Producto (Id, Nombre, Marca, Descripcion, Precio) " +
                                   "VALUES (@Id, @Nombre, @Marca, @Descripcion, @Precio)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Agregar los parámetros de manera segura
                        comando.Parameters.AddWithValue("@Id", id);
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Marca", marca);
                        comando.Parameters.AddWithValue("@Descripcion", descripcion);
                        comando.Parameters.AddWithValue("@Precio", precio);

                        // Abrir la conexión
                        conexion.Open();

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        // Si se afectaron filas, la inserción fue exitosa
                        return filasAfectadas > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errore
                return false;
            }
        }
    }

}
