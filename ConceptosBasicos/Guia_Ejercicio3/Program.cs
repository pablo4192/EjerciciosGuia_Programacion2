using System;
using System.Collections.Generic;

namespace Guia_Ejercicio3
{
    /*
    Consigna#
    Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

    Validar que el dato ingresado por el usuario sea un número.

    Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

    Si ingresa "salir", cerrar la consola.

    Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

    IMPORTANTE
    Utilizar sentencias de iteración, selectivas y el operador módulo (%).
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string seguir = "si";
            List<int> listaPrimos;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
                {
                    Console.WriteLine("Error ingrese un numero (mayor <= 0): ");

                    if (Console.ReadLine() == "salir")
                    {
                        break;
                    }

                }

                listaPrimos = RetornarNumeroPrimos(numero);

                if (listaPrimos[0] == 0)
                {
                    Console.WriteLine($"No existen numeros primos hasta el numero {numero}");
                }
                else
                {
                    Console.WriteLine($"Numeros primos hasta el numero {numero}:");

                    listaPrimos.ForEach((p) => Console.Write($"{p}, "));
                    Console.WriteLine();
                }

                Console.WriteLine("Desea seguir? (Escriba si, para ingresar otro numero): ");
                seguir = Console.ReadLine();
               

            } while (seguir == "si");
            
            
            

        }

        public static List<int> RetornarNumeroPrimos(int numero)
        {
            List<int> listaPrimos = new List<int>();
            bool primo;

            if(numero < 2)
            {
                listaPrimos.Add(0);
            }
            else
            {
                for (int i = 2; i <= numero; i++)
                {
                    primo = true;

                    for(int j = 2; j <= i; j++)
                    {
                        if(i != j && i % j == 0)
                        {
                            primo = false;
                            break;
                           
                        }
                        
                    }
                    if(primo == true)
                    {
                        listaPrimos.Add(i);
                    }
                }
            }

            return listaPrimos;
        }
    }
}
