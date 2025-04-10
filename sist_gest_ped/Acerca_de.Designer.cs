namespace CapaPresentacion.cs
{
    partial class Acerca_de
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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(33, 19);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 0;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Acerca_de
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Acerca_de";
            Text = "Acerca_de";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}