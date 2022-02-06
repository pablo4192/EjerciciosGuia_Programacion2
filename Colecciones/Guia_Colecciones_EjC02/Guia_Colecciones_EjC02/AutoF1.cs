using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Colecciones_EjC02
{
    public class AutoF1
    {
        short cantidadCombustible;
        bool enCompetencia;
        string escuderia;
        short numero;
        short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public bool SetCantidadCombustible(short value)
        {
            if(value > 0)
            {
                this.cantidadCombustible = value;
                return true;
            }
            return false;
            
        }

        public void SetEnCompetencia(bool value)
        {
            this.enCompetencia = value;
        }

        public bool SetVueltasRestantes(short value)
        {
            if(value > 0)
            {
                this.vueltasRestantes = value;
                return true;
            }
            return false;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del auto");
            sb.AppendLine($"Numero: {this.numero}");
            sb.AppendLine($"Escuderia: {this.escuderia}");
            sb.AppendLine($"Cantidad combustible: {this.cantidadCombustible} litros");
            if(this.enCompetencia)
            {
                sb.AppendLine("El auto se encuentra en competencia.");
                sb.AppendLine($"Vueltas restantes: {this.vueltasRestantes}");
            }
            else
            {
                sb.AppendLine("El auto no se encuentra compitiendo en estos momentos");
            }
            return sb.ToString();
        }
    }
}
