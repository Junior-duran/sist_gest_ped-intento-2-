using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.cs
{
    public partial class ProductoEscogido : Form
    {
        private ProductoNegocio productoNegocio;

        public ProductoEscogido()
        {
            InitializeComponent();
            productoNegocio = new ProductoNegocio();

        }


        private void ProductoEscogido_Load(object sender, EventArgs e)
        {

            int idProductoSeleccionado = 1; // Cambia este valor según el producto que quieras mostrar

            // Obtener los detalles del producto desde la capa de negocio
            string detallesProducto = productoNegocio.ObtenerDetallesProducto(idProductoSeleccionado);

            // Mostrar los detalles en el Label
            label1.Text = detallesProducto;
        }
        /*public void MostrarDetalles(int id, string marca, string nombre, decimal precio)
        {
            Label2.Text = "ID: " + id.ToString();
            Label3.Text = "Marca: " + marca;
            Label4.Text = "Nombre: " + nombre;
            Label5Precio.Text = "Precio: $" + precio.ToString("0.00");
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            int idProducto = 1;  // Esto puede ser asignado de forma dinámica en tu código

            // Obtenemos los detalles del producto
            string detalles = productoNegocio.ObtenerDetallesProducto(idProducto);

            // Asignamos el texto al Label
            label1.Text = detalles;
           MessageBox.Show("Producto añadido al carrito.");

            // Creamos una instancia de Form2
            //CarritoCompras carritoCompras = new CarritoCompras();
           // o cualquier info que quieras pasar

            // Instanciar o referenciar el formulario destino
            CarritoCompras formCarrito = new CarritoCompras();

            // Pasar el detalle al método
            formCarrito.AgregarDetalleAlCarrito(detalles);

            // Mostrar el formulario
            formCarrito.Show();
            // Llamamos al método CargarDatosEnDGV de Form2 y le pasamos el texto de los detalles
            //carritoCompras.CargarDatosEnDGV(detalles);

            // Mostramos Form2
            //carritoCompras.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#fca311");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#fca311");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto_CPU form = new Producto_CPU();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }
    }
}
