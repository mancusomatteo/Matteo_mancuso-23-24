using System;

namespace es_30_10
{
    public class Playlist
    {
        private string titolo;
        private string artista;
        private int durata;
        private string titoloAlbum;
        private int n_tracce_album;
        private bool ghost;

        public string Titolo
        {
            get { return titolo; }
            set {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("il titolo non può essere vuoto");
                }
                titolo = value; }
        }

        public string Artista
        {
            get { return artista; }
            set {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("l'artista non può essere vuoto");
                }
                artista = value; }
        }

        public int Durata
        {
            get { return durata; }
            set
            {
                if (value >= 0)
                    durata = value;
                else
                    throw new ArgumentException("La durata non può essere negativa.");
            }
        }

        public string TitoloAlbum
        {
            get { return titoloAlbum; }
            set {
                if (string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new ArgumentException("il titolo dell'album non può essere vuoto");
                }
                titoloAlbum = value; }
        }

        public int NumeroTracceAlbum
        {
            get { return n_tracce_album; }
            set
            {
                if (value >= 0)
                    n_tracce_album = value;
                else
                    throw new ArgumentException("Il numero di tracce non può essere negativo.");
            }
        }

        public bool IsGhostTrack
        {
            get { return ghost; }
            set { ghost = value; }
        }
        public void Modifica(string titolo, string artista, int durata, string titoloAlbum, int numeroTracceAlbum, bool isGhostTrack)
        {
            Titolo = titolo;
            Artista = artista;
            Durata = durata;
            TitoloAlbum = titoloAlbum;
            NumeroTracceAlbum = numeroTracceAlbum;
            IsGhostTrack = isGhostTrack;
        }
        public Playlist(string titolo,string titolo_Album, string artista, int durata, int n_tracce_album,bool ghost)
        {
            this.Titolo = titolo;
            this.TitoloAlbum = titolo_Album;
            this.Artista = artista;
            this.Durata = durata;
            this.NumeroTracceAlbum = n_tracce_album;
            this.IsGhostTrack = ghost;

        }

        public override string ToString()
        {
            return "Titolo: " + titolo + ", Artista: " + artista + ", Durata: " + durata  + " , Titolo album: " + titoloAlbum + ", n° tracce album: " + n_tracce_album + " Ghost: " + ghost;
        }
    }

}

