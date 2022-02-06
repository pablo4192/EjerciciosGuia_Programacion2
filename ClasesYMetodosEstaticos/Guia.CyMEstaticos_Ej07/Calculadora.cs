using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej07
{
    internal static class Calculadora
    {

        /// <summary>
        /// Calcula la longitud de la hipotenusa de un triangulo rectangulo utilizando el teorema de Pitagoras.
        /// </summary>
        /// <param name="baseTriangulo"></param>
        /// <param name="altura"></param>
        /// <returns>Longitud de la hipotenusa, 0 si base o altura pasados por parametro son < 0</returns>
        public static double CalcularHipotenusa(double baseTriangulo, double altura)
        {
            if(baseTriangulo < 0 || altura < 0)
            {
                return 0;
            }

            return Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2));

             
        }

    }
}
