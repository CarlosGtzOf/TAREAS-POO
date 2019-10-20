using System;

namespace pass_parametros
{
    class Program
    {
        class Peliculas
        {
            public string fav;
            private int e;
            public Peliculas(string fav)
            {
                this.fav = fav;
            }
            
            public void print()
            {
                Console.WriteLine($"mi pelicula favorita es {fav}\nEl numero es: {e}");
            }

            public void numero(in int w)
            {
                this.e = w + 2;
            }
        }

        class CamPel
        {
            public static void wow(ref Peliculas f)
            {
                f.fav = "Capitan America";
            }
        }

        class suma
        {
            public static void suma1(int a, int b, out int r)
            {
                r = a + b;
            }

            public static int suma1(int a, int b)
            {
                return a + b;
            }
        }

        static void Main(string[] args)
        {
            int x = 2, num1 = 2, num2 = 3, res = 0;
            Peliculas f = new Peliculas("harry potter");

            suma.suma1(num1, num2, out res);
            CamPel.wow(ref f);
            f.numero(in x);

            f.print();
            Console.WriteLine($"el resultado de la suma es {res}");           
        }
    }
}
