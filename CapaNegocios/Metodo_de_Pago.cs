using CapaNegocios;

namespace ENT
{
    // Clase que representa un método de pago asociado a una consulta
    public class MetodoDePago : IEntidad
    {
        public int Id { get; set; }             // Identificador único del método de pago
        public string Nombre { get; set; }      // Nombre del cliente o del titular del método de pago
        public string MetodoPG { get; set; }    // Tipo de método de pago (ej. Tarjeta, PayPal)
        public string Cedula { get; set; }      // Cédula del cliente
        public int IdConsulta { get; set; }     // ID de la consulta asociada

        // Constructor que inicializa todos los campos
        public MetodoDePago(int id, string nombre, string metodoPG, string cedula, int idConsulta)
        {
            Id = id;
            Nombre = nombre;
            MetodoPG = metodoPG;
            Cedula = cedula;
            IdConsulta = idConsulta;
        }

        // Representación textual del objeto, útil para debugging o mostrar en UI
        public override string ToString()
        {
            return $"Método de Pago: {MetodoPG}, Nombre: {Nombre}, Cédula: {Cedula}, Consulta ID: {IdConsulta}";
        }

        // Lista estática de métodos de pago aceptados
        public static List<string> ObtenerMetodosDePago()
        {
            return new List<string>
            {
                "Tarjeta de Crédito",
                "Tarjeta de Débito",
                "PayPal",
                "Transferencia Bancaria",
                "Criptomonedas"
            };
        }
    }
}
