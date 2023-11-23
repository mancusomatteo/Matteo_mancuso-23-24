using System;

namespace es_24_11
{
    public class Cassa
    {
        private static int tot_b;
        private int numB;


        public int NumB
        {
            get { return numB; }
        }

        public static int TotBiglVend
        {
            get { return tot_b; }
        }

        public void VendiBiglietto()
        {
            if (numB + 1  > 100 || tot_b + 1 > 250)
            {
                throw new ArgumentException("biglietti finiti");
            }              
            numB++;
            tot_b++;
        }

        public void AnnullaBiglietto()
        {
            if (numB - 1 < 0 || tot_b - 1 < 0)
            {
                throw new ArgumentException("errore");
            }                
            numB--;
            tot_b--;
        }

        public void VendiBiglietto(int n)
        {
            if (numB + n > 100 || tot_b + n > 100)
            {
                throw new ArgumentException("biglietti finiti");

            }             
            numB += n;
            tot_b += n;
        }

        public void AnnullaBiglietto(int n)
        {
            if (numB - n < 0 || tot_b - n < 0)
            {
                throw new ArgumentException("errore");
            }
            numB-= n;
            tot_b -= n;
        }

        public Cassa()
        {
            numB = 0;
        }
    }
}

