using System;
using Guia_Herencia_EjC01;

namespace Consola_Herencia_EjC01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creo equipo
            Equipo equipo1 = new Equipo(3, "Pipistrelos");


            //Creo jugadores
            Jugador j1 = new Jugador(33398156, "Sergio");
            Jugador j2 = new Jugador(32589654, "Alan");
            Jugador j3 = new Jugador(45879365, "Berta", 10, 5);
            Jugador j4 = new Jugador(48523658, "Joel", 25, 7);


            //Muestro jugadores
            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine();
            Console.WriteLine(j4.MostrarDatos());

            //Sumo jugadores a los equipos
            _ = equipo1 + j1;
            _ = equipo1 + j2;

            if (!(equipo1 + j2)) //No se puede agregar, repetido.
            {
                Console.WriteLine("J2 no se pudo agregar por que ya esta incorporado al equipo.");
            }

            if (equipo1 + j3)
            {
                Console.WriteLine("J3 se incorporo al equipo!");
            }

            if (!(equipo1 + j4)) //No se puede agregar, no hay mas lugar en el equipo
            {
                Console.WriteLine("No hay mas lugar en el equipo");
            }

            if (!(j1 == j2))
            {
                Console.WriteLine($"J1 y J2 no son la misma persona");
            }
        }
    }
}
