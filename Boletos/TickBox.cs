namespace Boletos
{
    public partial class TickBox : Form
    {
        public List<string> users;
        public List<string> contras;
        public List<string> names;
        public List<string> phones;
        public List<string> emails;
        private string[] datos;
        private int id;
        public TickBox()
        {
            users = new List<string>();
            contras = new List<string>();
            names = new List<string>();
            phones = new List<string>();
            emails = new List<string>();

            InitializeComponent();

            try
            {
                foreach (string linea in File.ReadLines("usuarios.txt")) //Lee el archivo línea por línea
                {
                    datos = linea.Trim().Split('|');
                    users.Add(datos[0]);
                    contras.Add(datos[1]);
                    emails.Add(datos[2]);
                    names.Add(datos[3]);
                    phones.Add(datos[4]);
                }
            }
            catch
            {
                File.WriteAllText("usuarios.txt", "");
            }

        }

        private void TickBox_Load(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
            sing_in.Enabled = false; // Deshabilita el botón de inicio 
        }

        private void controlBottom()
        {
            // Verfica que el texto no este vacío y que todos los caracteres sean letras.
            if (username.Text.Trim() != string.Empty && username.Text.All(char.IsLetter) && pass.Text != string.Empty)
            {
                sing_in.Enabled = true;
                errorProvider1.SetError(username, ""); // Desaparece el mensaje de error
            }
            else
            {
                sing_in.Enabled = false;
                if (!username.Text.All(char.IsLetter))
                {
                    errorProvider1.SetError(username, "El username sólo debe contener letras");
                }
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            controlBottom();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            controlBottom();
        }

        private void sing_up_Click(object sender, EventArgs e)
        {
            using (new_user Window_NewUser = new new_user())
            {
                Window_NewUser.ShowDialog();
                this.Close();
            }
        }
        private void tickBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sing_in_Click(object sender, EventArgs e)
        {
            if (users.Contains(username.Text) && contras.Contains(pass.Text))
            {
                id =  users.IndexOf(username.Text);
                using (Menu menu = new Menu(id))
                {
                    menu.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Error: Usuario y/o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
