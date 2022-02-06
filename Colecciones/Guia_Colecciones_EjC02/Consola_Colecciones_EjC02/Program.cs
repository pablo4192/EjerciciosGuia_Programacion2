using System;
using Guia_Colecciones_EjC02;

namespace Consola_Colecciones_EjC02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio competencia
            Competencia competencia = new Competencia(10, 3);

            //Instancio autos
            AutoF1 a1 = new AutoF1(1, "Mercedes");
            AutoF1 a2 = new AutoF1(2, "Bmw");
            AutoF1 a3 = new AutoF1(3, "Ferrari");
            AutoF1 a4 = new AutoF1(4, "Renault");

            //Muestro a1 antes de entrar a competencia
            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine();

            //Agrego autos a la competencia
            if (competencia + a1)
                Console.WriteLine("a1 agregado");
            
            if(!(competencia + a1))
                Console.WriteLine("El auto ya se encuentra en la competencia");

            if (competencia + a2)
                Console.WriteLine("a2 agregado");

            if (competencia + a3)
                Console.WriteLine("a3 agregado");

            if (!(competencia + a4))
                Console.WriteLine("No hay mas lugar!");

            
            //Muestro la competencia y sus competidores
            Console.WriteLine();
            Console.WriteLine(competencia.Mostrar());

            //Quito un auto de la competencia
            if(competencia - a2)
            {
                Console.WriteLine("Se elimino a2 de la competencia");
            }

            //Quito un auto que no se encuentra en la competencia
            if (!(competencia - a4))
            {
                Console.WriteLine("a4 no se pudo eliminar ya que no se encontraba compitiendo!");
            }




        }
    }
}
