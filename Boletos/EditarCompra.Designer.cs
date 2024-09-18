namespace Boletos
{
    partial class Edit_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_C));
            comboBox = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            boletos = new TextBox();
            confirm = new Button();
            button3 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.BackColor = Color.FromArgb(255, 254, 223);
            comboBox.ForeColor = Color.Black;
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(38, 169);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(489, 23);
            comboBox.TabIndex = 0;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 35F);
            label1.ForeColor = Color.FromArgb(255, 254, 223);
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(491, 53);
            label1.TabIndex = 1;
            label1.Text = "EDITA TU COMPRA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nie;
            pictureBox1.Location = new Point(465, 243);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 15F);
            label2.ForeColor = Color.FromArgb(255, 254, 223);
            label2.Location = new Point(38, 144);
            label2.Name = "label2";
            label2.Size = new Size(243, 22);
            label2.TabIndex = 3;
            label2.Text = "Selecciona tu compra";
            // 
            // boletos
            // 
            boletos.BackColor = Color.FromArgb(255, 254, 223);
            boletos.Location = new Point(544, 169);
            boletos.Name = "boletos";
            boletos.Size = new Size(48, 23);
            boletos.TabIndex = 4;
            // 
            // confirm
            // 
            confirm.BackColor = Color.FromArgb(255, 254, 223);
            confirm.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirm.Location = new Point(626, 168);
            confirm.Name = "confirm";
            confirm.Size = new Size(93, 23);
            confirm.TabIndex = 5;
            confirm.Text = "Confirmar";
            confirm.UseVisualStyleBackColor = false;
            confirm.Click += confirm_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 254, 223);
            button3.Font = new Font("Broadway", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(38, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Edit_C
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 46, 46);
            ClientSize = new Size(804, 461);
            Controls.Add(button3);
            Controls.Add(confirm);
            Controls.Add(boletos);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Edit_C";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Compras";
            Load += Edit_C_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox boletos;
        private Button confirm;
        private Button button3;
        private ErrorProvider errorProvider1;
    }
}