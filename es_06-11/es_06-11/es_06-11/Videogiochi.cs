using System;


namespace es_06_11
{
    public class Videogiochi
    {
        private string titolo;
        private double _prezzoDiAcquisto;
        private DateTime _dataDiAcquisto;
        private string console;

        public string Titolo
        {
            get { return titolo; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Titolo non valido");
                }
                titolo = value;
            }
        }
        public double PrezzoDiAcquisto
        {
            get { return _prezzoDiAcquisto; }
            set {
                if (value <= 0)
                {
                    throw new Exception("prezzo non valido");
                }
                _prezzoDiAcquisto = value;
            }
        }
        public DateTime DataDiAcquisto
        {
            get { return _dataDiAcquisto;  }
            set {
                if (value > DateTime.Now)
                {
                    throw new Exception("La data di acquisto non può essere nel futuro.");
                }
                _dataDiAcquisto = value.Date;  }
        }

        public string Console
        {
            get { return console; }
            set {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new Exception("Titolo non valido");
                    }
                    console = value; 
                }

        }
        public Videogiochi(string titolo, double prezzoDiAcquisto, DateTime dataDiAcquisto, string console)
        {
            this.Titolo = titolo;
            this.PrezzoDiAcquisto = prezzoDiAcquisto;
            this.DataDiAcquisto = dataDiAcquisto;
            this.Console = console;
            
        }
        public Videogiochi(Videogiochi altroVideogioco)
        {
            Titolo = altroVideogioco.Titolo;
            PrezzoDiAcquisto = altroVideogioco.PrezzoDiAcquisto;
            DataDiAcquisto = altroVideogioco.DataDiAcquisto;
            Console = altroVideogioco.Console;
        }
        public override string ToString()
        {
             return $"{Titolo} - Console: {Console} - Prezzo: {PrezzoDiAcquisto:C} - Data di Acquisto: {DataDiAcquisto.ToShortDateString()}";
        }
    }
}
   
