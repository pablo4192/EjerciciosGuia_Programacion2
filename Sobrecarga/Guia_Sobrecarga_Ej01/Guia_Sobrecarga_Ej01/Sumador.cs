using System;

namespace Guia_Sobrecarga_Ej01
{
    public class Sumador
    {
        int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador() : this(0)
        {

        }

        /// <summary>
        /// Realiza la suma entre los argumentos y aumenta en uno el valor del atributo cantidadSumas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Resultado de la suma</returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        /// <summary>
        /// Concatena los argumentos y aumenta en uno el valor del atributo cantidadSumas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>String con los argumentos concatenados</returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return string.Concat(a, b);
        }

        /// <summary>
        /// Conversion explicita de la clase Suma
        /// </summary>
        /// <param name="sumas"></param>
        public static explicit operator int(Sumador sumas) //Cuando a la clase Sumas la casteo a int me retorna el atributo cantidadSumas.
        {
            return sumas.cantidadSumas;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>Suma de los atributos cantidadSumas</returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (int)s1 + (int)s2; //Uso de la conversion explicita.
        }

        /// <summary>
        /// Sobrecarga del operador |
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>True si cantidadSumas de los parametros son iguales, False si son distintos</returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            if ((int)s1 == (int)s2)
            {
                return true;
            }
                
            return false;
        }


    }
}
