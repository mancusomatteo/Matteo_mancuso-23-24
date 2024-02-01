using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoli
{
    public class Edificio
    {
        private int unita_occupate;
        private int guadagno;
        private string tipo;

        public int Unita_occupate
        {
            get { return unita_occupate; }
        }
        public int Guadagno
        {
            get { return guadagno; }
        }
        public string Tipo
        {
            get { return tipo; }
        }

        public Edificio(int u, int g, string t)
        {
            unita_occupate = u;
            guadagno = g;
            tipo = t;
        }

    }
}
    
