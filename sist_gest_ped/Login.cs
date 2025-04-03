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
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
          mtb_Password.PasswordChar = '*';
            if (count > 0)
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
        }

    }
}

