using System;
using System.Collections.Generic;

namespace Guia_UnitTests_Ej01
{
    public class Calculadora
    {
        public static int Add(string numeros)
        {
            List<int> operandos = new List<int>();
            string operando = string.Empty;
            int operandoInt = 0;
            int resultado = 0;
            char delimitador = ',';

            #region Punto1
            //string operando1 = string.Empty;
            //string operando2 = string.Empty;
            //int operando1Int = 0;
            //int operando2Int = 0;
            #endregion


            if (string.IsNullOrEmpty(numeros))
            {
                return 0;
            }

            if(numeros[0] == '/' && numeros[1] == '/')
            {
                delimitador = numeros[2];

            }

            for(int i = 0; i < numeros.Length; i++)
            {
                if(char.IsDigit(numeros[i]) || numeros[i] == '-')
                {
                    operando += numeros[i];
                    
                }
                else if(numeros[i] == delimitador || numeros[i] == '\n' || numeros[i] == ',') 
                {
                    _ = int.TryParse(operando, out operandoInt);
                    if(operandoInt < 0)
                    {
                        throw new NegativoNoPermitidoException(operandoInt.ToString());
                        
                    }
                    operandos.Add(operandoInt);
                    operando = string.Empty;
                }
            }

            _ = int.TryParse(operando, out operandoInt);
            operandos.Add(operandoInt);

            #region Punto1
            ////No me interesa si lo parsea ya que su valor por defecto es 0 y no afecta a la suma.
            //_ = int.TryParse(operando1, out operando1Int); 
            //_ = int.TryParse(operando2, out operando2Int);
            #endregion


            foreach (int numero in operandos)
            {
                resultado += numero;
            }

            return resultado;
        }

    }
}
