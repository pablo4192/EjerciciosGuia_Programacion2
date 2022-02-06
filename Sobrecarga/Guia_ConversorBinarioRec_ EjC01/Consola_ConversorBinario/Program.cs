using System;
using Guia_ConversorBinarioRec__EjC01;

namespace Consola_ConversorBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = new NumeroBinario("1010");
            NumeroDecimal numeroDecimal = new NumeroDecimal(5);



            //Prueba sobrecarga de operadores + -
            Console.WriteLine($"El resultado de {numeroBinario.GetNumero()} + {numeroDecimal.GetNumero()} es : {numeroBinario + numeroDecimal} en binario");
            Console.WriteLine();
            Console.WriteLine($"El resultado de {numeroDecimal.GetNumero()} + {numeroBinario.GetNumero()} es : {numeroDecimal + numeroBinario} en decimal");
            Console.WriteLine();
            Console.WriteLine($"El resultado de {numeroBinario.GetNumero()} - {numeroDecimal.GetNumero()} es : {numeroBinario - numeroDecimal} en binario");
            Console.WriteLine();
            Console.WriteLine($"El resultado de {numeroDecimal.GetNumero()} - {numeroBinario.GetNumero()} es : {numeroDecimal - numeroBinario} en decimal");
            Console.WriteLine();

            //Prueba sobrecarga operadores == !=
            if (numeroBinario != numeroDecimal)
            {
                Console.WriteLine($"El numero {numeroBinario.GetNumero()} en binario es != a el numero {numeroDecimal.GetNumero()} en decimal");
            }

            if (new NumeroBinario("101") == numeroDecimal)
            {
                Console.WriteLine($"El numero 101 en binario es el {numeroDecimal.GetNumero()} en decimal");
            }

            if (numeroDecimal != numeroBinario)
            {
                Console.WriteLine($"{numeroDecimal.GetNumero()} != {numeroBinario.GetNumero()}");
            }




        }
    }
}
