using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Ejercicio7
{
    public static class Facturacion
    {
        public static List<Empleado> listaEmpleados;

        static Facturacion()
        {
            listaEmpleados = new List<Empleado>();
        }

        public static void IngresarDatos()
        {
            string seguir = "si";
            float valorHora;
            string nombre;
            int antiguedad;
            float horasTrabajadas;

            do
            {
                Empleado aux = new Empleado();

                Console.WriteLine("Ingrese valor hora: ");
                while(!float.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("Error, Ingrese valor hora: ");
                }
                aux.ValorHora = valorHora;

                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                while (string.IsNullOrEmpty(nombre) || !VerificarNombre(nombre))
                {
                    Console.WriteLine("Error, Ingrese nombre: ");
                    nombre = Console.ReadLine();
                }
                aux.Nombre = nombre;
                
                Console.WriteLine("Ingrese antiguedad: ");
                while(!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("Error, Ingrese antiguedad: ");
                }
                aux.Antiguedad = antiguedad;

                Console.WriteLine("Ingrese Cantidad horas trabajadas en el mes: ");
                while(!float.TryParse(Console.ReadLine(), out horasTrabajadas))
                {
                    Console.WriteLine("Error, Ingrese Cantidad horas trabajadas en el mes: ");
                }
                aux.HorasTrabajadas = horasTrabajadas;

                CalcularImporteACobrar(aux);
                listaEmpleados.Add(aux);

                Console.WriteLine("Desea ingresar mas datos? ('si' para seguir ingresando): ");
                seguir = Console.ReadLine();


            } while(seguir.ToLower() == "si");
        
        }

        public static void CalcularImporteACobrar(Empleado empleado)
        {
            double totalBruto = (empleado.ValorHora * empleado.HorasTrabajadas) + (empleado.Antiguedad * 150);
            double descuentos = totalBruto * 0.13;

            empleado.TotalBruto = totalBruto;
            empleado.TotalNeto = totalBruto - descuentos;
        }

        public static void MostrarRecibos()
        {
            int numeroRecibo = 0;

            Console.WriteLine();
            Console.WriteLine("***Liquidación Sueldos***");

            listaEmpleados.ForEach((e) =>
            {
                numeroRecibo++;

                Console.WriteLine($"Recibo n°{numeroRecibo}");
                Console.WriteLine("Nombre: " + e.Nombre);
                Console.WriteLine("Valor hora: " +e.ValorHora);
                Console.WriteLine("Antiguedad: " + e.Antiguedad);
                Console.WriteLine("Horas trabajadas: " + e.HorasTrabajadas);
                Console.WriteLine($"Total a cobrar Bruto: {e.TotalBruto}");
                Console.WriteLine($"Total a cobrar Neto: {e.TotalNeto}");
                Console.WriteLine();
            });
        }

        private static bool VerificarNombre(string nombre)
        {
            for(int i = 0; i<nombre.Length; i++)
            {
                if(!char.IsLetter(nombre[i]))
                {
                    return false;
                }
            }

            return true;
        }


    }
}


