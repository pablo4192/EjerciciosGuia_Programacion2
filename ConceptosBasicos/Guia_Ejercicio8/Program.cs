using System;

namespace Guia_Ejercicio8
{
    internal class Program
    {
        /*
        Consigna#
        Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
        ***
        *****
        *******
        *********
        El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. 
        Para el ejemplo anterior, la altura ingresada fue de 5.

        IMPORTANTE
        Utilizar sentencias de iteración y selectivas.
        
        */

        static void Main(string[] args)
        {
            ArmarTriangulo();
        }

        public static void ArmarTriangulo()
        {
            int altura;
            string piso = "*";

            Console.WriteLine("Ingrese un numero positivo que indique la cantidad de pisos de la piramide: ");
            while(!int.TryParse(Console.ReadLine(), out altura) || altura < 1)
            {
                Console.WriteLine("Error, Ingrese un numero positivo que indique la cantidad de pisos de la piramide: ");
            }

            Console.Clear();
            Console.WriteLine("Triangulo Rectangulo");
            Console.WriteLine();

            for(int i = 0; i < altura; i++)
            {
                Console.WriteLine(piso);
                piso += "**";
            }
        
        }

    }
}
