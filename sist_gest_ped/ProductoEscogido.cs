using CapaNegocios;  // Namespace para el acceso a la capa de negocios
using System;
using System.Windows.Forms;

namespace CapaPresentacion.cs
{
    public partial class ProductoEscogido : Form
    {
       // private int _productoId; // Variable para almacenar el ID del producto

        // ✅ Constructor que recibe el ID del producto
        public ProductoEscogido(int productoId)
            
        {
            InitializeComponent();
            CargarProductosEnListBox();
            //_productoId = productoId; // Asignar el ID del producto
            //this.Load += new EventHandler(ProductoEscogido_Load); // Asignar el evento Load
        }

        // Evento de clic para navegar al carrito de compras
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CarritoCompras form = new CarritoCompras(); // Crear el formulario CarritoCompras
            form.Show(); // Mostrar el formulario
            this.Close(); // Cerrar el formulario actual
        }

        // Evento de clic para volver a la vista de productos
        private void button3_Click(object sender, EventArgs e)
        {
            Producto_CPU form = new Producto_CPU(); // Crear el formulario Producto_CPU
            form.Show(); // Mostrar el formulario
            this.Close(); // Cerrar el formulario actual
        }

        // Evento de clic de un botón adicional, puedes agregar lógica aquí si lo necesitas
        private void button2_Click(object sender, EventArgs e)
        {
            // Implementar lógica adicional si es necesario
        }

        // Evento Load del formulario, se ejecuta cuando el formulario es cargado
        private void ProductoEscogido_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Limpiar cualquier item previo en el ListBox
            // Llamar al método ObtenerDetalleProductoPorID y agregar los datos al ListBox
            
        }

        // Evento TextChanged del RichTextBox (actualmente vacío)
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional aquí si es necesario
        }

        // Evento de selección del ListBox (actualmente vacío)
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes dejar este método vacío si no lo necesitas
        }
        private void CargarProductosEnListBox()
        {
            Producto.ProductoData data = new Producto.ProductoData();
            List<Producto> productos = data.ObtenerTodosLosProductos();

            listBox1.Items.Clear(); // Limpiar antes

            foreach (var producto in productos)
            {
                listBox1.Items.Add(producto.ToString());
            }
        }

    }
}

