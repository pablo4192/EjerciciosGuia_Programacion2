using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_EjC02
{
    public class AutoF1: VehiculoDeCarrera
    {
        
        short caballosDeFuerza;

        public AutoF1(short numero, string escuderia): base(numero, escuderia)
        {
            
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza): this(numero, escuderia)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia && a1.caballosDeFuerza == a2.caballosDeFuerza;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short CaballosDeFuerza 
        { 
            get { return this.caballosDeFuerza; } 
            set 
            {
                if (value > 0)
                    this.caballosDeFuerza = value;
            }
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del auto");
            sb.AppendLine($"Numero: {base.Numero}");
            sb.AppendLine($"Escuderia: {base.Escuderia}");
            sb.AppendLine($"Caballos de fuerza: {this.caballosDeFuerza}");
            sb.AppendLine($"Cantidad combustible: {base.CantidadCombustible} litros");
            if (base.EnCompetencia)
            {
                sb.AppendLine("El auto se encuentra en competencia.");
                sb.AppendLine($"Vueltas restantes: {base.VueltasRestantes}");
            }
            else
            {
                sb.AppendLine("El auto no se encuentra compitiendo en estos momentos");
            }
            return sb.ToString();
        }
    }
}
