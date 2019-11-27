using System;
using System.Collections.Generic;

namespace FaceClone
{
    abstract class Publicacion
    {
        private List<int> reacciones = new List<int>();
        private string N, E, HF, R;
        public Publicacion(string n, string e, string hf, string r)
        {
            this.N = n;
            this.E = e;
            this.HF = hf;
            this.R = r;
            //Me gusta/Like
            this.reacciones.Add(0);
            //Me encanta/Love
            this.reacciones.Add(1);
            //Me divierte/Haha
            this.reacciones.Add(2);
            //Me asombra/Wow
            this.reacciones.Add(3);
            //Me entristece/Sad
            this.reacciones.Add(4);
            //Me enoja/Angry
            this.reacciones.Add(5);
        }
        public abstract void imprime();
    }

    class Estado: Publicacion
    {
        public Estado(string nom, string est, string hofe, string r):base(nom, est, hofe, r)
        {
            
        }
        public void imprime()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
