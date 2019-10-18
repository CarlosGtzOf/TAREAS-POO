using System;

namespace pass_parametros
{
    class Program
    {
        class Peliculas
        {
            public string fav;
            public Peliculas(string fav)
            {
                this.fav = fav;
            }
            
            public void print()
            {
                Console.WriteLine($"mi pelicula favorita es {fav}");
            }
        }

        class CamPel
        {
            public static void wow(ref Peliculas f)
            {
                f.fav = "Capitan America";
            }
        }

        static void Main(string[] args)
        {
            Peliculas f = new Peliculas("harry potter");
            CamPel.wow(ref f);

            f.print();
            
        }
    }
}
