using System;

namespace Guia.CyMEstaticos_Ej07
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

        El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

        Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

        Mostrar el resultado en la consola. 
        */

        #endregion

        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;

            Console.WriteLine("***Calcular longitud de la hipotenusa de un triangulo rectangulo***");
            Console.WriteLine("Ingrese Base del triangulo (en centimetros): ");
            while(!double.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("Error, Ingrese Base del triangulo (en centimetros): ");
            }

            Console.WriteLine("Ingrese Altura del triangulo (en centimetros): ");
            while (!double.TryParse(Console.ReadLine(), out altura))
            {
                Console.WriteLine("Error, Ingrese Altura del triangulo (en centimetros): ");
            }

            Console.WriteLine($"La longitud de la hipotenusa es: {Calculadora.CalcularHipotenusa(baseTriangulo, altura)} cm");
        }
    }
}
