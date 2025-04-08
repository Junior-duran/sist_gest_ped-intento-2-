using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocios
{
        public interface IEntidad
        {
            int Id { get; set; } // Id común para todas las entidades
            string Nombre { get; set; } // Nombre común
        }
    /*public class ProductoNegocio
    {
        private ProductoData productoData = new ProductoData();

        public Producto BuscarProducto(int productoId)
        {
            return productoData.ObtenerProductoPorID(productoId);
        }
    }*/
}
