using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Encapsulamiento_EjC01
{
    public class Jugador
    {
        int dni;
        string nombre;
        int partidosJugados;
        
        int totalGoles;

        private Jugador()
        {
            this.totalGoles = 0;
            this.partidosJugados = 0;
            
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
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

        public string Nombre 
        { 
            get { return this.nombre; }
            set 
            {
                if(!string.IsNullOrEmpty(value))
                this.nombre = value; 
            } 
        }

        public int Dni 
        { 
            get { return this.dni; }
            set
            {
                if(value > 0)
                {
                    this.dni = value;
                }
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del jugador.");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Partidos jugados: {this.partidosJugados}");
            sb.AppendLine($"Total goles: {this.totalGoles}");
            sb.AppendLine($"Promedio goles: {this.PromedioGoles}");

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
