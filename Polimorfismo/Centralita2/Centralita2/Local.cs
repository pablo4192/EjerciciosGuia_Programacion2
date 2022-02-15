using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita2
{
    public class Local: Llamada
    {
        protected float costo;

        public override double CostoLlamada
        {
            get { return CalcularCosto(); }
        }


        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Calcula el costo de la llamada a partir de la duracion y el costo del minuto.
        /// </summary>
        /// <returns>Costo de la llamada</returns>
        private float CalcularCosto()
        {
            return base.duracion * this.costo;
        }

        /// <summary>
        /// Arma una cadena de texto con la informacion de la llamada.
        /// </summary>
        /// <returns>String con los datos de la llamada</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo: {this.costo}");
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Local);
        }

        //Para quitar el warning
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
