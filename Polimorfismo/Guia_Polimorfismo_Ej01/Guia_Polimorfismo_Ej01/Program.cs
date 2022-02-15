﻿using System;

namespace Guia_Polimorfismo_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobreescrito objetoSobrescrito = new SobreSobreescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Llamada a MiMetodo implementado en SobreSobreescrito");
            Console.WriteLine(objetoSobrescrito.MiMetodo());
        }
    }
}
