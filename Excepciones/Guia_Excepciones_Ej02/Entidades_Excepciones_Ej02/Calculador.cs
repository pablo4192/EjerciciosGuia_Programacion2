using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Excepciones_Ej02
{
    public  class Calculador
    {
        public static double Calcular(int n1, int n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("No es posible dividir por 0");
            

            return (double)n1 / n2;

        }

    }
}
