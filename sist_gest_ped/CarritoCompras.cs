using ENT;
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


namespace CapaPresentacion.cs
{
    public partial class CarritoCompras : Form
    {
        private ProductoNegocio productoNegocio = new ProductoNegocio();
        private void CargarProductos()
        {
            DataTable productos = productoNegocio.ObtenerProductos();
            dgvCarrito.DataSource = productos;
            // Agregar la nueva fila al DataGridView
          

        }

        public CarritoCompras()
        {
            InitializeComponent();
            // Inicializar el DataGridView
         
        }
        private void btn_AArticulos_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgvCarrito.SelectedRows[0];

                int id = Convert.ToInt32(filaSeleccionada.Cells["Id"].Value);
                string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
                string marca = filaSeleccionada.Cells["Marca"].Value.ToString();
                string descripcion = filaSeleccionada.Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(filaSeleccionada.Cells["Precio"].Value);

                bool resultado = productoNegocio.InsertarProducto(id, nombre, marca, descripcion, precio);

                if (resultado)
                {
                    MessageBox.Show("Producto insertado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al insertar el producto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila.");
            }
            Menu2 form = new Menu2();
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
    }
}
