using System;
using System.Collections.Generic;

namespace bici2
{

    class bici
    {
        private string marca;
        private int current_velociti;
        private int velocities;
        private Persona dueño;

        public void print()
        {
            Console.WriteLine("Marca: {0}, Velocity: {1} velocidad mx: {2}",marca, current_velociti, velocities);
        }

        public void init(string marca, int cv, int vs)
        {
                this.marca = marca;
                current_velociti = cv;
                velocities = vs;
        }

        public void sube()
        {
            if(current_velociti > velocities)
            {
                current_velociti = velocities;
            }
            else
            {
                current_velociti++;
            }
            
        }

    }

    class Persona
    {
        private string nombre;
        private string correoe;

        private List<bici> bicis;

        public void init(string n, string c)
        {
            nombre = n;
            correoe = c;
        }

        public void print()
        {
            Console.WriteLine("{0}, {1}", nombre, correoe);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bici Bici = new bici();
            Bici.init("Huffy", 2, 12);
            //Bici.sube();
            //Bici.print();

            bici Bici1 = new bici();
            Bici1.init("PineStar", 0, 0);
            //Bici1.sube();
            //Bici1.print();

            bici Bici3 = new bici();
            Bici3.init("Apache", 1, 0);
            //Bici3.sube();
            //Bici3.print();

            List<bici> bicis = new List<bici>();
            bicis.Add(Bici);
            bicis.Add(Bici1);
            bicis.Add(Bici3);

            foreach(bici b in bicis)
            {
                b.print();
            }

            Persona tom = new Persona();
            tom.init("Tom", "tom@gmail.com");
            tom.print();
            
            
            //Console.WriteLine("Hello World!");
        }
    }
}
