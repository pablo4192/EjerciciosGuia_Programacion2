using System;
using System.Collections.Generic;
using System.Linq;

namespace Guia_Colecciones_Ej02
{
    internal class Program
    {
        #region Consigna
        /*
        Crear una aplicación de consola que cargue en una Lista, Pila y Cola 20 números enteros (positivos y negativos) 
        distintos de cero de forma aleatoria utilizando la clase Random.

        1.Mostrar la colección tal como fue cargada.
        2.Luego mostrar los positivos ordenados en forma decreciente.
        3.Por último, mostrar los negativos ordenados en forma creciente. 
        */
        #endregion

        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>(); //Podria hacer solo una lista y ordenarla de forma decreciente quedando ordenados segun la consigna, en vez de separar por neg y pos.
            List<int> listaPositivos;
            List<int> listaNegativos;
            Stack<int> pila;
            Queue<int> cola;

            CargarLista(listaEnteros);
            MostrarLista(listaEnteros);
            Console.WriteLine();
            Console.WriteLine("Numeros positivos de la lista ordenados de forma decreciente.");
            listaPositivos = OrdenarPositivosDecreciente(listaEnteros.ToArray()).ToList();
            MostrarLista(listaPositivos);
            Console.WriteLine();
            Console.WriteLine("Numeros negativos de la lista ordenados de forma creciente.");
            listaNegativos = OrdenarNegativosCreciente(listaEnteros.ToArray()).ToList();
            MostrarLista(listaNegativos);
            Console.WriteLine();
            Console.WriteLine("Cola numeros positivos ordenados decreciente.");
            cola = CargarCola(listaPositivos);
            MostrarCola(cola);
            Console.WriteLine();
            Console.WriteLine("Cola numeros negativos ordenados creciente.");
            cola = CargarCola(listaNegativos);
            MostrarCola(cola);
            Console.WriteLine();
            Console.WriteLine("Pila numeros positivos ordenados decreciente.");
            listaPositivos.Reverse(); //En la pila el primero que entra es el ultimo que sale
            pila = CargarPila(listaPositivos);
            MostrarPila(pila);
            Console.WriteLine();
            Console.WriteLine("Pila numeros negativos ordenados creciente.");
            listaNegativos.Reverse();
            pila = CargarPila(listaNegativos);
            MostrarPila(pila);
            
           


        }

        /// <summary>
        /// Carga numeros Random en la lista pasada por parametro.
        /// </summary>
        /// <param name="listaEnteros"></param>
        private static void CargarLista(List<int> lista)
        {
            Random random = new Random();
            int numero;

            for (int i = 0; i < 20; i++)
            {
                numero = random.Next(-100, 100);
                while (numero == 0)
                {
                    numero = random.Next(-100, 100);
                }
                lista.Add(numero);
            }
            
        }

        /// <summary>
        /// Muestra el vector por consola.
        /// </summary>
        /// <param name="vectorEnteros"></param>
        private static void MostrarLista(List<int> lista)
        {
            foreach (int item in lista)
            {
                if(item != 0)
                {
                    Console.Write($"{item},");
                }
            }
        }

        /// <summary>
        /// Ordena los numeros positivos del vector de forma decreciente.
        /// </summary>
        /// <param name="vectorEnteros"></param>
        /// <returns>Vector ordenado</returns>
        private static int[] OrdenarPositivosDecreciente(int[] vectorEnteros)
        {
            int[] vectorOrdenado = new int[vectorEnteros.Length];
            int j = 0;
            int aux;

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                if (vectorEnteros[i] > 0)
                {
                    vectorOrdenado[j] = vectorEnteros[i];
                    j++;
                }
            }

            for (int i = 0; i < vectorOrdenado.Length - 1; i++)
            {
                for (int k = i + 1; k < vectorOrdenado.Length; k++)
                {
                    if (vectorOrdenado[i] < vectorOrdenado[k])
                    {
                        aux = vectorOrdenado[i];
                        vectorOrdenado[i] = vectorOrdenado[k];
                        vectorOrdenado[k] = aux;
                    }

                }

            }
            return vectorOrdenado;
        }

        /// <summary>
        /// Ordena los numeros negativos del vector en forma creciente.
        /// </summary>
        /// <param name="vectorEnteros"></param>
        /// <returns>Vector ordenado</returns>
        private static int[] OrdenarNegativosCreciente(int[] vectorEnteros)
        {
            int[] vectorOrdenado = new int[vectorEnteros.Length];
            int j = 0;
            int aux;

            for (int i = 0; i < vectorEnteros.Length; i++)
            {
                if (vectorEnteros[i] < 0)
                {
                    vectorOrdenado[j] = vectorEnteros[i];
                    j++;
                }
            }

            for (int i = 0; i < vectorOrdenado.Length - 1; i++)
            {
                for (int k = i + 1; k < vectorOrdenado.Length; k++)
                {
                    if (vectorOrdenado[i] > vectorOrdenado[k])
                    {
                        aux = vectorOrdenado[i];
                        vectorOrdenado[i] = vectorOrdenado[k];
                        vectorOrdenado[k] = aux;
                    }

                }

            }
            return vectorOrdenado;
        }

        private static Stack<int> CargarPila(List<int> lista)
        {
            Stack<int> pila = new Stack<int>();

            foreach (int item in lista)
            {
                if(item !=0)
                pila.Push(item);
            }
            return pila;
        }

        private static void MostrarPila(Stack<int> pila)
        {
            foreach (int item in pila)
            {
                Console.Write($"{item},");
            }
        }

        private static Queue<int> CargarCola(List<int> lista)
        {
            Queue<int> cola = new Queue<int>();

            foreach (int item in lista)
            {
                if (item != 0)
                    cola.Enqueue(item);
            }
            return cola;
        }

        private static void MostrarCola(Queue<int> cola)
        {
            foreach (int item in cola)
            {
                Console.Write($"{item},");
            }
        }


    }
}

    

    
        

       


