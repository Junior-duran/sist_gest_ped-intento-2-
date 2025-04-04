namespace CapaPresentacion.cs
{
    partial class MetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetodoPago));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(255, 192, 255);
            textBox1.Location = new Point(89, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 25);
            textBox1.TabIndex = 0;
            textBox1.Text = "Nombre";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(255, 192, 255);
            textBox2.Location = new Point(89, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 25);
            textBox2.TabIndex = 1;
            textBox2.Text = "Cedula";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(255, 192, 255);
            textBox3.Location = new Point(89, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 25);
            textBox3.TabIndex = 2;
            textBox3.Text = "Correo";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.FromArgb(255, 192, 255);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 302);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 25);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Formas de Pago";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 302);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(28, 206);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(122, 373);
            button1.Name = "button1";
            button1.Size = new Size(165, 31);
            button1.TabIndex = 12;
            button1.Text = "CONFIRMAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(122, 421);
            button2.Name = "button2";
            button2.Size = new Size(165, 31);
            button2.TabIndex = 13;
            button2.Text = "VOLVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 525);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MetodoPago";
            Text = "MetodoPago";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
    }
}