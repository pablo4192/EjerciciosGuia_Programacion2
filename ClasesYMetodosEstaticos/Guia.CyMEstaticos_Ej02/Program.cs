using System;

namespace Guia.CyMEstaticos_Ej02
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

        Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor. 
         
        */
        #endregion

        static void Main(string[] args)
        {
            Acumulador.ComenzarSuma();
        }
    }
}
