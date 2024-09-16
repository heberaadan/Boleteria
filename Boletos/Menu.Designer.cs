namespace Boletos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            saludo = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // saludo
            // 
            saludo.AutoSize = true;
            saludo.BorderStyle = BorderStyle.Fixed3D;
            saludo.Font = new Font("Broadway", 30F);
            saludo.ForeColor = SystemColors.ButtonFace;
            saludo.Location = new Point(12, 9);
            saludo.Name = "saludo";
            saludo.Size = new Size(311, 48);
            saludo.TabIndex = 0;
            saludo.Text = "BIENVENIDO, ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 199, 170);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 371);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 21);
            button1.Name = "button1";
            button1.Size = new Size(262, 23);
            button1.TabIndex = 0;
            button1.Text = "Editar perfil";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 63);
            button2.Name = "button2";
            button2.Size = new Size(262, 23);
            button2.TabIndex = 1;
            button2.Text = "Consultar Compras";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bodoque;
            pictureBox1.Location = new Point(24, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(90, 199, 170);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(349, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 371);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Broadway", 30F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(115, 21);
            label1.Name = "label1";
            label1.Size = new Size(241, 48);
            label1.TabIndex = 3;
            label1.Text = "COMPRAR";
            // 
            // button3
            // 
            button3.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(17, 324);
            button3.Name = "button3";
            button3.Size = new Size(114, 23);
            button3.TabIndex = 3;
            button3.Text = "Anterior";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(299, 324);
            button4.Name = "button4";
            button4.Size = new Size(114, 23);
            button4.TabIndex = 4;
            button4.Text = "Siguiente";
            button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(73, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 211);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 220, 185);
            ClientSize = new Size(804, 461);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(saludo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Menu";
            Load += this.Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saludo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button3;
        private Label label1;
    }
}