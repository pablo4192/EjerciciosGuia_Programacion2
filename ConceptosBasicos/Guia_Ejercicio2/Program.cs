using System;

namespace Guia_Ejercicio2
{
    /*
    Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el número sea mayor que cero, 
    caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

    IMPORTANTE
    Utilizar el método Pow de la clase Math para calcular las potencias.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero: ");

            while (!double.TryParse(Console.ReadLine(), out numero) || numero <= 0)
            {
                Console.WriteLine("ERROR, Ingresar numero mayor a 0: ");

            }

            cuadrado = CalcularCuadrado_cubo(numero, out cubo);

            Console.WriteLine($"El numero {numero} al cuadrado es: {cuadrado}");
            Console.WriteLine($"El numero {numero} al cubo es: {cubo}");
            
        }

        public static double CalcularCuadrado_cubo(double numero, out double cuboSalida)
        {
            if(numero > 0)
            {
                cuboSalida = Math.Pow(numero, 3);
                return Math.Pow(numero, 2);
            }

            cuboSalida = 0;
            return 0;

            
        }
    }
}
