using CapaNegocios;
using CapaDatos;
using System;
using System.Data.SqlClient;
using CapaPresentacion.cs;
namespace sist_gest_ped
{
    public partial class Form1 : Form
    {
        CD_Conexion conexion = new CD_Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT usuario, contraseña FROM usuarios_ingreso WHERE usuario = @usuario AND contraseña = @contraseña";
                string usuario = mtb_Usuario.Text;
                string contraseña = mtb_Password.Text;

                SqlConnection conexion_a_base_de_datos = conexion.AbrirConexion();
                SqlCommand comando = new SqlCommand(query, conexion_a_base_de_datos);

                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Exitoso", "Sistema");
                    Menu2 principal = new Menu2();
                    principal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Login Incorrecto", "Sistema");
                }

                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar datos: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
