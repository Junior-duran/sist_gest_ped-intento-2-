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
            Art_Eliminar = new Button();
            label1 = new Label();
            pb_Carrito = new PictureBox();
            btn_Volver = new Button();
            LblTotal1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Carrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCarrito
            // 
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(44, 157);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.ScrollBars = ScrollBars.Vertical;
            dgvCarrito.Size = new Size(723, 329);
            dgvCarrito.TabIndex = 0;
            // 
            // btn_AArticulos
            // 
            btn_AArticulos.BackColor = Color.Lime;
            btn_AArticulos.ForeColor = Color.White;
            btn_AArticulos.Location = new Point(44, 528);
            btn_AArticulos.Name = "btn_AArticulos";
            btn_AArticulos.Size = new Size(173, 36);
            btn_AArticulos.TabIndex = 1;
            btn_AArticulos.Text = "Agregar mas Articulos";
            btn_AArticulos.UseVisualStyleBackColor = false;
            btn_AArticulos.Click += btn_AArticulos_Click;
            // 
            // btn_RealComp
            // 
            btn_RealComp.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RealComp.ForeColor = Color.Fuchsia;
            btn_RealComp.Location = new Point(293, 528);
            btn_RealComp.Name = "btn_RealComp";
            btn_RealComp.Size = new Size(173, 36);
            btn_RealComp.TabIndex = 2;
            btn_RealComp.Text = "Realizar Compra";
            btn_RealComp.UseVisualStyleBackColor = true;
            btn_RealComp.Click += btn_RealComp_Click;
            // 
            // Art_Eliminar
            // 
            Art_Eliminar.BackColor = Color.Red;
            Art_Eliminar.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Art_Eliminar.ForeColor = Color.White;
            Art_Eliminar.Location = new Point(570, 529);
            Art_Eliminar.Name = "Art_Eliminar";
            Art_Eliminar.Size = new Size(173, 36);
            Art_Eliminar.TabIndex = 3;
            Art_Eliminar.Text = "Eliminar Articulo";
            Art_Eliminar.UseVisualStyleBackColor = false;
            Art_Eliminar.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(241, 31);
            label1.TabIndex = 4;
            label1.Text = "Carrito de Compra";
            // 
            // pb_Carrito
            // 
            pb_Carrito.Image = (Image)resources.GetObject("pb_Carrito.Image");
            pb_Carrito.Location = new Point(312, 100);
            pb_Carrito.Name = "pb_Carrito";
            pb_Carrito.Size = new Size(49, 50);
            pb_Carrito.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Carrito.TabIndex = 5;
            pb_Carrito.TabStop = false;
            // 
            // btn_Volver
            // 
            btn_Volver.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Volver.ForeColor = Color.Fuchsia;
            btn_Volver.Location = new Point(10, 11);
            btn_Volver.Name = "btn_Volver";
            btn_Volver.Size = new Size(96, 35);
            btn_Volver.TabIndex = 11;
            btn_Volver.Text = "Volver";
            btn_Volver.UseVisualStyleBackColor = true;
            btn_Volver.Click += btn_Volver_Click;
            // 
            // LblTotal1
            // 
            LblTotal1.AutoSize = true;
            LblTotal1.Location = new Point(44, 503);
            LblTotal1.Name = "LblTotal1";
            LblTotal1.Size = new Size(43, 17);
            LblTotal1.TabIndex = 12;
            LblTotal1.Text = "label2";
            // 
            // CarritoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(LblTotal1);
            Controls.Add(btn_Volver);
            Controls.Add(pb_Carrito);
            Controls.Add(label1);
            Controls.Add(Art_Eliminar);
            Controls.Add(btn_RealComp);
            Controls.Add(dgvCarrito);
            Controls.Add(btn_AArticulos);
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
        private Button Art_Eliminar;
        private Button btn_RealComp;
        private Button btn_AArticulos;
        private Label label1;
        private PictureBox pb_Carrito;
        private Button btn_Volver;
        private Label LblTotal1;
    }
}