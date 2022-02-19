using System;
using Guia_Archivos_LanzarYAtrapar;
using Io;

namespace Consola_Archivos_LanzarYAtrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception excepcion;
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            try
            {
                OtraClase otraClase = new OtraClase();
            }
            catch (MiExcepcion e)
            {
                //Console.WriteLine(e.Message);

                
                DateTime fecha = DateTime.Now;
                ruta += $"\\{fecha.Year}{fecha.Month}{fecha.Day}-{fecha.Hour}{fecha.Minute}.txt";
                ArchivoDeTexto.Guardar(ruta, e.Message);
                
                excepcion = e.InnerException;

                while (excepcion != null) //Recorro las innerException hasta que sea null y muestro sus mensajes
                {
                    //Console.WriteLine(excepcion.Message);
                    ArchivoDeTexto.Guardar(ruta, excepcion.Message);
                    excepcion = excepcion.InnerException;
                }

            }

            //Muesro los errores desde el archivo por Consola
            Console.WriteLine(ArchivoDeTexto.Leer(ruta));
        }
    }
}
