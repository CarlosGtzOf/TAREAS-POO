using System;
using System.IO;
using System.Collections.Generic;

namespace creacion
{

    class Producto
    {
        public string code, descripcion;
        public double precio;

        public Producto(string code, string descripcion, double precio)
        {
            this.code = code; this.descripcion = descripcion; this.precio = precio;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Producto> productos = new List<Producto>();
            productos.Add(new Producto("AQW", " Lapiz azul w2", 12.23d));
            productos.Add(new Producto("AQW", " Lapiz verde w2", 12.23d));
            productos.Add(new Producto("AQW", " Lapiz negro w2", 22.23d));
            productos.Add(new Producto("AQW", " Lapiz rojo w2", 22.23d));
            FileStream fs = new FileStream(@"productos.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter txtOut = new StreamWriter(fs);
            foreach(Producto p in productos)
            {
                txtOut.WriteLine($"{p.code},{p.descripcion}, {p.precio}");
            }
            txtOut.Close();
            Console.WriteLine("Archivo grabado");
            Console.ReadKey();

            List<Producto> pro_lei = new List<Producto>();
            using (StreamReader sr = new StreamReader("productos.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)//no lleguemos al final del archivo
                {
                    string[] columnas = line.Split(",");
                    //Console.WriteLine(columnas[0]);
                    pro_lei.Add(new Producto(columnas[0], columnas[1], Double.Parse(columnas[2])));


                }
            }
            
            foreach(Producto p in pro_lei)
            {
                Console.WriteLine($"{p.code},{p.descripcion}, {p.precio}");
            }

            /*Console.WriteLine("Captura el folder a crear");
            string archivo = Console.ReadLine();
            File.SetAttributes(archivo, FileAttributes.Hidden);
            Directory.CreateDirectory(directorio);  
            Directory.Delete(directorio, true);
            if(Directory.Exists(directorio))
            {       
                Console.WriteLine("Ya existe"); 
            }
            else
            {
                Directory.CreateDirectory(directorio);
            }*/
        }
    }
}
