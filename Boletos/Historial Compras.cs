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
    public partial class History : Form
    {
        private List<PictureBox> pictureBox; // Agrega las imagenes
        private TickBox tickBox; // Para obtener el username
        private Label etiqueta; // Titulo 
        private List<Label> label; // El texto de cada uno de la información del concierto 
        private List<Panel> panel;
        private int id_user, i_label;
        private int posX = 20, posY = 80;
        private List<string> compras;
        private string[] datos;
        private List<Button> button;
        public History(int id)
        {
            pictureBox = new List<PictureBox>();
            panel = new List<Panel>();
            button = new List<Button>();
            tickBox = new TickBox();
            id_user = id;
            label = new List<Label>();
            compras = new List<string>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i_label = 0;
            foreach (string linea in File.ReadLines(tickBox.users[id_user] + "_ticket.txt"))
            {
                compras.Add(linea);
            }

            // Agregar un Panel 
            for (int j = 0; j < compras.Count(); j++)
            {
                panel.Add(new Panel());
                panel[j].Location = new Point(posX, posY + (170 * j));
                panel[j].Size = new Size(760, 150);
                panel[j].BackColor = Color.FromArgb(137, 118, 50);

                datos = compras[j].Split('|');

                for (int i = 0; i < datos.Length - 2; i++)
                {
                    label.Add(new Label());
                    if(i == 4)
                    {
                        label[i_label].Text = "Boleto(s) Comprado(s): " + datos[i];
                    }
                    else if(i == 5)
                    {
                        label[i_label].Text = "Fecha de Compra: " + datos[i];
                    }
                    else
                    {
                        label[i_label].Text = datos[i];
                    }
                    label[i_label].Location = new Point(20,10+(20*i));
                    label[i_label].Font = new Font("Broadway", 7);
                    label[i_label].ForeColor = Color.FromArgb(255, 245, 214);
                    label[i_label].AutoSize = true;

                    i_label++;
                }

                pictureBox.Add(new PictureBox());
                pictureBox[j].Location = new Point(630, 20);  // Colocamos la imagen a la derecha de las etiquetas
                pictureBox[j].Size = new Size(100, 100);      // Tamaño de la imagen
                pictureBox[j].SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox[j].Image = Image.FromFile(@"Images\" + datos[datos.Length-1] +".jpg");  // Ruta de la imagen

                for (int i = i_label - datos.Length + 2; i < i_label; i++)
                {
                    panel[j].Controls.Add(label[i]);
                }

                panel[j].Controls.Add(pictureBox[j]);

                this.Controls.Add(panel[j]);
            }
            // Crear y configurar el control Label (para texto estático)
            etiqueta = new Label();
            etiqueta.Text = "Tus Compras:";
            etiqueta.Location = new Point(20, 20);
            etiqueta.Font = new Font("Broadway", 35);
            etiqueta.ForeColor = Color.FromArgb(255, 245, 214);
            etiqueta.AutoSize = true; // Ajusta el tamaño automáticamente

            this.Controls.Add(etiqueta);

            Button boton = new Button();
            boton.Text = "Regresar";
            boton.Font = new Font("Broadway", 9);
            boton.Size = new Size(200, 40);
            boton.ForeColor = Color.FromArgb(255, 245, 214);
            boton.Location = new Point(panel[panel.Count() - 1].Location.X, panel[panel.Count() - 1].Location.Y + panel[panel.Count() - 1].Height + 10);

            this.Controls.Add(boton);

            boton.Click += Boton_Click;
        }

        private void Boton_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

    }
}
