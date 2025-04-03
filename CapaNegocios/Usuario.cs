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
    public class CN_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();
        private string usuario;
        private string contrasena;
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        public bool Login()
        {
            try
            {
                string query = @"SELECT COUNT(*) FROM Usuarios 
                                 WHERE Usuario = @usuario 
                                 AND Contraseña = HASHBYTES('SHA2_256', @contrasena)";
                using (SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexion_a_base_de_datos))
                    {
                        comando.Parameters.AddWithValue("@usuario", usuario);
                        comando.Parameters.AddWithValue("@contrasena", contrasena);
                        int count = (int)comando.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ingresar datos: " + ex.Message);
            }
        }
    }
}
