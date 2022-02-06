using System;

namespace Guia_EjA01
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        El factorial de un número es una operación que consiste en multiplicar un numero “n” 
        por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

        En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado. 
        */
        #endregion

        static void Main(string[] args)
        {
            double numero;
            long factorial;

            Console.WriteLine("Ingrese un numero para calcular su factorial: ");
            while(!double.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Error, ingrese un numero para calcular su factorial (entero y positivo): ");
            }

            factorial = CalcularFactorial(numero);
            Console.WriteLine($"El factorial del numero {numero} es: {factorial}");
        }

        /// <summary>
        /// Calcula el factorial de un numero entero positivo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        private static long CalcularFactorial(double numero)
        {
            long fact = 1;

            for (int i = 1; i <= numero; i++)
            {
                fact *= i;
            }
            return fact;

           
        }
    }
}
