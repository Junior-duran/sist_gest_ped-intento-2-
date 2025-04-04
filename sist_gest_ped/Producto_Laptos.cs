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
    public partial class Producto_Laptos : Form
    {
        public Producto_Laptos()
        {
            InitializeComponent();
        }

        private void btn_ver_ASUS_Click(object sender, EventArgs e)
        {
            ProductoEscogido13 form = new ProductoEscogido13();
            form.Show();
            this.Close();
        }

        private void btn_ver_LEVONO_Click(object sender, EventArgs e)
        {
            ProductoEscogido14 form = new ProductoEscogido14();
            form.Show();
            this.Close();
        }

        private void btn_ver_ALIEN_Click(object sender, EventArgs e)
        {
            ProductoEscogido15 form = new ProductoEscogido15();
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
