using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_EjC02
{
    public class MotoCross: VehiculoDeCarrera
    {
        short cilindrada;

        public MotoCross(short numero, string escuderia): base(numero, escuderia)
        {

        }

        public MotoCross(short numero, string escuderia, short cilindrada): this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada 
        { 
            get { return this.cilindrada; }
            set 
            { 
                if(value > 0)
                this.cilindrada = value; 
            } 
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            return m1.Numero == m2.Numero && m1.Escuderia == m2.Escuderia && m1.cilindrada == m2.cilindrada;
        }

        public static bool operator !=(MotoCross m1, MotoCross m2)
        {
            return !(m1 == m2);
        }

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
