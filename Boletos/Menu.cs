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
    public partial class Menu : Form
    {
        private int id_user;
        private TickBox tickBox;
        private int ImageNumber = 1;
        private string[] lineas;
        public List<Concierto> conciertos;
        private int inicio, fin, img;
        public Menu(int id)
        {
            conciertos = new List<Concierto>();
            tickBox = new TickBox();
            id_user = id;

            string info = Properties.Resources.info_conciertos;
            lineas = info.Split('\n');

            for (int i = 0; i < 10; i++)
            {
                conciertos.Add(new Concierto());
                conciertos[i].addinfo(lineas[i]);
            }

            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            saludo.Text += tickBox.names[id_user]; // Adjunta el nombre del usuario con el titulo Bienvenidos
        }

        private void salir_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Slider()
        {
            if (ImageNumber > 10)
            {
                ImageNumber = 1;
            }
            else if (ImageNumber < 1)
            {
                ImageNumber = 10;
            }

            slide_picture.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ImageNumber++;
            Slider();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 10;
            }
            slide_picture.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ImageNumber++;
            if (ImageNumber > 10)
            {
                ImageNumber = 1;
            }
            slide_picture.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
        }
        private void slide_picture_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            DateTime fecha_cadu;
            string id_image = slide_picture.ImageLocation;

            if (id_image != null) // Extrae el indice de la imagen del boleto que se quiere comprar
            {
                inicio = id_image.IndexOf('\\');
                fin = id_image.IndexOf('.');

                id_image = id_image.Substring(inicio + 1, fin - inicio - 1);

                img = int.Parse(id_image);

                using (NumBoletos num = new NumBoletos(img - 1, conciertos))
                {
                    num.ShowDialog();
                }

                if (conciertos[img-1].numBoletos > 0)
                {
                    fecha_cadu = fecha.AddMinutes(2);

                    using (StreamWriter ticket = new StreamWriter(tickBox.users[id_user] + "_ticket.txt", true))
                    {
                        ticket.WriteLine(conciertos[img - 1].tour + "|" + conciertos[img - 1].artist + "|" + conciertos[img - 1].site + "|" + conciertos[img - 1].date.Trim() + "|" + conciertos[img - 1].numBoletos + "|" + fecha + "|" + fecha_cadu + "|" + img);
                    }
                }
            }
        }

        private void historial_compras_Click(object sender, EventArgs e)
        {
            if (File.Exists(tickBox.users[id_user] + "_ticket.txt"))
            {
                using (History history = new History(id_user))
                {
                    history.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Error: Aún no ha hecho ninguna compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Edit edit = new Edit(id_user))
            {
                edit.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Edit_C edit = new Edit_C(id_user, conciertos)) { edit.ShowDialog(); }
        }
    }
}

