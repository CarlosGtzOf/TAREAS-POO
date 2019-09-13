using System;

namespace Pelicula
{
    //metodos
    class pelicula
    {
        
        public String titulo;
        public String año;


    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula();
            pelicula p2 = new pelicula();

            p1.titulo = "Black Panter";
            p1.año = "2018";

            p2.titulo = "Lord Of The Rings Return Of The King";
            p2.año = "2003";

            Console.WriteLine("{0}, {1}\n{2}, {3}", p1.titulo, p1.año, p2.titulo, p2.año);
            
        }
    }
}
