using System;

namespace Guia_Ejercicio1
{
    public class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = ("Ejercicio 01");

            int numero1 = PedirNumero();
            int numero2 = PedirNumero();
            int numero3 = PedirNumero();
            int numero4 = PedirNumero();
            int numero5 = PedirNumero();

            Console.WriteLine( "Numero mayor: " + RetornarMayor(numero1, numero2, numero3, numero4, numero5));
            Console.WriteLine( "Numero menor: " + RetornarMenor(numero1, numero2, numero3, numero4, numero5));
            float promedio = CalcularPromedio(numero1, numero2, numero3, numero4, numero5);

            Console.WriteLine("Promedio: " + promedio.ToString("#,###.00"));

        }

        private static int PedirNumero()
        {
            int numero;

            Console.WriteLine("Inserte un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }

            return 0;
        }

        private static float CalcularPromedio(int n1, int n2, int n3, int n4, int n5)
        {
            return (float) (n1 + n2 + n3 + n4 + n5) / 5;
        }

        private static int RetornarMayor(int n1, int n2, int n3, int n4, int n5)
        {
            int[] arrayInt = { n1, n2, n3, n4, n5 };

            int mayor = arrayInt[0];

            for(int i = 1; i < arrayInt.Length; i++)
            {
                if(arrayInt[i] > mayor)
                {
                    mayor = arrayInt[i];
                    
                }
            }

            return mayor;

        }

        private static int RetornarMenor(int n1, int n2, int n3, int n4, int n5)
        {
            int[] arrayInt = { n1, n2, n3, n4, n5 };

            int menor = arrayInt[0];

            for (int i = 1; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] < menor)
                {
                    menor = arrayInt[i];

                }
            }

            return menor;

        }

    }
}
