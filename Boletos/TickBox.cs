namespace Boletos
{
    public partial class TickBox : Form
    {
        public TickBox()
        {
            InitializeComponent();
        }

        private void sing_in_Click(object sender, EventArgs e)
        {

        }

        private void TickBox_Load(object sender, EventArgs e)
        {
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
                if (!username.Text.All(char.IsLetter))
                {
                    errorProvider1.SetError(username, "El nombre sólo debe contener letras");
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
    }
}
