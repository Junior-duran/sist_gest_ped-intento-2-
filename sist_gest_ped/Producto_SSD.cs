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
    public partial class Producto_SSD : Form
    {
        public Producto_SSD()
        {
            InitializeComponent();
        }

        private void Producto_SSD_Load(object sender, EventArgs e)
        {

        }

        private void btn_ver_KING_Click(object sender, EventArgs e)
        {
            ProductoEscogido10 form = new ProductoEscogido10();
            form.Show();
        }

        private void btn_ver_SAMGUNG_Click(object sender, EventArgs e)
        {
            ProductoEscogido11 form = new ProductoEscogido11();
            form.Show();
        }

        private void btn_ver_M2HIK_Click(object sender, EventArgs e)
        {
            ProductoEscogico12 form = new ProductoEscogico12();
            form.Show();
        }
    }
}
