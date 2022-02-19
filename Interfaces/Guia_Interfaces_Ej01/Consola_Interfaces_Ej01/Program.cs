using System;
using Guia_Interfaces_Ej01;

namespace Consola_Interfaces_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parte 1
            ConsoleColor colorOriginal = Console.ForegroundColor;

            Lapiz miLapiz = new Lapiz(10);
            Boligrafo miBoligrafo = new Boligrafo(20, ConsoleColor.Green);

            EscrituraWrapper eLapiz = miLapiz.Escribir("Hola");
            Console.ForegroundColor = eLapiz.Color;
            Console.WriteLine(eLapiz.Texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miLapiz.ToString());

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");
            Console.ForegroundColor = eBoligrafo.Color;
            Console.WriteLine(eBoligrafo.Texto);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine(miBoligrafo.ToString());

            //Parte 2
            CartucheraMultiUso cartucheraMultiUso = new CartucheraMultiUso();
            CartucheraSimple cartucheraSimple = new CartucheraSimple();

            Lapiz lapiz1 = new Lapiz(10);
            Lapiz lapiz2 = new Lapiz(13);
            
            Boligrafo boli1 = new Boligrafo(6, ConsoleColor.Red);
            Boligrafo boli2 = new Boligrafo(8, ConsoleColor.Green);
            Boligrafo boli3 = new Boligrafo(4, ConsoleColor.White);
            
            //Agrego utiles a la lista de IAcciones de cartucheraMultiUso
            cartucheraMultiUso.Lista.Add(lapiz1);
            cartucheraMultiUso.Lista.Add(lapiz2);
            cartucheraMultiUso.Lista.Add(boli1);
            cartucheraMultiUso.Lista.Add(boli2);
            cartucheraMultiUso.Lista.Add(boli3);

            //Agrego utiles a lista de lapices y lista de boligrafos de cartucheraSimple
            cartucheraSimple.Lapices.Add(lapiz1);
            cartucheraSimple.Lapices.Add(lapiz2);
            cartucheraSimple.Boligrafos.Add(boli1);
            cartucheraSimple.Boligrafos.Add(boli2);
            cartucheraSimple.Boligrafos.Add(boli3);
            
            //Llamo a RecorrerElementos hasta que alguno retorne false
            bool retornoMultiUso = true;
            bool retornoSimple = true;

            while (retornoMultiUso && retornoSimple)
            {
                retornoMultiUso = cartucheraMultiUso.RecorrerElementos();
                Console.WriteLine(retornoMultiUso);

                if (!retornoMultiUso)
                    break;

                retornoSimple = cartucheraSimple.RecorrerElementos();
                Console.WriteLine(retornoSimple);

                if (!retornoSimple)
                    break;
            }
            
            
            
            
            

                

            


        }
    }
}
