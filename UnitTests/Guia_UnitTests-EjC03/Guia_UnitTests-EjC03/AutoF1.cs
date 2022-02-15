using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_UnitTests_EjC03
{
    public class AutoF1 : VehiculoDeCarrera
    {
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza) : this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        /// <summary>
        /// Verifica la igualdad entre dos AutosF1
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns>True si son iguales, False si son distintos.</returns>
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.caballosDeFuerza == a2.caballosDeFuerza;
        }

        /// <summary>
        /// Verifica la desigualdad entre dos AutosF1
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns>True si son distintos, False si son iguales.</returns>
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set
            {
                if (value > 0)
                    this.caballosDeFuerza = value;
            }
        }

        /// <summary>
        /// Arma una cadena de texto con los datos del AutoF1.
        /// </summary>
        /// <returns>String con información del auto.</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del auto");
            sb.AppendLine($"Numero: {base.Numero}");
            sb.AppendLine($"Escuderia: {base.Escuderia}");
            sb.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            sb.AppendLine($"Cantidad combustible: {base.CantidadCombustible} litros");
            if (base.EnCompetencia)
            {
                sb.AppendLine("El auto se encuentra en competencia.");
                sb.AppendLine($"Vueltas restantes: {base.VueltasRestantes}");
            }
            else
            {
                sb.AppendLine("El auto no se encuentra compitiendo en estos momentos");
            }
            return sb.ToString();
        }
    }
}
