using System;
using System.Collections.Generic;

namespace Peliculas
{
    //metodos
    class Pelicula    {
        private string Titulo;
        private Int16 Año;
        private string Pais;
        private string Director;

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
        
        public Pelicula() 
        {

		}
		public Pelicula(string titulo, Int16 año)
        {
			this.Titulo = titulo;
			this.Año = año;
		}

        public void imprime() 
        {
			Console.WriteLine("{0}, {1}", this.Titulo, this.Año);
		}
        
    }

    class Program
    {

        static void Main(string[] args)
        {
            /*Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            p1.SetTitulo("Black Panter");
            p1.SetAño(2018);

            p2.SetTitulo("Lord Of The Rings Return Of The King");
                p2.SetAño(2003);
                p2.SetDirector("Peter Jackson");
                p2.SetPais("New Zealand, United States");

            p1.print();
            p2.print();
            */
            /*List<String> personas = new List<String>();

            personas.Add("Birdman, 2018");
            personas.Add("12 años de esclavitud, 2014");
            personas.Add("El artista, 2012");
            personas.Add("Bohemian Rhapsody, 2018");
            personas.Add("Shakespeare in love, 1999");
            foreach (string s in personas)

            Console.WriteLine(s);*/

            List<Pelicula> peliculas = new List<Pelicula>();

			peliculas.Add(new Pelicula("La forma del agua", 2017));
            peliculas.Add(new Pelicula("Birdman", 2018));
            peliculas.Add(new Pelicula("El artista", 2012));
            peliculas.Add(new Pelicula("Bohemian Rhapsody", 2018));
            peliculas.Add(new Pelicula("Shakespeare in love", 1999));

            foreach(Pelicula s in peliculas)
            {
                s.imprime();
            }
            
        }
    }
}