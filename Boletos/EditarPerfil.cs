using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletos
{
    public partial class Edit : Form
    {
        private TickBox tickBox;
        private int id_user;
        public Edit(int id)
        {
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
    }
}
