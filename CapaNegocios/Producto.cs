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
        public Producto (int id, string nombre, string marca, string descripcion, int idProveedor, int idProducto)
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
       

    }

}


            
    

