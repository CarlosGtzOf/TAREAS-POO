using System;

namespace duracion
{

    class Duracion
    {
        private int segundos;

        /*public Duracion(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
        }*/
        public Duracion(int h, int m, int s)
        {  
            segundos = h * 60 * 60;
            segundos += m * 60;
            segundos += s;
        }
        public void print()
        {
            Console.WriteLine($"{segundos}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Duracion P = new Duracion(02, 15, 12);
            Duracion C = new Duracion(00, 02, 15);
            Duracion Pa = new Duracion(02, 00, 10);
            P.print();
            C.print();
            Pa.print();

        }
    }
}
