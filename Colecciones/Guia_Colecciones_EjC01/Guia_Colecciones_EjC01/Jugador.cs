using System;
using System.Text;

namespace Guia_Colecciones_EjC01
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        float promedioGoles;
        int totalGoles;

        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
            this.promedioGoles = 0;
        }

        public Jugador(int dni, string nombre): this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos): this(dni, nombre)
        {
            this.partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }

        public float GetpromedioGoles()
        {
            if(this.partidosJugados == 0)
            {
                return 0;
            }

            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del jugador.");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total goles: {this.totalGoles}");
            sb.AppendLine($"Promedio goles: {GetpromedioGoles()}");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.dni == j2.dni);
        }
    }
}
