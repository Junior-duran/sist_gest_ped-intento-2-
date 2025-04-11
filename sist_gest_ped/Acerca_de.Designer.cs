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
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.ForeColor = Color.White;
            button1.Location = new Point(202, 351);
            button1.Name = "button1";
            button1.Size = new Size(360, 43);
            button1.TabIndex = 0;
            button1.Text = "VOLVER AL MENU PRINCIPAL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 303);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 1;
            label1.Text = "Version 1.32";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 62);
            label2.Name = "label2";
            label2.Size = new Size(642, 48);
            label2.TabIndex = 2;
            label2.Text = "Albert Frank 2023-3794, Junior Duran 2023-1146, Clary luz 2022-2144\r\n\r\n";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 420);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 30);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(770, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(30, 390);
            panel3.TabIndex = 5;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 30);
            panel4.Name = "panel4";
            panel4.Size = new Size(30, 390);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(30, 30);
            panel5.Name = "panel5";
            panel5.Size = new Size(740, 20);
            panel5.TabIndex = 7;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(30, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(740, 20);
            panel6.TabIndex = 8;
            panel6.Paint += panel6_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 110);
            label3.Name = "label3";
            label3.Size = new Size(434, 19);
            label3.TabIndex = 9;
            label3.Text = "NOT CAP, LO TIGUERE NO MIENTEN BRUUUUUHHHH ;)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(363, 329);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 10;
            label4.Text = "Yeeeeee";
            // 
            // Acerca_de
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Acerca_de";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private Label label4;
    }
}