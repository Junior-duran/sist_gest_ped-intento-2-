﻿namespace CapaPresentacion.cs
{
    partial class ProductoEscogido16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido16));
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
            pictureBox2.Location = new Point(440, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 42;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(287, 444);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 46;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(108, 444);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 47;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(71, 348);
            label3.Name = "label3";
            label3.Size = new Size(426, 57);
            label3.TabIndex = 48;
            label3.Text = "Teléfono BlackBerry Classic con procesador Snapdragon S4 Plus, \r\npantalla de 3.5” y teclado QWERTY físico. Ideal para productividad \r\nempresarial y comunicaciones eficientes.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(182, 310);
            label1.Name = "label1";
            label1.Size = new Size(179, 19);
            label1.TabIndex = 49;
            label1.Text = "BLACKBERRY CLASSIC";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // ProductoEscogido16
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 510);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Name = "ProductoEscogido16";
            Text = "ProductoEscogido16";
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