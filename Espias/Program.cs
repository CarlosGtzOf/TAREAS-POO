using System;

namespace Espias
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            nombre = "Fulano";
            apellido = " De Tal";
        }
    }

    class Anonymus
    {
       public static void anonimiza(Persona p)
        {
            p.nombre = "xxxxxxxxxxxxxx";
            p.apellido = " tu madre";
        }
        public static void cambia(ref Persona p)
        {
            p = new Persona();
            p.nombre = "new";
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Console.WriteLine(p.nombre);
            Anonymus.anonimiza(p);
            Console.WriteLine(p.nombre);
            Anonymus.cambia(ref p);
            Console.WriteLine(p.nombre);

        }
    }
}
