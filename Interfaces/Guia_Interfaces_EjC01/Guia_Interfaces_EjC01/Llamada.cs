using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Interfaces_EjC01
{
    public abstract class Llamada
    {
        public enum ETipoLlamada
        {
            Local,
            Provincial,
            Todas
        }



        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public abstract double CostoLlamada { get; }

        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }

        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }


        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;

        }

        /// <summary>
        /// Arma una cadena de texto con la informacion de la llamada.
        /// </summary>
        /// <returns>String con datos de la llamada</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Datos de la llamada***");
            sb.AppendLine($"Duracion: {this.duracion}");
            sb.AppendLine($"Nro Destino: {this.nroDestino}");
            sb.AppendLine($"Nro Origen: {this.nroOrigen}");

            return sb.ToString();
        }

        /// <summary>
        /// Ordena llamadas usando como criterio la duracion de la misma, ordena de forma ascendente.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Numero entero positivo si ordena ascendente, negativo si ordena descendente, 0 si los valores comparados son iguales.</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return (int)(llamada1.duracion - llamada2.duracion);
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen;
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}

