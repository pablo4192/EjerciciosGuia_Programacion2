using System;
using Guia_Generics_Ej01;

namespace Consola_Generisc_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> tFutbol = new Torneo<EquipoFutbol>("Torneo Futbol");
            Torneo<EquipoBasquet> tBasquet = new Torneo<EquipoBasquet>("Torneo Basquet");

            
            Equipo FutbolE1 = new EquipoFutbol("River", new DateTime(1950, 10, 05));
            Equipo FutbolE2 = new EquipoFutbol("Boca", new DateTime(1945, 12, 05));
            Equipo FutbolE3 = new EquipoFutbol("Racing", new DateTime(1936, 05, 20));
            
            Equipo BasquetE1 = new EquipoBasquet("Olimpia", new DateTime(1990, 05, 8));
            Equipo BasquetE2 = new EquipoBasquet("Chicago", new DateTime(2000, 9, 5));
            Equipo BasquetE3 = new EquipoBasquet("Bahia", new DateTime(1955, 6, 11));

            //Agrego Equipos a torneo de futbol
            if(tFutbol + FutbolE1)
            {
                Console.WriteLine("Torneo Futbol, EquipoFutbol1 agregado.");
            }
            if(tFutbol + FutbolE2)
            {
                Console.WriteLine("Torneo Futbol, EquipoFutbol2 agregado.");
            }
            if(tFutbol + FutbolE3)
            {
                Console.WriteLine("Torneo Futbol, EquipoFutbol3 agregado.");
            }

            

            //Agrego equipos a torneo de Basquet
            if (tBasquet + BasquetE1)
            {
                Console.WriteLine("Torneo Basquet, EquipoBasquet1 agregado.");
            }
            if (tBasquet + BasquetE2)
            {
                Console.WriteLine("Torneo Basquet, EquipoBasquet2 agregado.");
            }
            if (tBasquet + BasquetE3)
            {
                Console.WriteLine("Torneo Basquet, EquipoBasquet3 agregado.");
            }
            if(!(tBasquet + BasquetE2))
            {
                Console.WriteLine("Torneo Basquet, EquipoBasquet2 no se agrego, ya esta en el torneo.");
            }

            Console.WriteLine();

            //Muestro los torneos
            Console.WriteLine("Torneo Futbol");
            Console.WriteLine(tFutbol.Mostrar());
            Console.WriteLine("---------------------");

            Console.WriteLine("Torneo Basquet");
            Console.WriteLine(tBasquet.Mostrar());
            Console.WriteLine("---------------------");

            //Muestro los partidos jugados
            Console.WriteLine("Partidos Jugados");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Futbol Fecha {i + 1}:");
                Console.WriteLine(tFutbol.JugarPartido);
                Console.WriteLine($"Basquet Fecha {i + 1}:");
                Console.WriteLine(tBasquet.JugarPartido);
            }


        }
    }
}
