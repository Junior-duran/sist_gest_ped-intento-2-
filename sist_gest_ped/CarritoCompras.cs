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
        public CarritoCompras()
        {
            InitializeComponent();
            // Inicializar el DataGridView
        }
        private void InicializarCarrito()
        {
            dgvCarrito.Columns.Clear(); // Asegúrate que no haya columnas duplicadas
            dgvCarrito.Columns.Add("Id", "ID");
            dgvCarrito.Columns.Add("Nombre", "Nombre");
            dgvCarrito.Columns.Add("Marca", "Marca");
            dgvCarrito.Columns.Add("Precio", "Precio");
        }
        

        private void btn_AArticulos_Click(object sender, EventArgs e)
        {
            Menu2 form = new Menu2();
            form.Show();
            this.Close();
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
            // Mostrar todos los productos en el catálogo (dgvProductos)
            dgvCarrito.DataSource = Producto.ObtenerTodos();
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            InicializarCarrito(); // Prepara las columnas del carrito
        }

    } 
}
