using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScacchiC
{
    public class Pedone : Pedina
    {
        public Pedone(Colore colore, int riga, int colonna, Scacchiera scacchiera) : base(colore, riga, colonna, scacchiera)
        {

        }

        public override void mangia(int r, int c)
        {
            throw new NotImplementedException();
        }

        public override void trasforma(Pedina p)
        {
            throw new NotImplementedException();
        }

        public override void muovi(int nuovaRiga, int nuovaColonna)
        {
            base.muovi(nuovaRiga, nuovaColonna);

            int diffR = Math.Abs(nuovaRiga - riga);
            int diffC = nuovaColonna - colonna;
            if (diffC != 0)
            {
                //TODO - caso mangio
                throw new ArgumentException("Mossa non valida");
            }
            if (!primaMossa && diffR == 2)
            {
                throw new ArgumentException("Mossa non valida");
            }
            if (diffR == 0 || diffR > 2)
            {
                throw new ArgumentException("Mossa non valida");
            }
            if(primaMossa==true && diffR==2 && diffC==0)
            {
                if(scacchiera.pedinaNelMezzo(riga,colonna,nuovaRiga,nuovaColonna))
                {
                    throw new ArgumentException("è presente una pedina nel mezzo");
                }
                else if (scacchiera.pedinaNelMezzo(riga, colonna, nuovaRiga-1, nuovaColonna))
                {
                    throw new ArgumentException(" è presente una pedina nel mezzo ");
                }
            }
            if (colore == Pedina.Colore.Black)
            {
               if (nuovaRiga < riga)
                {
                    throw new ArgumentException("Mossa non valida");
                }
            }
            else
            {
                if (nuovaRiga > riga)
                {
                    throw new ArgumentException("Mossa non valida");
                }
            }
            //non posso muovere oltre una casella (in tutte le direzioni)
            if (Math.Abs(nuovaRiga - riga) > 1 || Math.Abs(nuovaColonna - colonna) > 1)
            {
                throw new ArgumentException("Mossa non valida");
            }

            //TODO - manca arrocco

            //non e piu la prima mossa
            primaMossa = false;

            //muovo
            scacchiera.rimuoviPedina(riga, colonna);
            riga = nuovaRiga;
            colonna = nuovaColonna;
            scacchiera.posizionaPedina(riga, colonna, this);

        }

        public override string stampa()
        {
            return "♟";
        }
    }
}
