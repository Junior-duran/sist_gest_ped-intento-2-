namespace CapaPresentacion.cs
{
    partial class ProductoEscogido8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEscogido8));
            pictureBox2 = new PictureBox();
            label2 = new Label();
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
            pictureBox2.Location = new Point(437, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(85, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(252, 299);
            label2.Name = "label2";
            label2.Size = new Size(21, 19);
            label2.TabIndex = 27;
            label2.Text = "...";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 45);
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
            button3.Location = new Point(299, 408);
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
            button2.Location = new Point(125, 408);
            button2.Name = "button2";
            button2.Size = new Size(125, 38);
            button2.TabIndex = 23;
            button2.Text = "Agregar ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ProductoEscogido8
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 493);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "ProductoEscogido8";
            Text = "ProductoEscogido8";
            Load += ProductoEscogido8_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button2;
    }
}