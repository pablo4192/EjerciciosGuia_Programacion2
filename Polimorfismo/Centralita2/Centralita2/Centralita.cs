using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita2
{
    public class Centralita
    {
        List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;

        }

        public double GananciaporLocal
        {

            get
            {
                return CalcularGanancia(Llamada.ETipoLlamada.Local);
            }


        }

        public double GananciaPorProvincia
        {
            get
            {
                return CalcularGanancia(Llamada.ETipoLlamada.Provincial);
            }
        }

        public double GananciaPorTotal
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
        private double CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            double ganancia = 0;

            foreach (Llamada call in this.listaLlamadas)
            {
                if (Llamada.ETipoLlamada.Local == tipo)
                {
                    if (call.GetType() == typeof(Local)) 
                        ganancia += call.CostoLlamada; //Con polimorfismo reconoce si es local o provincial y usa la implementacion de la clase derivada
                }
                else if (Llamada.ETipoLlamada.Provincial == tipo)
                {
                    if (call.GetType() == typeof(Provincial))
                        ganancia += call.CostoLlamada;
                }
                else
                {
                    if (call.GetType() == typeof(Local))
                        ganancia += call.CostoLlamada;
                    else if (call.GetType() == typeof(Provincial))
                        ganancia += call.CostoLlamada;
                }
            }
            return ganancia;



        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la centralita
        /// </summary>
        /// <returns>String con informacion de la central telefonica</returns>
        private string Mostrar()
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
                sb.AppendLine(call.ToString());
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

        public override string ToString()
        {
            return Mostrar();
        }

        private void AgregarLlamada(Llamada llamada)
        {
            this.listaLlamadas.Add(llamada);
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            foreach (Llamada call in c.listaLlamadas)
            {
                if (call == l)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if(c != l)
            {
                c.AgregarLlamada(l);
            }
            return c;
        }
    }
}
