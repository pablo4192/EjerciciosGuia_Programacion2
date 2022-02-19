using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Generics_EjC01
{
    public class Competencia<T> where T: VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }

        short cantidadCompetidores;
        short cantidadVueltas;
        List<T> competidores;
        TipoCompetencia tipo;

        public List<T> Competidores { get { return this.competidores; } }

        private Competencia()
        {
            this.competidores = new List<T>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        /// <summary>
        /// Arma una cadena de texto con los datos de la competencia
        /// </summary>
        /// <returns>String con información de la competencia</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("***Datos de la competencia***");

            sb.AppendLine($"Cantidad maxima de competidores: {this.cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas}");
            sb.AppendLine();
            sb.AppendLine("///Datos de los competidores///");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                //Agregar Polimorfismo para quitar esto.
                if(vehiculo.GetType() == typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else if (vehiculo.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                }


            }
            return sb.ToString();
        }

        /// <summary>
        /// Agrega un vehiculo a la competencia pasada por parametro
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns>True si lo pudo agregar, False si no lo pudo agregar</returns>
        /// <exception cref="CompetenciaNoDisponibleException"></exception>
        public static bool operator +(Competencia<T> c, VehiculoDeCarrera v)
        {
            Random random = new Random();

            try
            {
                if (c.competidores.Count >= c.cantidadCompetidores || c == v ||
                (c.tipo == TipoCompetencia.F1 && v.GetType() == typeof(MotoCross)) ||
                (c.tipo == TipoCompetencia.MotoCross && v.GetType() == typeof(AutoF1)))
                {
                    return false;
                }
            }
            catch (CompetenciaNoDisponibleException ex)
            {
                throw new CompetenciaNoDisponibleException("Competencia incorrecta", c.ToString(), "Operador sobrecargado +", ex);
            }


            c.competidores.Add((T)v);
            v.EnCompetencia = true;
            v.VueltasRestantes = c.cantidadVueltas;
            v.CantidadCombustible = (short)random.Next(15, 100);
            return true;
        }

        /// <summary>
        /// Quita un vehiculo de la competencia
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns>True si removio el vehiculo, False si el vehiculo pasado por parametro no pertenece a la competencia</returns>
        public static bool operator -(Competencia<T> c, VehiculoDeCarrera v)
        {
            if (c == v)
            {
                c.competidores.Remove((T)v);
                v.EnCompetencia = false;
                v.VueltasRestantes = 0;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si el vehiculo se encuentra en la competencia pasada por parametro
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns>True si se encuentra en la competencia, False si no esta.</returns>
        /// <exception cref="CompetenciaNoDisponibleException"></exception>
        public static bool operator ==(Competencia<T> c, VehiculoDeCarrera v)
        {

            if (c.tipo == TipoCompetencia.F1 && v.GetType() == typeof(AutoF1))
            {
                foreach (T auto in c.competidores)
                {
                    if (auto == (T)v)
                        return true;

                }

            }
            else if (c.tipo == TipoCompetencia.MotoCross && v.GetType() == typeof(MotoCross))
            {
                foreach (T moto in c.competidores)
                {
                    if (moto == (T)v)
                        return true;

                }

            }
            else
            {
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", c.ToString(), "Operador sobrecargado ==");
            }


            return false;
        }

        /// <summary>
        /// Verifica si el vehiculo no se encuentra en la competencia pasada por parametro.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="v"></param>
        /// <returns>True si el vehiculo no esta en la competencia, False si esta en la competencia.</returns>
        public static bool operator !=(Competencia<T> c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
    }
}
