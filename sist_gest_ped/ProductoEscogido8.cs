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
    public partial class ProductoEscogido8 : Form
    {
        private CarritoCompras carritoForm = new CarritoCompras(); // Solo una vez
        private ProductoNegocio productoNegocio;
        public ProductoEscogido8()
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

            int idProducto = 8; // Este sería dinámico en tu caso
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
            Producto_Ram form = new Producto_Ram();
            form.Show();
            this.Close();

        }

        private void ProductoEscogido8_Load(object sender, EventArgs e)
        {
            int idProductoSeleccionado = 8; // Cambia este valor según el producto que quieras mostrar

            // Obtener los detalles del producto desde la capa de negocio
            string detallesProducto = productoNegocio.ObtenerDetallesProducto(idProductoSeleccionado);

            // Mostrar los detalles en el Label
            label2.Text = detallesProducto;
        }
    }
}
