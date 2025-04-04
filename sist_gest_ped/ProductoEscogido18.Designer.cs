namespace CapaPresentacion.cs
{
    partial class ProductoEscogido18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido18));
            label3 = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 335);
            label3.Name = "label3";
            label3.Size = new Size(426, 57);
            label3.TabIndex = 50;
            label3.Text = "iPhone 15 Pro Max con chip A17 Bionic, pantalla Super Retina \r\nXDR 6.7” 120Hz, cámara de 48MP, y batería de 4323mAh. Ofrece \r\nalto rendimiento, grabación en 4K y conectividad 5G.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(170, 289);
            label1.Name = "label1";
            label1.Size = new Size(162, 19);
            label1.TabIndex = 51;
            label1.Text = "IPHONE 15 PRO MAX";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(103, 421);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 52;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(276, 421);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 53;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(405, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iphone;
            pictureBox1.Location = new Point(139, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // ProductoEscogido18
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 510);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "ProductoEscogido18";
            Text = "ProductoEscogido18";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}