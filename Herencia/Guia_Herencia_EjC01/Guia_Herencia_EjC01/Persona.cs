using System;
using System.Text;

namespace Guia_Herencia_EjC01
{
    public class Persona
    {
        long dni;
        string nombre;

        public long Dni
        {
            get { return this.dni; }
            set
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    this.nombre = value;
            }
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona(long dni, string nombre): this(nombre)
        {
            this.dni = dni;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos de la persona");
            sb.AppendLine($"Dni: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");

            return sb.ToString();
        }
    }
}
