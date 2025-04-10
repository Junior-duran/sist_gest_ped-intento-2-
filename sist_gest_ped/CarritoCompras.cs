
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
using CapaNegocios.CapaNegocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace CapaPresentacion.cs
{
    public partial class CarritoCompras : Form
    {
        public CarritoCompras()
        {
            InitializeComponent();
            InitializeDGV();

        }
        private void InitializeDGV()
        {
            // Limpiar cualquier configuración previa

            // Agregar las columnas necesarias
            dgvCarrito.Columns.Add("ID", "ID");
           

        }
        private CN_Carrito negocioCarrito = new CN_Carrito();
        private void btn_AArticulos_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = negocioCarrito.MostrarCarrito();
                dgvCarrito.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del carrito: " + ex.Message);
            }


        }
        public void AgregarDetalleAlCarrito(string detalle)
        {
            // Puedes adaptar esto según la estructura de tu DataGridView
            dgvCarrito.Rows.Add(detalle);

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

       
        /* public void CargarDatosEnDGV(string detalles)
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
         }*/


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
