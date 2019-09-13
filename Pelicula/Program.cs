using System;

namespace Pelicula
{
    //metodos
    class pelicula
    {
        
        public String titulo;
        public String año;
        public String titulo2;
        public String año2;

        public void print()
        {
            Console.WriteLine("{0}, {1}\n{2}, {3}", titulo, año, titulo2, año2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            pelicula p1 = new pelicula();

            p1.titulo = "Black Panter";
            p1.año = "2018";

            p1.titulo2 = "Lord Of The Rings Return Of The King";
            p1.año2 = "2003";

            p1.print();
        }
    }
}
