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
   
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
            custimizarDiseño();
           
        }
        private void custimizarDiseño()
        {
            panel1.Visible = true;
            panelMediaSubMenu.Visible = true;
            panelSideMenu.Visible = true;

        }
        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelSideMenu.Visible == true)
                panelSideMenu.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btn_Media_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel1.Visible = true; // Asegurar que el panel esté visible
            panel1.Controls.Clear(); // Limpiar cualquier contenido anterior
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto_CPU form = new Producto_CPU();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Producto_GPU form = new Producto_GPU();
            form.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Producto_Ram form = new Producto_Ram();
            form.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Producto_SSD form = new Producto_SSD();
            form.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Producto_Laptos form = new Producto_Laptos();
            form.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Producto_Telefono form = new Producto_Telefono();
            form.Show();
            this.Close();
        }

        private void btn_Acerca_de_Click(object sender, EventArgs e)
        {
            Acerca_de form = new Acerca_de();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }
    }
}
