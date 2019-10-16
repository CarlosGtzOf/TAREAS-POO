using System;

namespace duracion
{

    class Duracion
    {
        private double segundos;

        /*public Duracion(int h, int m, int s)
        {
            horas = h;
            minutos = m;
            segundos = s;
        }*/

        public Duracion(double seg)
        {
            segundos = seg;
        }

        public Duracion(int h, int m, int s)
        {  
            segundos = h * 60 * 60;
            segundos += m * 60;
            segundos += s;
        }

        public double A_horas()
        {
            return Math.Floor(segundos/(60*60));
        }
        public double A_minutos()
        {
            return Math.Floor(segundos/60);
        }
        public double A_segundos()
        {
            return Math.Floor(segundos);
        }

        public void print()
        {
            double h = Math.Floor(A_horas());
            double m = Math.Floor((segundos - (60*60*h))/60);
            double s = Math.Floor((segundos - (60*60*h) - (60*m)));
            Console.WriteLine($"{h} | {m} | {s}");
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
