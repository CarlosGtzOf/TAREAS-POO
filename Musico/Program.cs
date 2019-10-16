using System;
using System.Collections.Generic;

namespace Musico
{
    class Musico 
    {

        protected string nombre;
        public Musico(string n)
        {
        nombre=n;

        }
        public virtual string Saluda()
        {
        return String.Format("hola soy {0}", nombre);
        }

        public virtual void Afina()
        {
            Console.WriteLine("{0}, Afina su instrumento ",nombre);
        }

    }

    class Bajista:Musico
    {
       private string bajo;
       public Bajista(string no,string bajo):base(no)
       {
       this.bajo=bajo;
       } 

       public override void Afina()
       {
           Console.WriteLine(" {0} esta afinando su bajo {1}",nombre,bajo);
       }

       public override string Saluda()
       {
           return base.Saluda() + " y soy bajista";
       }
    }

    class Guitarrista:Musico
    {
       private string Guitarra;
       public Guitarrista(string no,string Guitarra):base(no)
       {
       this.Guitarra=Guitarra;
       } 

       public override void Afina()
       {
           Console.WriteLine("{0} esta afinando su bajo {1}",nombre,Guitarra);
       }
    }

    class Program
    { 

        static void Main()
        {
            Musico tom=new Musico("Tom");
            Bajista flea=new Bajista("Flea","Gibson");
            Guitarrista carlos=new Guitarrista("Carlos","Gibson");
            
            tom.Saluda();
            flea.Saluda();
            carlos.Saluda();

            tom.Afina();
            flea.Afina();
            carlos.Afina();

            List<Musico> grupo = new List<Musico>();
            grupo.Add(tom);
            grupo.Add(flea);
            grupo.Add(carlos);
            foreach(Musico m in grupo)
            {
                m.Saluda();
                m.Afina();
            }

        }
    }
}