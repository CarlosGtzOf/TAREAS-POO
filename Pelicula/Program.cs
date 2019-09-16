using System;
using System.Collections.Generic;

namespace Peliculas
{
    //metodos
    class Pelicula    {
        private string Titulo;
        private Int16 Año;
        //private string Pais;
        //private string Director;
        private List<Actor> actores = new List<Actor>();

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

        public void AgregarActor(Actor actor)
        {
            actores.Add(actor);
        }
        public void imprime() 
        {
			Console.WriteLine("actores de pelicula {0}. {1} ", Titulo, Año);
            foreach(Actor a in actores)
            {
                Console.WriteLine("{0}, {1}", a.nombre, a.año);
            }
		}
        
    }

    class Actor
    {
        public string nombre;
        public Int16 año;
        public Actor(String nombre, Int16 año)
        {
            this.nombre = nombre;
            this.año = año;
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
            

            /*List<Pelicula> peliculas = new List<Pelicula>();

			peliculas.Add(new Pelicula("La forma del agua", 2017));
            peliculas.Add(new Pelicula("Birdman", 2018));
            peliculas.Add(new Pelicula("El artista", 2012));
            peliculas.Add(new Pelicula("Bohemian Rhapsody", 2018));
            peliculas.Add(new Pelicula("Shakespeare in love", 1999));

            foreach(Pelicula s in peliculas)
            {
                s.imprime();            
            }*/
            
            Pelicula p1 = new Pelicula("La La Land", 2016);
			p1.AgregarActor(new Actor("Ryan Gosling", 1980));
			p1.AgregarActor(new Actor("Emma Stone", 1988));

			p1.imprime();
        }
    }
}