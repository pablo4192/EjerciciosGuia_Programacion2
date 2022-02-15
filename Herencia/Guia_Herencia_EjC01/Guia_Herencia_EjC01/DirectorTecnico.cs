using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_EjC01
{
    public class DirectorTecnico: Persona
    {
        DateTime fechaNacimiento;

        private DirectorTecnico(string nombre): base(nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento): this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string MostrarDatos() //Puedo utilizar polimorfismo aca!
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del DT");
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Fecha Nacimiento: {this.fechaNacimiento}");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento;
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}
