using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_Colecciones_EjC02
{
    public class Competencia
    {
        short cantidadCompetidores;
        short cantidadVueltas;
        List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores): this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Datos de la competencia***");

            sb.AppendLine($"Cantidad maxima de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine();
            sb.AppendLine("///Datos de los competidores///");
            foreach (AutoF1 auto in this.competidores)
            {
                sb.AppendLine(auto.MostrarDatos());
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random random = new Random();

            if(c.competidores.Count >= c.cantidadCompetidores || c == a)
            {
                return false;
            }
            c.competidores.Add(a);
            a.SetEnCompetencia(true);
            a.SetVueltasRestantes(c.cantidadVueltas);
            a.SetCantidadCombustible((short)random.Next(15, 100));
            return true;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                a.SetEnCompetencia(false);
                a.SetVueltasRestantes(0);
                return true;
            }
            return false;
        }


        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 auto in c.competidores)
            {
                if (auto == a)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
