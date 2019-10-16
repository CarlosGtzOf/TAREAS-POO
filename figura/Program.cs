using System;
using System.Collections.Generic;

namespace figura
{
    abstract class Figura
    {
        protected int ancho, alto;
        protected int px, py;
        protected string color_relleno, color_borde;

        public Figura(int ancho, int alto, int px, int py, string color_relleno, string color_borde)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.px = px;
            this.py = py;
            this.color_relleno = color_relleno;
            this.color_borde = color_borde;

        }

        public abstract void dibuja();
    }


    class Rectangulo: Figura
    {
        public Rectangulo(int ancho, int alto, int px, int py, string color_relleno, string color_borde):base(ancho, alto, px, py, color_relleno, color_borde)
        {
        
        }
        public override void dibuja()
        {
            Console.WriteLine("se dibuja un rectangulo color {0} en x = {1} y y = {2}", color_relleno, px, py);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            //Figura = figura = new Figura(10,10);
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Rectangulo(10, 10, 10, 10, "rojo", "rojo"));
        }
    }
}

