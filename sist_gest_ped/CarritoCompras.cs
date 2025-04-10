
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CapaDatos;
using static CapaDatos.ProductoDatos;
using static CapaNegocio.ProductoNegocio;


namespace CapaPresentacion.cs
{
    public partial class CarritoCompras : Form
    {
        private List<ProductoDatos.Producto> listaProductos = new List<ProductoDatos.Producto>();


        public CarritoCompras()
        {
            InitializeComponent();
            InitializeDGV();
            ActualizarDataGridView();
        }
        private void InitializeDGV()
        {

            dgvCarrito.Columns.Add("ID", "ID");
            dgvCarrito.Columns.Add("Nombre", "Nombre");
            dgvCarrito.Columns.Add("Marca", "Marca");
            dgvCarrito.Columns.Add("Precio", "Precio");
            dgvCarrito.Columns[0].Width = 50;
            dgvCarrito.Columns[1].Width = 150;
            dgvCarrito.Columns[2].Width = 100;
            dgvCarrito.Columns[3].Width = 80;
        }

        public void AgregarProducto(ProductoDatos.Producto producto)
        {
            listaProductos.Add(producto); // Añade el producto a la lista de productos

            // Vuelves a llenar el DataGridView con todos los productos de la lista
            ActualizarDataGridView();
        }

        // Actualiza el DataGridView con todos los productos en la lista
        private void ActualizarDataGridView()
        {
            dgvCarrito.Rows.Clear(); // Limpiar el DataGridView

            // Agregar todos los productos de la lista al DataGridView
            foreach (var p in listaProductos)
            {
                dgvCarrito.Rows.Add(p.IdProducto, p.Nombre, p.Marca, p.Precio);
            }
        }


        private void btn_AArticulos_Click(object sender, EventArgs e)
        {

            Menu2 form = new Menu2();
            form.Show();
            this.Close();

        }

        public void AgregarDetalleAlCarrito(string detalle)
        {
            // Puedes adaptar esto según la estructura de tu DataGridView
            dgvCarrito.Rows.Add(detalle);
            ActualizarVista();

            // Llamamos al método que actualiza el DataGridView
            ActualizarDataGridView(); // Actualiza el DataGridView con los productos en la lista
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
            CargarProductosEnDGV();
            ActualizarVista();
        }
        private void CargarProductosEnDGV()
        {
            dgvCarrito.Rows.Clear();

            foreach (var p in CarritoGlobal.Productos)
            {
                dgvCarrito.Rows.Add(p.IdProducto, p.Nombre, p.Marca, p.Precio);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dgvCarrito.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvCarrito.SelectedRows)
                {
                    if (!fila.IsNewRow)
                    {
                        int idEliminar = Convert.ToInt32(fila.Cells["ID"].Value);

                        // Elimina el producto también de la lista global
                        var productoAEliminar = CarritoGlobal.Productos.FirstOrDefault(p => p.IdProducto == idEliminar);
                        if (productoAEliminar != null)
                        {
                            CarritoGlobal.Productos.Remove(productoAEliminar);
                        }

                        // Elimina la fila del DGV
                        dgvCarrito.Rows.Remove(fila);
                    }
                }

                // Refresca la vista y total
                ActualizarVista();
            }
            else
            {
                MessageBox.Show("Selecciona un producto para eliminar.");
            }
        }
        public void ActualizarVista()
        {
            dgvCarrito.Rows.Clear();

            foreach (var p in CarritoGlobal.Productos)
            {
                dgvCarrito.Rows.Add(p.IdProducto, p.Nombre, p.Marca, p.Precio);
            }

            CalcularTotal(); // <-- Asegúrate de que esto se mantenga aquí
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (var producto in CarritoGlobal.Productos)
            {
                total += producto.Precio;
            }

            LblTotal1.Text = $"Total: {total:F2}";
        }
        //NO FUNCIONA ESTE EVENTO CLICK DE LBL
        private void LblTotal_Click(object sender, EventArgs e)
        {
   
        }
    }
}

