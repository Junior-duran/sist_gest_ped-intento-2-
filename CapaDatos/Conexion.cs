using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Conexion
    {
        // Objeto SqlConnection con cadena de conexión a la base de datos local
        private SqlConnection Conexion = new SqlConnection("Server=.;Database=Sist_Gest_Ventas;Integrated Security=True;");

        // Método para abrir la conexión si está cerrada
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed) // Se abre la conexión si está cerrada
                Conexion.Open();
            
            return Conexion;
            //Se retorna la conexión (ya sea abierta o ya abierta)
        }
        // Método para cerrar la conexión si está abierta
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close(); // Se cierra la conexión si está abierta
           
            return Conexion; // Se retorna la conexión cerrada
        }
    }
}
