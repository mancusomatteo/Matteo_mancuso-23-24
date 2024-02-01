using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormCasa
{
    public class Terreno
    {
        private int guadagno;
        private int nUnita;

        public int NUnita
        {
            get { return nUnita; }
            set
            {
                if(value < 0 || value > 500)
                {
                    throw new Exception("il numero di unita deve essere compreso tra 1 e 500");
                }
                else
                {
                    nUnita = value;
                }
            }
        }

        private List<Bilocale> Bilocali = new List<Bilocale>();
        private List<Trilocale> Trilocali = new List<Trilocale>();
        private List<Quadrilocale> Quadrilocali = new List<Quadrilocale>();

        public Terreno(int nUnita)
        {
            NUnita = nUnita;
        }

        public void AllocaBi(Bilocale b)
        {
            Bilocali.Add(b);
            NUnita -= 2;
        }
        public void AllocaTri(Trilocale t)
        {
            Trilocali.Add(t);
            NUnita -= 3;
        }
        public void AllocaQua(Quadrilocale q)
        {
            Quadrilocali.Add(q);
            NUnita -= 4;
        }
        public void DisallocaBi(Bilocale b)
        {
            Bilocali.Remove(b);
            NUnita += 2;
        }
        public void DisallocaTri(Trilocale t)
        {
            Trilocali.Remove(t);
            NUnita += 3;
        }
        public void DisallocaQua(Quadrilocale q)
        {
            Quadrilocali.Remove(q);
            NUnita += 4;
        }
    }

}
