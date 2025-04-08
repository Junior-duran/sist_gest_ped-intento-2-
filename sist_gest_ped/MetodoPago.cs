using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocios;
using ENT;

namespace CapaPresentacion.cs
{
    public partial class MetodoPago : Form
    {
        public MetodoPago()
        {
            InitializeComponent();
            CargarMetodosDePago();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras();
            form.Show();
            this.Close();
        }
        private void CargarMetodosDePago()
        {
            List<string> metodos = MetodoDePago.ObtenerMetodosDePago();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(metodos.ToArray());

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

    }
}
