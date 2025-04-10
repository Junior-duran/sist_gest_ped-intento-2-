using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;
using System;
using CapaNegocios;
using CapaDatos;
using System.Data.SqlClient;

namespace ENT
{
    // Clase que representa un usuario del sistema, con manejo de credenciales seguras
    public class Usuario : IEntidad
    {
        public int Id { get; set; }                     // Identificador único del usuario
        public string Nombre { get; set; }              // Nombre del usuario
        public byte[] Contraseña { get; private set; }  // Contraseña hasheada (no almacenada en texto plano)

        // Constructor vacío necesario para deserialización o uso con ORM
        public Usuario() { }

        // Constructor que recibe la contraseña en texto plano y la convierte a hash
        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = HashContraseña(contraseña); // Se guarda como hash

        }

        // Método estático que hashea la contraseña usando SHA-256
        public static byte[] HashContraseña(string contraseña)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(contraseña));
            }
        }

        // Verifica si la contraseña ingresada coincide con el hash guardado
        public bool VerificarContraseña(string contraseñaIngresada)
        {
            byte[] hashIngresado = HashContraseña(contraseñaIngresada);
            return System.Collections.StructuralComparisons.StructuralEqualityComparer.Equals(Contraseña, hashIngresado);
        }

        // Representación textual del usuario
        public override string ToString()
        {
            return $"Usuario: {Nombre}";
        }
    }
    
}
