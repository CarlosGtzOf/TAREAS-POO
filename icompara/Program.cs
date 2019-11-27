using System;
using System.Collections.Generic;
namespace icompara
{

    class Persona : IComparable
    {
        int id;
        string nombre;

        public Persona(int id ,string n)
        {
            this.id = id;
            this.nombre = n;
        }

        public override string ToString() 
        {
            return string.Format($"{id}: {nombre}");
        }

        public int CompareTo(Object o)
        {
          return this.id.CompareTo(((Persona)o).id);
        }    
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> pers = new List<Persona>();
            pers.Add(new Persona(2 ,"pam"));
            pers.Add(new Persona(1 ,"jim"));
            pers.Add(new Persona(3 ,"mike\n"));
            foreach(Persona p in pers)
            {
                Console.WriteLine(p);
            }
            List<Persona> pers1 = new List<Persona>();
            pers1.Add(new Persona(2 ,"pam"));
            pers1.Add(new Persona(1 ,"jim"));
            pers1.Add(new Persona(3 ,"mike"));
            pers1.Sort();
            foreach(Persona p in pers1)
            {
                Console.WriteLine(p);
            }
        }
    }
}
