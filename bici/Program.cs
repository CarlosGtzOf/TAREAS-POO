using System;

namespace bici
{

    class Bici
    {
        //cambios
        public string color, type, brand;
        public int velocitis, size;

        //metodos
        public void print()
        {
            Console.WriteLine("brand:{0}, color:{1}", brand, color);
        }



    }

    class Program
    {
        static void Main(string[] args)
        {
            Bici bici = new Bici();
            bici.brand = "Mangus";
            bici.color = "Red";
            bici.print();
        }
    }
}
