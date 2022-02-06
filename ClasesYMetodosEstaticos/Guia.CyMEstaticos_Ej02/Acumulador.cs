using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej02
{
    internal class Acumulador
    {
        /// <summary>
        /// Realiza la peticion de numeros por consola y los acumula, mostrando el resultado al finalizar.
        /// </summary>
        public static void ComenzarSuma()
        {
            int numero;
            int acumulador = 0;
            string seguir;

            do
            {
                Console.WriteLine("Ingrese un numero para realizar la suma: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Error, Ingrese un numero para realizar la suma: ");
                }

                acumulador += numero;

                Console.WriteLine("Desea continuar? (S para seguir, pulse otra tecla para finalizar): ");
                seguir = Console.ReadLine();


            } while (Validador.ValidarRespuesta(seguir));

            Console.WriteLine($"La suma total es: {acumulador}");
        }

    }
}
