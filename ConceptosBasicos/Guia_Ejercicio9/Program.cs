using System;

namespace Guia_Ejercicio9
{
    internal class Program
    {
        /*
        Consigna#
        Escribir un programa que imprima por consola un triángulo como el siguiente:

                *      //va aumentando 2 asteriscos por piso, la cantidad de espacios del techo es igual a los asteriscos agregados en la base (8)
               ***     //2 * la cantidad de pisos - 1 me da la cantidad de espacios del techo
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
            int espacios = 1;
            string asterisco = "*";
            
            Console.WriteLine("Ingrese un numero positivo que indique la cantidad de pisos de la piramide: ");
            while (!int.TryParse(Console.ReadLine(), out altura) || altura < 1)
            {
                Console.WriteLine("Error, Ingrese un numero positivo que indique la cantidad de pisos de la piramide: ");
            }

            
            Console.Clear();
            Console.WriteLine("Triangulo Equilatero");
            Console.WriteLine();

            for(int linea = 0; linea < altura; linea++)
            {
                for (int espacio = espacios; espacio < altura * 2; espacio++)
                {
                    Console.Write(" ");
                }
                espacios++;

                Console.WriteLine(asterisco);
                asterisco += "**";
                    
            }
        }
    }
}
