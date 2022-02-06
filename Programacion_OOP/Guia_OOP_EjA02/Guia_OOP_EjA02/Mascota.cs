using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_OOP_EjA02
{
    public class Mascota
    {
        string especie;
        string nombre;
        DateTime fechaNacimiento;
        string[] vacunas; //En el caso de colecciones usaria List< >.

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            vacunas = new string[10];
        }

        /// <summary>
        /// Agrega vacunas al array de vacunas de la mascota.
        /// </summary>
        /// <param name="vacuna"></param>
        /// <returns>TRue si agrego, False si no habia lugar en el array.</returns>
        public bool IngresarVacunaAlHistorial(string vacuna)
        {
            for(int i = 0; i <vacunas.Length; i++)
            {
                if(vacunas[i] == null)
                {
                    vacunas[i] = vacuna;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la mascota
        /// </summary>
        /// <returns>String con los datos de la mascota.</returns>
        public string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();
            bool flagSinVacunas = true;

            sb.AppendLine($"Especie: {this.especie}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Fecha de nacimiento: {this.fechaNacimiento}");
            sb.AppendLine("***Vacunas***");
            for(int vacuna = 0; vacuna < vacunas.Length; vacuna++)
            {
                if(vacunas[vacuna] != null)
                {
                    sb.Append($"{vacunas[vacuna]}, ");
                    flagSinVacunas = false;
                }
            }

            if(flagSinVacunas)
            {
                sb.AppendLine("La mascota no posee vacunas en su historial");
            }
            Console.WriteLine("---------------------------------------------");

            return sb.ToString();
        }
    }
}
