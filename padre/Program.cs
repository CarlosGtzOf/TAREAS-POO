using System;
using System.Collections.Generic;
namespace padre
{
    class Componente
    {
        public string nombre;
        public Contenedor padre;

        public Componente(string nombre, Contenedor padre)
        {
            this.nombre = nombre;
            this.padre = padre;
        }
        public void print()
        {
            Console.WriteLine($"soy {nombre} y mi padre es {padre.nombre}");
        }
    }

    class Contenedor
    {
        public string nombre;
        public List<Componente> componentes = new List<Componente>();

        public Contenedor(string nombre)
        {
            this.nombre = nombre;
            componentes.Add(new Componente("primero", this));
            componentes.Add(new Componente("segundo", this));
            componentes.Add(new Componente("tercero", this));
        }

        public void print()
        {
            foreach (var hijo in componentes)
            {
                hijo.print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor padre1 = new Contenedor("Contenedor1");
            Contenedor padre2 = new Contenedor("Contenedor2");

            padre1.print();
            Console.WriteLine("\n");
            padre2.print();
        }
    }
}
