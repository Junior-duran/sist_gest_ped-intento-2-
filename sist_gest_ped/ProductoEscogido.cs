using CapaNegocios;
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
using CapaDatos;

namespace CapaPresentacion.cs
{
    public partial class ProductoEscogido : Form
    {
        private int _productoId;
        public ProductoEscogido()
        {
            InitializeComponent();
           // _productoId = productoId;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto_CPU form = new Producto_CPU();
            form.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ProductoEscogido_Load(object sender, EventArgs e)
        {
            /*ProductoNegocio negocio = new ProductoNegocio();
            Producto producto = negocio.BuscarProducto(_productoId);

            if (producto != null)
            {
                richTextBox1.Text = $"Nombre: {producto.Nombre}\n" +
                                    $"Marca: {producto.Marca}\n" +
                                    $"Descripción: {producto.Descripcion}\n" +
                                    $"Precio: {producto.Precio:C}";
            }
            else
            {
                richTextBox1.Text = "Producto no encontrado.";
            }*/
        }
    }
}

