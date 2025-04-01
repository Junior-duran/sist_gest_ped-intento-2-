namespace CapaPresentacion.cs
{
    partial class ProductoEscogido10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido10));
            pictureBox2 = new PictureBox();
            label7 = new Label();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(437, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Fuchsia;
            label7.Location = new Point(418, 62);
            label7.Name = "label7";
            label7.Size = new Size(125, 19);
            label7.TabIndex = 30;
            label7.Text = "Carrito de Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 344);
            label2.Name = "label2";
            label2.Size = new Size(506, 57);
            label2.TabIndex = 31;
            label2.Text = "Unidad SSD Kingston 2.5\" con interfaz SATA III, velocidades de lectura/escritura \r\nhasta 550 MB/sy 500 MB/s. Ideal para mejorar tiempos de carga y eficiencia \r\nen sistemas de gama media.";
            label2.Click += label2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(99, 435);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 32;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(281, 435);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 33;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ssd_kingston;
            pictureBox1.Location = new Point(132, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(194, 295);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 35;
            label1.Text = "SSD KINGSTON 2.5";
            // 
            // ProductoEscogido10
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 510);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Name = "ProductoEscogido10";
            Text = "ProductoEscogido10";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label7;
        private Label label2;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}