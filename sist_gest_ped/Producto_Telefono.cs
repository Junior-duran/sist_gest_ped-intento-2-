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
    public partial class Producto_Telefono : Form
    {
        public Producto_Telefono()
        {
            InitializeComponent();
        }

        private void btn_ver_Black_Click(object sender, EventArgs e)
        {
            ProductoEscogido16 form = new ProductoEscogido16();
            form.Show();
            this.Close();
        }

        private void btn_ver_Galaxy_Click(object sender, EventArgs e)
        {
            ProductoEscogido17 form = new ProductoEscogido17();
            form.Show();
            this.Close();
        }

        private void btn_ver_Iphone_Click(object sender, EventArgs e)
        {
            ProductoEscogido18 form = new ProductoEscogido18();
            form.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }
    }
}
