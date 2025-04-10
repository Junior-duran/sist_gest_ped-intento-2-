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
    public partial class Acerca_de : Form
    {
        public Acerca_de()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu2 form = new Menu2();
            form.Show();
            this.Close();
        }
    }
}
