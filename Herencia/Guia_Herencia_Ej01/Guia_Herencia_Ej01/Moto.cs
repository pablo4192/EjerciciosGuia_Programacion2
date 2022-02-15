using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_Ej01
{
    public class Moto : VehiculoTerrestre
    {
        short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, short cilindrada): base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cilindrada = cilindrada;
        }

        public short Cilindrada { get { return this.cilindrada; } }
    }
}
