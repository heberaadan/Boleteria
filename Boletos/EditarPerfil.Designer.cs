namespace Boletos
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            label1 = new Label();
            phone = new TextBox();
            password_2 = new TextBox();
            password = new TextBox();
            name = new TextBox();
            new_username = new TextBox();
            email = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            salir = new Button();
            Edit_email = new Button();
            Edit_user = new Button();
            Edit_name = new Button();
            Edit_pass = new Button();
            Edit_phone = new Button();
            pictureBox1 = new PictureBox();
            save = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 35.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(78, 88, 91);
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(409, 53);
            label1.TabIndex = 0;
            label1.Text = "EDITAR PERFIL";
            // 
            // phone
            // 
            phone.Location = new Point(22, 364);
            phone.Name = "phone";
            phone.Size = new Size(233, 23);
            phone.TabIndex = 27;
            phone.TextChanged += phone_TextChanged;
            // 
            // password_2
            // 
            password_2.Location = new Point(22, 315);
            password_2.Name = "password_2";
            password_2.Size = new Size(233, 23);
            password_2.TabIndex = 26;
            password_2.UseSystemPasswordChar = true;
            password_2.TextChanged += password_2_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(22, 266);
            password.Name = "password";
            password.Size = new Size(233, 23);
            password.TabIndex = 25;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(22, 217);
            name.Name = "name";
            name.Size = new Size(233, 23);
            name.TabIndex = 24;
            name.TextChanged += name_TextChanged;
            // 
            // new_username
            // 
            new_username.Location = new Point(22, 170);
            new_username.Name = "new_username";
            new_username.Size = new Size(233, 23);
            new_username.TabIndex = 23;
            new_username.TextChanged += new_username_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(22, 120);
            email.Name = "email";
            email.Size = new Size(233, 23);
            email.TabIndex = 22;
            email.TextChanged += email_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Broadway", 13F);
            label7.ForeColor = Color.FromArgb(78, 88, 91);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(22, 341);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 21;
            label7.Text = "Telefono";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Broadway", 13F);
            label6.ForeColor = Color.FromArgb(78, 88, 91);
            label6.ImageAlign = ContentAlignment.TopCenter;
            label6.Location = new Point(22, 292);
            label6.Name = "label6";
            label6.Size = new Size(233, 20);
            label6.TabIndex = 20;
            label6.Text = "Confirmar contraseña";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Broadway", 13F);
            label5.ForeColor = Color.FromArgb(78, 88, 91);
            label5.ImageAlign = ContentAlignment.TopCenter;
            label5.Location = new Point(22, 97);
            label5.Name = "label5";
            label5.Size = new Size(190, 20);
            label5.TabIndex = 19;
            label5.Text = "Correo electrónico";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 13F);
            label4.ForeColor = Color.FromArgb(78, 88, 91);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(22, 243);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 18;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 13F);
            label2.ForeColor = Color.FromArgb(78, 88, 91);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(22, 147);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 17;
            label2.Text = "Usuario";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 13F);
            label3.ForeColor = Color.FromArgb(78, 88, 91);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(22, 194);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 16;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // salir
            // 
            salir.BackColor = Color.FromArgb(245, 227, 174);
            salir.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salir.ForeColor = Color.FromArgb(78, 88, 91);
            salir.Location = new Point(22, 415);
            salir.Name = "salir";
            salir.Size = new Size(75, 23);
            salir.TabIndex = 28;
            salir.Text = "Salir";
            salir.UseVisualStyleBackColor = false;
            salir.Click += salir_Click;
            // 
            // Edit_email
            // 
            Edit_email.BackColor = Color.FromArgb(245, 227, 174);
            Edit_email.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_email.ForeColor = Color.FromArgb(78, 88, 91);
            Edit_email.Location = new Point(261, 120);
            Edit_email.Name = "Edit_email";
            Edit_email.Size = new Size(75, 23);
            Edit_email.TabIndex = 29;
            Edit_email.Text = "Cambiar";
            Edit_email.UseVisualStyleBackColor = false;
            Edit_email.Click += Edit_email_Click;
            // 
            // Edit_user
            // 
            Edit_user.BackColor = Color.FromArgb(245, 227, 174);
            Edit_user.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_user.ForeColor = Color.FromArgb(78, 88, 91);
            Edit_user.Location = new Point(261, 170);
            Edit_user.Name = "Edit_user";
            Edit_user.Size = new Size(75, 23);
            Edit_user.TabIndex = 30;
            Edit_user.Text = "Cambiar";
            Edit_user.UseVisualStyleBackColor = false;
            Edit_user.Click += Edit_user_Click;
            // 
            // Edit_name
            // 
            Edit_name.BackColor = Color.FromArgb(245, 227, 174);
            Edit_name.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_name.ForeColor = Color.FromArgb(78, 88, 91);
            Edit_name.Location = new Point(261, 217);
            Edit_name.Name = "Edit_name";
            Edit_name.Size = new Size(75, 23);
            Edit_name.TabIndex = 31;
            Edit_name.Text = "Cambiar";
            Edit_name.UseVisualStyleBackColor = false;
            Edit_name.Click += Edit_name_Click;
            // 
            // Edit_pass
            // 
            Edit_pass.BackColor = Color.FromArgb(245, 227, 174);
            Edit_pass.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_pass.ForeColor = Color.FromArgb(78, 88, 91);
            Edit_pass.Location = new Point(261, 266);
            Edit_pass.Name = "Edit_pass";
            Edit_pass.Size = new Size(75, 23);
            Edit_pass.TabIndex = 32;
            Edit_pass.Text = "Cambiar";
            Edit_pass.UseVisualStyleBackColor = false;
            Edit_pass.Click += Edit_pass_Click;
            // 
            // Edit_phone
            // 
            Edit_phone.BackColor = Color.FromArgb(245, 227, 174);
            Edit_phone.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Edit_phone.ForeColor = Color.FromArgb(78, 88, 91);
            Edit_phone.Location = new Point(261, 364);
            Edit_phone.Name = "Edit_phone";
            Edit_phone.Size = new Size(75, 23);
            Edit_phone.TabIndex = 34;
            Edit_phone.Text = "Cambiar";
            Edit_phone.UseVisualStyleBackColor = false;
            Edit_phone.Click += Edit_phone_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.manga;
            pictureBox1.Location = new Point(402, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(366, 267);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // save
            // 
            save.BackColor = Color.FromArgb(245, 227, 174);
            save.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save.ForeColor = Color.FromArgb(78, 88, 91);
            save.Location = new Point(180, 415);
            save.Name = "save";
            save.Size = new Size(75, 23);
            save.TabIndex = 36;
            save.Text = "Guardar";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 227, 174);
            ClientSize = new Size(804, 461);
            Controls.Add(save);
            Controls.Add(pictureBox1);
            Controls.Add(Edit_phone);
            Controls.Add(Edit_pass);
            Controls.Add(Edit_name);
            Controls.Add(Edit_user);
            Controls.Add(Edit_email);
            Controls.Add(salir);
            Controls.Add(phone);
            Controls.Add(password_2);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(new_username);
            Controls.Add(email);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Perfil";
            Load += Edit_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox phone;
        private TextBox password_2;
        private TextBox password;
        private TextBox name;
        private TextBox new_username;
        private TextBox email;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button salir;
        private Button Edit_email;
        private Button Edit_user;
        private Button Edit_name;
        private Button Edit_pass;
        private Button Edit_phone;
        private PictureBox pictureBox1;
        private Button save;
        private ErrorProvider errorProvider1;
    }
}