using System;

namespace Guia.CyMEstaticos_Ej05
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Crear una aplicación de consola que permita al usuario ingresar un número entero.

        Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

        Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

        Mostrar en la consola el resultado.

        Por ejemplo, si se ingresa el número 2 la salida deberá ser:

        Tabla de multiplicar del número 2:
        2 x 1 = 2
        2 x 2 = 4
        2 x 3 = 6
        2 x 4 = 8
        2 x 5 = 10
        2 x 6 = 12
        2 x 7 = 14
        2 x 8 = 16
        2 x 9 = 18 
        */
        #endregion

        static void Main(string[] args)
        {
            int numero;
            string tabla = "";

            Console.WriteLine("Ingrese un numero para saber su tabla de multiplicar: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                tabla = Tabla.RetonarTablaMultiplicar(numero);
            }

            Console.WriteLine(tabla);
        }
    }
}
