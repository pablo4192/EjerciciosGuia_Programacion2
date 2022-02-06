using System;

namespace Guia.CyMEstaticos_Ej06
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

        public double CalcularAreaCuadrado(double longitudLado) {}
        public double CalcularAreaTriangulo(double base, double altura) {}
        public double CalcularAreaCirculo(double radio) {}
        El ingreso de los datos como la visualización se deberán realizar desde el método Main(). 
        */
        #endregion

        static void Main(string[] args)
        {
            do
            {
                Menu();

                Console.WriteLine("Desea realizar otro calculo? (SI para seguir): ");

            } while (CalculadoraDeArea.ValidarRespuesta(Console.ReadLine()));

        }

        /// <summary>
        /// Presenta el menu de opciones.
        /// </summary>
        private static void Menu()
        {
            double longitudLado;
            double baseTriangulo;
            double altura;
            double radio;

            Console.WriteLine("***Calculadora de areas***");
            Console.WriteLine();
            Console.WriteLine("Escoja una opcion: ");
            Console.WriteLine("1) Calcular area cuadrado");
            Console.WriteLine("2) Calcular area triangulo");
            Console.WriteLine("3) Calcular area circulo");

            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Ingrese longitud lado: ");
                    if(double.TryParse(Console.ReadLine(), out longitudLado))
                    {
                        Console.WriteLine($"El area del cuadrado es: {CalculadoraDeArea.CalcularAreaCuadrado(longitudLado)}");
                    }
                    else
                    {
                        Console.WriteLine("Error, a ingresado un caracter invalido");
                    }    
                    break;
                case "2":
                    Console.WriteLine("Ingrese base: ");
                    if (double.TryParse(Console.ReadLine(), out baseTriangulo))
                    {
                        Console.WriteLine("Ingrese altura del triangulo: ");
                        if(double.TryParse(Console.ReadLine(), out altura))
                        {
                            Console.WriteLine($"El area del cuadrado es: {CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, altura)}");
                        }
                        else
                        {
                            Console.WriteLine("Error, a ingresado un caracter invalido");
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("Ingrese radio: ");
                    if (double.TryParse(Console.ReadLine(), out radio))
                    {
                        Console.WriteLine($"El area del circulo es: {CalculadoraDeArea.CalcularAreaCirculo(radio)}");
                    }
                    else
                    {
                        Console.WriteLine("Error, a ingresado un caracter invalido");
                    }
                    break;
                default:
                    Console.WriteLine("Error, a ingresado un caracter invalido");
                    break;
            }
        }
    }
}
