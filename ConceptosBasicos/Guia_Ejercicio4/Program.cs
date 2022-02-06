using System;

namespace Guia_Ejercicio4
{
    /*
    Consigna#
    Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) 
    que son divisores del número.

    El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

    Escribir una aplicación que encuentre los 4 primeros números perfectos.

    IMPORTANTE
    Utilizar sentencias de iteración y selectivas.

    INFORMACIÓN
    Para conocer más sobre los números perfectos, consultar el siguiente enlace a Wikipedia. 
     
    */


    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numerosPerfectos = RetornarNumerosPerfectos();

            for(int i = 0; i < numerosPerfectos.Length; i++)
            {
                Console.WriteLine(numerosPerfectos[i]);
            }
        }

        //2^n-1 * (2^n - 1)
        public static double[] RetornarNumerosPerfectos()
        {
            double[] arrayNumerosperfectos = new double[4];

            arrayNumerosperfectos[0] = Math.Pow(2, 2 - 1) * (Math.Pow(2,2) - 1);
            arrayNumerosperfectos[1] = Math.Pow(2, 3 - 1) * (Math.Pow(2,3) - 1);
            arrayNumerosperfectos[2] = Math.Pow(2, 5 - 1) * (Math.Pow(2,5) - 1);
            arrayNumerosperfectos[3] = Math.Pow(2, 7 - 1) * (Math.Pow(2,7) - 1);

            return arrayNumerosperfectos;
        }

    }
}
