using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_UnitTests_EjC03
{
    public class CompetenciaNoDisponibleException: Exception
    {
        string nombreClase;
        string nombreMetodo;

        public string NombreClase { get; }
        public string NombreMetodo { get; }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        /// <summary>
        /// Arma una cadena de texto con la informacion de la Excepcion.
        /// </summary>
        /// <returns>String con datos sobre la Excepcion</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Exception excepcion;

            sb.AppendLine($"Excepcion en el metodo {this.nombreMetodo}, de la clase {this.nombreClase}");
            sb.AppendLine(this.Message);

            excepcion = this.InnerException;

            while (excepcion != null)
            {
                sb.AppendLine($"{excepcion.ToString()}\t");
                excepcion = excepcion.InnerException;
            }


            return sb.ToString();
        }
    }
}
