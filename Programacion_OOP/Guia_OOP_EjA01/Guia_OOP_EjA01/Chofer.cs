using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_OOP_EjA01
{
    public class Chofer
    {
        string nombre;
        int[] arrayKm;

        public Chofer(string nombre)
        {
            this.nombre = nombre;
            arrayKm = new int[7];
        }

        public int[] GetArrayKm()
        {
            return this.arrayKm;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        /// <summary>
        /// Pide el ingreso por consola de los km realizados por los choferes.
        /// </summary>
        public void PedirKmPorConsola()
        {
            int km;

            Console.WriteLine($"Por favor ingrese los kilometros recorridos por el chofer {this.nombre}.");

            for(int i = 0; i < arrayKm.Length; i++)
            {
                Console.WriteLine($"Dia {i + 1}: ");
                while(!int.TryParse(Console.ReadLine(), out km) || km < 0)
                {
                    Console.WriteLine("Error, ingrese un numero valido de km: ");
                }
                CargarKm(i, km);
            }

            Console.WriteLine("Kilometros realizados en la semana cargados exitosamente!");
            Console.WriteLine();
        }

        /// <summary>
        /// Carga los km en el array de km del chofer
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="km"></param>
        private void CargarKm(int indice, int km)
        {
            this.arrayKm[indice] = km;
        }

        /// <summary>
        /// Arma una cadena de texto con los datos del chofer.
        /// </summary>
        /// <returns>String con los datos del chofer.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Datos del chofer {this.nombre}.");
            sb.AppendLine("Km recorridos en la semana: ");
            sb.AppendLine($"Dia 1: {arrayKm[0]} km");
            sb.AppendLine($"Dia 2: {arrayKm[1]} km");
            sb.AppendLine($"Dia 3: {arrayKm[2]} km");
            sb.AppendLine($"Dia 4: {arrayKm[3]} km");
            sb.AppendLine($"Dia 5: {arrayKm[4]} km");
            sb.AppendLine($"Dia 6: {arrayKm[5]} km");
            sb.AppendLine($"Dia 7: {arrayKm[6]} km");

            return sb.ToString();
        }
    }
}
