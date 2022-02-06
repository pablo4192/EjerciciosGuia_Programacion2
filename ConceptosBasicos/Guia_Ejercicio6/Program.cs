using System;
using System.Collections.Generic;

namespace Guia_Ejercicio6
{
    internal class Program
    {
        /*
        Escribir un programa que determine si un año es bisiesto.

        Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
        salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

        Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.

        IMPORTANTE
        Utilizar sentencias de iteración, selectivas y el operador módulo (%). 
         
        */

        static void Main(string[] args)
        {
            int anioInicial;
            int anioFinal;
            List<int> aniosBisiestos;

            Console.WriteLine("ingrese año inicial: ");
            while(!int.TryParse(Console.ReadLine(), out anioInicial))
            {
                Console.WriteLine("Error, ingrese año inicial: ");
            }

            Console.WriteLine("ingrese año final: ");
            while (!int.TryParse(Console.ReadLine(), out anioFinal))
            {
                Console.WriteLine("Error, ingrese año final: ");
            }

            aniosBisiestos = CalcularAnioBisiesto(anioInicial, anioFinal);

            if(aniosBisiestos[0] == 0)
            {
                Console.WriteLine("No hay años bisiestos");
            }
            else
            {
                aniosBisiestos.ForEach((a) => Console.Write(a + ", "));
            }

        }

        private static List<int> CalcularAnioBisiesto(int anioInicial, int anioFinal)
        {
            List<int> aniosBisiestos = new List<int>();

            if(anioInicial <= 0 || anioFinal <= 0)
            {
                 aniosBisiestos.Add(0);
                 return aniosBisiestos;
            }

            for(int i = anioInicial; i <= anioFinal; i++)
            {
                if(i % 100 == 0 && i % 400 == 0)
                {
                   aniosBisiestos.Add(i);
                   
                }
                else
                {
                    if(i % 4 == 0)
                    {
                        aniosBisiestos.Add(i);
                    }
                }

            }

            return aniosBisiestos;
        }
    }
}
