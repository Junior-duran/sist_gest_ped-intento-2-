namespace CapaPresentacion.cs
{
    partial class CarritoCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoCompras));
            dgvCarrito = new DataGridView();
            btn_AArticulos = new Button();
            btn_RealComp = new Button();
            button3 = new Button();
            label1 = new Label();
            pb_Carrito = new PictureBox();
            btn_Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Carrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(50, 185);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(826, 387);
            dgvCarrito.TabIndex = 0;
            // 
            // btn_AArticulos
            // 
            btn_AArticulos.BackColor = Color.Lime;
            btn_AArticulos.ForeColor = Color.White;
            btn_AArticulos.Location = new Point(50, 580);
            btn_AArticulos.Margin = new Padding(3, 4, 3, 4);
            btn_AArticulos.Name = "btn_AArticulos";
            btn_AArticulos.Size = new Size(198, 42);
            btn_AArticulos.TabIndex = 1;
            btn_AArticulos.Text = "Agregar mas Articulos";
            btn_AArticulos.UseVisualStyleBackColor = false;
            btn_AArticulos.Click += btn_AArticulos_Click;
            // 
            // btn_RealComp
            // 
            btn_RealComp.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RealComp.ForeColor = Color.Fuchsia;
            btn_RealComp.Location = new Point(362, 580);
            btn_RealComp.Margin = new Padding(3, 4, 3, 4);
            btn_RealComp.Name = "btn_RealComp";
            btn_RealComp.Size = new Size(198, 42);
            btn_RealComp.TabIndex = 2;
            btn_RealComp.Text = "Realizar Compra";
            btn_RealComp.UseVisualStyleBackColor = true;
            btn_RealComp.Click += btn_RealComp_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(678, 580);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(198, 42);
            button3.TabIndex = 3;
            button3.Text = "Eliminar Articulo";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(50, 131);
            label1.Name = "label1";
            label1.Size = new Size(300, 38);
            label1.TabIndex = 4;
            label1.Text = "Carrito de Compra";
            // 
            // pb_Carrito
            // 
            pb_Carrito.Image = (Image)resources.GetObject("pb_Carrito.Image");
            pb_Carrito.Location = new Point(357, 118);
            pb_Carrito.Margin = new Padding(3, 4, 3, 4);
            pb_Carrito.Name = "pb_Carrito";
            pb_Carrito.Size = new Size(56, 59);
            pb_Carrito.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Carrito.TabIndex = 5;
            pb_Carrito.TabStop = false;
            // 
            // btn_Volver
            // 
            btn_Volver.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Volver.ForeColor = Color.Fuchsia;
            btn_Volver.Location = new Point(11, 13);
            btn_Volver.Margin = new Padding(3, 4, 3, 4);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(110, 41);
            btn_Volver.TabIndex = 11;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // CarritoCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 738);
            Controls.Add(btn_Volver);
            Controls.Add(pb_Carrito);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btn_RealComp);
            Controls.Add(dgvCarrito);
            Controls.Add(btn_AArticulos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarritoCompras";
            Text = "CarritoCompras";
            Load += CarritoCompras_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Carrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarrito;
        private Button button3;
        private Button btn_RealComp;
        private Button btn_AArticulos;
        private Label label1;
        private PictureBox pb_Carrito;
        private Button btn_Volver;
    }
}