using CapaNegocios;
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
            Producto producto = Producto.ObtenerProductoFijo();

            if (producto != null)
            {
                richTextBox1.Text = producto.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el producto con ID 5.");
                richTextBox1.Clear();
            }

        }
       
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //// Aquí puedes manejar el evento TextChanged si es necesario
        }
    }
}

