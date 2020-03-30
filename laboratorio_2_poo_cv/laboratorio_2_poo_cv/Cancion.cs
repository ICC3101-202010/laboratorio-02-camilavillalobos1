using System;
namespace laboratorio_2_poo_cv
{
    class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string genero_song;


        public Cancion(string name, string album, string artist, string genero_song)
        {
            this.name = name;
            this.album = album;
            this.artist = artist;
            this.genero_song = genero_song;

        }

        public string Informacion()
        {
            return (" Genero: " + genero_song + ", Artista: " + artist + ", Album: " + album + ", Nombre:" + name);
        }

    }
}