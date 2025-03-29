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
            mtb_Usuario = new MaskedTextBox();
            mtb_Password = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            lbl_usuario = new Label();
            lbl_Password = new Label();
            btn_Login = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mtb_Usuario
            // 
            mtb_Usuario.Location = new Point(153, 364);
            mtb_Usuario.Name = "mtb_Usuario";
            mtb_Usuario.Size = new Size(196, 23);
            mtb_Usuario.TabIndex = 0;
            mtb_Usuario.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // mtb_Password
            // 
            mtb_Password.Location = new Point(153, 411);
            mtb_Password.Name = "mtb_Password";
            mtb_Password.Size = new Size(196, 23);
            mtb_Password.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = CapaPresentacion.cs.Properties.Resources._5087579;
            pictureBox1.Location = new Point(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Location = new Point(100, 372);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(47, 15);
            lbl_usuario.TabIndex = 3;
            lbl_usuario.Text = "Usuario";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(100, 419);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 4;
            lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Constantia", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.FromArgb(255, 128, 255);
            btn_Login.Location = new Point(134, 528);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(183, 56);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 698);
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
    }
}
