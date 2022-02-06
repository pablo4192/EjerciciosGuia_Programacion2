using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Colecciones_EjC01
{
    public class Equipo
    {
        short cantidadDeJugadores;
        List<Jugador> jugadores;
        string nombre;

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e.jugadores.Contains(j) || e.jugadores.Count >= e.cantidadDeJugadores )
            {
                return false;
            }
            e.jugadores.Add(j);
            return true;
            
        }
    }
}
