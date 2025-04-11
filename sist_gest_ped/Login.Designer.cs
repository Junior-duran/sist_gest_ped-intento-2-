namespace sist_gest_ped
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            mtb_Usuario = new MaskedTextBox();
            mtb_Password = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            lbl_usuario = new Label();
            lbl_Password = new Label();
            btn_Login = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mtb_Usuario
            // 
            mtb_Usuario.Location = new Point(117, 345);
            mtb_Usuario.Name = "mtb_Usuario";
            mtb_Usuario.Size = new Size(224, 25);
            mtb_Usuario.TabIndex = 0;
            mtb_Usuario.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // mtb_Password
            // 
            mtb_Password.Location = new Point(117, 417);
            mtb_Password.Name = "mtb_Password";
            mtb_Password.Size = new Size(224, 25);
            mtb_Password.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_usuario.ForeColor = Color.Black;
            lbl_usuario.Location = new Point(50, 351);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(61, 19);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Password.ForeColor = Color.Black;
            lbl_Password.Location = new Point(39, 423);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(72, 19);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.FromArgb(64, 64, 64);
            btn_Login.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(132, 500);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(183, 63);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(456, 25);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(431, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(25, 582);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(25, 582);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(25, 582);
            panel4.Name = "panel4";
            panel4.Size = new Size(406, 25);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(25, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(406, 10);
            panel5.TabIndex = 10;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(25, 572);
            panel6.Name = "panel6";
            panel6.Size = new Size(406, 10);
            panel6.TabIndex = 11;
            panel6.Paint += panel6_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 607);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Login);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_usuario);
            Controls.Add(pictureBox1);
            Controls.Add(mtb_Password);
            Controls.Add(mtb_Usuario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtb_Usuario;
        private MaskedTextBox mtb_Password;
        private PictureBox pictureBox1;
        private Label lbl_usuario;
        private Label lbl_Password;
        private Button btn_Login;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
