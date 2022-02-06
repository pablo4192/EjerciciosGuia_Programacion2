using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej06
{
    internal class CalculadoraDeArea
    {
        /// <summary>
        /// Calcula el area de un cuadrado.
        /// </summary>
        /// <param name="longitudLado"></param>
        /// <returns>Area del cuadrado, en caso de longitudLado negativo 0</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            if(longitudLado < 0)
            {
                return 0;
            }
            
            return longitudLado * longitudLado;
        }

        /// <summary>
        /// Calcula el area de un triangulo.
        /// </summary>
        /// <param name="baseTriangulo"></param>
        /// <param name="altura"></param>
        /// <returns>Area del triangulo, si alguno de los parametros es negativo 0.</returns>
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            if (baseTriangulo < 0 || altura < 0)
            {
                return 0;
            }

            return (baseTriangulo * altura) / 2;
        }

        /// <summary>
        /// Calcula el area de un circulo.
        /// </summary>
        /// <param name="radio"></param>
        /// <returns>Area del circulo, si el radio es negativo 0.</returns>
        public static double CalcularAreaCirculo(double radio) 
        {
            const double pi = 3.14;

            if(radio < 0)
            {
                return 0;
            }

            return pi * Math.Pow(radio, 2);
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
