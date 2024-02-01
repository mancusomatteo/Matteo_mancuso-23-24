using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCasa
{
    public class Quadrilocale : Edificio
    {

        public Quadrilocale(string col, int anno)
        {
            Colore = col;
            AnnoVendita = anno;
        }

        public override string ToString()
        {

            return $"Colore: {Colore}, anno di vendita: {AnnoVendita}";
        }
    }
}
