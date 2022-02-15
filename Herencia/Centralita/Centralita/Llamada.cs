using System;
using System.Text;

namespace Centralita_Herencia_EjC02
{
    public class Llamada
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
        public string Mostrar()
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
             
    }
}
