using System;

namespace errores
{

    class NegativeIntegerExeption:Exception
    {
        public NegativeIntegerExeption():base("Debes poner numeros positivos")
        {
        }
    }
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("ingresa tu edad: ");
            try
            {
            string captura = Console.ReadLine();
            int valor = int.Parse(captura); 
            if(valor < 0)
            {
                throw new NegativeIntegerExeption();
            }
            Console.WriteLine($"Captura: {valor}");
            Console.WriteLine($"En 10 años tendras: {100/valor}");
            Main();
            }
            /*catch(FormatException)
            {
                Console.WriteLine("formato incorrecto");
            }
            /*catch(OverflowException)
            {
                Console.WriteLine("Estas fuera del rango");
            }*/
            catch(DivideByZeroException)
            {
                Console.WriteLine("No puedes dividir entre cero");
            }
            /*catch(Exception e)
            {
                Console.WriteLine("mal");
                Console.WriteLine(e.Message);
            }*/
            catch(StackOverflowException e)
            {
                Console.WriteLine("mal");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finaly");
            }


            Console.ReadKey();
        }
    }
}
