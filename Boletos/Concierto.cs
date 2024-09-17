using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos
{
    public class Concierto
    {
        public string tour;
        public string artist;
        public string date;
        public string site;
        private string[] info;
        public int numBoletos;
        public Concierto() {
            numBoletos = 0;
        }
        public void addinfo(string fila)
        {
            info = fila.Split('|');
            tour = info[0];
            artist = info[1];
            site = info[2];
            date = info[3];
        }
    }
}
