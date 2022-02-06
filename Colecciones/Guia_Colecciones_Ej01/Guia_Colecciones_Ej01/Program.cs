using System;

namespace Guia_Colecciones_Ej01
{
    internal class Program
    {
        #region Consigna
        /*
        Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) distintos de cero de forma aleatoria 
        utilizando la clase Random.

        1.Mostrar el vector tal como fue ingresado.
        2.Luego mostrar los positivos ordenados en forma decreciente.
        3.Por último, mostrar los negativos ordenados en forma creciente. 
        */
        #endregion

        static void Main(string[] args)
        {
            int[] vector = new int[20];
            int[] vectorPositivos;
            int[] vectorNegativos;
            CargarNumeros(vector);
            MostrarVector(vector);
            Console.WriteLine();
            vectorPositivos = OrdenarPositivosDecreciente(vector);
            Console.WriteLine("Se ordenaron los numeros positivos del vector de forma decreciente.");
            MostrarVector(vectorPositivos);
            Console.WriteLine();
            vectorNegativos = OrdenarNegativosCreciente(vector);
            Console.WriteLine("Se ordenaron los numeros negativos del vector de forma creciente.");
            MostrarVector(vectorNegativos);
            

        }

        /// <summary>
        /// Carga numeros Random en el vector pasado por parametro.
        /// </summary>
        /// <param name="vectorEnteros"></param>
        private static void CargarNumeros(int[] vectorEnteros)
        {
            
            Random random = new Random();
            int numero;

            for(int i = 0; i <vectorEnteros.Length; i++)
            {
                numero = random.Next(-100, 100);
                while(numero == 0)
                {
                    numero = random.Next(-100, 100);
                }
                vectorEnteros[i] = numero;
            }

        }

        /// <summary>
        /// Muestra el vector por consola.
        /// </summary>
        /// <param name="vectorEnteros"></param>
        private static void MostrarVector(int[] vectorEnteros)
        {
            for(int i = 0; i<vectorEnteros.Length; i++)
            {
                if(vectorEnteros[i] != 0)
                Console.Write($"{vectorEnteros[i]},");
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

            for(int i = 0; i < vectorEnteros.Length; i++)
            {
                if(vectorEnteros[i] > 0)
                {
                    vectorOrdenado[j] = vectorEnteros[i];
                    j++;
                }
            }

            for(int i = 0; i < vectorOrdenado.Length -1; i++)
            {
                for(int k = i+1; k < vectorOrdenado.Length; k++)
                {
                    if(vectorOrdenado[i] < vectorOrdenado[k])
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

    }
}
