using System;
using System.Collections.Generic;

namespace Alumno
{
    class Alumno
    {
        protected string nombre;
        protected string tialu;
        
        public Alumno(string no, string tialu)
        {
            this.nombre = no;
            this.tialu = tialu;
        }

        public void print()
        {
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia\n");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre} tienes que hacer una investigacion de un tema");
        }
    }

    class Licenciatura:Alumno
    {
        public Licenciatura(string nombre, string tialu):base(nombre, tialu)
        {
            
        }

        public new void print()
        {
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia\n");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre}tienes que hacer una investigacion de un tema");
        }
    }

    class Posgrado:Alumno
    {
        public Posgrado(string nombre, string tialu):base(nombre, tialu)
        {

        }

        public new void print()
        {
            if(tialu == "Licenciatura")
            Console.WriteLine($"{nombre} tienes que hacer servicio social y recidencia");
            
            else if(tialu == "Posgrado")
            Console.WriteLine($"{nombre}tienes que hacer una investigacion de un tema");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Alumno prueba = new Alumno("nombre", "Posgrado");
            Alumno prueba1 = new Alumno("nombre", "Licenciatura");
            prueba.print();
            prueba1.print();

            Licenciatura a = new Licenciatura("Carlos", "Licenciatura");
            a.print();

            Posgrado b = new Posgrado("Tom", "Posgrado");
            b.print();
        }
    }
}
