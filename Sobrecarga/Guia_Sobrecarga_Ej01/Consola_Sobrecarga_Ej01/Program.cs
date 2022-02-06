using System;
using Guia_Sobrecarga_Ej01;

namespace Consola_Sobrecarga_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecarga Ej01";

            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador(5);
            long sumaDeAtributos;

            Console.WriteLine($"Retorno del metodo Sumar(long a, long b) : {sumador1.Sumar(10, 5)}");
            Console.WriteLine();

            Console.WriteLine($"Retorno del metodo Sumar(string a, strin b) : {sumador1.Sumar("Hola", "Señoda")}");
            Console.WriteLine();
            
            if(!(sumador1 | sumador2)) //== false
            {
                Console.WriteLine("El operador | indica que los sumadores no contienen el mismo valor en el atributo cantidadSumas");
            }

            sumaDeAtributos = sumador1 + sumador2;

            Console.WriteLine($"El operador sobrecargado + da como resultado la suma de los atributos cantidadSumas: {sumaDeAtributos}");

        }
    }
}
