using System;
using Geometria;

namespace OOP_Consola_Ej05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto vertice1 = new Punto(-4, -3);
            Punto vertice3 = new Punto(4, 3);

            Rectangulo rectangulo1 = new Rectangulo(vertice1, vertice3);

            MostrarRectangulo(rectangulo1);
        }

        public static void MostrarRectangulo(Rectangulo rectangulo)
        {
            Console.WriteLine($"Area del rectangulo: {rectangulo.GetArea()}");
            Console.WriteLine($"Perimetro del rectangulo: {rectangulo.GetPerimetro()}");

        }
    }
}
