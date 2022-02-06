using System;
using Guia_Encapsulamiento_Ej02;

namespace Consola_Encapsulamiento_Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio el libro
            Libro libro1 = new Libro();

            //Le asigno segun el indice mediante el set de la propiedad
            libro1[0] = "Hable mas fuerte que tengo una toalla";
            libro1[1] = "Todos estan enfermos, y no es gripe gordito";
            libro1[2] = "Querida Edna, debo dejarte ¿Por qué? No puedo decirlo. ¿A dónde iré? No puedes saberlo.¿Cómo llegaré? Ah… todavía no lo decido. Pero puedo decirte algo, cada vez que escuche el viento, susurrará tu nombre… Edna! Con mi amor para toda la eternidad. Woodrow.";

            //Muestro por consola el texto en el indice 2 de la lista de paginas 
            Console.WriteLine(libro1[2]);
            Console.WriteLine();

            //Mediante el get retorno un string vacio ya que el indice es incorrecto
            Console.WriteLine($"El indice es incorrecto: {libro1[5]}"); //texto vacio despues de los dos puntos

            //Agrego una pagina mas ya que el indice es mayor a la cantidad de paginas
            libro1[9] = "No me lo agradescan a mi, si no a mi navaja!!";
            Console.WriteLine();

            //Muestro la pagina agregada
            Console.WriteLine(libro1[3]);
            Console.WriteLine();

            //Cambio el valor de una pagina existente
            libro1[1] = "A la grande le puse Cuca";
            Console.WriteLine(libro1[1]);




        }
    }
}
