using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Polimorfismo_Ej01
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();


        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }

        public override bool Equals(object obj) //Si es llamado por un objeto de tipo Sobreescrito siempre retorna true independiente del objeto que le pase por parametro.
        {
            return this.GetType() == typeof(Sobreescrito); //En el video esta asi. //Podria preguntar si this.GetType() == obj.GeType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
