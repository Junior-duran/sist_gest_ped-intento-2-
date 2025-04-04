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
    public partial class Producto_CPU : Form
    {
        public Producto_CPU()
        {
            InitializeComponent();
        }

        private void btn_ver_i5_Click(object sender, EventArgs e)
        {
            ProductoEscogido form = new ProductoEscogido();
            form.Show();
        }

        private void btn_ver_i7_Click(object sender, EventArgs e)
        {
            ProductoEscogido2 form = new ProductoEscogido2();
            form.Show();
        }

        private void btn_ver_i9_Click(object sender, EventArgs e)
        {
            ProductoEscogido3 form = new ProductoEscogido3();
            form.Show();
        }
    }
}
