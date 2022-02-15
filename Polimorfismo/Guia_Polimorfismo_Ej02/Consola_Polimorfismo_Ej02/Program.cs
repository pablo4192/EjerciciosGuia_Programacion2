using System;
using System.Collections.Generic;
using Guia_Polimorfismo_Ej02;

namespace Consola_Polimorfismo_Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>();
            Figura cuadrado = new Cuadrado(4);
            Figura circulo = new Circulo(10);
            Figura rectangulo = new Rectangulo(4, 2);

            listaFiguras.Add(cuadrado);
            listaFiguras.Add(circulo);
            listaFiguras.Add(rectangulo);

            foreach (Figura figura in listaFiguras)
            {
                Console.WriteLine(figura.Dibujar());
                Console.WriteLine(figura.CalcularSuperficie().ToString("0.##"));
                Console.WriteLine(figura.CalcularPerimetro().ToString("0.##"));
                Console.WriteLine($"Tipo del objeto: {figura.GetType()}");
                Console.WriteLine("-------------------------------------");
            }
            
        }
    }
}
