using System;
using Entidades3;

namespace Guia_OOP_Ej03
{
    #region Consigna
    /*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

    Diagrama de clases...

    La clase Estudiante:

    Tendrá un constructor estático que inicializará el atributo estático random.
    Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
    El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
    El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
    El método privado CalcularPromedio retornará el promedio de las dos notas.
    El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos 
    siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
    El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
    Nombre, apellido y legajo.
    Nota del primer y segundo parcial.
    Promedio.
    Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".
    
    Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
    Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
    Mostrar los datos de todos los alumnos.
    IMPORTANTE
    Para darle un valor aleatorio a la nota final utilice el método de instancia Next de la clase Random. 

    */

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante e1 = new Estudiante("Mely", "Loscalzo", "1234");
            Estudiante e2 = new Estudiante("Pabli", "Estanguet", "1235");
            Estudiante e3 = new Estudiante("Nachi", "Loscalzo", "1236");

            e1.SetNotaPrimerParcial(6);
            e1.SetNotaSegundoParcial(8);
            e2.SetNotaPrimerParcial(3);
            e2.SetNotaSegundoParcial(9);
            e3.SetNotaPrimerParcial(4);
            e3.SetNotaSegundoParcial(7);

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine();
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine();
            Console.WriteLine(e3.Mostrar());
        }
    }
}
