using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_EjC01
{
    public class Jugador: Persona
    {
       
        int partidosJugados;
        int totalGoles;

        public Jugador(int dni, string nombre): base(dni, nombre)
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;

        }
       
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get { return this.partidosJugados; }
        }

        public float PromedioGoles
        {
            get
            {
                if (this.partidosJugados == 0)
                {
                    return 0;
                }

                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        public int TotalGoles { get { return this.totalGoles; } }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del jugador.");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Dni: {this.Dni}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total goles: {this.totalGoles}");
            sb.AppendLine($"Promedio goles: {this.PromedioGoles}");

            return sb.ToString();
        } //Usar Polimorfismo

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
