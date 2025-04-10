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
            components = new System.ComponentModel.Container();
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
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(89, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(89, 213);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(242, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(89, 263);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(242, 25);
            textBox3.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.Fuchsia;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(89, 303);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(242, 25);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Formas de Pago";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 28);
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
            button1.ForeColor = Color.Fuchsia;
            button1.Location = new Point(132, 358);
            button1.Name = "button1";
            button1.Size = new Size(165, 31);
            button1.TabIndex = 12;
            button1.Text = "CONFIRMAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(132, 410);
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
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(176, 141);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 14;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(176, 191);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 15;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Fuchsia;
            label3.Location = new Point(176, 241);
            label3.Name = "label3";
            label3.Size = new Size(53, 19);
            label3.TabIndex = 16;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Fuchsia;
            label4.Location = new Point(176, 291);
            label4.Name = "label4";
            label4.Size = new Size(0, 19);
            label4.TabIndex = 17;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // MetodoPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 525);
            Controls.Add(label4);
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
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
        private Label label4;
        private ErrorProvider errorProvider1;
    }
}