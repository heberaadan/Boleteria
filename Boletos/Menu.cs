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
        private List<Concierto> conciertos;
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
            string id_image = slide_picture.ImageLocation;

            if(id_image != null) // Extrae el indice de la imagen del boleto que se quiere comprar
            {
                inicio = id_image.IndexOf('\\');
                fin = id_image.IndexOf('.');

                id_image = id_image.Substring(inicio + 1, fin - inicio - 1);
                img = int.Parse(id_image);
                MessageBox.Show("Gracias por comprar un boleto para: " + conciertos[img-1].tour, "Compra exitosa", MessageBoxButtons.OK);

                using (StreamWriter ticket = new StreamWriter("ticket.txt", true))
                {
                    ticket.WriteLine(tickBox.users[id_user] + "|" + conciertos[img - 1].tour + "|" + conciertos[img - 1].numBoletos.ToString());
                }
            }
        }
    }
}

