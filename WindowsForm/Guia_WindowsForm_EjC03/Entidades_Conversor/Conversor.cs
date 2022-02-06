using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Conversor
{
    public class Conversor
    {
        /// <summary>
        /// Convierte un numero decimal en binario.
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Numero en binario</returns>
        public static string ConvertirDecimalABinario(double numeroEntero)
        {
            string numeroBinario = "";
            string retornoBinario = "";

            while (numeroEntero / 2 != 0)
            {
                numeroBinario += (numeroEntero % 2).ToString();
                numeroEntero = (int)numeroEntero / 2; //Casteo a entero para retirar los decimales.

                if (numeroEntero == 1)
                {
                    numeroBinario += "1";
                    break;
                }
            }

            for (int i = numeroBinario.Length - 1; i >= 0; i--)
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
        public static double ConvertirBinarioADecimal(string numeroBinario)
        {
            int potencia = 0;
            double numero;
            double numeroBinarioRetorno = 0;

            if (double.TryParse(numeroBinario, out numero) && numero >= 0)
            {
                for (int i = numeroBinario.Length - 1; i >= 0; i--)
                {
                    if (numeroBinario[i] == '1')
                    {
                        numeroBinarioRetorno += Math.Pow(2, potencia);

                    }

                    potencia++;
                }

                return numeroBinarioRetorno;
            }

            return -1;
        }

    }
}
