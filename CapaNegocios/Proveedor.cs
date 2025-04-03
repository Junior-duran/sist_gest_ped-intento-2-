using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{ 


    public class Proveedor : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }

        public Proveedor() { }

        public Proveedor(int id, string nombre, string pais)
        {
            Id = id;
            Nombre = nombre;
            Pais = pais;
        }

        public override string ToString()
        {
            return $"Proveedor: {Nombre}, País: {Pais}";
        }
    }
}



