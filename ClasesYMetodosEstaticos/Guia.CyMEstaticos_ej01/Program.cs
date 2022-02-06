using System;

namespace Guia.CyMEstaticos_ej01
{
    #region Consigna
    /*
       Consigna#
       Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

       bool Validar(int valor, int min, int max)
       valor: dato a validar.
       min: mínimo valor incluido.
       max: máximo valor incluido.
       Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

       Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

       IMPORTANTE
       Utilizar variables escalares, NO utilizar vectores/arrays.
    */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = DataEntry.IngresarDatos();
            int numero2 = DataEntry.IngresarDatos(); 
            int numero3 = DataEntry.IngresarDatos(); 
            int numero4 = DataEntry.IngresarDatos(); 
            int numero5 = DataEntry.IngresarDatos(); 
            int numero6 = DataEntry.IngresarDatos(); 
            int numero7 = DataEntry.IngresarDatos(); 
            int numero8 = DataEntry.IngresarDatos(); 
            int numero9 = DataEntry.IngresarDatos();
            int numero10 = DataEntry.IngresarDatos();

            Validador.MostrarMinMaxProm(numero1, numero2, numero3, numero4, numero5, numero6, numero7, numero8, numero9, numero10);

        }
    }
}
