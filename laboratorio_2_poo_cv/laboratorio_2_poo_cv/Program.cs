using System;
using System.Collections.Generic;

namespace laboratorio_2_poo_cv
{
    class Program

    {
        private static string name;
        private static string album;
        private static string artist;
        private static string genero_song;
        public string usuario;

        //CONSOLA OFICIAL DE LA TERMINAL 
        public static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido a Espotifai \n ");
            Console.WriteLine("[1] Ver todas las canciones \n [2] Agregar canciones \n [3] Salir del programa \n");
            Console.Write("Que desea hacer: ");
            string usuario = Console.ReadLine();
            while(usuario == "1" )
            {
                if (usuario == "1")
                {
                    Espotifai espotifai = new Espotifai();
                    Console.WriteLine(espotifai.VerCanciones());
                }

                else if (usuario == "2")
                {
                    Cancion song = new Cancion(name, album, artist, genero_song );
                    Console.Write("Nombre de la cancion: ");
                    name = Console.ReadLine();
                    Console.Write("Nombre del album: ");
                    album = Console.ReadLine();
                    Console.Write("Nombre del artista: ");
                    artist= Console.ReadLine();
                    Console.Write("NGenero de la cancion: ");
                    genero_song = Console.ReadLine();
                    Console.WriteLine(song.Informacion());
                    Cancion cancion1 = new Cancion("nombre1", "album1", "artista1", "genero1");
                    Console.WriteLine(cancion1.Informacion());
                }

            }




        }


        
    }

}   

