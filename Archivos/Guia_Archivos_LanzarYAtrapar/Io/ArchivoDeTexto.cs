using System;
using System.IO;

namespace Io
{
    public static class ArchivoDeTexto
    {
        /// <summary>
        /// Guarda en un archivo de texto la informacion pasada por parametro
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="info"></param>
        public static void Guardar(string ruta, string info)
        {
            try
            {
                if (File.Exists(ruta))
                {
                    
                    using (StreamWriter escritor = new StreamWriter(ruta, true))
                    {
                        escritor.WriteLine(info);
                    }
                }
                else
                {
                    using (StreamWriter escritor = new StreamWriter(ruta))
                    {
                        escritor.Write(info);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Excepcion ocurrida al guardar: {ex.Message}");
            }

            
        }

        /// <summary>
        /// Lee el archivo de la ruta pasada por parametro
        /// </summary>
        /// <param name="ruta"></param>
        /// <returns>Contenido del archivo leido en cadena de texto, si el archivo no existe lanza FileNotFoundException</returns>
        public static string Leer(string ruta)
        {
            try
            {
                if (!File.Exists(ruta))
                {
                    throw new FileNotFoundException();
                }
                else
                {
                    using (StreamReader lector = new StreamReader(ruta))
                    {
                        return lector.ReadToEnd();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Excepcion ocurrida al guardar: {ex.Message}");
                return string.Empty;
            }

            

        }
    }
}
