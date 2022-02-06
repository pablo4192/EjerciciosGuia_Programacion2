using System;
using Billetes;

namespace Consola_Sobrecarga_Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecarga Ej02";

            Peso peso = new Peso(1);
            Dolar dolar = new Dolar(1);
            Euro euro = new Euro(1);

            //Prueba de casteos (conversiones explicitas)
            Console.WriteLine($"1 dolar equivale a {((Euro)dolar).GetCantidad()} euros");
            Console.WriteLine();
            Console.WriteLine($"1 euro equivale a {((Peso)euro).GetCantidad()} pesos");
            Console.WriteLine();
            Console.WriteLine($"1 peso equivale a {((Euro)peso).GetCantidad()} euros");
            Console.WriteLine();

            //Prueba de operadores 
            Console.WriteLine($"1 peso + 1 dolar es: {(peso + dolar).GetCantidad()} pesos");
            Console.WriteLine($"1 dolar + 1 euro es: {(dolar + euro).GetCantidad()} dolares");
            Console.WriteLine($"1 euro + 1 peso es: {(euro + peso).GetCantidad()} euros");
            Console.WriteLine();
            Console.WriteLine($"1 dolar - 1 peso es: {(dolar - peso).GetCantidad()} dolares");
            Console.WriteLine($"1 euro - 1 dolar es: {(euro - dolar).GetCantidad()} euros");
            Console.WriteLine($"1 peso - 1 dolar es: {(peso - dolar).GetCantidad()} pesos");
            Console.WriteLine();

            //Prueba operadores == , !=
            if(new Peso(102.65) == dolar)
            {
                Console.WriteLine("$102.65 equivalen a u$1");
            }

            if(euro != dolar)
            {
                Console.WriteLine("eu$1 es != a u$1; u$1 equivale a eu$0.85");
            }

            if(peso == new Peso(1))
            {
                Console.WriteLine("$1 equivale a $1");
            }

            if(new Euro(0.008326360006827616) == peso)
            {
                Console.WriteLine("$1 equivale a eu$0.008326360006827616");
            }



        }
    }
}
