using ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocios;

namespace CapaPresentacion.cs
{
    public partial class CarritoCompras : Form
    {
        public CarritoCompras()
        {
            InitializeComponent();
            // Inicializar el DataGridView

        }
        private void btn_AArticulos_Click(object sender, EventArgs e)
        {
            Menu2 form = new Menu2();
            form.Show();
            this.Close();
        }

        private void btn_RealComp_Click(object sender, EventArgs e)
        {
            MetodoPago form = new MetodoPago();
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
