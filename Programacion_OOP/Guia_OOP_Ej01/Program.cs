using System;
using Entidades;

namespace Guia_OOP_Ej01
{
    #region Consigna
    /*
    Consigna#
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

    Deberá tener los atributos:

    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo. 
    */
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Pablito", 50000);

            Console.WriteLine("Monto: " + cuenta1.CantidadGet());
            cuenta1.Ingresar(5000);
            Console.WriteLine("Monto: " + cuenta1.CantidadGet());

            cuenta1.Retirar(25000);
            Console.WriteLine("Monto: " + cuenta1.CantidadGet());

            Console.WriteLine(cuenta1.Mostrar());

            if(!cuenta1.Retirar(-9000))
            {
                Console.WriteLine("no se pueden retirar montos negativos");
            }


        }
    }
}
