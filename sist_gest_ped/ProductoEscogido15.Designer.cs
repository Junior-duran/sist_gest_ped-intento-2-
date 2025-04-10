namespace CapaPresentacion.cs
{
    partial class ProductoEscogido15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido15));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(438, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(148, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 249);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 255);
            button2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(111, 448);
            button2.Name = "button2";
            button2.Size = new Size(125, 39);
            button2.TabIndex = 44;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(297, 448);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
            button3.TabIndex = 45;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(255, 323);
            label3.Name = "label3";
            label3.Size = new Size(21, 19);
            label3.TabIndex = 47;
            label3.Text = "...";
            // 
            // ProductoEscogido15
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 510);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "ProductoEscogido15";
            Text = "ProductoEscogido15";
            Load += ProductoEscogido15_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}