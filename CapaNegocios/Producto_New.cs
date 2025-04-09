using CapaDatos; // Asegúrate de que la clase Producto esté dentro de este espacio de nombres
using System;
using static CapaDatos.ProductoDatos;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private ProductoDatos productoDatos;  // Clase de la capa de datos

        public ProductoNegocio()
        {
            productoDatos = new ProductoDatos();  // Instanciamos la clase de la capa de datos
        }

        // Método para obtener los detalles del producto
        public string ObtenerDetallesProducto(int idProducto)
        {
            // Llamamos a la capa de datos para obtener el producto por ID
            Producto producto = productoDatos.ObtenerProductoPorId(idProducto);

            // Verificamos si se obtuvo un producto válido
            if (producto != null)
            {
                // Retornamos la información formateada del producto
                return $"📦 PRODUCTO ENCONTRADO\n" +
                       $"ID: {producto.IdProducto}\n" +
                       $"Nombre: {producto.Nombre}\n" +
                       $"Marca: {producto.Marca}\n" +
                       $"Descripción: {producto.Descripcion}\n" +
                       $"Precio: {producto.Precio:C}";
            }
            else
            {
                // Si no se encuentra el producto, retornamos un mensaje
                return "Producto no encontrado.";
            }
        }
    }
}

