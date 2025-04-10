namespace CapaPresentacion.cs
{
    partial class ProductoEscogido4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido4));
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(425, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 364);
            label6.Name = "label6";
            label6.Size = new Size(0, 19);
            label6.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 287);
            label3.Name = "label3";
            label3.Size = new Size(13, 19);
            label3.TabIndex = 27;
            label3.Text = ".";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(261, 430);
            button3.Name = "button3";
            button3.Size = new Size(124, 38);
            button3.TabIndex = 24;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(118, 430);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 23;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ProductoEscogido4
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 497);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "ProductoEscogido4";
            Text = "ProductoEscogido4";
            Load += ProductoEscogido4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label6;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
    }
}