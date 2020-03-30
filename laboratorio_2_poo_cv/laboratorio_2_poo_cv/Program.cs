using System;
using System.Collections.Generic;

namespace laboratorio_2_poo_cv
{
    class Program

    {
        

        //CONSOLA OFICIAL DE LA TERMINAL 
        public static void Main(string[] args)
        {
            Cancion cancion1 = new Cancion("nombre1", "album1", "artista1", "genero1");
            Console.WriteLine(cancion1.Informacion());



        }


        
    }

}   

