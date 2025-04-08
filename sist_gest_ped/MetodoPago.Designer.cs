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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(255, 192, 255);
            textBox1.Location = new Point(89, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(255, 192, 255);
            textBox2.Location = new Point(89, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(255, 192, 255);
            textBox3.Location = new Point(89, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 25);
            textBox3.TabIndex = 2;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 141);
            label1.Name = "label1";
            label1.Size = new Size(57, 17);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 186);
            label2.Name = "label2";
            label2.Size = new Size(48, 17);
            label2.TabIndex = 15;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(187, 234);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 16;
            label3.Text = "Correo";
            // 
            // MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 525);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "MetodoPago";
            Text = "MetodoPago";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}