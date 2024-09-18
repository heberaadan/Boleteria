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
    public partial class Edit_C : Form
    {
        private int show; // Se guarda el concierto que se quiere cambiar 
        private List<string> fecha_cadu;
        private TickBox tickBox;
        private int user;
        private List<Concierto> shows;
        private List<string> tickets;
        private List<string> compras;
        private List<string> id_img;
        public Edit_C(int id, List<Concierto> conciertos)
        {
            id_img = new List<string>();
            compras = new List<string>();
            fecha_cadu = new List<string>();
            tickets = new List<string>();
            shows = conciertos;
            user = id;
            tickBox = new TickBox();
            InitializeComponent();
        }

        private void Edit_C_Load(object sender, EventArgs e)
        {
            string[] cadena;

            if (File.Exists(tickBox.users[user] + "_ticket.txt"))
            {
                foreach (string linea in File.ReadLines(tickBox.users[user] + "_ticket.txt"))
                {
                    cadena = linea.Trim().Split('|');
                    comboBox.Items.Add(cadena[0] + " - ( " + cadena[3] + " ) - " +
                        "" + cadena[2]);
                    tickets.Add(cadena[4]);
                    fecha_cadu.Add(cadena[6]);
                    compras.Add(linea);
                    id_img.Add(cadena[7]);
                }
            }
            else
            {
                MessageBox.Show("Error: Aún no ha realizado ninguan compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            show = comboBox.SelectedIndex;

            DateTime fecha = DateTime.Now;
            DateTime cadu = DateTime.Parse(fecha_cadu[show]);

            int min = fecha.Minute, min_cadu = cadu.Minute;
            int hour = fecha.Hour, hour_cadu = cadu.Hour;

            if (show != -1)
            {
                boletos.Text = tickets[show];

                if (min > min_cadu & hour >= hour_cadu)
                {
                    boletos.Enabled = false;
                    errorProvider1.SetError(boletos, "Expiro el tiempo para realizar un cambio");
                }
                else
                {
                    boletos.Enabled = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            string[] cadena;
            int cambio;
            if(boletos.Text != string.Empty & boletos.Text.All(char.IsNumber))
            {
                int img = int.Parse(id_img[show]);
                using(StreamWriter write = new StreamWriter(tickBox.users[user] + "_ticket.txt"))
                {
                    for(int i = 0;i < compras.Count(); i++)
                    {
                        if(i != show)
                        {
                            write.WriteLine(compras[i]);
                        }
                        else
                        {
                            if (int.Parse(boletos.Text) > 0)
                            {
                                write.WriteLine(shows[img-1].tour + "|" + shows[img-1].artist + "|" + shows[img - 1].site + "|" + shows[img-1].date.Trim() + "|" + boletos.Text + "|" + DateTime.Parse(fecha_cadu[show]).AddMinutes(-2) + "|" + fecha_cadu[show] + "|" + img);
                            }else if(int.Parse(boletos.Text) < 0)
                            {
                                MessageBox.Show("Error: Número no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }                        
                    }
                }
                MessageBox.Show("Cambios Hechos con exito !!!", "Cambio Exitoso",MessageBoxButtons.OK);
            }
            else
            {
                errorProvider1.SetError(boletos,"Número no válido");
            }
            this.Close();
        }
    }
}
