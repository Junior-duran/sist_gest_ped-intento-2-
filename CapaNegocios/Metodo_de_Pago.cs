using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;
using CapaNegocios;

namespace ENT
{
    public class MetodoDePago : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string MetodoPG { get; set; }
        public string Cedula { get; set; }
        public int IdConsulta { get; set; }

        public MetodoDePago() { }

        public MetodoDePago(int id, string nombre, string metodoPG, string cedula, int idConsulta)
        {
            Id = id;
            Nombre = nombre;
            MetodoPG = metodoPG;
            Cedula = cedula;
            IdConsulta = idConsulta;
        }

        public override string ToString()
        {
            return $"Método de Pago: {MetodoPG}, Nombre: {Nombre}, Cédula: {Cedula}, Consulta ID: {IdConsulta}";
        }
    }
}
