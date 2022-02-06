using System;
using Guia_OOP_EjA02;

namespace Consola_OOP_EjA02
{
    #region Consigna
    /*
    Requerimiento#
    El dueño de una veterinaria nos contrató para que desarrollemos una aplicación donde pueda consultar la lista de clientes y sus mascotas.

    De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.

    De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. Los primeros tres datos son obligatorios para dar de alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas. De las vacunas sólo interesa conocer el nombre.

    Consigna#
    Crear una aplicación de consola.
    Modelar y declarar las clases necesarias para resolver la necesidad del cliente. Hacerlo en un proyecto de biblioteca de clases.
    Las clases deberán tener los métodos necesarios, incluyendo uno que devuelva toda la información del objeto en formato string.
    Instanciar los siguientes objetos:
    Un cliente con un perro sin vacunar.
    Un cliente con un gato con la vacuna "Triple Felina".
    Un cliente con un gato sin vacunas y un perro con la vacuna contra la rabia.
    Mostrar por consola todos los datos de los clientes instanciados y sus mascotas. 
    */
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente("Evita 386", "Edgardo", "Bertuti", "1550603020");
            Cliente cliente2 = new Cliente("Alvear 4192", "Jacinta", "Cachurra", "1550965847");
            Cliente cliente3 = new Cliente("Del penacho 123", "Raimundo", "Cacholo", "1550871425");

            Mascota mascota1 = new Mascota("Siames", "Tomy", new DateTime(2020, 05,01));
            Mascota mascota2 = new Mascota("TriColor", "Wayra", new DateTime(2019, 01, 20));
            Mascota mascota3 = new Mascota("Salchica", "Pipistrelo", new DateTime(2015, 12, 15));
            Mascota mascota4 = new Mascota("BulLDog", "Sanson", new DateTime(2016, 05, 13));

            mascota2.IngresarVacunaAlHistorial("Triple felina");
            mascota2.IngresarVacunaAlHistorial("Moderna");
            mascota3.IngresarVacunaAlHistorial("Sputnik");
            mascota3.IngresarVacunaAlHistorial("Contra la Rabia");
            
            cliente2.AsociarMascotaACliente(mascota4);
            cliente1.AsociarMascotaACliente(mascota2);
            cliente3.AsociarMascotaACliente(mascota1);
            cliente3.AsociarMascotaACliente(mascota3);

            Console.WriteLine(cliente1.MostrarCliente());
            Console.WriteLine(cliente2.MostrarCliente());
            Console.WriteLine(cliente3.MostrarCliente());

            
        }
    }
}
