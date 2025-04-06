using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios;

namespace ENT
{
    public class Consulta : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public string MetodoDePago { get; set; }

        public Consulta(int id, string nombre, decimal precio, DateTime fecha, string metodoDePago)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Fecha = fecha;
            MetodoDePago = metodoDePago;
        }

        public override string ToString()
        {
            return $"Consulta: {Nombre}, Precio: {Precio}, Fecha: {Fecha.ToShortDateString()}, Método de Pago: {MetodoDePago}";
        }
    }
}
