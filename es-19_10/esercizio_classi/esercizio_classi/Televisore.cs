using System;


namespace esercizio_classi
{
    internal class Televisore
    {
        private string marca;
        private string modello;
        private int nMaxcanali;
        private int vMax;
        private int vMin;
        private bool aColori;
        private bool on;
        private int canaleattuale;
        private int volumeattuale;


        public Televisore(string marca, string modello, bool acolori)
        {
            this.marca = marca;
            this.modello = modello;
            this.aColori = aColori;
            this.nMaxcanali = 100;
            this.vMax = 50;
            this.vMin = 0;
            this.on = false;
            this.canaleattuale = 1;
            this.volumeattuale = vMin;
        }
        public Televisore(string marca, string modello, int nMaxcanali, int vMax, int vMin, bool aColori)
        {
            this.marca = marca;
            this.modello = modello;
            this.nMaxcanali = nMaxcanali;
            this.vMax = vMax;
            this.vMin = vMin;
            this.aColori = aColori;
            this.on = false;
            this.canaleattuale = 1;
            this.volumeattuale = vMin;
        }
        public void Marca(string m)
        {
            if (string.IsNullOrWhiteSpace(m) == true)
            {
                throw new ArgumentException("la marca non può essere vuota");

            }
            marca = m;
        }
        public void Modello(string mo)
        {
            if (string.IsNullOrWhiteSpace(mo) == true)
            {
                throw new ArgumentException("la marca non può essere vuota");

            }
            modello = mo;
        }
        public void ON()
        {
            on = true;
        }
        public void alzavolume()
        {
            if (on == true)
            {
                if (volumeattuale < vMax)
                {
                    volumeattuale++;
                }
            }
        }

        public void abbassavolume(int v)
        {
            if (on== true)
            {
                if (volumeattuale > vMin) {
                    volumeattuale--;
                }
            }
        }
        public void AlzaVolume(int n)
        {
            if (on == true)
            {
                volumeattuale += n;
                if (volumeattuale < vMax)
                {
                    volumeattuale = vMax;
                }
                }
        }

        public void AbbassaVolume(int n)
        {
            if (on ==  true)
            {
                volumeattuale -= n;
                if (volumeattuale > vMin)
                {
                    volumeattuale = vMin;
                }
                }
        }

        public void Incrementa_canale()
        
        {
            if (on == true)
            {
                if (canaleattuale<nMaxcanali)
                {
                    canaleattuale++;
                }
            }
        }
        public void decrementa_canale()

        {
            if (on)
            {
                if (canaleattuale > 1)
                {
                    canaleattuale--;
                }
            }
        }

        public bool accesa()
        {
            return on;
        }

        public int Canaleattuale()
        {
            return canaleattuale;
        }

        public int Volumeattuale()
        {
            return volumeattuale;
        }

        public string informazioni()
        {
            return (" marca: " + marca + "; modello: " + modello + "; canale: " + canaleattuale + "; volume: " + volumeattuale + "; acceso: " + on );
        
        }
        public void CopiaInfoTelevisione(Televisore televisore)
        {
            this.marca = televisore.marca;
            this.modello = televisore.modello;
            this.nMaxcanali = televisore.nMaxcanali;
            this.vMin = televisore.vMin;
            this.vMax = televisore.vMax;
            this.aColori = televisore.aColori;
            this.on = televisore.on;
            this.canaleattuale = televisore.canaleattuale;
            this.volumeattuale = televisore.volumeattuale;
        }
    }
    

}
