using System;

namespace Guia.CyMEstaticos_Ej03
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

        El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.
        public string ConvertirDecimalABinario(int numeroEntero) {}

        El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.
        public int ConvertirBinarioADecimal(int numeroEntero) {}

        IMPORTANTE
        NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección. 
        */
        
        #endregion

        static void Main(string[] args)
        {
            int numeroDec;
            int numeroBin;

            Console.WriteLine("Ingrese un numero decimal para convertirlo en binario: ");
            if (int.TryParse(Console.ReadLine(), out numeroDec))
            {
                Console.WriteLine($"Se realizo la conversion, el numero en binario es: {Conversor.ConvertirDecimalABinario(numeroDec)}");
            }

            Console.WriteLine("Ingrese un numero binario para convertirlo en decimal: ");
            if (int.TryParse(Console.ReadLine(), out numeroBin))
            {
                Console.WriteLine($"Se realizo la conversion, el numero en decimal es: {Conversor.ConvertirBinarioADecimal(numeroBin)}");
            }


        }
    }
}
