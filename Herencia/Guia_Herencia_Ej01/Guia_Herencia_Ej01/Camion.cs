using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_Ej01
{
    public class Camion: VehiculoTerrestre
    {
        int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.pesoCarga = pesoCarga;
        }

        public int PesoCarga { get { return this.pesoCarga; } }
    }
}
