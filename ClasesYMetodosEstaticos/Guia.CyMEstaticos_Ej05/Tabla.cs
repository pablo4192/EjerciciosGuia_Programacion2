using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej05
{
    internal class Tabla
    {
        /// <summary>
        /// Retorna la tabla de multiplicar del numero pasado por parametro.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string RetonarTablaMultiplicar(int numero)
        {
            StringBuilder stringBuilder = new StringBuilder();

            Console.WriteLine($"Tabla de multiplicar del numero {numero}:");
            
            for(int multiplicador = 0; multiplicador < 10; multiplicador++)
            {
                stringBuilder.Append($"{numero} x {multiplicador} = ");
                stringBuilder.AppendLine((numero * multiplicador).ToString());
                
            }

            return stringBuilder.ToString();
        }

    }
}
