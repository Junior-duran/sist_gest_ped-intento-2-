using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data.SqlClient;
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

        public Producto() { }

        public Producto(int id, string nombre, string marca, string descripcion, int idProveedor)
        {
            Id = id;
            Nombre = nombre;
            Marca = marca;
            Descripcion = descripcion;
            IdProveedor = idProveedor;
        }

        public override string ToString()
        {
            return $"Producto: {Nombre}, Marca: {Marca}, Descripción: {Descripcion}, Proveedor ID: {IdProveedor}";
        }
    }
}

