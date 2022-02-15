using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Excepciones_EjC01
{
    public class Provincial: Llamada
    {
        public enum EFranja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        EFranja franja;

        public Provincial(EFranja miFranja, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franja = miFranja;
        }

        public Provincial(string origen, EFranja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franja = miFranja;
        }


        public override double CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        /// <summary>
        /// Calcula el costo de la llamada segun su duracion y el costo del minuto segun franja horaria
        /// </summary>
        /// <returns>Costo de la llamada</returns>
        private float CalcularCosto()
        {
            if (this.franja == EFranja.Franja_1)
                return base.duracion * (float)0.99;
            else if (this.franja == EFranja.Franja_2)
                return base.duracion * (float)1.25;
            else
                return base.duracion * (float)0.66;

        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la llamada
        /// </summary>
        /// <returns>String con datos de la llamada</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Franja: {this.franja}");
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");

            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == typeof(Provincial);
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
