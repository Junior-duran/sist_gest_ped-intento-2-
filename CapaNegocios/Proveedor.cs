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

    // Clase que representa un proveedor en el sistema
    public class Proveedor : IEntidad
    {
        public int Id { get; set; }         // Identificador único del proveedor
        public string Nombre { get; set; }  // Nombre del proveedor
        public string Pais { get; set; }    // País de origen del proveedor

        // Constructor vacío necesario para ciertas operaciones como serialización o frameworks ORM
        public Proveedor() { }

        // Constructor con parámetros para inicializar todas las propiedades
        public Proveedor(int id, string nombre, string pais)
        {
            Id = id;
            Nombre = nombre;
            Pais = pais;
        }

        // Representación textual de la clase, útil para mostrar en la interfaz de usuario o logs
        public override string ToString()
        {
            return $"Proveedor: {Nombre}, País: {Pais}";
        }
    }
}



