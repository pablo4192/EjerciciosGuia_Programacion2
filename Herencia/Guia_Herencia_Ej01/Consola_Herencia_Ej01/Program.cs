using System;
using Guia_Herencia_Ej01;

namespace Consola_Herencia_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camion c = new Camion(8, 2, Colores.Blanco, 6, 1000);
            Moto m = new Moto(2, 0, Colores.Negro, 4, 250);
            Automovil a = new Automovil(4, 5, Colores.Rojo, 5, 5);

            Console.WriteLine("***Camion***");
            Console.WriteLine($"Ruedas: {c.CantidadRuedas}, Puertas: {c.CantidadRuedas}, Color: {c.Color}, Marchas: {c.CantidadMarchas}, PesoCarga: {c.PesoCarga}");
            Console.WriteLine("***Moto***");
            Console.WriteLine($"Ruedas: {m.CantidadRuedas}, Puertas: {m.CantidadRuedas}, Color: {m.Color}, Marchas: {m.CantidadMarchas}, Cilindrada: {m.Cilindrada}");
            Console.WriteLine("***Automovil***");
            Console.WriteLine($"Ruedas: {a.CantidadRuedas}, Puertas: {a.CantidadRuedas}, Color: {a.Color}, Marchas: {a.CantidadMarchas}, Pasajeros: {a.CantidadPasajeros}");

        }
    }
}
