using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPoli
{
    public class Terreno
    {
        private int unita_disponibili;
        private int guadagno;
        private List<Edificio> edifici = new List<Edificio>();

        public int Unita_disponibili
        {
            get { return unita_disponibili; }
            set
            {
                if (value < 0) throw new Exception("Unità disponibili insufficienti");
                unita_disponibili = value;
            }
        }
        public int Guadagno
        {
            get { return guadagno; }
            set { guadagno = value; }
        }
        public List<Edificio> Edifici
        {
            get { return edifici; }
        }

        public void alloca_ed(Edificio e)
        {
            try { Unita_disponibili -= e.Unita_occupate; }
            catch { return; }
            edifici.Add(e);
            Guadagno += e.Guadagno;
        }

        public void dealloca_ed(Edificio e)
        {
            edifici.Remove(e);
            Unita_disponibili += e.Unita_occupate;
            Guadagno -= e.Guadagno;
        }

        public List<string> stampa_edifici()
        {
            List<string> edificii = new List<string>();
            foreach (Edificio e in edifici)
            {
                edificii.Add(e.ToString());
            }
            return edificii;
        }

        public Terreno(int u)
        {
            Unita_disponibili = u;
            Guadagno = 0;
        }
    }
}
    

