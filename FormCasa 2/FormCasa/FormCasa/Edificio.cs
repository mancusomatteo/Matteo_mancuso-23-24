using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCasa
{
    public class Edificio
    {
        private List<string> coloriAmmessi = new List<string>()
        {"bianco","nero","rosso","giallo" };
        private string colore;

        public string Colore
        {
            get { return colore; }
            set
            {
                if (coloriAmmessi.Contains(value))
                {
                    colore = value;
                }
                else
                {
                    throw new Exception("il colore non e ammesso");
                }
            }
        }

        private int annoVendita;

        public int AnnoVendita
        {
            get { return annoVendita; }
            set
            {
                if (value < 1950 || value > 2024)
                {
                    throw new Exception("anno di vendita non valido");
                }
                else
                {
                    annoVendita = value;
                }
            }
        }

    }
}
