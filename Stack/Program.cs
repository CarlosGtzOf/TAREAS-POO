using System;

namespace stack
{
    class Stack<T>
    {
        private T[] elementos;
        public int tamaño;
        private int apuntador = 0;

        public Stack():this(100)
        {

        }

        public Stack(int Tamaño)
        {
            tamaño = Tamaño;
            elementos = new T[Tamaño];
        }
        
        public void Push(T elemento)
        {
            elementos[apuntador] = elemento;
            apuntador++;
        }

        public T Pop()
        {
            apuntador--;
            return elementos[apuntador];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> nombres = new Stack<string>(); 
            nombres.Push("Hola");
            nombres.Push(" ");
            nombres.Push("Mundo");
            for(int i = 0; i < 3; i++)
            {
                Console.Write(nombres.Pop());
            }
        
        }
    }
}