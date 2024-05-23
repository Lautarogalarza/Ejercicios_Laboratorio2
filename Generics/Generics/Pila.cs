using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Pila<T>
    {
        private List<T> elementos = new List<T>();

        public void Push(T elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar()
        {
            foreach (T elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }

        public T Pop()
        {
            if (elementos.Count == 0)
            {
                throw new Exception("No tengo elementos en mi pila");
            }

            int ultimoIndex = elementos.Count - 1;
            T aux = elementos[ultimoIndex];
            elementos.RemoveAt(ultimoIndex);

            return aux;
        }

        public static void EjecutarToString(T elemento)
        {
            Console.WriteLine(elemento.ToString());
        }
    }
















    public class PilaInt
    {
        private List<int> elementos = new List<int>();

        public void Push(int elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar()
        {
            foreach (int elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }
    }

    public class PilaString
    {
        private List<string> elementos = new List<string>();

        public void Push(string elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar()
        {
            foreach (string elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }
    }

    public class PilaPersona
    {
        private List<Persona> elementos = new List<Persona>();

        public void Push(Persona elemento)
        {
            elementos.Add(elemento);
        }

        public void Mostrar()
        {
            foreach (Persona elemento in elementos)
            {
                Console.WriteLine(elemento.ToString());
            }
        }
    }


}
