using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Excepciones_EjC02
{
    public class MotoCross: VehiculoDeCarrera
    {
        short cilindrada;

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set
            {
                if (value > 0)
                    this.cilindrada = value;
            }
        }

        /// <summary>
        /// Verifica si las motos pasadas por parametro son iguales
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>True si son iguales, False si son distintas.</returns>
        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia && m1.cilindrada == m2.cilindrada;
        }

        /// <summary>
        /// Verifica si las motos pasadas por parametro son distintas.
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns>True si son distintas, False si son iguales.</returns>
        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la Moto
        /// </summary>
        /// <returns>String con información de la Moto</returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la Moto");
            sb.AppendLine($"Cilindrada: {this.cilindrada}");
            sb.AppendLine($"Numero: {base.Numero}");
            sb.AppendLine($"Escuderia: {base.Escuderia}");
            sb.AppendLine($"Cantidad combustible: {base.CantidadCombustible} litros");
            if (base.EnCompetencia)
            {
                sb.AppendLine("La Moto se encuentra en competencia.");
                sb.AppendLine($"Vueltas restantes: {base.VueltasRestantes}");
            }
            else
            {
                sb.AppendLine("La Moto no se encuentra compitiendo en estos momentos");
            }
            return sb.ToString();
        }
    }
}
