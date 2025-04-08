
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
            // ID para el i5
            int idProducto = 60; // ID del producto I5
            ProductoEscogido form = new ProductoEscogido(idProducto); // Crear instancia de ProductoEscogido y pasar el ID
            form.Show(); // Mostrar el formulario
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

    }
}
