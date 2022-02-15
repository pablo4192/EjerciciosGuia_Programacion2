using System;

namespace Guia_Excepciones_Ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception excepcion;

            try
            {
                OtraClase otraClase = new OtraClase();
            }
            catch(MiExcepcion e)
            {
                Console.WriteLine(e.Message);
                excepcion = e.InnerException;

                while(excepcion != null) //Recorro las innerException hasta que sea null y muestro sus mensajes
                {
                    Console.WriteLine(excepcion.Message);
                    excepcion = excepcion.InnerException;
                }

            }



        }
    }
}
