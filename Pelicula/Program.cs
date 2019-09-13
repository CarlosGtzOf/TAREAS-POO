using System;

namespace Pelicula
{
    //sin metodos
    class pelicula
    {
        
        public String titulo;
        public Int16 año;
        public String director;
        public String pais;


    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula();
            pelicula p2 = new pelicula();

            p1.titulo = "Black Panter";
            p1.año = 2018;
            p1.director = "Ryan Coogler";
            p1.pais = "Cataratas del Iguazú";

            p2.titulo = "Lord Of The Rings Return Of The King";
            p2.año = 2003;
            p2.director = "Peter Jackson";
            p2.pais = "New Zealand, United States";

            Console.WriteLine("{0}, {1}, {2}, {3}\n{4}, {5}, {6}, {7}", p1.titulo, p1.año, p1.director, p1.pais, p2.titulo, p2.año, p2.director, p2.pais);
            
        }
    }
}