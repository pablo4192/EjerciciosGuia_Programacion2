using System;
using System.Text;

namespace Entidades3
{
    public class Estudiante
    {
        string apellido;
        string legajo;
        string nombre;
        int notaPrimerParcial;
        int notaSegundoParcial;
        static Random random;

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            
        }

        /// <summary>
        /// Setter Nota primer parcial.
        /// </summary>
        /// <param name="nota"></param>
        public void SetNotaPrimerParcial(int nota)
        {
            if(nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }
        }

        /// <summary>
        /// Setter Nota segundo parcial.
        /// </summary>
        /// <param name="nota"></param>
        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }
        }

        /// <summary>
        /// Calcula el promedio del alumno.
        /// </summary>
        /// <returns></returns>
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        /// <summary>
        /// Calcula La nota final del alumno.
        /// </summary>
        /// <returns>Nota final, o -1 si alguno de los parciales tiene como nota menor a 4</returns>
        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial < 4 || this.notaSegundoParcial < 4)
            {
                return -1;
            }

            return random.Next(6, 10);
        }

        /// <summary>
        /// Construye una cadena de texto con los datos del alumno.
        /// </summary>
        /// <returns>String con datos del alumno.</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal;

            sb.AppendLine("Datos del alumno");
            sb.AppendLine($"{this.nombre} {this.apellido}" );
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota segundo parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            notaFinal = CalcularNotaFinal();

            if(notaFinal == -1)
            {
                sb.Append("Alumno desaprobado");
            }
            else
            {
                sb.Append($"Nota final: {notaFinal}");
            }
                
            return sb.ToString();
        }
    }
}
