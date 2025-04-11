using CapaDatos;
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
    public partial class ProductoEscogido2 : Form
    {
        private CarritoCompras carritoForm = new CarritoCompras(); // Solo una vez
        private ProductoNegocio productoNegocio;

        public ProductoEscogido2()
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

            int idProducto = 2; // Este sería dinámico en tu caso
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
            Producto_CPU form = new Producto_CPU();
            form.Show();
            this.Close();
        }

        private void ProductoEscogido2_Load(object sender, EventArgs e)
        {
            int idProductoSeleccionado = 2; // Cambia este valor según el producto que quieras mostrar

            // Obtener los detalles del producto desde la capa de negocio
            string detallesProducto = productoNegocio.ObtenerDetallesProducto(idProductoSeleccionado);

            // Mostrar los detalles en el Label
            label1.Text = detallesProducto;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#fca311");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#fca311"); ;
        }
    }
}
