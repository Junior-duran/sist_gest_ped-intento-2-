using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using ENT;

namespace CapaPresentacion.cs
{
    public partial class MetodoPago : Form
    {
        public MetodoPago()
        {
            InitializeComponent();
            CargarMetodosDePago();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }
        private void CargarMetodosDePago()
        {
            List<string> metodos = MetodoDePago.ObtenerMetodosDePago();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(metodos.ToArray());

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                // Mostrar mensaje de compra exitosa
                MessageBox.Show("¡Compra realizada exitosamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: aquí puedes limpiar los campos o cerrar el formulario
                // LimpiarCampos();
                // this.Close();
            }
            else
            {
                // Mostrar advertencia si hay errores
                MessageBox.Show("Revisa los campos con error antes de continuar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool ValidarCampos()
        {
            bool valido = true;
            errorProvider1.Clear();

            // Validar Correo
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !textBox3.Text.Contains("@"))
            {
                errorProvider1.SetError(textBox3, "No se puede ingresar un correo sin '@'.");
                valido = false;
            }

            // Validar Cédula (debe tener solo números y 11 caracteres)
            if (string.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Length != 11 || !textBox2.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(textBox2, "No se puede ingresar una cédula inválida (debe tener 11 números).");
                valido = false;
            }

            // Validar Nombre (no debe estar vacío ni contener números)
            if (string.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Any(char.IsDigit))
            {
                errorProvider1.SetError(textBox1, "No se puede ingresar un nombre vacío o con números.");
                valido = false;
            }

            return valido;
        }


    }
}
