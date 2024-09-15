namespace Boletos
{
    partial class TickBox
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TickBox));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            username = new TextBox();
            sing_in = new Button();
            label4 = new Label();
            sing_up = new Button();
            errorProvider1 = new ErrorProvider(components);
            pass = new TextBox();
            tickBox_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 58F);
            label1.ForeColor = Color.FromArgb(51, 46, 29);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(380, 88);
            label1.TabIndex = 0;
            label1.Text = "TickBox";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.goyopan;
            pictureBox1.Location = new Point(455, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 15F);
            label2.Location = new Point(41, 132);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 215);
            label3.Name = "label3";
            label3.Size = new Size(136, 22);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // username
            // 
            username.Font = new Font("Bahnschrift SemiLight SemiConde", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(41, 172);
            username.Name = "username";
            username.Size = new Size(265, 23);
            username.TabIndex = 4;
            username.TextChanged += username_TextChanged;
            // 
            // sing_in
            // 
            sing_in.BackColor = Color.FromArgb(239, 235, 169);
            sing_in.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            sing_in.Location = new Point(41, 301);
            sing_in.Name = "sing_in";
            sing_in.Size = new Size(75, 23);
            sing_in.TabIndex = 6;
            sing_in.Text = "Ingresar";
            sing_in.UseVisualStyleBackColor = false;
            sing_in.Click += sing_in_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(493, 345);
            label4.Name = "label4";
            label4.Size = new Size(276, 20);
            label4.TabIndex = 7;
            label4.Text = "¿Eres nuevo en la aplicación?";
            // 
            // sing_up
            // 
            sing_up.BackColor = Color.FromArgb(239, 235, 169);
            sing_up.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            sing_up.Location = new Point(559, 368);
            sing_up.Name = "sing_up";
            sing_up.Size = new Size(155, 23);
            sing_up.TabIndex = 8;
            sing_up.Text = "Crear nueva cuenta";
            sing_up.UseVisualStyleBackColor = false;
            sing_up.Click += sing_up_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pass
            // 
            pass.Font = new Font("Bahnschrift SemiLight SemiConde", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pass.Location = new Point(41, 250);
            pass.Name = "pass";
            pass.Size = new Size(265, 23);
            pass.TabIndex = 9;
            pass.UseSystemPasswordChar = true;
            pass.TextChanged += pass_TextChanged;
            // 
            // tickBox_close
            // 
            tickBox_close.BackColor = Color.FromArgb(239, 235, 169);
            tickBox_close.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tickBox_close.Location = new Point(41, 426);
            tickBox_close.Name = "tickBox_close";
            tickBox_close.Size = new Size(75, 23);
            tickBox_close.TabIndex = 10;
            tickBox_close.Text = "Salir";
            tickBox_close.UseVisualStyleBackColor = false;
            tickBox_close.Click += tickBox_close_Click;
            // 
            // TickBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 211);
            ClientSize = new Size(804, 461);
            Controls.Add(tickBox_close);
            Controls.Add(pass);
            Controls.Add(sing_up);
            Controls.Add(label4);
            Controls.Add(sing_in);
            Controls.Add(username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(51, 46, 29);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TickBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TickBox";
            Load += TickBox_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox username;
        private Button sing_in;
        private Label label4;
        private Button sing_up;
        private ErrorProvider errorProvider1;
        private TextBox pass;
        private Button tickBox_close;
    }
}
