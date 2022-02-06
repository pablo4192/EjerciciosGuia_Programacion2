using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej04
{
    internal class Calculadora
    {
        /// <summary>
        /// Realiza el calculo matematico entre dos numeros.
        /// </summary>
        /// <param name="operando1"></param>
        /// <param name="operando2"></param>
        /// <param name="operacion"></param>
        /// <returns>Resultado en caso de exito, 0 en caso de error</returns>
        public static double Calcular(double operando1, double operando2, string operacion)
        {
            double resultado = 0;

            switch(operacion)
            {
                case "+":
                    resultado = operando1 + operando2;
                    break;
                case "-":
                    resultado = operando1 - operando2;
                    break;
                case "*":
                    resultado = operando1 * operando2;
                    break;
                case "/":
                    if(Validar(operando2))
                    {
                        resultado = operando1 / operando2;
                    }
                    break;
            }
                   
            return resultado;
               
        }

        /// <summary>
        /// Valida que el segundo operando sea != 0.
        /// </summary>
        /// <param name="operando2"></param>
        /// <returns>True si es != 0, False si es 0.</returns>
        private static bool Validar(double operando2)
        {
            if(operando2 != 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida si la respuesta pasada por parametro es S
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns>True si es la letra S, False si no lo es</returns>
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta.ToUpper() == "SI")
            {
                return true;
            }

            return false;
        }
    }
}
