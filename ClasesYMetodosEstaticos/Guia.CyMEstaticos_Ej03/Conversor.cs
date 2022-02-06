using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej03
{
    internal class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Numero en binario</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario = "";
            string retornoBinario = "";

            while(numeroEntero / 2 != 0) 
            {
                numeroBinario += (numeroEntero % 2).ToString();
                numeroEntero = (int)numeroEntero / 2;

                if(numeroEntero == 1)
                {
                    numeroBinario += "1";
                    break;
                }
            }

            for(int i = numeroBinario.Length - 1; i >= 0; i--)
            {
                retornoBinario += numeroBinario[i];
            }

            return retornoBinario;
        }

        /// <summary>
        /// Convierte un numero binario en decimal (solo numeros positivos).
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Numero convertido en binario, -1 en caso de error</returns>
        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroString = numeroEntero.ToString();
            int potencia = 0;
            
            double numeroBinario = 0;

            if(numeroEntero >= 0)
            {
                for (int i = numeroString.Length -1; i >= 0; i--)
                {
                    if (numeroString[i] == '1')
                    {
                        numeroBinario += Math.Pow(2, potencia);

                    }

                    potencia++;
                }

                return Convert.ToInt32(numeroBinario);
            }

            return -1;
        }

    }
}
