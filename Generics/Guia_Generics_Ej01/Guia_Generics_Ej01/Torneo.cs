using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Generics_Ej01
{
    public class Torneo<T> where T: Equipo
    {
        List<T> equipos;
        string nombre;

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre): this()
        {
            this.nombre = nombre;
        }


        public string JugarPartido 
        { 
            get
            {
                Random rand = new Random();

                if(this.equipos.Count > 1)
                {
                    Equipo e1 = this.equipos[rand.Next(0, this.equipos.Count)];
                    Equipo e2 = this.equipos[rand.Next(0, this.equipos.Count)];
                    
                    while(e1 == e2)
                    {
                        e1 = this.equipos[rand.Next(0, this.equipos.Count)];
                        e2 = this.equipos[rand.Next(0, this.equipos.Count)];
                    }
                    
                    
                    return this.CalcularPartido(e1, e2); 
                }
                else
                {
                    return "No hay suficientes equipos para Jugar un partido.";
                }
            }
        }

        public static bool operator ==(Torneo<T> torneo, Equipo equipo)
        {
            foreach (Equipo e in torneo.equipos)
            {
                if(e == equipo)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Torneo<T> torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static bool operator +(Torneo<T> torneo, Equipo equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add((T)equipo);
                return true;
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Datos del Torneo***");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"--- Equipos ---");

            foreach (Equipo e in this.equipos)
            {
                sb.AppendLine(e.Ficha());
            }
            sb.AppendLine("-----------------------");

            return sb.ToString();
        }

        private string CalcularPartido<T>(T equipo1, T equipo2) where T: Equipo
        {
            Random rand = new Random();

            return $"[{equipo1.Nombre}]{rand.Next(0, 6)} - {rand.Next(0, 6)}[{equipo2.Nombre}]";
        }

        

    }
}
