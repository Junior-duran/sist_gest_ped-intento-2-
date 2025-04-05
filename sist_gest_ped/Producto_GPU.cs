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
    public partial class Producto_GPU : Form
    {
        public Producto_GPU()
        {
            InitializeComponent();
        }

        private void btn_ver_3050_Click(object sender, EventArgs e)
        {
            ProductoEscogido4 form = new ProductoEscogido4();
            form.Show();
            this.Close();
        }

        private void btn_ver_4070_Click(object sender, EventArgs e)
        {
            ProductoEscogido5 form = new ProductoEscogido5();
            form.Show();
            this.Close();
        }

        private void btn_ver_5080_Click(object sender, EventArgs e)
        {
            ProductoEscogido6 form = new ProductoEscogido6();
            form.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            Menu2 form = new Menu2();
            form.Show();
            this.Close();
        }
    }
}
