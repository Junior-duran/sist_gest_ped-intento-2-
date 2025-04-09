
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
            dgvCarrito.Columns.Add("ID", "ID Producto");
            dgvCarrito.Columns.Add("Nombre", "Nombre");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns.Add("Cantidad", "Cantidad");
        }
        public void CargarDatosEnDGV(string detalles)
        {
            if (dgvCarrito != null)
            {
                // Separar los detalles por salto de línea
                string[] detallesProducto = detalles.Split('\n');

                // Validar que los datos coincidan con las columnas del DGV
                if (detallesProducto.Length == dgvCarrito.Columns.Count)
                {
                    dgvCarrito.Rows.Add(detallesProducto);
                }
                else
                {
                    MessageBox.Show("El número de datos no coincide con las columnas del carrito.");
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
