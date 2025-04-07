using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaNegocios;
using CapaDatos;
using System.Data;




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
        public class Producto1
        {
            private Producto1 ProductoDll = new Producto1();

            public DataTable ObtenerListaProducto()
            {
                return ProductoDll.ObtenerListaProducto();
            }
        }
        public class ProductoNegocio
        {
            // public ProductoDll (ProdctoData);

            public ProductoNegocio()
            {
                productoDll = new ProductoDll(); // Crear la instancia de la capa de datos
            }

            public string ObtenerListaProducto(int productoId)
            {
                try
                {
                    // Llamar al método de la capa de datos para obtener el nombre del producto
                    return ProdctoData.ObtenerNoProducto(productoId);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la capa de negocio", ex);
                }
            }

        }

    }

}


            
    

