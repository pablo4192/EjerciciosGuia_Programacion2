using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Herencia_EjC02
{
    public class Local: Llamada
    {
        protected float costo;

        public float CostoLlamada 
        {
            get { return CalcularCosto(); } 
        }

        
        public Local(Llamada llamada, float costo): base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo ) : this(new Llamada(duracion, destino, origen), costo)
        {
            
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
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Datos de la llamada***");
            sb.AppendLine($"Duracion: {base.duracion}");
            sb.AppendLine($"Nro Destino: {base.nroDestino}");
            sb.AppendLine($"Nro Origen: {base.nroOrigen}");
            sb.AppendLine($"Costo: {this.costo}");
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }
    }
}
