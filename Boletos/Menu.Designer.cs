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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            saludo = new Label();
            panel1 = new Panel();
            button2 = new Button();
            salir_menu = new Button();
            pictureBox1 = new PictureBox();
            historial_compras = new Button();
            button1 = new Button();
            panel2 = new Panel();
            slide_picture = new PictureBox();
            siguiente = new Button();
            anterior = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)slide_picture).BeginInit();
            SuspendLayout();
            // 
            // saludo
            // 
            saludo.AutoSize = true;
            saludo.BorderStyle = BorderStyle.Fixed3D;
            saludo.Font = new Font("Broadway", 25F);
            saludo.ForeColor = SystemColors.ButtonFace;
            saludo.Location = new Point(12, 9);
            saludo.Name = "saludo";
            saludo.Size = new Size(268, 40);
            saludo.TabIndex = 0;
            saludo.Text = "BIENVENIDO, ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 199, 170);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(salir_menu);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(historial_compras);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(12, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 371);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(24, 101);
            button2.Name = "button2";
            button2.Size = new Size(262, 23);
            button2.TabIndex = 7;
            button2.Text = "Editar Compras";
            button2.UseVisualStyleBackColor = true;
            // 
            // salir_menu
            // 
            salir_menu.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salir_menu.Location = new Point(24, 324);
            salir_menu.Name = "salir_menu";
            salir_menu.Size = new Size(114, 23);
            salir_menu.TabIndex = 6;
            salir_menu.Text = "Salir";
            salir_menu.UseVisualStyleBackColor = true;
            salir_menu.Click += salir_menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bodoque;
            pictureBox1.Location = new Point(44, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // historial_compras
            // 
            historial_compras.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            historial_compras.Location = new Point(24, 63);
            historial_compras.Name = "historial_compras";
            historial_compras.Size = new Size(262, 23);
            historial_compras.TabIndex = 1;
            historial_compras.Text = "Consultar Compras";
            historial_compras.UseVisualStyleBackColor = true;
            historial_compras.Click += historial_compras_Click;
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
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(90, 199, 170);
            panel2.Controls.Add(slide_picture);
            panel2.Controls.Add(siguiente);
            panel2.Controls.Add(anterior);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(349, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 371);
            panel2.TabIndex = 2;
            // 
            // slide_picture
            // 
            slide_picture.Image = (Image)resources.GetObject("slide_picture.Image");
            slide_picture.Location = new Point(31, 86);
            slide_picture.Name = "slide_picture";
            slide_picture.Size = new Size(393, 211);
            slide_picture.SizeMode = PictureBoxSizeMode.Zoom;
            slide_picture.TabIndex = 5;
            slide_picture.TabStop = false;
            slide_picture.Click += slide_picture_Click;
            // 
            // siguiente
            // 
            siguiente.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            siguiente.Location = new Point(299, 324);
            siguiente.Name = "siguiente";
            siguiente.Size = new Size(114, 23);
            siguiente.TabIndex = 4;
            siguiente.Text = "Siguiente";
            siguiente.UseVisualStyleBackColor = true;
            siguiente.Click += button4_Click;
            // 
            // anterior
            // 
            anterior.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            anterior.Location = new Point(17, 324);
            anterior.Name = "anterior";
            anterior.Size = new Size(114, 23);
            anterior.TabIndex = 3;
            anterior.Text = "Anterior";
            anterior.UseVisualStyleBackColor = true;
            anterior.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Broadway", 30F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(114, 21);
            label1.Name = "label1";
            label1.Size = new Size(241, 48);
            label1.TabIndex = 3;
            label1.Text = "COMPRAR";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
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
            MaximizeBox = false;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)slide_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saludo;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button historial_compras;
        private Button button1;
        private Panel panel2;
        private Button siguiente;
        private Button anterior;
        private Label label1;
        private Button salir_menu;
        private System.Windows.Forms.Timer timer1;
        private PictureBox slide_picture;
        private Button button2;
    }
}