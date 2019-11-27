using System;

namespace pila
{
    public class Pila< T >
    {
        readonly int tamaño;
        int apuntador = 0;
        T[] elementos;
            
        public Pila() : this(100)
	    {

        }

        public Pila(int size)
        {
            tamaño = size;
            elementos = new T[tamaño];
        }

        public void Push(T elemento)
        {
            if(apuntador>=tamaño)
            {
                throw new StackOverflowException();
            }
            else
            {
                elementos[apuntador]=elemento;
                apuntador++;
            }
        }

        public T Pop()
        {        
    
            if(apuntador>0)
            {      
                T elemento=elementos[0];
                for (int i = 1; i < apuntador; i++)
                {
                elementos[i-1]=elementos[i];
                }   
                apuntador--;
                return elemento;
            }
            else
            {
                apuntador=0;
                throw new InvalidOperationException("stack vacio");
            }
        }

    }

    class Program
    {

        static void Main(string[] args)
        {
            Pila<string> list = new Pila<string>();
            list.Push("Mundo");
            list.Push(" ");
            list.Push("Hola");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(list.Pop());
            }
            
            

        }
    }
}
