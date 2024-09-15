using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Boletos
{
    public partial class new_user : Form
    {
        string usuario, contraseña, nombre, celular, correo;
        string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public new_user()
        {
            InitializeComponent();
        }


        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email_TextChanged != null && Regex.IsMatch(email.Text, patronCorreo))
            {
                correo = email.Text;
                errorProvider1.SetError(email, "");
            }
            else
            {
                errorProvider1.SetError(email, "Dirección de correo no válido");
            }
        }

        private void new_username_TextChanged(object sender, EventArgs e)
        {
            if (new_username.Text.All(char.IsLetter))
            {
                usuario = new_username.Text;
                errorProvider1.SetError(new_username, "");
            }
            else
            {
                errorProvider1.SetError(new_username, "No se aceptan carácteres especiales (Solo texto)");
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            string name2 = name.Text.Replace(" ", "");
            if (name2.All(char.IsLetter))
            {
                nombre = name.Text;
                errorProvider1.SetError(name, "");
            }
            else
            {
                errorProvider1.SetError(name, "No se aceptan carácteres especiales");
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            VerificarContra();
        }

        private void password_2_TextChanged(object sender, EventArgs e)
        {
            VerificarContra();
        }

        private void VerificarContra()
        {
            if (password_2.Text != string.Empty)
            {
                if (password.Text.Equals(password_2.Text)) // Compara ambas contraseñas para ver que esten correctas
                {
                    contraseña = password_2.Text;
                    errorProvider1.SetError(password_2, "");
                }
                else
                {
                    errorProvider1.SetError(password_2, " Las contraseñas no coinciden");
                }
            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text.All(char.IsNumber))
            {
                celular = phone.Text;
                errorProvider1.SetError(phone, "");
            }
            else
            {
                errorProvider1.SetError(phone, "Número telefónico no válido");
            }

            if (phone.Text.Length > 10) // Verifica que el número no sea mas largo de 10 carácteres
            {
                errorProvider1.SetError(phone, "Número muy largo");
            }
        }
        private bool FullDatos()
        {
            if (email.Text != string.Empty && new_username.Text != string.Empty && password.Text != string.Empty && password_2.Text != string.Empty && phone.Text != string.Empty)
            {
                errorProvider1.SetError(email, "");
                errorProvider1.SetError(new_username, "");
                errorProvider1.SetError(password, "");
                errorProvider1.SetError(password_2, "");
                errorProvider1.SetError(name, "");
                errorProvider1.SetError(phone, "");
                return true;
            }
            else
            {
                return false;
            }
        }
        private void enter_Click(object sender, EventArgs e)
        {
            if (FullDatos())
            {
                using (StreamWriter users = new StreamWriter("usuarios.txt", true))
                {
                    users.WriteLine(usuario + "|" + contraseña + "|" + correo + "|" + celular);
                }
                MessageBox.Show("Datos registrados con exito !!!  :)", "Datos Registrados");
            }
            else
            {
                if (email.Text == String.Empty)
                {
                    errorProvider1.SetError(email, "Llenar el campo vacío ");
                }
                if (new_username.Text == String.Empty)
                {
                    errorProvider1.SetError(new_username, "Llenar el campo vacío ");
                }
                if (name.Text == String.Empty)
                {
                    errorProvider1.SetError(name, "Llenar el campo vacío ");
                }
                if (password.Text == String.Empty)
                {
                    errorProvider1.SetError(password, "Llenar el campo vacío ");
                }
                if (password_2.Text == String.Empty)
                {
                    errorProvider1.SetError(password_2, "Llenar el campo vacío ");
                }
            }
        }

        private void create_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            using (TickBox Window_NewUser = new TickBox())
            {
                Window_NewUser.ShowDialog();
                this.Close();
            }
        }
    }
}
