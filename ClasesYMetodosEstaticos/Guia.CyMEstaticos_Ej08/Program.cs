using System;
using System.Text;

namespace Guia.CyMEstaticos_Ej08
{
    internal class Program
    {
        #region Consigna
        /*
        Consigna#
        Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. 
        Tener en cuenta los años bisiestos.

        Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona 
        hasta la fecha actual utilizando el método desarrollado anteriormente.

        Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio. 
        */
        #endregion
        static void Main(string[] args)
        {
            Console.Title = "Clases y Metodos estaticos, Ej 08";

            DateTime fecha;
            string nombre;
            StringBuilder sb = new StringBuilder();
            

            Console.WriteLine("***Calculadora de dias vividos***");
            Console.WriteLine();

            do
            {
                sb.Clear();

                do
                {
                    Console.WriteLine("Por favor ingrese su nombre: ");
                    nombre = Console.ReadLine();

                } while (!CalculadoraDeDias.ValidarNombre(nombre));


                Console.WriteLine("Ingrese Dia de su nacimiento: ");
                sb.Append(Console.ReadLine());
                sb.Append("/");

                Console.WriteLine("Ingrese Mes de su nacimiento: ");
                sb.Append(Console.ReadLine());
                sb.Append("/");

                Console.WriteLine("Ingrese Año de su nacimiento: ");
                sb.Append(Console.ReadLine());

                if (DateTime.TryParse(sb.ToString(), out fecha))
                {
                    Console.WriteLine();
                    Console.WriteLine($"Hola {nombre}, la cantidad de dias que has vivido desde el {fecha} son: {CalculadoraDeDias.ContadorDeDias(fecha)}");
                }
                else
                {
                    Console.WriteLine("Ha ingresado una fecha invalida!");
                }
                Console.WriteLine("Desea ingresar otra fecha? (SI para seguir): ");

            } while (CalculadoraDeDias.ValidarRespuesta(Console.ReadLine()));
            
        }
    }
}
