using System;

namespace Pelicula
{
    //metodos
    class Peli
    {
        private String Titulo;
        private Int16 Año;
        private String Pais;
        private String Director;

        public void SetTitulo(string titulo)
        {
            this.Titulo = titulo;
        }

        public String GetTitulo()
        {
            return this.Titulo;
        }

        public void SetAño(Int16 año)
        {
            this.Año = año;
        }

        public Int16 GetAño()
        {
            return this.Año;
        }

        public void SetDirector(string director)
        {
            this.Director = director;
        }

        public String GetDirector()
        {
            return this.Director;
        }

        public void SetPais(string pais)
        {
            this.Pais = pais;
        }

        public String GetPais()
        {
            return this.Pais;
        }
        

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Peli p1 = new Peli();
            Peli p2 = new Peli();
            p1.SetTitulo("Black Panter");
            p1.SetAño(2018); 
            p1.SetDirector("Ryan Coogler");
            p1.SetPais("Cataratas del Iguazú");

            p2.SetTitulo("Lord Of The Rings Return Of The King");
            p2.SetAño(2003);
            p2.SetDirector("Peter Jackson");
            p2.SetPais("New Zealand, United States");
            
            Console.WriteLine("{0}, {1}, {2}, {3}\n{4}, {5}, {6}, {7}", p1.GetTitulo(), p1.GetAño(), p1.GetDirector(),p1.GetPais(), p2.GetTitulo(), p2.GetAño(), p2.GetDirector(), p2.GetPais());
        }
    }
}