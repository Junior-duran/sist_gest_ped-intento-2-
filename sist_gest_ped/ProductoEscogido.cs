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

        private void button1_Click(object sender, EventArgs e)
        {
            int idProducto = 1;  // Esto puede ser asignado de forma dinámica en tu código

            // Obtenemos los detalles del producto
            string detalles = productoNegocio.ObtenerDetallesProducto(idProducto);

            // Asignamos el texto al Label
            label1.Text = detalles;

            // Creamos una instancia de Form2
            CarritoCompras CarritoCompras = new CarritoCompras();

            // Llamamos al método CargarDatosEnDGV de Form2 y le pasamos el texto de los detalles
            CarritoCompras.CargarDatosEnDGV(detalles);

            // Mostramos Form2
            CarritoCompras.Show();
        }
    }
}
