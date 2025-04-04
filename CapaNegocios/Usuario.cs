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
    public class Usuario : IEntidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public byte[] Contraseña { get; private set; }

        public Usuario() { }

        public Usuario(string nombre, string contraseña)
        {
            Nombre = nombre;
            Contraseña = HashContraseña(contraseña);

        }

        public static byte[] HashContraseña(string contraseña)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(contraseña));
            }
        }

        public bool VerificarContraseña(string contraseñaIngresada)
        {
            byte[] hashIngresado = HashContraseña(contraseñaIngresada);
            return System.Collections.StructuralComparisons.StructuralEqualityComparer.Equals(Contraseña, hashIngresado);
        }

        public override string ToString()
        {
            return $"Usuario: {Nombre}";
        }
    }
    
}
