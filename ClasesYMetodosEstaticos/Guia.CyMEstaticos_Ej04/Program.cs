using System;

namespace Guia.CyMEstaticos_Ej04
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

        Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

        Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
        El método devolverá el resultado de la operación.

        Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación 
        elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

        Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

        El usuario decidirá cuándo finalizar el programa.
        
        */
        #endregion

        static void Main(string[] args)
        {
            double operando1;
            double operando2;
            string operacion;
            
            do
            {
                Console.WriteLine("***Calculadora***");
                Console.WriteLine();

                Console.WriteLine("Ingrese operando1: ");
                while(!double.TryParse(Console.ReadLine(), out operando1))
                {
                    Console.WriteLine("Error, Ingrese operando1: ");
                }

                Console.WriteLine("Ingrese operando2: ");
                while (!double.TryParse(Console.ReadLine(), out operando2))
                {
                    Console.WriteLine("Error, Ingrese operando2: ");
                }

                Console.WriteLine("Ingrese operacion a realizar (+,-,*,/): ");
                operacion = Console.ReadLine();

                Console.WriteLine($"El resultado de la operacion es: {Calculadora.Calcular(operando1, operando2, operacion)}");
                Console.WriteLine();

                Console.WriteLine("Desea realizar otra operacion? (SI para seguir): ");

            } while (Calculadora.ValidarRespuesta(Console.ReadLine()));

        }
    }
}
