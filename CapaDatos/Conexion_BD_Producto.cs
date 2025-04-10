﻿using System;
using System.Data.SqlClient;

namespace CapaDatos
{
    // Clase que contiene lógica para acceder a los datos del producto desde la base de datos
    public class ProductoDatos
    {
        // Clase anidada que representa el modelo de datos de un producto
        public class Producto
        {
            public int IdProducto { get; set; }
            public string Nombre { get; set; }
            public string Marca { get; set; }
            public string Descripcion { get; set; }
            public decimal Precio { get; set; }
        }
        // Cadena de conexión a la base de datos
        private string connectionString = "Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;"; // Reemplazar con tu cadena de conexión

        // Método que obtiene un producto por su ID desde la base de datos
        public Producto ObtenerProductoPorId(int idProducto)
        {
            string query = "SELECT Nombre, Marca, Descripcion, Precio FROM Producto WHERE idProducto = @idProducto";
            Producto producto = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Parámetro para evitar inyección SQL y mejorar la seguridad 
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
                        // Manejo básico de errores
                        throw new Exception("Error al obtener el producto: " + ex.Message);
                    }
                }
            }

            return producto;
        }
    }
}
