using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Herencia_Ej01
{
    public class VehiculoTerrestre
    {
        short cantidadRuedas;
        short cantidadPuertas;
        Colores color;
        short cantidadMarchas;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
            this.cantidadMarchas = cantidadMarchas;
        }

        public short CantidadRuedas { get { return this.cantidadRuedas; } }
        public short CantidadPuertas { get { return this.cantidadPuertas; } }
        public Colores Color { get { return this.color; } }
        public short CantidadMarchas { get { return this.cantidadMarchas; } }
    }
}
