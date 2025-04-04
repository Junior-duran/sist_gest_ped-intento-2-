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
    public partial class Producto_Ram : Form
    {
        public Producto_Ram()
        {
            InitializeComponent();
        }

        private void btn_ver_8GB_Click(object sender, EventArgs e)
        {
            ProductoEscogido7 form = new ProductoEscogido7();
            form.Show();
        }

        private void btn_ver_16GB_Click(object sender, EventArgs e)
        {
            ProductoEscogido8 form = new ProductoEscogido8();
            form.Show();
        }

        private void btn_ver_32GB_Click_1(object sender, EventArgs e)
        {
            ProductoEscogido9 form = new ProductoEscogido9();
            form.Show();
        }
    }
}
