
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            this.Close(); // Cerrar el formulario actual;

        }

        private void btn_ver_i7_Click(object sender, EventArgs e)
        {
            ProductoEscogido2 form = new ProductoEscogido2();
            form.Show();
            this.Close();
        }

        private void btn_ver_i9_Click(object sender, EventArgs e)
        {
            ProductoEscogido3 form = new ProductoEscogido3();
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

        private void Producto_CPU_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            panel4.BackColor = ColorTranslator.FromHtml("#14213d");
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = ColorTranslator.FromHtml("#fca311");
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = ColorTranslator.FromHtml("#fca311");
        }
    }
}
