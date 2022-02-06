using System;

namespace Guia_Ejercicio5
{
    /*
    Consigna#
    Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, 
    cuyas sumas son iguales.

    El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
    cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) 
    en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.

    Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.

    IMPORTANTE
    Utilizar sentencias de iteración y selectivas. 
     
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            int centro;
            int numero;

            Console.WriteLine("Ingrese un numero para saber el centro numerico entre 1 y el mismo: ");

            while( !int.TryParse(Console.ReadLine(), out numero) )
            {
                Console.WriteLine("Error, Ingrese un numero para saber el centro numerico entre 1 y el mismo: ");
            }

            centro = RetornarCentroNumerico(numero);

            if(centro != 0)
            {
                Console.WriteLine($"El centro es: {centro}");
            }
            else
            {
                Console.WriteLine($"No hay centro numerico");
            }

            
        }

        public static int RetornarCentroNumerico(int numero)
        {
            int retorno = 0;
            int acumuladorA;
            int acumuladorB;

            int aumento = 1;
            

            while(aumento < numero)
            {
                aumento++;

                acumuladorA = 0;
                acumuladorB = 0;

                for (int i = 1; i < aumento; i++)
                {
                    acumuladorA += i;
                }

                for(int i = numero; i > aumento; i--)
                {
                    acumuladorB += i;
                }

                if(acumuladorA == acumuladorB)
                {
                    retorno = aumento;
                    break;
                }
            }


            

            return retorno;
        }

    }
}
