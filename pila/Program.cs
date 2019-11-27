using System;

namespace pila
{
    public class Pila<T>
        {
            readonly int tamaño;
            int apuntador = 0;
            T[] elementos;

            public Pila(int size)
            {
                tamaño = size;
                elementos = new T[tamaño];
            }

            public void Push(T elementos)
            {
                if(apuntador < tamaño)
                {
                    throw new StackOverflowException();
                    this.elementos[apuntador] = elementos;
                    apuntador++;    
                }
                else
                {
                    //error
                }
            }

            public T Pop()
            {
                apuntador--;
                if(apuntador >= 0)
                {
                    return elementos[apuntador];
                }
                else
                {
                    apuntador = 0;
                    throw new InvalidOperationException("no se puede apuntar en una pila vacia");
                }
            }

        }

    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
