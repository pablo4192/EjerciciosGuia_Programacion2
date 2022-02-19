using System;
using System.Text;

namespace Entidades_Interface_Ej02
{
    public abstract class Paquete: IAduana
    {
        string codigoSeguimiento;
        protected decimal costoEnvio;
        string destino;
        string origen;
        double pesoKg;

        protected Paquete(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg)
        {
            this.codigoSeguimiento = codigoSeguimiento;
            this.costoEnvio = costoEnvio;
            this.destino = destino;
            this.origen = origen;
            this.pesoKg = pesoKg;
        }

       
        public abstract bool TienePrioridad { get; }

        

        public string ObtenerInformacionDePaquete()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Paquete");
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo de envio: {this.costoEnvio}");
            sb.AppendLine($"Destino: {this.destino}");
            sb.AppendLine($"Origen: {this.origen}");
            sb.AppendLine($"Peso Kg: {this.pesoKg}");
            if(this.TienePrioridad)
            {
                sb.AppendLine("Tiene Prioridad");
            }
            else
            {
                sb.AppendLine("No tiene Prioridad");
            }

            return sb.ToString();
        }

        //Implementacion IAduana

        public decimal Impuestos
        {
            get { return this.costoEnvio * (decimal)0.35; }
        }

        public virtual decimal AplicarImpuestos()
        {
            return this.costoEnvio + Impuestos;
        }
    }
}
