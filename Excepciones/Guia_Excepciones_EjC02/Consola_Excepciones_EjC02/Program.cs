using System;
using Guia_Excepciones_EjC02;

namespace Consola_Excepciones_EjC02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instancio competencia
            Competencia competenciaAutos = new Competencia(10, 3, Competencia.TipoCompetencia.F1);
            Competencia competenciaMotos = new Competencia(8, 2, Competencia.TipoCompetencia.MotoCross);

            //Instancio autos
            AutoF1 a1 = new AutoF1(1, "Mercedes");
            AutoF1 a2 = new AutoF1(2, "Bmw");
            AutoF1 a3 = new AutoF1(3, "Ferrari");
            AutoF1 a4 = new AutoF1(4, "Renault");

            //Instancio Motos
            MotoCross m1 = new MotoCross(15, "Harley");
            MotoCross m2 = new MotoCross(22, "Zanella");
            MotoCross m3 = new MotoCross(33, "Gilera");

            //Muestro a1 antes de entrar a competencia
            Console.WriteLine(a1.MostrarDatos());
            Console.WriteLine();

            try
            {
                //Agrego autos a la competencia
                if (competenciaAutos + a1)
                    Console.WriteLine("a1 agregado");

                if (!(competenciaAutos + a1))
                    Console.WriteLine("El auto ya se encuentra en la competencia");

                if (competenciaAutos + a2)
                    Console.WriteLine("a2 agregado");

                if (competenciaAutos + a3)
                    Console.WriteLine("a3 agregado");

                if (!(competenciaAutos + a4))
                    Console.WriteLine("No hay mas lugar!");


                //Muestro la competencia y sus competidores
                Console.WriteLine();
                Console.WriteLine(competenciaAutos.Mostrar());

                //Quito un auto de la competencia
                if (competenciaAutos - a2)
                {
                    Console.WriteLine("Se elimino a2 de la competencia");
                }

                //Quito un auto que no se encuentra en la competencia
                if (!(competenciaAutos - a4))
                {
                    Console.WriteLine("a4 no se pudo eliminar ya que no se encontraba compitiendo!");
                }

                //Prueba competencia Motos
                //Muestro m2 antes de la competencia
                Console.WriteLine(m2.MostrarDatos());
                Console.WriteLine();



                if (competenciaMotos + m1)
                {
                    Console.WriteLine("Se agrego m1 a competenciaMotos");
                }

                if (!(competenciaMotos - m2))
                {
                    Console.WriteLine("No se puede quitar m2 de la competencia ya que no se encuentra compitiendo");
                }

                if (competenciaMotos + m2)
                {
                    Console.WriteLine("Se agrego m2 a la competenciaMotos");
                }

                if (!(competenciaAutos + m1))
                {
                    Console.WriteLine("No se pudo agregar m1 a la competencia, ya que m1 es una moto y la competencia es F1");
                }

                if (!(competenciaMotos + a4))
                {
                    Console.WriteLine("No se pudo agregar a4 a la competenciaMotos ya que a4 es un auto");
                }
            }
            catch(CompetenciaNoDisponibleException ex)
            {
                Console.WriteLine();
                Console.WriteLine("**Excepciones**");
                Console.WriteLine(ex.ToString());
            }

            

            //Muestro la competencia de motos
            Console.WriteLine();
            Console.WriteLine(competenciaMotos.Mostrar());
        }
    }
}
