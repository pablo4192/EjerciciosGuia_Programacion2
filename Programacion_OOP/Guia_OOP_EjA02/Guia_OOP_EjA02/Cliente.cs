using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_OOP_EjA02
{
    // De los clientes le interesa conocer el domicilio, el nombre y apellido y un teléfono. A un cliente se le pueden asociar una o más mascotas.
    public class Cliente
    {
        string domicilio;
        string nombre;
        string apellido;
        string telefono;
        Mascota[] mascotas; //En el caso de colecciones usaria una List< >.

        public Cliente(string domicilio, string nombre, string apellido, string telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            mascotas = new Mascota[10];
        }

        /// <summary>
        /// Asocia una mascota a un cliente en particular.
        /// </summary>
        /// <param name="mascota"></param>
        /// <returns>True si asocio, False si no hay lugar en el array</returns>
        public bool AsociarMascotaACliente(Mascota mascota)
        {
            for(int i = 0; i < mascotas.Length; i++)
            {
                if(mascotas[i] == null)
                {
                    mascotas[i] = mascota;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Arma una cadena de texto con los datos del cliente.
        /// </summary>
        /// <returns>String con datos del cliente.</returns>
        public string MostrarCliente()
        {
            StringBuilder sb = new StringBuilder();
            int contadorMascotas = 0;

            sb.AppendLine($"Domicilio: {this.domicilio}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Telefono: {this.telefono}");
            sb.AppendLine("***Mascotas del cliente***");

            for(int mascota = 0; mascota < mascotas.Length; mascota++)
            {
                if(mascotas[mascota] != null)
                {
                    contadorMascotas++;
                    sb.AppendLine($"Mascota {mascota + 1}:");
                    sb.AppendLine(mascotas[mascota].MostrarMascota());
                }
            }


            return sb.ToString();
        }
    }
}
