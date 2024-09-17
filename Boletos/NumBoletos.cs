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
    public partial class NumBoletos : Form
    {
        List<Concierto> conciertos;
        private int img;
        private int user;
        public NumBoletos(int id, List<Concierto> show)
        {
            conciertos = show;
            img = id;
            InitializeComponent();
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            if (num.Text != string.Empty & num.Text.All(char.IsNumber))
            {
                if (int.Parse(num.Text) > 0)
                {
                    conciertos[img].numBoletos = int.Parse(num.Text);
                }
                else
                {
                    MessageBox.Show("Error: Número de boletos invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra hecha con exito!!! \n"+
                    "\t -Concierto: " + conciertos[img].tour +
                    "\n \t - Número de Boletos: " + conciertos[img].numBoletos, "Compra exitosa", MessageBoxButtons.OK);

            this.Close();
        }
        public int Num_Boletos()
        {
            return conciertos[img].numBoletos;
        }
    }
}
