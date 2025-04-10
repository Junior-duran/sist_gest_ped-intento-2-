using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaNegocio.ProductoNegocio;

namespace CapaPresentacion.cs
{
    public partial class ProductoEscogido15 : Form
    {
        private CarritoCompras carritoForm = new CarritoCompras(); // Solo una vez
        private ProductoNegocio productoNegocio;
        public ProductoEscogido15()
        {
            InitializeComponent();
            productoNegocio = new ProductoNegocio();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idProducto = 15; // Este sería dinámico en tu caso
            var producto = productoNegocio.ObtenerProductoPorId(idProducto);

            if (producto != null)
            {
                CarritoGlobal.AgregarProducto(producto);
                MessageBox.Show("Producto añadido al carrito.");

            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto_Laptos form = new Producto_Laptos();
            form.Show();
            this.Close();
        }

        private void ProductoEscogido15_Load(object sender, EventArgs e)
        {
            int idProductoSeleccionado = 15; // Cambia este valor según el producto que quieras mostrar

            // Obtener los detalles del producto desde la capa de negocio
            string detallesProducto = productoNegocio.ObtenerDetallesProducto(idProductoSeleccionado);

            // Mostrar los detalles en el Label
            label3.Text = detallesProducto;
        }
    }
}
