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

            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar iniciar sesión:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#fca311");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#fca311");
        }
    }
}

