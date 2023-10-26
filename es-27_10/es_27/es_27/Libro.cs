using System;


namespace es_27
{
     class Libro
    {
        private int n_pagine;
        private string titolo;
        private string autore;
        private string genere;



        public int N_pagine
        {
            get { return n_pagine; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("numero di pagine errato");
                }
                n_pagine = value;
            }
        }
        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("il titolo non può essere vuoto");
                }
                titolo = value;
            }
        }
        public string Autore
        {
            get { return autore; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("l'autore non può essere vuoto");
                }
                autore = value;
            }
        }
        public string Genere
        {
            get { return genere; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("il genere non può essere vuoto");

                }

                else
                {
                    genere = value;
                }

            }
        }
        public Libro(int n_pagine, string titolo, string autore, string genere)
        {
            this.N_pagine = n_pagine;
            this.Titolo = titolo;
            this.Autore = autore;
            this.Genere = genere;

        }
        public void Modifica(string genere)
        {
            Genere = genere;

        }
        public override string ToString()
        {
            return "Titolo: " + titolo + ", Autore: " + autore + ", Pagine: " + n_pagine + ", Genere: " + genere + " , Costo: " + Costo().ToString();
        }
        public double Costo()
        {
            double costoBase = n_pagine * 0.01;

            if (n_pagine > 100 && n_pagine <= 200)
            {
                double temp = n_pagine * 0.01;
                double sconto = temp * 0.01;
                costoBase = temp - sconto;
            }
            else if (n_pagine > 200 && n_pagine <= 500)
            {
                double temp = n_pagine * 0.01;
                double sconto = temp * 0.03;
                costoBase = temp - sconto;
            }
            else if (n_pagine > 500)
            {
                double temp = n_pagine * 0.01;
                double sconto = temp * 0.05;
                costoBase = temp - sconto;
            }

            return costoBase;
        }
    }
}

