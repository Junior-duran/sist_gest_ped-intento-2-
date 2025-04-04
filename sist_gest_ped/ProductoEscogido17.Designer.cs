namespace CapaPresentacion.cs
{
    partial class ProductoEscogido17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido17));
            pictureBox2 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(415, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(272, 444);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 47;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(116, 444);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 48;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 358);
            label3.Name = "label3";
            label3.Size = new Size(497, 57);
            label3.TabIndex = 49;
            label3.Text = "Samsung Galaxy S25 Ultra con procesador Exynos 2200 o Snapdragon 8 Gen 2\r\n,pantalla AMOLED 6.8” 120Hz ,cámara de 200MP y batería de 5000mAh. \r\nGran rendimiento y fotografía avanzada.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(178, 315);
            label1.Name = "label1";
            label1.Size = new Size(154, 19);
            label1.TabIndex = 50;
            label1.Text = "GALAXY S25 ULTRA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 281);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // ProductoEscogido17
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 510);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Name = "ProductoEscogido17";
            Text = "ProductoEscogido17";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
    }
}