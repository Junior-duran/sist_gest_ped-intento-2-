
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;
using sist_gest_ped;


namespace CapaPresentacion.cs
{
    public partial class CarritoCompras : Form
    {
        private void InitializeDGV()
        {
            // Limpiar cualquier configuración previa

            // Agregar las columnas necesarias
            dgvCarrito.Columns.Add("ID", "ID");
            dgvCarrito.Columns.Add("Detalles", "Detalles");
            InitializeDGV();
        }

        private void btn_AArticulos_Click(object sender, EventArgs e)
        {
        }


        private void btn_RealComp_Click(object sender, EventArgs e)
        {
            MetodoPago form = new MetodoPago();
            form.Show();
            this.Close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Menu2 form = new Menu2();
            form.Show();
            this.Close();
        }

        private void CarritoCompras_Load(object sender, EventArgs e)
        {

        }
        public void CargarDatosEnDGV(string detalles)
        {
            if (dgvCarrito != null)
            {
                // Limpiar las filas existentes antes de agregar nuevas
                dgvCarrito.Rows.Clear();

                // Separar los detalles del producto por saltos de línea
                string[] detallesProducto = detalles.Split('\n');

                // Asegurarse de que el número de detalles coincida con el número de columnas
                if (detallesProducto.Length == dgvCarrito.Columns.Count)
                {
                    // Añadir la fila con los detalles
                    dgvCarrito.Rows.Add(detallesProducto);
                }
                else
                {
                    MessageBox.Show("El número de detalles no coincide con el número de columnas.");
                }
            }
            else
            {
                MessageBox.Show("El DataGridView no está inicializado.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                // Eliminar la fila seleccionada
                foreach (DataGridViewRow fila in dgvCarrito.SelectedRows)
                {
                    // Si es una fila de datos (no una fila de encabezado)
                    if (!fila.IsNewRow)
                    {
                        dgvCarrito.Rows.Remove(fila);
                    }
                }
            }
            else
            {
                // Mostrar un mensaje si no hay ninguna fila seleccionada
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
