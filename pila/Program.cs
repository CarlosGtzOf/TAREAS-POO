using System;

namespace pila
{
    public class Pila<T>
        {
            readonly int tamaño;
            int apuntador = 0;
            T[] element;

            public Pila(int size)
            {
                tamaño = size;
                element = new T[tamaño];
            }

            public void Push(T elemento)
            {
                if(apuntador >= tamaño)
                {
                    throw new StackOverflowException();
                    element[apuntador] = elemento;
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
                    return element[apuntador];
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
