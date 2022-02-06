using System;
using Guia_OOP_EjA01;

namespace Consola_OOP_EjA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chofer chofer1 = new Chofer("Pedrito");   
            Chofer chofer2 = new Chofer("Cacho");   
            Chofer chofer3 = new Chofer("Susana");

            Chofer choferAux;

            chofer1.PedirKmPorConsola();
            chofer2.PedirKmPorConsola();
            chofer3.PedirKmPorConsola();

            Empresa.SetArrayChoferes(chofer1);
            Empresa.SetArrayChoferes(chofer2);
            Empresa.SetArrayChoferes(chofer3);

            choferAux = Empresa.ChoferConMasKmRecorridos();
            Console.WriteLine($"El chofer con mas km recorridos es: {choferAux.GetNombre()}");

            choferAux = Empresa.ChoferConMasKmRecorridos_Dia3();
            Console.WriteLine($"El chofer con mas km recorridos el dia 3 es: {choferAux.GetNombre()}");

            choferAux = Empresa.ChoferConMasKmRecorridos_Dia5();
            Console.WriteLine($"El chofer con mas km recorridos el dia 5 es: {choferAux.GetNombre()}");




        }
    }
}
