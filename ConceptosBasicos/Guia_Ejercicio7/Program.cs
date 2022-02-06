using System;

namespace Guia_Ejercicio7
{
    internal class Program
    {
        /*
        Consigna#
        Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) 
        y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.

        Se pide calcular el importe a cobrar teniendo en cuenta que el total 
        (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
        hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas 
        operaciones restarle el 13% en concepto de descuentos.

        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto 
        y el total a cobrar neto de todos los empleados ingresados.

        IMPORTANTE
        Utilizar sentencias de iteración y selectivas.

        No es necesario ni se deben utilizar vectores/arrays. 
         
         */

        static void Main(string[] args)
        {
            Facturacion.IngresarDatos();
            Facturacion.MostrarRecibos();
        }
    }
}
