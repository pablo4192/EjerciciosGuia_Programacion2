using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita_Herencia_EjC02
{
    public class Centralita
    {
        List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
            
        }

        public float GananciaporLocal 
        {
            
            get
            {
                return CalcularGanancia(Llamada.ETipoLlamada.Local);
            }

            
        }

        public float GananciaPorProvincia 
        { 
            get
            {
                return CalcularGanancia(Llamada.ETipoLlamada.Provincial);
            }
        }

        public float GananciaPorTotal 
        {
            get
            {
                return CalcularGanancia(Llamada.ETipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        /// <summary>
        /// Calcula la ganancia segun el tipo de llamada
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns>Ganancia calculada</returns>
        private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada call in this.listaLlamadas)
            {
                if(Llamada.ETipoLlamada.Local == tipo)
                {
                    if(call.GetType() == typeof(Local))
                    ganancia += ((Local)call).CostoLlamada;
                }
                else if(Llamada.ETipoLlamada.Provincial == tipo)
                {
                    if (call.GetType() == typeof(Provincial))
                        ganancia += ((Provincial)call).CostoLlamada;
                }
                else
                {
                    if(call.GetType() == typeof(Local))
                    ganancia += ((Local)call).CostoLlamada;
                    else if(call.GetType() == typeof(Provincial))
                        ganancia += ((Provincial)call).CostoLlamada;
                }

            }
            return ganancia;



        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la centralita
        /// </summary>
        /// <returns>String con informacion de la central telefonica</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia por llamadas Locales: {this.GananciaporLocal}");
            sb.AppendLine($"Ganancia por llamadas Provinciales: {this.GananciaPorProvincia}");
            sb.AppendLine($"Ganancias Totales: {this.GananciaPorTotal}");
            sb.AppendLine();
            sb.AppendLine("***Listado de llamadas***");
            sb.AppendLine();
            foreach (Llamada call in this.listaLlamadas)
            {
                if (call.GetType() == typeof(Local))
                    sb.AppendLine(((Local)call).Mostrar());
                else if(call.GetType() == typeof(Provincial))
                    sb.AppendLine(((Provincial)call).Mostrar());
            }

            sb.AppendLine("----------------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Ordena la lista de llamadas de la centralita por duracion de forma ascendente
        /// </summary>
        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }




    }
}
