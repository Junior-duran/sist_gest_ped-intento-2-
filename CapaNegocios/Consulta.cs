using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocios;

namespace ENT
{
    public class Consulta : IEntidad
    {
        public int Id { get; set; }                 // Identificador único de la consulta
        public string Nombre { get; set; }          // Nombre de la consulta o del cliente
        public decimal Precio { get; set; }         // Precio de la consulta
        public DateTime Fecha { get; set; }         // Fecha en que se realizó la consulta
        public string MetodoDePago { get; set; }    // Método de pago utilizado (Ej. Efectivo, Tarjeta)

        // Constructor para inicializar todos los atributos
        public Consulta(int id, string nombre, decimal precio, DateTime fecha, string metodoDePago)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Fecha = fecha;
            MetodoDePago = metodoDePago;
        }

        // Representación en texto de la clase, útil para depuración o mostrar en interfaces
        public override string ToString()
        {
            return $"Consulta: {Nombre}, Precio: {Precio}, Fecha: {Fecha.ToShortDateString()}, Método de Pago: {MetodoDePago}";
        }
    }
}
