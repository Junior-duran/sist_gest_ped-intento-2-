namespace CapaPresentacion.cs
{
    partial class ProductoEscogido9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido9));
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Fuchsia;
            label7.Location = new Point(413, 60);
            label7.Name = "label7";
            label7.Size = new Size(125, 19);
            label7.TabIndex = 29;
            label7.Text = "Carrito de Compra";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(439, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 305);
            label2.Name = "label2";
            label2.Size = new Size(526, 57);
            label2.TabIndex = 27;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(185, 262);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 26;
            label1.Text = "DDR4 32GB 5600 MHz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(161, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(286, 401);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 24;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(124, 401);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 23;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            // 
            // ProductoEscogido9
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 502);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "ProductoEscogido9";
            Text = "ProductoEscogido9";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
    }
}