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
            LblTotal1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
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
            btn_AArticulos.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AArticulos.ForeColor = Color.White;
            btn_AArticulos.Location = new Point(44, 544);
            btn_AArticulos.Name = "btn_AArticulos";
            btn_AArticulos.Size = new Size(173, 36);
            btn_AArticulos.TabIndex = 1;
            btn_AArticulos.Text = "Agregar mas Articulos";
            btn_AArticulos.UseVisualStyleBackColor = false;
            btn_AArticulos.Click += btn_AArticulos_Click;
            // 
            // btn_RealComp
            // 
            btn_RealComp.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RealComp.ForeColor = Color.Black;
            btn_RealComp.Location = new Point(305, 545);
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
            Art_Eliminar.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Art_Eliminar.ForeColor = Color.White;
            Art_Eliminar.Location = new Point(584, 545);
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
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 111);
            label1.Name = "label1";
            label1.Size = new Size(280, 36);
            label1.TabIndex = 4;
            label1.Text = "Carrito de Compra";
            // 
            // pb_Carrito
            // 
            pb_Carrito.Image = (Image)resources.GetObject("pb_Carrito.Image");
            pb_Carrito.Location = new Point(330, 111);
            pb_Carrito.Name = "pb_Carrito";
            pb_Carrito.Size = new Size(49, 40);
            pb_Carrito.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Carrito.TabIndex = 5;
            pb_Carrito.TabStop = false;
            // 
            // LblTotal1
            // 
            LblTotal1.AutoSize = true;
            LblTotal1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotal1.Location = new Point(44, 500);
            LblTotal1.Name = "LblTotal1";
            LblTotal1.Size = new Size(72, 30);
            LblTotal1.TabIndex = 12;
            LblTotal1.Text = "label2";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 602);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(775, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 602);
            panel3.TabIndex = 15;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(25, 602);
            panel4.Name = "panel4";
            panel4.Size = new Size(750, 25);
            panel4.TabIndex = 16;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(25, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 15);
            panel5.TabIndex = 17;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(25, 587);
            panel6.Name = "panel6";
            panel6.Size = new Size(750, 15);
            panel6.TabIndex = 18;
            panel6.Paint += panel6_Paint;
            // 
            // CarritoCompras
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 627);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(LblTotal1);
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
        private Label LblTotal1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}