using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_ej01
{
    internal class DataEntry
    {
        /// <summary>
        /// Pide el ingreso por consola de un numero entero validandolo por medio del metodo Validar.
        /// </summary>
        /// <returns>Numero validado</returns>
        public static int IngresarDatos()
        {
            int numero;

            Console.WriteLine("Ingrese numero: ");
            while(!int.TryParse(Console.ReadLine(), out numero ) || !Validador.Validar(numero, -100, 100))
            {
                Console.WriteLine("Error, Ingrese numero: ");
                
            }

            return numero;
        }
            

            

    }
}
