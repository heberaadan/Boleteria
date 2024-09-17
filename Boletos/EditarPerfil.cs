using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Boletos
{
    public partial class Edit : Form
    {
        private int up_name = 0, up_email = 0, up_phone = 0, up_pass = 0, up_user = 0;
        private TickBox tickBox;
        private int id_user;
        private new_user neu;
        public Edit(int id)
        {
            neu = new new_user();
            id_user = id;
            tickBox = new TickBox();
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            email.Enabled = false;
            email.Text = tickBox.emails[id_user];
            name.Enabled = false;
            name.Text = tickBox.names[id_user];
            phone.Enabled = false;
            phone.Text = tickBox.phones[id_user];
            password.Enabled = false;
            password.Text = tickBox.contras[id_user];
            password_2.Enabled = false;
            password_2.Text = tickBox.contras[id_user];
            new_username.Enabled = false;
            new_username.Text = tickBox.users[id_user];
        }
        private void Edit_email_Click(object sender, EventArgs e)
        {
            email.Enabled = true;
        }
        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Enabled)
            {
                if (email.Text != string.Empty & Regex.IsMatch(email.Text, neu.patronCorreo))
                {
                    up_email = 1;
                    errorProvider1.SetError(email, "");
                    tickBox.emails[id_user] = email.Text;
                }
                else
                {
                    errorProvider1.SetError(email, "Dirección de correo no válido");
                }
            }
        }
        private void Edit_user_Click(object sender, EventArgs e)
        {
            new_username.Enabled = true;
        }

        private void new_username_TextChanged(object sender, EventArgs e)
        {
            if (new_username.Enabled)
            {
                if (new_username.Text.All(char.IsLetter) & new_username.Text != string.Empty)
                {
                    up_user = 1;
                    tickBox.users[id_user] = new_username.Text;
                }
            }
        }

        private void Edit_name_Click(object sender, EventArgs e)
        {
            name.Enabled = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Enabled)
            {
                string name2 = name.Text.Replace(" ", "");
                if (name2.All(char.IsLetter) & name2 != string.Empty)
                {
                    up_name = 1;
                    errorProvider1.SetError(name, "");
                    tickBox.names[id_user] = name.Text;
                }
                else
                {
                    errorProvider1.SetError(name, "No se permiten número ni carácteres especiales");
                }
            }
        }
        private void Edit_pass_Click(object sender, EventArgs e)
        {
            password.Enabled = true;
            password_2.Enabled = true;
        }

        private void Compara_Contras()
        {
            if(password.Enabled && password_2.Enabled)
            {
                if (password_2.Text != string.Empty & password.Text != string.Empty)
                {
                    if (password_2.Text.Equals(password.Text))
                    {
                        up_pass = 1;
                        errorProvider1.SetError(password_2, "");
                        tickBox.contras[id_user] = password_2.Text;
                    }
                    else
                    {
                        errorProvider1.SetError(password_2, "Las contraseñas no coinciden");
                    }
                }
            }
        }
        private void password_TextChanged(object sender, EventArgs e)
        {
            Compara_Contras();
        }

        private void password_2_TextChanged(object sender, EventArgs e)
        {
            Compara_Contras();
        }

        private void Edit_phone_Click(object sender, EventArgs e)
        {
            phone.Enabled = true;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Enabled)
            {
                if (phone.Text != string.Empty & phone.Text.All(char.IsNumber))
                {
                    up_phone = 1;
                    errorProvider1.SetError(phone, "");
                    tickBox.phones[id_user] = phone.Text;
                }
                else
                {
                    errorProvider1.SetError(phone, "Solo se permiten números");
                }
            }
        }


        private void Actualizar_Usuarios()
        {
            List<string> lineas = new List<string>();

            foreach (string linea in File.ReadLines("usuarios.txt"))
            {
                lineas.Add(linea);
            }

            using (StreamWriter write = new StreamWriter("usuarios.txt"))
            {
                for (int i = 0; i < lineas.Count; i++)
                {
                    if (i != id_user)
                    {
                        write.WriteLine(lineas[i]);
                    }
                    else
                    {
                        write.WriteLine(tickBox.users[id_user] + "|" + tickBox.contras[id_user] + "|" + tickBox.emails[id_user] + "|" + tickBox.names[id_user] + "|" + tickBox.phones[id_user]);
                    }
                }
            }
            MessageBox.Show("Datos Actualizados con Exito !! \n"+data_update(), "Actualización", MessageBoxButtons.OK);
        }
        private string data_update()
        {
            string actualizacion = "";

            if(up_phone == 1)
            {
                actualizacion += " - Teléfono \n";
            }
            if (up_email == 1)
            {
                actualizacion += " - Email\n";
            }
            if(up_pass == 1){
                actualizacion += " - Contraseña \n";
            }
            if(up_name == 1)
            {
                actualizacion += " - Nombre \n";
            }
            if(up_user == 1)
            {
                actualizacion += " - Usiario\n";
            }
            return actualizacion;
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!new_username.Enabled)
            {
                Actualizar_Usuarios();
            }
            else
            {
                if (tickBox.users.Contains(new_username.Text) == false & new_username.Enabled == true)
                {
                    Actualizar_Usuarios();
                }
                else
                {
                    MessageBox.Show("Error: El usuario que ingreso ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            using (Menu menu = new Menu(id_user))
            {
                menu.ShowDialog();
            }
        }
    }
}
