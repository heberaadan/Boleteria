namespace Boletos
{
    partial class new_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_user));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            enter = new Button();
            back = new Button();
            email = new TextBox();
            new_username = new TextBox();
            name = new TextBox();
            password = new TextBox();
            password_2 = new TextBox();
            phone = new TextBox();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            create_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Broadway", 30F);
            label1.ForeColor = Color.FromArgb(239, 235, 169);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(145, 22);
            label1.Name = "label1";
            label1.Size = new Size(453, 48);
            label1.TabIndex = 0;
            label1.Text = "Crear nueva cuenta";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 13F);
            label3.ForeColor = Color.FromArgb(239, 235, 169);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(60, 185);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 13F);
            label2.ForeColor = Color.FromArgb(239, 235, 169);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(60, 138);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 13F);
            label4.ForeColor = Color.FromArgb(239, 235, 169);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(60, 234);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 4;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Broadway", 13F);
            label5.ForeColor = Color.FromArgb(239, 235, 169);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(60, 88);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 5;
            label5.Text = "Correo electrónico";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Broadway", 13F);
            label6.ForeColor = Color.FromArgb(239, 235, 169);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(60, 283);
            label6.Name = "label6";
            label6.Size = new Size(233, 20);
            label6.TabIndex = 6;
            label6.Text = "Confirmar contraseña";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Broadway", 13F);
            label7.ForeColor = Color.FromArgb(239, 235, 169);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(60, 332);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 7;
            label7.Text = "Telefono";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // enter
            // 
            enter.BackColor = Color.FromArgb(250, 252, 211);
            enter.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            enter.Location = new Point(60, 416);
            enter.Name = "enter";
            enter.Size = new Size(88, 23);
            enter.TabIndex = 8;
            enter.Text = "Confirmar";
            enter.UseVisualStyleBackColor = false;
            enter.Click += enter_Click;
            // 
            // back
            // 
            back.BackColor = Color.FromArgb(250, 252, 211);
            back.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            back.Location = new Point(611, 416);
            back.Name = "back";
            back.Size = new Size(75, 23);
            back.TabIndex = 9;
            back.Text = "Regresar";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // email
            // 
            email.Location = new Point(60, 111);
            email.Name = "email";
            email.Size = new Size(233, 23);
            email.TabIndex = 10;
            email.TextChanged += email_TextChanged;
            // 
            // new_username
            // 
            new_username.Location = new Point(60, 161);
            new_username.Name = "new_username";
            new_username.Size = new Size(233, 23);
            new_username.TabIndex = 11;
            new_username.TextChanged += new_username_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(60, 208);
            name.Name = "name";
            name.Size = new Size(233, 23);
            name.TabIndex = 12;
            name.TextChanged += name_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(60, 257);
            password.Name = "password";
            password.Size = new Size(233, 23);
            password.TabIndex = 13;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // password_2
            // 
            password_2.Location = new Point(60, 306);
            password_2.Name = "password_2";
            password_2.Size = new Size(233, 23);
            password_2.TabIndex = 14;
            password_2.UseSystemPasswordChar = true;
            password_2.TextChanged += password_2_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(60, 355);
            phone.Name = "phone";
            phone.Size = new Size(233, 23);
            phone.TabIndex = 15;
            phone.TextChanged += phone_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gato;
            pictureBox1.Location = new Point(422, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // create_close
            // 
            create_close.BackColor = Color.FromArgb(250, 252, 211);
            create_close.Font = new Font("Broadway", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            create_close.Location = new Point(717, 416);
            create_close.Name = "create_close";
            create_close.Size = new Size(75, 23);
            create_close.TabIndex = 18;
            create_close.Text = "Salir";
            create_close.UseVisualStyleBackColor = false;
            create_close.Click += create_close_Click;
            // 
            // new_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 46, 29);
            ClientSize = new Size(804, 461);
            Controls.Add(create_close);
            Controls.Add(pictureBox1);
            Controls.Add(phone);
            Controls.Add(password_2);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(new_username);
            Controls.Add(email);
            Controls.Add(back);
            Controls.Add(enter);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "new_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear Usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button enter;
        private Button back;
        private TextBox email;
        private TextBox new_username;
        private TextBox name;
        private TextBox password;
        private TextBox password_2;
        private TextBox phone;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private Button create_close;
    }
}