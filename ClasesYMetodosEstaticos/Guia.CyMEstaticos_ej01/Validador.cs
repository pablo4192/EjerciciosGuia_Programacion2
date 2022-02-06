using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    internal class Validador
    {
        /// <summary>
        /// Valida si el valor pasado por parametro se encuentra entre el minimo y maximo valor permitido
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns>true si esta entre el minimo y el maximo, false si no esta</returns>
        public static bool Validar(int valor, int min, int max)
        {
            if(valor > max || valor < min)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calcula y muestra por consola el maximo, minimo valor ingresado y el promedio.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        /// <param name="n4"></param>
        /// <param name="n5"></param>
        /// <param name="n6"></param>
        /// <param name="n7"></param>
        /// <param name="n8"></param>
        /// <param name="n9"></param>
        /// <param name="n10"></param>
        public static void MostrarMinMaxProm(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10)
        {
            int[] arrayInt = { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10 };
            int acumulado = arrayInt[0];
            float promedio;

            int mayor = arrayInt[0];
            int menor = arrayInt[0];
            for(int i = 1; i<arrayInt.Length; i++)
            {
                acumulado += arrayInt[i];

                if(arrayInt[i] > mayor)
                {
                    mayor = arrayInt[i];
                }
                if(arrayInt[i] < menor)
                {
                    menor = arrayInt[i];
                }
            }

            promedio = (float) acumulado / 10;

            Console.WriteLine($"El numero minimo ingresado es: {menor}");
            Console.WriteLine($"El numero maximo ingresado es: {mayor}");
            Console.WriteLine($"El promedio entre los numeros ingresados es: {promedio}");
        }
        

    }
        


}
