using System;

namespace herencia
{
    class Persona
    {
        protected string _nombre;
    
        public string Nombre
        {
            get
            {
                return _nombre;
            }
        }

        public Persona(string n)
        {
            _nombre = n;
        }

        public void print()
        {
            Console.WriteLine($"mi nombre es: {_nombre}");
        }
    
    
    }

    class Alumno: Persona 
    {
        protected string num_control;
        public Alumno(string _nombre, string num_control):base(_nombre)
        {
            this.num_control = num_control;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona tom = new Persona("Tom");
            Persona jim = new Persona("jim");
            Alumno luis = new Alumno("luis", "19210537");

            tom.print();
            jim.print();
            luis.print();
        }
    }
}
