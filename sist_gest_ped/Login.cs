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
        private int count;

        public Form1()
        {
            InitializeComponent();
            mtb_Password.UseSystemPasswordChar = true; // Ocultar contraseña con *
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string usuario = mtb_Usuario.Text.Trim();
            string password = mtb_Password.Text;

            if (VerificarCredenciales(usuario, password))
            {
                MessageBox.Show("Bienvenido, " + usuario, "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Aquí puedes abrir otro formulario o el menú principal
                Menu2 form = new Menu2();
                form.Show();
                this.Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarCredenciales(string usuario, string password)
        {
            string connectionString = "Server=.;Database=Sist_Gest_Ventas;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Contraseña", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }   
}

